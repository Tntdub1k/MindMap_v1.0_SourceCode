using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Reflection;



namespace iChing
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        //MVVM things begin here
        private ModelV1_0 Model = new ModelV1_0();


        private int currentlyShowing = 0;
        private bool tracing = false;
        private List<TraceRoute> RouteMaps = new List<TraceRoute>(0);
        private string LastKeyPressed = "";
        private int LastPressedTimestamp = -1;


        public class TraceRoute
        {
            public string Title { get; set; }
            public List<int> Hexagrams { get; set; }
            public Color SPColor { get; set; }
            public bool[] disabledList { get; set; }
        }

        public void deserializeRouteMaps()
        {

            try
            {
                string json = System.IO.File.ReadAllText("RouteMaps");
                RouteMaps = Newtonsoft.Json.JsonConvert.DeserializeObject<List<TraceRoute>>(json);
                foreach (var route in RouteMaps)
                {
                    route.disabledList = route.disabledList ?? new bool[route.Hexagrams.Count];
                }
            }
            catch
            {
                //
            }
        }


        public MainWindow()
        {
            InitializeComponent();
#warning Does initializecomponent wait for all the objects to be loaded/created before going on? Should maybe add a different thread and some kind of progress bar/wait until components are loaded before continuing.

            // Add (Initialize) our custom controls in here
            var control = new HexagramImagesPortugese();
            control.Opacity = 0.27;
            HexagramGrid.Children.Add(control);
        
            SetupTable();

            Random rand = new Random();
            int randInt = rand.Next(1, 64);

            currentlyShowing = randInt;

            updateApplication();



            deserializeRouteMaps();
            //FieldInfo[] info = TracingPanel.GetType().GetFields();

            

            //Not related to above code, for downloading files from internet
            /*
            System.Net.WebClient Client = new System.Net.WebClient();
            for (int i = 35; i < 65; i++)
            {
                try
                {
                    Client.DownloadFile("http://www.imagick.org.br/pagmag/I_Ching/"+i+".jpg", @"C:\Users\Nick\Documents\Software\i Ching\iChing\Hexagram Images\"+i+".jpg");
                }
                catch (Exception)
                {
                    Client.DownloadFile("http://www.imagick.org.br/pagmag/I_Ching/" + i + "a.jpg", @"C:\Users\Nick\Documents\Software\i Ching\iChing\Hexagram Images\" + i + ".jpg");
                }
            }

            */

        }

        FrameworkElement CloneFrameworkElement(FrameworkElement originalElement)
        {
            string elementString = System.Windows.Markup.XamlWriter.Save(originalElement);

            System.IO.StringReader stringReader = new System.IO.StringReader(elementString);
            System.Xml.XmlReader xmlReader = System.Xml.XmlReader.Create(stringReader);
            FrameworkElement clonedElement = (FrameworkElement)System.Windows.Markup.XamlReader.Load(xmlReader);

            return clonedElement;
        }

        // main text code, setup table, hexagram info 
        #region


        private void SetupTable()
        {




            for (int row = 0; row < 8; row++)
            {
                for (int column = 0; column < 8; column++)
                {
                    Border HexBorder = new Border();
                    HexBorder.Width = 45;
                    HexBorder.Height = 28;
                    HexBorder.BorderThickness = new Thickness { Top = 0, Right = 1, Left = 0, Bottom = 1 };
                    HexBorder.BorderBrush = new SolidColorBrush(Colors.Black);

                    TextBox HexBox = new TextBox();
                    string HexNum = Convert.ToString(Model.HexArray[row, column]);
                    HexBox.Text = HexNum;
                    HexBox.Tag = HexNum;
                    HexBox.ToolTip = Model.iChing[Model.HexArray[row, column]].ChiTitle + " ~ " + Model.iChing[Model.HexArray[row, column]].EngTitle;
                    HexBox.FontSize = 15;
                    HexBox.Background = new SolidColorBrush(Color.FromArgb(100, 254, 254, 254));
                    HexBox.IsReadOnly = true;
                    HexBox.Cursor = Cursors.Arrow;
                    HexBox.VerticalContentAlignment = System.Windows.VerticalAlignment.Center;
                    HexBox.HorizontalContentAlignment = System.Windows.HorizontalAlignment.Center;
                    HexBox.BorderThickness = new Thickness { Top = 0, Right = 0, Left = 0, Bottom = 0 };
                    HexBox.PreviewMouseDown += new MouseButtonEventHandler(SearchItemClick);

                    HexBorder.Child = HexBox;

                    switch (row)
                    {
                        case 0:
                            ChienPanel.Children.Add(HexBorder);
                            break;
                        case 1:
                            ChenPanel.Children.Add(HexBorder);
                            break;
                        case 2:
                            KanPanel.Children.Add(HexBorder);
                            break;
                        case 3:
                            KenPanel.Children.Add(HexBorder);
                            break;
                        case 4:
                            KunPanel.Children.Add(HexBorder);
                            break;
                        case 5:
                            SunPanel.Children.Add(HexBorder);
                            break;
                        case 6:
                            LiPanel.Children.Add(HexBorder);
                            break;
                        case 7:
                            TuiPanel.Children.Add(HexBorder);
                            break;


                    }
                }
            }

            //TitleBox.Text = hexResult;
            //TitleBox.PreviewMouseDown += new MouseButtonEventHandler(SearchItemClick);
        }

        private void updateApplication()
        {
            TitleBoxNum.Content = currentlyShowing + ". ";
            TitleBoxChi.Content = Model.iChing[currentlyShowing].ChiSymbol + " ";
            TitleBoxText.Content = Model.iChing[currentlyShowing].ChiTitle + " / " + Model.iChing[currentlyShowing].EngTitle;
            HexTitle.Text = Model.iChing[currentlyShowing].Hex;
            AlternateTitlesBox.Text = "Alternate Titles: " + Model.iChing[currentlyShowing].AltTitles;
            AboveBelowBox.Text = Model.iChing[currentlyShowing].Above + "\n" + Model.iChing[currentlyShowing].Below;
            AboveBelowSymbolsBox.Text = Model.iChing[currentlyShowing].AboveSymbol + "\n" + Model.iChing[currentlyShowing].BelowSymbol;
            Intro1Box.Text = Model.iChing[currentlyShowing].Intro1;
            TheJudgmentBox.Text = Model.iChing[currentlyShowing].TheJudgment;
            Intro2Box.Text = Model.iChing[currentlyShowing].Intro2;
            TheImageBox.Text = Model.iChing[currentlyShowing].TheImage;
            Intro3Box.Text = Model.iChing[currentlyShowing].Intro3;
            Line1Box.Text = Model.iChing[currentlyShowing].Read1;
            Line2Box.Text = Model.iChing[currentlyShowing].Read2;
            Line3Box.Text = Model.iChing[currentlyShowing].Read3;
            Line4Box.Text = Model.iChing[currentlyShowing].Read4;
            Line5Box.Text = Model.iChing[currentlyShowing].Read5;
            Line6Box.Text = Model.iChing[currentlyShowing].Read6;
            ChangesTo1.Text = "● " + Model.iChing[currentlyShowing].Place1ChangesToNumber + ". " + Model.iChing[Model.iChing[currentlyShowing].Place1ChangesToNumber].EngTitle + " ●";
            ChangesTo2.Text = "● " + Model.iChing[currentlyShowing].Place2ChangesToNumber + ". " + Model.iChing[Model.iChing[currentlyShowing].Place2ChangesToNumber].EngTitle + " ●";
            ChangesTo3.Text = "● " + Model.iChing[currentlyShowing].Place3ChangesToNumber + ". " + Model.iChing[Model.iChing[currentlyShowing].Place3ChangesToNumber].EngTitle + " ●";
            ChangesTo4.Text = "● " + Model.iChing[currentlyShowing].Place4ChangesToNumber + ". " + Model.iChing[Model.iChing[currentlyShowing].Place4ChangesToNumber].EngTitle + " ●";
            ChangesTo5.Text = "● " + Model.iChing[currentlyShowing].Place5ChangesToNumber + ". " + Model.iChing[Model.iChing[currentlyShowing].Place5ChangesToNumber].EngTitle + " ●";
            ChangesTo6.Text = "● " + Model.iChing[currentlyShowing].Place6ChangesToNumber + ". " + Model.iChing[Model.iChing[currentlyShowing].Place6ChangesToNumber].EngTitle + " ●";

            Changes1BoxNumber.Text = Model.iChing[currentlyShowing].Place1ChangesToNumber + ". ";
            Changes2BoxNumber.Text = Model.iChing[currentlyShowing].Place2ChangesToNumber + ". ";
            Changes3BoxNumber.Text = Model.iChing[currentlyShowing].Place3ChangesToNumber + ". ";
            Changes4BoxNumber.Text = Model.iChing[currentlyShowing].Place4ChangesToNumber + ". ";
            Changes5BoxNumber.Text = Model.iChing[currentlyShowing].Place5ChangesToNumber + ". ";
            Changes6BoxNumber.Text = Model.iChing[currentlyShowing].Place6ChangesToNumber + ". ";
            Changes1BoxText.Text = Model.iChing[Model.iChing[currentlyShowing].Place1ChangesToNumber].EngTitle;
            Changes2BoxText.Text = Model.iChing[Model.iChing[currentlyShowing].Place2ChangesToNumber].EngTitle;
            Changes3BoxText.Text = Model.iChing[Model.iChing[currentlyShowing].Place3ChangesToNumber].EngTitle;
            Changes4BoxText.Text = Model.iChing[Model.iChing[currentlyShowing].Place4ChangesToNumber].EngTitle;
            Changes5BoxText.Text = Model.iChing[Model.iChing[currentlyShowing].Place5ChangesToNumber].EngTitle;
            Changes6BoxText.Text = Model.iChing[Model.iChing[currentlyShowing].Place6ChangesToNumber].EngTitle;
            Changes1BoxH.Text = Model.iChing[Model.iChing[currentlyShowing].Place1ChangesToNumber].Hex;
            Changes2BoxH.Text = Model.iChing[Model.iChing[currentlyShowing].Place2ChangesToNumber].Hex;
            Changes3BoxH.Text = Model.iChing[Model.iChing[currentlyShowing].Place3ChangesToNumber].Hex;
            Changes4BoxH.Text = Model.iChing[Model.iChing[currentlyShowing].Place4ChangesToNumber].Hex;
            Changes5BoxH.Text = Model.iChing[Model.iChing[currentlyShowing].Place5ChangesToNumber].Hex;
            Changes6BoxH.Text = Model.iChing[Model.iChing[currentlyShowing].Place6ChangesToNumber].Hex;
            Line1BoxSquareCircle.Text = Model.iChing[currentlyShowing].SquareCircle1;
            Line2BoxSquareCircle.Text = Model.iChing[currentlyShowing].SquareCircle2;
            Line3BoxSquareCircle.Text = Model.iChing[currentlyShowing].SquareCircle3;
            Line4BoxSquareCircle.Text = Model.iChing[currentlyShowing].SquareCircle4;
            Line5BoxSquareCircle.Text = Model.iChing[currentlyShowing].SquareCircle5;
            Line6BoxSquareCircle.Text = Model.iChing[currentlyShowing].SquareCircle6;
            Line1BoxSquareCircle_Copy.Text = Model.iChing[currentlyShowing].SquareCircle1;
            Line2BoxSquareCircle_Copy.Text = Model.iChing[currentlyShowing].SquareCircle2;
            Line3BoxSquareCircle_Copy.Text = Model.iChing[currentlyShowing].SquareCircle3;
            Line4BoxSquareCircle_Copy1.Text = Model.iChing[currentlyShowing].SquareCircle4;
            Line5BoxSquareCircle_Copy.Text = Model.iChing[currentlyShowing].SquareCircle5;
            Line6BoxSquareCircle_Copy.Text = Model.iChing[currentlyShowing].SquareCircle6;
            BorderComment1.Visibility = Visibility.Collapsed;
            BorderComment2.Visibility = Visibility.Collapsed;
            BorderComment3.Visibility = Visibility.Collapsed;
            BorderComment4.Visibility = Visibility.Collapsed;
            BorderComment5.Visibility = Visibility.Collapsed;
            BorderComment6.Visibility = Visibility.Collapsed;


            var SquareCircleTextBoxes = new List<TextBox>();
            SquareCircleTextBoxes.Add(Line1BoxSquareCircle_Copy);
            SquareCircleTextBoxes.Add(Line2BoxSquareCircle_Copy);
            SquareCircleTextBoxes.Add(Line3BoxSquareCircle_Copy);
            SquareCircleTextBoxes.Add(Line4BoxSquareCircle_Copy1);
            SquareCircleTextBoxes.Add(Line5BoxSquareCircle_Copy);
            SquareCircleTextBoxes.Add(Line6BoxSquareCircle_Copy);

            var ChangesNumberBox = new List<TextBox>();
            ChangesNumberBox.Add(Changes1BoxNumber);
            ChangesNumberBox.Add(Changes2BoxNumber);
            ChangesNumberBox.Add(Changes3BoxNumber);
            ChangesNumberBox.Add(Changes4BoxNumber);
            ChangesNumberBox.Add(Changes5BoxNumber);
            ChangesNumberBox.Add(Changes6BoxNumber);

            var ChangesTextBox = new List<TextBox>();
            ChangesTextBox.Add(Changes1BoxText);
            ChangesTextBox.Add(Changes2BoxText);
            ChangesTextBox.Add(Changes3BoxText);
            ChangesTextBox.Add(Changes4BoxText);
            ChangesTextBox.Add(Changes5BoxText);
            ChangesTextBox.Add(Changes6BoxText);


            var ChangesHTextBox = new List<TextBox>();
            ChangesHTextBox.Add(Changes1BoxH);
            ChangesHTextBox.Add(Changes2BoxH);
            ChangesHTextBox.Add(Changes3BoxH);
            ChangesHTextBox.Add(Changes4BoxH);
            ChangesHTextBox.Add(Changes5BoxH);
            ChangesHTextBox.Add(Changes6BoxH);


            var control = HexagramGrid.Children[0];
            PropertyInfo p = HexagramGrid.Children[0].GetType().GetProperty("currentlyShowing");
            p.SetValue(control, currentlyShowing, null);

            


            for (int i = 0; i < SquareCircleTextBoxes.Count; i++)
            {
                switch (SquareCircleTextBoxes[i].Text)
                {
                    case "○":
                        ChangesNumberBox[i].Foreground = new SolidColorBrush(Colors.CadetBlue);
                        ChangesTextBox[i].Foreground = new SolidColorBrush(Colors.CadetBlue);
                        ChangesHTextBox[i].Foreground = new SolidColorBrush(Colors.CadetBlue);
                        break;
                    case "⬜":
                        ChangesNumberBox[i].Foreground = new SolidColorBrush(Colors.IndianRed);
                        ChangesTextBox[i].Foreground = new SolidColorBrush(Colors.IndianRed);
                        ChangesHTextBox[i].Foreground = new SolidColorBrush(Colors.IndianRed);
                        break;
                    default:
                        ChangesNumberBox[i].Foreground = new SolidColorBrush(Colors.Black);
                        ChangesTextBox[i].Foreground = new SolidColorBrush(Colors.Black);
                        ChangesHTextBox[i].Foreground = new SolidColorBrush(Colors.Black);
                        break;

                }
            }




            //Update hexagram places
            if (Model.iChing[currentlyShowing].Code != null)
            {
                HexBox.Text = Model.iChing[currentlyShowing].Hex;
                /*
                if (iChing[currentlyShowing].Code[0] == 1) { Place1.Fill = (Brush)FindResource("Yang"); }
                else { Place1.Fill = (Brush)FindResource("Yin"); };
                if (iChing[currentlyShowing].Code[1] == 1) { Place2.Fill = (Brush)FindResource("Yang"); }
                else { Place2.Fill = (Brush)FindResource("Yin"); };
                if (iChing[currentlyShowing].Code[2] == 1) { Place3.Fill = (Brush)FindResource("Yang"); }
                else { Place3.Fill = (Brush)FindResource("Yin"); };
                if (iChing[currentlyShowing].Code[3] == 1) { Place4.Fill = (Brush)FindResource("Yang"); }
                else { Place4.Fill = (Brush)FindResource("Yin"); };
                if (iChing[currentlyShowing].Code[4] == 1) { Place5.Fill = (Brush)FindResource("Yang"); }
                else { Place5.Fill = (Brush)FindResource("Yin"); };
                if (iChing[currentlyShowing].Code[5] == 1) { Place6.Fill = (Brush)FindResource("Yang"); }
                else { Place6.Fill = (Brush)FindResource("Yin"); };*/
            }
            else { System.Windows.MessageBox.Show("Not yet defined"); }
            //LinesViewer.ScrollToTop();
            //MainTextViewer.ScrollToTop();

            switch (JamesDeKorneTab.IsSelected)
            {
                case true:
                    byte[] content = Convert.FromBase64String(Model.GnosticJamesDeKorneEdition[currentlyShowing]);

                    jamesDKRTB.Document.Blocks.Clear();
                    System.IO.MemoryStream ms = new System.IO.MemoryStream(content);
                    TextRange tRange = new TextRange(jamesDKRTB.Document.ContentStart, jamesDKRTB.Document.ContentEnd);
                    string dataFormat = DataFormats.Rtf;
                    ms.Position = 0;
                    tRange.Load(ms, dataFormat);
                    break;
                case false:
                    break;
            }



        }



        private void Place1_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            currentlyShowing = Model.iChing[currentlyShowing].Place1ChangesToNumber;
            updateApplication();
            if (tracing == true)
            {
                AddHexagramToCurrentRoute();
            }
        }

        private void Place2_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            currentlyShowing = Model.iChing[currentlyShowing].Place2ChangesToNumber;
            updateApplication();
            if (tracing == true)
            {
                AddHexagramToCurrentRoute();
            }
        }

        private void Place3_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            currentlyShowing = Model.iChing[currentlyShowing].Place3ChangesToNumber;
            updateApplication();
            if (tracing == true)
            {
                AddHexagramToCurrentRoute();
            }
        }

        private void Place4_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            currentlyShowing = Model.iChing[currentlyShowing].Place4ChangesToNumber;
            updateApplication();
            if (tracing == true)
            {
                AddHexagramToCurrentRoute();
            }
        }

        private void Place5_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            currentlyShowing = Model.iChing[currentlyShowing].Place5ChangesToNumber;
            updateApplication();
            if (tracing == true)
            {
                AddHexagramToCurrentRoute();
            }
        }

        private void Place6_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            currentlyShowing = Model.iChing[currentlyShowing].Place6ChangesToNumber;
            updateApplication();
            if (tracing == true)
            {
                AddHexagramToCurrentRoute();
            }
        }


        #endregion

        private void TextBox1_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Line1Box_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (BorderComment1.Visibility == System.Windows.Visibility.Collapsed)
            {
                BorderComment1.Visibility = System.Windows.Visibility.Visible;
                Comment1.Text = Model.WilhelmBaynesComments[currentlyShowing].Read1;
                BorderComment1.BringIntoView();
            }
            else
            {
                BorderComment1.Visibility = System.Windows.Visibility.Collapsed;
            }
        }


        private void displayNumber(int number)
        {
            currentlyShowing = number;
            MainTextViewer.ScrollToTop();
            updateApplication();
            TabControl1.SelectedIndex = 0;
        }


        private void Id1_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            StackPanel sp = (StackPanel)sender;
            try
            {
                string tagString = sp.Tag.ToString();
                displayNumber(Convert.ToInt32(tagString));
            }
            catch (Exception)
            {
                throw new Exception("whats the number for this hex?");
            }


        }

        private void Line6Box_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (BorderComment6.Visibility == System.Windows.Visibility.Collapsed)
            {
                BorderComment6.Visibility = System.Windows.Visibility.Visible;
                Comment6.Text = Model.WilhelmBaynesComments[currentlyShowing].Read6;
                BorderComment6.BringIntoView();
            }
            else
            {
                BorderComment6.Visibility = System.Windows.Visibility.Collapsed;
            }
        }

        private void Line5Box_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (BorderComment5.Visibility == System.Windows.Visibility.Collapsed)
            {
                BorderComment5.Visibility = System.Windows.Visibility.Visible;
                Comment5.Text = Model.WilhelmBaynesComments[currentlyShowing].Read5;
                BorderComment5.BringIntoView();

            }
            else
            {
                BorderComment5.Visibility = System.Windows.Visibility.Collapsed;
            }
        }

        private void Line4Box_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (BorderComment4.Visibility == System.Windows.Visibility.Collapsed)
            {
                BorderComment4.Visibility = System.Windows.Visibility.Visible;
                Comment4.Text = Model.WilhelmBaynesComments[currentlyShowing].Read4;
                BorderComment4.BringIntoView();
            }
            else
            {
                BorderComment4.Visibility = System.Windows.Visibility.Collapsed;
            }
        }

        private void Line3Box_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (BorderComment3.Visibility == System.Windows.Visibility.Collapsed)
            {
                BorderComment3.Visibility = System.Windows.Visibility.Visible;
                Comment3.Text = Model.WilhelmBaynesComments[currentlyShowing].Read3;
                BorderComment3.BringIntoView();
            }
            else
            {
                BorderComment3.Visibility = System.Windows.Visibility.Collapsed;
            }
        }

        private void Line2Box_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (BorderComment2.Visibility == System.Windows.Visibility.Collapsed)
            {
                BorderComment2.Visibility = System.Windows.Visibility.Visible;
                Comment2.Text = Model.WilhelmBaynesComments[currentlyShowing].Read2;
                BorderComment2.BringIntoView();
                ;
            }
            else
            {
                BorderComment2.Visibility = System.Windows.Visibility.Collapsed;
            }
        }

        private void SetToLines()
        {
            switch (JamesDeKorneTab.IsSelected)
            {
                case true:
                    string keyword = "Line-1";
                    TextRange text = new TextRange(jamesDKRTB.Document.ContentStart, jamesDKRTB.Document.ContentEnd);
                    TextPointer current = text.Start.GetInsertionPosition(LogicalDirection.Forward);
                    int i = 0;
                    while (current != null)
                    {
                        string textInRun = current.GetTextInRun(LogicalDirection.Forward);
                        if (!string.IsNullOrWhiteSpace(textInRun))
                        {
                            int index = textInRun.IndexOf(keyword);
                            if (index != -1)
                            {
                                jamesDKRTB.ScrollToVerticalOffset(i * 3);
                            }
                        }
                        current = current.GetNextContextPosition(LogicalDirection.Forward);
                        i++;
                    }
                    break;
                default:
                    MainTextViewer.UpdateLayout();
                    MainTextViewer.ScrollToVerticalOffset(Intro1Box.ActualHeight + TheJudgmentBox.ActualHeight + Intro2Box.ActualHeight + TheImageBox.ActualHeight + Intro3Box.ActualHeight + AboveBelowBox.ActualHeight + 17);
                    break;
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            SetToLines();
        }

        private void Button_ClickText(object sender, RoutedEventArgs e)
        {
            MainTextViewer.ScrollToTop();
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.Left:
                    if (currentlyShowing > 1)
                    {
                        currentlyShowing--;
                    }
                    else
                    {
                        currentlyShowing = 64;
                    }
                    updateApplication();
                    break;
                case Key.Right:
                    if (currentlyShowing < 64)
                    {
                        currentlyShowing++;
                    }
                    else
                    {
                        currentlyShowing = 1;
                    }
                    updateApplication();
                    break;
                case Key.Up:
                    switch (JamesDeKorneTab.IsSelected)
                    {
                        case true:
                            jamesDKRTB.LineUp();
                            break;
                        case false:
                            MainTextViewer.LineUp();
                            break;
                    }
                    break;
                case Key.Down:
                    switch (JamesDeKorneTab.IsSelected)
                    {
                        case true:
                            jamesDKRTB.LineDown();
                            break;
                        case false:
                            MainTextViewer.LineDown();
                            break;
                    }
                    break;
                case Key.D0:
                case Key.D1:
                case Key.D2:
                case Key.D3:
                case Key.D4:
                case Key.D5:
                case Key.D6:
                case Key.D7:
                case Key.D8:
                case Key.D9:
                case Key.NumPad0:
                case Key.NumPad1:
                case Key.NumPad2:
                case Key.NumPad3:
                case Key.NumPad4:
                case Key.NumPad5:
                case Key.NumPad6:
                case Key.NumPad7:
                case Key.NumPad8:
                case Key.NumPad9:
                    string pressedKey = e.Key.ToString();

                    if (pressedKey.StartsWith("D"))
                    {
                        pressedKey = pressedKey.Replace("D", "");
                        //MessageBox.Show(pressedKey);
                    }

                    else if (pressedKey.StartsWith("NumPad"))
                    {
                        pressedKey = pressedKey.Replace("NumPad", "");
                        //MessageBox.Show(pressedKey);
                    }

                    if (LastPressedTimestamp != -1)
                    {
                        if (DateTime.Now.Second <= LastPressedTimestamp + 1)
                        {
                            if (LastKeyPressed != "")
                            {
                                int hexagramToShow = Convert.ToInt16(LastKeyPressed + pressedKey);
                                if ((hexagramToShow <= 64) && (hexagramToShow > 0)) {
                                    currentlyShowing = hexagramToShow;
                                    updateApplication();

                                }
                            }
                        }
                        LastPressedTimestamp = -1;
                    }
                    else
                    {
                        if (pressedKey != "0")
                        {
                        currentlyShowing = Convert.ToInt16(pressedKey);
                        updateApplication();
                        }
                        LastPressedTimestamp = DateTime.Now.Second;
                    }
                    LastKeyPressed = pressedKey;

                    break;

            }
        }

        void SearchItemClick(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            int hexNumber = Convert.ToInt32(tb.Tag);
            currentlyShowing = hexNumber;
            updateApplication();
        }


        private void item1_click(object sender, RoutedEventArgs e)
        {

            MenuItem mnu = sender as MenuItem;
            StackPanel sp = null;
            if (mnu != null)
            {
                sp = ((ContextMenu)mnu.Parent).PlacementTarget as StackPanel;
            }
            int indexToDelete = (TracingPanel.Children.IndexOf(sp) - 1) / 2;
            RouteMaps.RemoveAt(indexToDelete);
            TabItem_Loaded(sender, e);
        }

        private void subitem_click(object sender, RoutedEventArgs e)
        {

            MenuItem mnu = sender as MenuItem;
            MenuItem mnuParent = mnu.Parent as MenuItem;
            StackPanel sp = null;
            if (mnuParent != null)
            {
                sp = ((ContextMenu)mnuParent.Parent).PlacementTarget as StackPanel;
            }

            int indexToMove = (TracingPanel.Children.IndexOf(sp) - 1) / 2;
            TraceRoute tempTR = RouteMaps[indexToMove];
            RouteMaps.RemoveAt(indexToMove);
            RouteMaps.Insert(Convert.ToInt16(mnu.Tag), tempTR);
            TabItem_Loaded(sender, e);
        }

        private void item2_click(object sender, RoutedEventArgs e)
        {

            MenuItem mnu = sender as MenuItem;
            StackPanel sp = null;
            if (mnu != null)
            {
                sp = ((ContextMenu)mnu.Parent).PlacementTarget as StackPanel;
            }
            int indexToMove = (TracingPanel.Children.IndexOf(sp) - 1) / 2;
            if (indexToMove > 0)
            {
                TraceRoute tempTR = RouteMaps[indexToMove];
                RouteMaps.RemoveAt(indexToMove);
                RouteMaps.Insert(indexToMove - 1, tempTR);
                TabItem_Loaded(sender, e);
            }

        }

        private void item3_click(object sender, RoutedEventArgs e)
        {

            MenuItem mnu = sender as MenuItem;
            StackPanel sp = null;
            if (mnu != null)
            {
                sp = ((ContextMenu)mnu.Parent).PlacementTarget as StackPanel;
            }
            int indexToMove = (TracingPanel.Children.IndexOf(sp) - 1) / 2;
            if (indexToMove < RouteMaps.Count - 1)
            {
                TraceRoute tempTR = RouteMaps[indexToMove];
                RouteMaps.RemoveAt(indexToMove);
                RouteMaps.Insert(indexToMove + 1, tempTR);
                TabItem_Loaded(sender, e);
            }



        }

        private void item4_click(object sender, RoutedEventArgs e)
        {
            colorbutton.Visibility = Visibility.Visible;
            Colorbar.Visibility = Visibility.Visible;

            MenuItem mnu = sender as MenuItem;
            StackPanel sp = null;
            if (mnu != null)
            {
                sp = ((ContextMenu)mnu.Parent).PlacementTarget as StackPanel;
            }
            SolidColorBrush b = sp.Background as SolidColorBrush;
            if (b.Color.A != 0)
            {
                Colorbar.SelectedColor = b.Color;
            }
            int index = (TracingPanel.Children.IndexOf(sp) - 1) / 2;
            Colorbar.Tag = index;
        }



        void TracingPathPanelRightClick(object sender, RoutedEventArgs e)
        {

            /*  Brush b = new SolidColorBrush(Color.FromArgb(60,100,0,0));
              //MessageBox.Show((TracingPanel.Children.IndexOf(sender as StackPanel)).ToString());
              TextBox tb = (TracingPanel.Children[TracingPanel.Children.IndexOf(sender as StackPanel) - 1] as TextBox);
              tb.Background = new SolidColorBrush(Color.FromArgb(40, 100, 0, 0));
              tb.BorderBrush = new SolidColorBrush(Color.FromArgb(40, 100, 0, 0)); 

              (sender as StackPanel).Background = b;
              */
        }

        private static int[] AllIndexesOf(string str, string substr)
        {
            if (string.IsNullOrWhiteSpace(str) ||
                string.IsNullOrWhiteSpace(substr))
            {
                throw new ArgumentException("String or substring is not specified.");
            }

            var indexes = new List<int>();
            int index = 0;

            while ((index = str.IndexOf(substr, index, StringComparison.OrdinalIgnoreCase)) != -1)
            {
                indexes.Add(index++);
            }

            return indexes.ToArray();
        }

        private string SearchTextPortion(string text, string substr)
        {
            int margin = 5;
            int length = 65;
            if (text.Length < length)
            {
                length = text.Length;
            }

            string compiledSearch = "";


            int[] arrayOfFoundResults = AllIndexesOf(text, substr);
            for (int j = 0; j < arrayOfFoundResults.Length; j++)
            {

                int begin = arrayOfFoundResults[j] - margin;

                if (begin < 0)
                {
                    begin = 0;
                }
                if (begin + length > text.Length - 1)
                {
                    begin = text.Length - length;
                }
                compiledSearch += "--" + text.Substring(begin, length) + "\n";
            }
            return compiledSearch;
        }
        private string SearchLinesPortion(string text, string substr, string linenum)
        {
            int margin = 5;
            int length = 65;
            if (text.Length < length)
            {
                length = text.Length;
            }

            string compiledSearch = "";


            int[] arrayOfFoundResults = AllIndexesOf(text, substr);
            for (int j = 0; j < arrayOfFoundResults.Length; j++)
            {

                int begin = arrayOfFoundResults[j] - margin;

                if (begin < 0)
                {
                    begin = 0;
                }
                if (begin + length > text.Length - 1)
                {
                    begin = text.Length - length;
                }
                compiledSearch += linenum + " --" + text.Substring(begin, length) + "\n";
            }
            return compiledSearch;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(SearchEntry.Text))
            {
                SearchViewer.Visibility = Visibility.Visible;
                string substr = SearchEntry.Text;


                /*TextBox newBox = new TextBox();
                newBox.Text = "Hello1";
                newBox.PreviewMouseDown += new MouseButtonEventHandler((s2, e2) => SearchItemClick(s2,e2, 12));
                SearchPanel.Children.Add(newBox);
                SearchPanel.UpdateLayout();
                */

                for (int i = 1; i <= 64; i++)
                {

                    string MainText = SearchTextPortion(Model.iChing[i].Intro1, SearchEntry.Text);
                    MainText += SearchTextPortion(Model.iChing[i].TheJudgment, SearchEntry.Text);
                    MainText += SearchTextPortion(Model.iChing[i].Intro2, SearchEntry.Text);
                    MainText += SearchTextPortion(Model.iChing[i].TheImage, SearchEntry.Text);
                    MainText += SearchTextPortion(Model.iChing[i].Intro3, SearchEntry.Text);

                    string Lines = SearchLinesPortion(Model.iChing[i].Read1, SearchEntry.Text, "1");
                    Lines += SearchLinesPortion(Model.iChing[i].Read2, SearchEntry.Text, "2");
                    Lines += SearchLinesPortion(Model.iChing[i].Read3, SearchEntry.Text, "3");
                    Lines += SearchLinesPortion(Model.iChing[i].Read4, SearchEntry.Text, "4");
                    Lines += SearchLinesPortion(Model.iChing[i].Read5, SearchEntry.Text, "5");
                    Lines += SearchLinesPortion(Model.iChing[i].Read6, SearchEntry.Text, "6");

                    string Comments = SearchLinesPortion(Model.WilhelmBaynesComments[i].Read1, SearchEntry.Text, "1");
                    Comments += SearchLinesPortion(Model.WilhelmBaynesComments[i].Read2, SearchEntry.Text, "2");
                    Comments += SearchLinesPortion(Model.WilhelmBaynesComments[i].Read3, SearchEntry.Text, "3");
                    Comments += SearchLinesPortion(Model.WilhelmBaynesComments[i].Read4, SearchEntry.Text, "4");
                    Comments += SearchLinesPortion(Model.WilhelmBaynesComments[i].Read5, SearchEntry.Text, "5");
                    Comments += SearchLinesPortion(Model.WilhelmBaynesComments[i].Read6, SearchEntry.Text, "6");




                    bool textResult = !String.IsNullOrEmpty(MainText);
                    bool linesResult = !String.IsNullOrEmpty(Lines);
                    bool commentsResult = !String.IsNullOrEmpty(Comments);

                    if (textResult || linesResult || commentsResult)
                    {
                        //Title
                        string hexResult = Convert.ToString(i) + ". " + Model.iChing[i].EngTitle + " " + Model.iChing[i].Hex;
                        TextBox TitleBox = new TextBox();
                        TitleBox.Tag = i;
                        TitleBox.Text = hexResult;
                        TitleBox.FontWeight = FontWeights.Bold;
                        TitleBox.PreviewMouseDown += new MouseButtonEventHandler(SearchItemClick);
                        SearchPanel.Children.Add(TitleBox);

                        if (textResult)
                        {
                            TextBox mainTextBox = new TextBox();
                            mainTextBox.Tag = i;
                            mainTextBox.Text = "[Text] " + MainText;
                            mainTextBox.PreviewMouseDown += new MouseButtonEventHandler(SearchItemClick);
                            SearchPanel.Children.Add(mainTextBox);
                        }

                        if (linesResult)
                        {
                            TextBox linesBox = new TextBox();
                            linesBox.Tag = i;
                            linesBox.Text = "[Lines] " + Lines;
                            linesBox.PreviewMouseDown += new MouseButtonEventHandler(SearchItemClick);
                            SearchPanel.Children.Add(linesBox);
                        }
                        if (commentsResult)
                        {
                            TextBox commentBox = new TextBox();
                            commentBox.Tag = i;
                            commentBox.Text = "[Comments] " + Comments;
                            commentBox.PreviewMouseDown += new MouseButtonEventHandler(SearchItemClick);
                            SearchPanel.Children.Add(commentBox);
                        }

                        SearchPanel.UpdateLayout();
                    }


                    //search maintext


                    //search lines


                    //search comments


                    //add entry to search bar
                }
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            SearchPanel.Children.Clear();
            SearchViewer.Visibility = Visibility.Collapsed;
        }


        private void SearchEntry_KeyUp(object sender, KeyEventArgs e)
        {
            SearchPanel.Children.Clear();
            if (SearchEntry.Text.Length > 2)
            {
                Button_Click_1(this, e);
            }
        }


        private void AddHexagramToCurrentRoute()
        {
            RouteMaps[RouteMaps.Count - 1].Hexagrams.Add(currentlyShowing);

            bool[] temparray = new bool[RouteMaps[RouteMaps.Count - 1].disabledList.Length + 1];
            for (int i = 0; i < RouteMaps[RouteMaps.Count - 1].disabledList.Length; i++)
            {
                temparray[i] = RouteMaps[RouteMaps.Count - 1].disabledList[i];
            }
            temparray[temparray.Length - 1] = false;

            RouteMaps[RouteMaps.Count - 1].disabledList = temparray;

        }

        //viewer, displaying only
        private void AddHexagramToTraceMap(int hexagram, bool disabled)
        {
            PathTemplate newPathEntry = new PathTemplate();
            newPathEntry.PreviewMouseLeftButtonDown += new MouseButtonEventHandler(PathTemplateClick);
            newPathEntry.HexBox.Text = Model.iChing[hexagram].Hex;
            newPathEntry.PathBar.Value = hexagram;
            newPathEntry.TextBox.Text = Model.iChing[hexagram].EngTitle;
            if (disabled)
            {
                newPathEntry.OpacityMask = new SolidColorBrush(Color.FromArgb(40, 100, 100, 100));
            }
            foreach (object child in TracingPanel.Children)
            {
                if (child is StackPanel)
                {
                    if (Convert.ToString((child as StackPanel).Tag) == "Map" + Convert.ToString(TracingPanel.Children.Count))
                    {
                        (child as StackPanel).Children.Add(newPathEntry);
                        (child as StackPanel).Children.Add(new TextBox() { Text = "⬤  ", FontSize = 10, Height = 80, VerticalAlignment = VerticalAlignment.Top, Background = null, BorderBrush = null, VerticalContentAlignment = VerticalAlignment.Center, IsTabStop = false, IsHitTestVisible = false });
                    }

                }
            }


        }

        private void PathTemplateClick(object sender, MouseButtonEventArgs e)
        {
            StackPanel parentPanel = ((sender as PathTemplate).Parent) as StackPanel;
            int int1 = parentPanel.Children.IndexOf((sender as PathTemplate));
            int indexofHexagramInPanel = int1 / 2;
            int int2 = TracingPanel.Children.IndexOf(parentPanel);
            if (int2 >= 0)
            {
                int index = int2 / 2;
                switch (RouteMaps[index].disabledList[indexofHexagramInPanel])
                {
                    case true:
                        RouteMaps[index].disabledList[indexofHexagramInPanel] = false;
                        break;
                    case false:
                        RouteMaps[index].disabledList[indexofHexagramInPanel] = true;
                        break;
                }
                TabItem_Loaded(sender, e);
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            switch (tracing)
            {
                case true:
                    tracing = false;
                    TracerBtn.Content = "Trace";
                    TabItem_Loaded(sender, e);
                    break;
                case false:
                    tracing = true;
                    TraceRoute tr = new TraceRoute();
                    tr.Title = "";
                    tr.SPColor = System.Windows.Media.Color.FromArgb(0, 0, 0, 0);
                    tr.Hexagrams = new List<int>(1);
                    tr.disabledList = new bool[1];
                    tr.Hexagrams.Add(currentlyShowing);

                    RouteMaps.Add(tr);
                    TracerBtn.Content = "Finish Tracing";
                    break;
            }

        }

        private void Tb_TextChanged(object sender, TextChangedEventArgs e)
        {
            int index = TracingPanel.Children.IndexOf(sender as TextBox) / 2;
            RouteMaps[index].Title = (sender as TextBox).Text;
        }



        public void serializeTracingPanel()
        {
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(RouteMaps);
            System.IO.File.WriteAllText("RouteMaps", json);


        }
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            serializeTracingPanel();

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            if (currentlyShowing > 1)
            {
                currentlyShowing--;
            }
            else
            {
                currentlyShowing = 64;
            }
            updateApplication();
        }

        private void button_Click_5(object sender, RoutedEventArgs e)
        {
            if (currentlyShowing < 64)
            {
                currentlyShowing++;
            }
            else
            {
                currentlyShowing = 1;
            }
            updateApplication();
        }



        private void MapViewer_Initialized(object sender, EventArgs e)
        {

        }



        private void TabItem_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void TabItem_Loaded(object sender, RoutedEventArgs e)
        {
            TracingPanel.Children.Clear();
            if (RouteMaps != null)
            {
                foreach (var route in RouteMaps)
                {

                    TextBox tb = new TextBox();
                    tb.Text = route.Title;
                    tb.IsReadOnly = false;
                    tb.IsEnabled = true;
                    tb.AllowDrop = true;
                    tb.Focusable = true;
                    tb.IsHitTestVisible = true;
                    tb.IsTabStop = true;
                    tb.Width = double.NaN;
                    Color tbColor = new Color();
                    if (route.SPColor.A > 40)
                    {
                        tbColor.A = Convert.ToByte(40);
                    }
                    tbColor.R = route.SPColor.R;
                    tbColor.G = route.SPColor.G;
                    tbColor.B = route.SPColor.B;
                    tb.Background = new SolidColorBrush(tbColor);
                    tb.BorderBrush = new SolidColorBrush(tbColor);
                    tb.TextChanged += Tb_TextChanged;
                    TracingPanel.Children.Add(tb);

                    StackPanel newPathPanel = new StackPanel();
                    newPathPanel.Orientation = Orientation.Horizontal;
                    newPathPanel.Tag = "Map" + Convert.ToString(TracingPanel.Children.Count + 1);
                    newPathPanel.Width = double.NaN;
                    newPathPanel.Height = double.NaN;
                    if (route.SPColor.A >= 40)
                    {
                        tbColor.A = Convert.ToByte(60);
                    }
                    newPathPanel.Background = new SolidColorBrush(tbColor);
                    newPathPanel.PreviewMouseRightButtonDown += new MouseButtonEventHandler(TracingPathPanelRightClick);

                    ContextMenu pMenu = new ContextMenu();
                    MenuItem item1 = new MenuItem();
                    item1.Header = "Delete";
                    item1.PreviewMouseLeftButtonDown += new MouseButtonEventHandler(item1_click);
                    pMenu.Items.Add(item1);
                    MenuItem submenu1 = new MenuItem();
                    submenu1.Header = "Move to:";
                    int index = 0;
                    foreach (var item in RouteMaps)
                    {
                        MenuItem subitem = new MenuItem();
                        subitem.Header = item.Title;
                        subitem.Tag = index;
                        index++;
                        subitem.PreviewMouseLeftButtonDown += new MouseButtonEventHandler(subitem_click);
                        submenu1.Items.Add(subitem);
                    }
                    pMenu.Items.Add(submenu1);
                    MenuItem item2 = new MenuItem();
                    item2.Header = "Move up";
                    item2.PreviewMouseLeftButtonDown += new MouseButtonEventHandler(item2_click);
                    pMenu.Items.Add(item2);
                    MenuItem item3 = new MenuItem();
                    item3.Header = "Move down";
                    item3.PreviewMouseLeftButtonDown += new MouseButtonEventHandler(item3_click);
                    pMenu.Items.Add(item3);
                    MenuItem item4 = new MenuItem();
                    item4.Header = "Choose Color";
                    item4.PreviewMouseLeftButtonDown += new MouseButtonEventHandler(item4_click);
                    pMenu.Items.Add(item4);


                    newPathPanel.ContextMenu = pMenu;

                    TracingPanel.Children.Add(newPathPanel);

                    for (int i = 0; i < route.Hexagrams.Count; i++)
                    {
                        AddHexagramToTraceMap(route.Hexagrams[i], route.disabledList[i]);
                    }
                    /*    foreach (var hexagram in route.Hexagrams)
                        {
                            AddHexagramToTraceMap(hexagram);
                        }
                    */

                }
            }

        }

        private void colorbutton_Click(object sender, RoutedEventArgs e)
        {
            colorbutton.Visibility = Visibility.Hidden;
            Colorbar.Visibility = Visibility.Hidden;
            Color? color = Colorbar.SelectedColor;
            Color ColorRGBA = (Color)System.Windows.Media.ColorConverter.ConvertFromString(color.ToString());
            RouteMaps[Convert.ToInt32(Colorbar.Tag)].SPColor = ColorRGBA;
            TabItem_Loaded(sender, e);
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            /*
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            TextRange tRange = new TextRange(jamesDKRTB.Document.ContentStart, jamesDKRTB.Document.ContentEnd);
            string dataFormat = DataFormats.Rtf;
            tRange.Save(ms, dataFormat);

            ms.Position = 0;

            string base64 = Convert.ToBase64String(ms.ToArray());

            jamesDKRTB.Document.Blocks.Clear();

            GnosticJamesDeKorneEdition[Convert.ToInt16(textBoxtemp.Text)] = base64;
            textBoxtemp.Text = (Convert.ToInt16(textBoxtemp.Text) + 1).ToString();

            // Start Load
            /*     byte[] content = Convert.FromBase64String(base64);



                  ms.Position = 0;
                  TextRange textRange = new TextRange(jamesDKRTB.Document.ContentStart, jamesDKRTB.Document.ContentEnd);
                  textRange.Load(ms, dataFormat);

          */

        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(Model.GnosticJamesDeKorneEdition);
            System.IO.File.WriteAllText("GnosticJamesDeKorneEdition", json);
        }

        private void JamesDeKorneTab_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void JamesDeKorneTab_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            JamesDeKorneTab.IsSelected = true;
            updateApplication();
        }

        private void JamesDeKorneTab_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
        }

        private void tabControl_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void tabControl_KeyDown(object sender, KeyEventArgs e)
        {
            //
        }

        //
        private void tabControl_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
        }

        private void ShowImageBtn_Click(object sender, RoutedEventArgs e)
        {
            HexagramGrid.Children[0].Opacity = 1;
        }
    }









}


public class Comments
{
    public Comments() { }
    public Comments(string read1, string read2, string read3, string read4, string read5, string read6)
    {
        Read1 = read1;
        Read2 = read2;
        Read3 = read3;
        Read4 = read4;
        Read5 = read5;
        Read6 = read6;
    }

    public string Read1 { get; set; }
    public string Read2 { get; set; }
    public string Read3 { get; set; }
    public string Read4 { get; set; }
    public string Read5 { get; set; }
    public string Read6 { get; set; }

}



public class iChingNumber
{
    public iChingNumber() { }

    public iChingNumber(string engTitle, string chiTitle, string chiSymbol, string altTitles, string hex, string above, string below,
        string aboveSymbol, string belowSymbol, string intro1, string theJudgment,
        string intro2, string theImage, string intro3, string read1, string read2,
        string read3, string read4, string read5, string read6, int place1ChangesToNumber,
        int place2ChangesToNumber, int place3ChangesToNumber, int place4ChangesToNumber,
        int place5ChangesToNumber, int place6ChangesToNumber, string place1ChangesToTitle,
        string place2ChangesToTitle, string place3ChangesToTitle, string place4ChangesToTitle,
        string place5ChangesToTitle, string place6ChangesToTitle, string squareCircle1,
        string squareCircle2, string squareCircle3, string squareCircle4, string squareCircle5,
        string squareCircle6, int[] code)
    {
        EngTitle = engTitle;
        ChiTitle = chiTitle;
        ChiSymbol = chiSymbol;
        AltTitles = altTitles;
        Hex = hex;
        Above = above;
        Below = below;
        AboveSymbol = aboveSymbol;
        BelowSymbol = belowSymbol;
        Intro1 = intro1;
        TheJudgment = theJudgment;
        Intro2 = intro2;
        TheImage = theImage;
        Intro3 = intro3;
        Read1 = read1;
        Read2 = read2;
        Read3 = read3;
        Read4 = read4;
        Read5 = read5;
        Read6 = read6;
        Place1ChangesToNumber = place1ChangesToNumber;
        Place2ChangesToNumber = place2ChangesToNumber;
        Place3ChangesToNumber = place3ChangesToNumber;
        Place4ChangesToNumber = place4ChangesToNumber;
        Place5ChangesToNumber = place5ChangesToNumber;
        Place6ChangesToNumber = place6ChangesToNumber;
        Place1ChangesToTitle = place1ChangesToTitle;
        Place2ChangesToTitle = place2ChangesToTitle;
        Place3ChangesToTitle = place3ChangesToTitle;
        Place4ChangesToTitle = place4ChangesToTitle;
        Place5ChangesToTitle = place5ChangesToTitle;
        Place6ChangesToTitle = place6ChangesToTitle;
        SquareCircle1 = squareCircle1;
        SquareCircle2 = squareCircle2;
        SquareCircle3 = squareCircle3;
        SquareCircle4 = squareCircle4;
        SquareCircle5 = squareCircle5;
        SquareCircle6 = squareCircle6;
        Code = code;
    }


    public string EngTitle { get; set; }
    public string ChiTitle { get; set; }
    public string ChiSymbol { get; set; }
    public string Hex { get; set; }
    public string AltTitles { get; set; }
    public string Above { get; set; }
    public string Below { get; set; }
    public string AboveSymbol { get; set; }
    public string BelowSymbol { get; set; }
    public string Intro1 { get; set; }
    public string TheJudgment { get; set; }
    public string Intro2 { get; set; }
    public string TheImage { get; set; }
    public string Intro3 { get; set; }
    public string Read1 { get; set; }
    public string Read2 { get; set; }
    public string Read3 { get; set; }
    public string Read4 { get; set; }
    public string Read5 { get; set; }
    public string Read6 { get; set; }
    public int Place1ChangesToNumber { get; set; }
    public int Place2ChangesToNumber { get; set; }
    public int Place3ChangesToNumber { get; set; }
    public int Place4ChangesToNumber { get; set; }
    public int Place5ChangesToNumber { get; set; }
    public int Place6ChangesToNumber { get; set; }
    public string Place1ChangesToTitle { get; set; }
    public string Place2ChangesToTitle { get; set; }
    public string Place3ChangesToTitle { get; set; }
    public string Place4ChangesToTitle { get; set; }
    public string Place5ChangesToTitle { get; set; }
    public string Place6ChangesToTitle { get; set; }
    public string SquareCircle1 { get; set; }
    public string SquareCircle2 { get; set; }
    public string SquareCircle3 { get; set; }
    public string SquareCircle4 { get; set; }
    public string SquareCircle5 { get; set; }
    public string SquareCircle6 { get; set; }
    public int[] Code { get; set; }

}

