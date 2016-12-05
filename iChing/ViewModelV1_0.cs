using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Reflection;
using System.Windows;

namespace iChing
{
    class ViewModelV1_0
    {   

        private ModelV1_0 Model = new ModelV1_0();
        private MainWindow View = new MainWindow();

        private void AddEventHandlers()
        {



        View.PreviewKeyDown += new KeyEventHandler(Window_KeyDown);

            View.Line1Box.PreviewMouseDown += new MouseButtonEventHandler(Line1Box_MouseDown);
            View.Line2Box.PreviewMouseDown += new MouseButtonEventHandler(Line2Box_MouseDown);
            View.Line3Box.PreviewMouseDown += new MouseButtonEventHandler(Line3Box_MouseDown);
            View.Line4Box.PreviewMouseDown += new MouseButtonEventHandler(Line4Box_MouseDown);
            View.Line5Box.PreviewMouseDown += new MouseButtonEventHandler(Line5Box_MouseDown);
            View.Line6Box.PreviewMouseDown += new MouseButtonEventHandler(Line6Box_MouseDown);

            View.Place1.PreviewMouseDown += new MouseButtonEventHandler(Place1_PreviewMouseUp);
            View.Place2.PreviewMouseDown += new MouseButtonEventHandler(Place2_PreviewMouseUp);
            View.Place3.PreviewMouseDown += new MouseButtonEventHandler(Place3_PreviewMouseUp);
            View.Place4.PreviewMouseDown += new MouseButtonEventHandler(Place4_PreviewMouseUp);
            View.Place5.PreviewMouseDown += new MouseButtonEventHandler(Place5_PreviewMouseUp);
            View.Place6.PreviewMouseDown += new MouseButtonEventHandler(Place6_PreviewMouseUp);

            View.ChangesTo1.PreviewMouseDown += new MouseButtonEventHandler(Place1_PreviewMouseUp);
            View.ChangesTo2.PreviewMouseDown += new MouseButtonEventHandler(Place2_PreviewMouseUp);
            View.ChangesTo3.PreviewMouseDown += new MouseButtonEventHandler(Place3_PreviewMouseUp);
            View.ChangesTo4.PreviewMouseDown += new MouseButtonEventHandler(Place4_PreviewMouseUp);
            View.ChangesTo5.PreviewMouseDown += new MouseButtonEventHandler(Place5_PreviewMouseUp);
            View.ChangesTo6.PreviewMouseDown += new MouseButtonEventHandler(Place6_PreviewMouseUp);


            View.MapItem.Loaded += new RoutedEventHandler(TabItem_Loaded);

            View.tabControl.PreviewKeyDown += new KeyEventHandler(tabControl_PreviewKeyDown);

            View.ShowImageBtn.Click += new RoutedEventHandler(ShowImageBtn_Click);
            View.SearchEntry.PreviewKeyUp += new KeyEventHandler(SearchEntry_KeyUp);

            View.JamesDeKorneTab.PreviewMouseDown += new MouseButtonEventHandler(JamesDeKorneTab_PreviewMouseLeftButtonDown);

            View.Id1.PreviewMouseDown += new MouseButtonEventHandler(Id1_PreviewMouseDown);
            View.Id2.PreviewMouseDown += new MouseButtonEventHandler(Id1_PreviewMouseDown);
            View.Id3.PreviewMouseDown += new MouseButtonEventHandler(Id1_PreviewMouseDown);
            View.Id4.PreviewMouseDown += new MouseButtonEventHandler(Id1_PreviewMouseDown);
            View.Id5.PreviewMouseDown += new MouseButtonEventHandler(Id1_PreviewMouseDown);
            View.Id6.PreviewMouseDown += new MouseButtonEventHandler(Id1_PreviewMouseDown);
            View.Id7.PreviewMouseDown += new MouseButtonEventHandler(Id1_PreviewMouseDown);
            View.Id8.PreviewMouseDown += new MouseButtonEventHandler(Id1_PreviewMouseDown);
            View.Id9.PreviewMouseDown += new MouseButtonEventHandler(Id1_PreviewMouseDown);
            View.Id10.PreviewMouseDown += new MouseButtonEventHandler(Id1_PreviewMouseDown);
            View.Id11.PreviewMouseDown += new MouseButtonEventHandler(Id1_PreviewMouseDown);
            View.Id12.PreviewMouseDown += new MouseButtonEventHandler(Id1_PreviewMouseDown);
            View.Id13.PreviewMouseDown += new MouseButtonEventHandler(Id1_PreviewMouseDown);
            View.Id14.PreviewMouseDown += new MouseButtonEventHandler(Id1_PreviewMouseDown);
            View.Id15.PreviewMouseDown += new MouseButtonEventHandler(Id1_PreviewMouseDown);
            View.Id16.PreviewMouseDown += new MouseButtonEventHandler(Id1_PreviewMouseDown);
            View.Id17.PreviewMouseDown += new MouseButtonEventHandler(Id1_PreviewMouseDown);
            View.Id18.PreviewMouseDown += new MouseButtonEventHandler(Id1_PreviewMouseDown);
            View.Id19.PreviewMouseDown += new MouseButtonEventHandler(Id1_PreviewMouseDown);
            View.Id20.PreviewMouseDown += new MouseButtonEventHandler(Id1_PreviewMouseDown);
            View.Id21.PreviewMouseDown += new MouseButtonEventHandler(Id1_PreviewMouseDown);
            View.Id22.PreviewMouseDown += new MouseButtonEventHandler(Id1_PreviewMouseDown);
            View.Id23.PreviewMouseDown += new MouseButtonEventHandler(Id1_PreviewMouseDown);
            View.Id24.PreviewMouseDown += new MouseButtonEventHandler(Id1_PreviewMouseDown);
            View.Id25.PreviewMouseDown += new MouseButtonEventHandler(Id1_PreviewMouseDown);
            View.Id26.PreviewMouseDown += new MouseButtonEventHandler(Id1_PreviewMouseDown);
            View.Id27.PreviewMouseDown += new MouseButtonEventHandler(Id1_PreviewMouseDown);
            View.Id28.PreviewMouseDown += new MouseButtonEventHandler(Id1_PreviewMouseDown);
            View.Id29.PreviewMouseDown += new MouseButtonEventHandler(Id1_PreviewMouseDown);
            View.Id30.PreviewMouseDown += new MouseButtonEventHandler(Id1_PreviewMouseDown);
            View.Id31.PreviewMouseDown += new MouseButtonEventHandler(Id1_PreviewMouseDown);
            View.Id32.PreviewMouseDown += new MouseButtonEventHandler(Id1_PreviewMouseDown);
            View.Id33.PreviewMouseDown += new MouseButtonEventHandler(Id1_PreviewMouseDown);
            View.Id34.PreviewMouseDown += new MouseButtonEventHandler(Id1_PreviewMouseDown);
            View.Id35.PreviewMouseDown += new MouseButtonEventHandler(Id1_PreviewMouseDown);
            View.Id36.PreviewMouseDown += new MouseButtonEventHandler(Id1_PreviewMouseDown);
            View.Id37.PreviewMouseDown += new MouseButtonEventHandler(Id1_PreviewMouseDown);
            View.Id38.PreviewMouseDown += new MouseButtonEventHandler(Id1_PreviewMouseDown);
            View.Id39.PreviewMouseDown += new MouseButtonEventHandler(Id1_PreviewMouseDown);
            View.Id40.PreviewMouseDown += new MouseButtonEventHandler(Id1_PreviewMouseDown);
            View.Id41.PreviewMouseDown += new MouseButtonEventHandler(Id1_PreviewMouseDown);
            View.Id42.PreviewMouseDown += new MouseButtonEventHandler(Id1_PreviewMouseDown);
            View.Id43.PreviewMouseDown += new MouseButtonEventHandler(Id1_PreviewMouseDown);
            View.Id44.PreviewMouseDown += new MouseButtonEventHandler(Id1_PreviewMouseDown);
            View.Id45.PreviewMouseDown += new MouseButtonEventHandler(Id1_PreviewMouseDown);
            View.Id46.PreviewMouseDown += new MouseButtonEventHandler(Id1_PreviewMouseDown);
            View.Id47.PreviewMouseDown += new MouseButtonEventHandler(Id1_PreviewMouseDown);
            View.Id48.PreviewMouseDown += new MouseButtonEventHandler(Id1_PreviewMouseDown);
            View.Id49.PreviewMouseDown += new MouseButtonEventHandler(Id1_PreviewMouseDown);
            View.Id50.PreviewMouseDown += new MouseButtonEventHandler(Id1_PreviewMouseDown);
            View.Id51.PreviewMouseDown += new MouseButtonEventHandler(Id1_PreviewMouseDown);
            View.Id52.PreviewMouseDown += new MouseButtonEventHandler(Id1_PreviewMouseDown);
            View.Id53.PreviewMouseDown += new MouseButtonEventHandler(Id1_PreviewMouseDown);
            View.Id54.PreviewMouseDown += new MouseButtonEventHandler(Id1_PreviewMouseDown);
            View.Id55.PreviewMouseDown += new MouseButtonEventHandler(Id1_PreviewMouseDown);
            View.Id56.PreviewMouseDown += new MouseButtonEventHandler(Id1_PreviewMouseDown);
            View.Id57.PreviewMouseDown += new MouseButtonEventHandler(Id1_PreviewMouseDown);
            View.Id58.PreviewMouseDown += new MouseButtonEventHandler(Id1_PreviewMouseDown);
            View.Id59.PreviewMouseDown += new MouseButtonEventHandler(Id1_PreviewMouseDown);
            View.Id60.PreviewMouseDown += new MouseButtonEventHandler(Id1_PreviewMouseDown);
            View.Id61.PreviewMouseDown += new MouseButtonEventHandler(Id1_PreviewMouseDown);
            View.Id62.PreviewMouseDown += new MouseButtonEventHandler(Id1_PreviewMouseDown);
            View.Id63.PreviewMouseDown += new MouseButtonEventHandler(Id1_PreviewMouseDown);
            View.Id64.PreviewMouseDown += new MouseButtonEventHandler(Id1_PreviewMouseDown);

            View.JamesDeKorneTab.PreviewMouseDown += new MouseButtonEventHandler(JamesDeKorneTab_MouseLeftButtonDown);
            View.colorbutton.Click += new RoutedEventHandler(colorbutton_Click);
            View.button_Copy.Click += new RoutedEventHandler(button_Copy_Click);
            View.button.Click += new RoutedEventHandler(button_Click_5);
            View.savebutton.Click += new RoutedEventHandler(Button_Click_4);
            View.TracerBtn.Click += new RoutedEventHandler(Button_Click_3);
            View.Xbutton.Click += new RoutedEventHandler(Button_Click_2);
            View.SearchButton.Click += new RoutedEventHandler(Button_Click_1);
            View.TextButton.Click += new RoutedEventHandler(Button_ClickText);
            View.LinesButton.Click += new RoutedEventHandler(Button_Click);
        }

        private int currentlyShowing = 0;
        private bool tracing = false;
        private List<TraceRoute> RouteMaps = new List<TraceRoute>(0);
        private string LastKeyPressed = "";
        private int LastPressedTimestamp = -1;

        public ViewModelV1_0()
        {
            AddEventHandlers();

            //InitializeComponent();
#warning Does initializecomponent wait for all the objects to be loaded/created before going on? Should maybe add a different thread and some kind of progress bar/wait until components are loaded before continuing.

            // Add (Initialize) our custom controls in here
            var control = new HexagramImagesPortugeseV1_0();
            control.Opacity = 1.0;
            View.HexagramGrid.Children.Add(control);

            SetupTable();

            Random rand = new Random();
            int randInt = rand.Next(1, 64);

            currentlyShowing = randInt;

            updateApplication();



            deserializeRouteMaps();
            View.Show();


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
                            View.ChienPanel.Children.Add(HexBorder);
                            break;
                        case 1:
                            View.ChenPanel.Children.Add(HexBorder);
                            break;
                        case 2:
                            View.KanPanel.Children.Add(HexBorder);
                            break;
                        case 3:
                            View.KenPanel.Children.Add(HexBorder);
                            break;
                        case 4:
                            View.KunPanel.Children.Add(HexBorder);
                            break;
                        case 5:
                            View.SunPanel.Children.Add(HexBorder);
                            break;
                        case 6:
                            View.LiPanel.Children.Add(HexBorder);
                            break;
                        case 7:
                            View.TuiPanel.Children.Add(HexBorder);
                            break;


                    }
                }
            }

            //TitleBox.Text = hexResult;
            //TitleBox.PreviewMouseDown += new MouseButtonEventHandler(SearchItemClick);
        }

        private void updateApplication()
        {
            View.TitleBoxNum.Content = currentlyShowing + ". ";
            View.TitleBoxChi.Content = Model.iChing[currentlyShowing].ChiSymbol + " ";
            View.TitleBoxText.Content = Model.iChing[currentlyShowing].ChiTitle + " / " + Model.iChing[currentlyShowing].EngTitle;
            View.HexTitle.Text = Model.iChing[currentlyShowing].Hex;
            View.AlternateTitlesBox.Text = "Alternate Titles: " + Model.iChing[currentlyShowing].AltTitles;
            View.AboveBelowBox.Text = Model.iChing[currentlyShowing].Above + "\n" + Model.iChing[currentlyShowing].Below;
            View.AboveBelowSymbolsBox.Text = Model.iChing[currentlyShowing].AboveSymbol + "\n" + Model.iChing[currentlyShowing].BelowSymbol;
            View.Intro1Box.Text = Model.iChing[currentlyShowing].Intro1;
            View.TheJudgmentBox.Text = Model.iChing[currentlyShowing].TheJudgment;
            View.Intro2Box.Text = Model.iChing[currentlyShowing].Intro2;
            View.TheImageBox.Text = Model.iChing[currentlyShowing].TheImage;
            View.Intro3Box.Text = Model.iChing[currentlyShowing].Intro3;
            View.Line1Box.Text = Model.iChing[currentlyShowing].Read1;
            View.Line2Box.Text = Model.iChing[currentlyShowing].Read2;
            View.Line3Box.Text = Model.iChing[currentlyShowing].Read3;
            View.Line4Box.Text = Model.iChing[currentlyShowing].Read4;
            View.Line5Box.Text = Model.iChing[currentlyShowing].Read5;
            View.Line6Box.Text = Model.iChing[currentlyShowing].Read6;
            View.ChangesTo1.Text = "● " + Model.iChing[currentlyShowing].Place1ChangesToNumber + ". " + Model.iChing[Model.iChing[currentlyShowing].Place1ChangesToNumber].EngTitle + " ●";
            View.ChangesTo2.Text = "● " + Model.iChing[currentlyShowing].Place2ChangesToNumber + ". " + Model.iChing[Model.iChing[currentlyShowing].Place2ChangesToNumber].EngTitle + " ●";
            View.ChangesTo3.Text = "● " + Model.iChing[currentlyShowing].Place3ChangesToNumber + ". " + Model.iChing[Model.iChing[currentlyShowing].Place3ChangesToNumber].EngTitle + " ●";
            View.ChangesTo4.Text = "● " + Model.iChing[currentlyShowing].Place4ChangesToNumber + ". " + Model.iChing[Model.iChing[currentlyShowing].Place4ChangesToNumber].EngTitle + " ●";
            View.ChangesTo5.Text = "● " + Model.iChing[currentlyShowing].Place5ChangesToNumber + ". " + Model.iChing[Model.iChing[currentlyShowing].Place5ChangesToNumber].EngTitle + " ●";
            View.ChangesTo6.Text = "● " + Model.iChing[currentlyShowing].Place6ChangesToNumber + ". " + Model.iChing[Model.iChing[currentlyShowing].Place6ChangesToNumber].EngTitle + " ●";

            View.Changes1BoxNumber.Text = Model.iChing[currentlyShowing].Place1ChangesToNumber + ". ";
            View.Changes2BoxNumber.Text = Model.iChing[currentlyShowing].Place2ChangesToNumber + ". ";
            View.Changes3BoxNumber.Text = Model.iChing[currentlyShowing].Place3ChangesToNumber + ". ";
            View.Changes4BoxNumber.Text = Model.iChing[currentlyShowing].Place4ChangesToNumber + ". ";
            View.Changes5BoxNumber.Text = Model.iChing[currentlyShowing].Place5ChangesToNumber + ". ";
            View.Changes6BoxNumber.Text = Model.iChing[currentlyShowing].Place6ChangesToNumber + ". ";
            View.Changes1BoxText.Text = Model.iChing[Model.iChing[currentlyShowing].Place1ChangesToNumber].EngTitle;
            View.Changes2BoxText.Text = Model.iChing[Model.iChing[currentlyShowing].Place2ChangesToNumber].EngTitle;
            View.Changes3BoxText.Text = Model.iChing[Model.iChing[currentlyShowing].Place3ChangesToNumber].EngTitle;
            View.Changes4BoxText.Text = Model.iChing[Model.iChing[currentlyShowing].Place4ChangesToNumber].EngTitle;
            View.Changes5BoxText.Text = Model.iChing[Model.iChing[currentlyShowing].Place5ChangesToNumber].EngTitle;
            View.Changes6BoxText.Text = Model.iChing[Model.iChing[currentlyShowing].Place6ChangesToNumber].EngTitle;
            View.Changes1BoxH.Text = Model.iChing[Model.iChing[currentlyShowing].Place1ChangesToNumber].Hex;
            View.Changes2BoxH.Text = Model.iChing[Model.iChing[currentlyShowing].Place2ChangesToNumber].Hex;
            View.Changes3BoxH.Text = Model.iChing[Model.iChing[currentlyShowing].Place3ChangesToNumber].Hex;
            View.Changes4BoxH.Text = Model.iChing[Model.iChing[currentlyShowing].Place4ChangesToNumber].Hex;
            View.Changes5BoxH.Text = Model.iChing[Model.iChing[currentlyShowing].Place5ChangesToNumber].Hex;
            View.Changes6BoxH.Text = Model.iChing[Model.iChing[currentlyShowing].Place6ChangesToNumber].Hex;
            View.Line1BoxSquareCircle.Text = Model.iChing[currentlyShowing].SquareCircle1;
            View.Line2BoxSquareCircle.Text = Model.iChing[currentlyShowing].SquareCircle2;
            View.Line3BoxSquareCircle.Text = Model.iChing[currentlyShowing].SquareCircle3;
            View.Line4BoxSquareCircle.Text = Model.iChing[currentlyShowing].SquareCircle4;
            View.Line5BoxSquareCircle.Text = Model.iChing[currentlyShowing].SquareCircle5;
            View.Line6BoxSquareCircle.Text = Model.iChing[currentlyShowing].SquareCircle6;
            View.Line1BoxSquareCircle_Copy.Text = Model.iChing[currentlyShowing].SquareCircle1;
            View.Line2BoxSquareCircle_Copy.Text = Model.iChing[currentlyShowing].SquareCircle2;
            View.Line3BoxSquareCircle_Copy.Text = Model.iChing[currentlyShowing].SquareCircle3;
            View.Line4BoxSquareCircle_Copy1.Text = Model.iChing[currentlyShowing].SquareCircle4;
            View.Line5BoxSquareCircle_Copy.Text = Model.iChing[currentlyShowing].SquareCircle5;
            View.Line6BoxSquareCircle_Copy.Text = Model.iChing[currentlyShowing].SquareCircle6;
            View.BorderComment1.Visibility = Visibility.Collapsed;
            View.BorderComment2.Visibility = Visibility.Collapsed;
            View.BorderComment3.Visibility = Visibility.Collapsed;
            View.BorderComment4.Visibility = Visibility.Collapsed;
            View.BorderComment5.Visibility = Visibility.Collapsed;
            View.BorderComment6.Visibility = Visibility.Collapsed;


            var SquareCircleTextBoxes = new List<TextBox>();
            SquareCircleTextBoxes.Add(View.Line1BoxSquareCircle_Copy);
            SquareCircleTextBoxes.Add(View.Line2BoxSquareCircle_Copy);
            SquareCircleTextBoxes.Add(View.Line3BoxSquareCircle_Copy);
            SquareCircleTextBoxes.Add(View.Line4BoxSquareCircle_Copy1);
            SquareCircleTextBoxes.Add(View.Line5BoxSquareCircle_Copy);
            SquareCircleTextBoxes.Add(View.Line6BoxSquareCircle_Copy);

            var ChangesNumberBox = new List<TextBox>();
            ChangesNumberBox.Add(View.Changes1BoxNumber);
            ChangesNumberBox.Add(View.Changes2BoxNumber);
            ChangesNumberBox.Add(View.Changes3BoxNumber);
            ChangesNumberBox.Add(View.Changes4BoxNumber);
            ChangesNumberBox.Add(View.Changes5BoxNumber);
            ChangesNumberBox.Add(View.Changes6BoxNumber);

            var ChangesTextBox = new List<TextBox>();
            ChangesTextBox.Add(View.Changes1BoxText);
            ChangesTextBox.Add(View.Changes2BoxText);
            ChangesTextBox.Add(View.Changes3BoxText);
            ChangesTextBox.Add(View.Changes4BoxText);
            ChangesTextBox.Add(View.Changes5BoxText);
            ChangesTextBox.Add(View.Changes6BoxText);


            var ChangesHTextBox = new List<TextBox>();
            ChangesHTextBox.Add(View.Changes1BoxH);
            ChangesHTextBox.Add(View.Changes2BoxH);
            ChangesHTextBox.Add(View.Changes3BoxH);
            ChangesHTextBox.Add(View.Changes4BoxH);
            ChangesHTextBox.Add(View.Changes5BoxH);
            ChangesHTextBox.Add(View.Changes6BoxH);


            var control = View.HexagramGrid.Children[0];
            PropertyInfo p = View.HexagramGrid.Children[0].GetType().GetProperty("currentlyShowing");
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
                View.HexBox.Text = Model.iChing[currentlyShowing].Hex;
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

            switch (View.JamesDeKorneTab.IsSelected)
            {
                case true:
                    byte[] content = Convert.FromBase64String(Model.GnosticJamesDeKorneEdition[currentlyShowing]);

                    View.jamesDKRTB.Document.Blocks.Clear();
                    System.IO.MemoryStream ms = new System.IO.MemoryStream(content);
                    TextRange tRange = new TextRange(View.jamesDKRTB.Document.ContentStart, View.jamesDKRTB.Document.ContentEnd);
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
            if (View.BorderComment1.Visibility == System.Windows.Visibility.Collapsed)
            {
                View.BorderComment1.Visibility = System.Windows.Visibility.Visible;
                View.Comment1.Text = Model.WilhelmBaynesComments[currentlyShowing].Read1;
                View.BorderComment1.BringIntoView();
            }
            else
            {
                View.BorderComment1.Visibility = System.Windows.Visibility.Collapsed;
            }
        }


        private void displayNumber(int number)
        {
            currentlyShowing = number;
            View.MainTextViewer.ScrollToTop();
            updateApplication();
            View.TabControl1.SelectedIndex = 0;
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
            if (View.BorderComment6.Visibility == System.Windows.Visibility.Collapsed)
            {
                View.BorderComment6.Visibility = System.Windows.Visibility.Visible;
                View.Comment6.Text = Model.WilhelmBaynesComments[currentlyShowing].Read6;
                View.BorderComment6.BringIntoView();
            }
            else
            {
                View.BorderComment6.Visibility = System.Windows.Visibility.Collapsed;
            }
        }

        private void Line5Box_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (View.BorderComment5.Visibility == System.Windows.Visibility.Collapsed)
            {
                View.BorderComment5.Visibility = System.Windows.Visibility.Visible;
                View.Comment5.Text = Model.WilhelmBaynesComments[currentlyShowing].Read5;
                View.BorderComment5.BringIntoView();

            }
            else
            {
                View.BorderComment5.Visibility = System.Windows.Visibility.Collapsed;
            }
        }

        private void Line4Box_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (View.BorderComment4.Visibility == System.Windows.Visibility.Collapsed)
            {
                View.BorderComment4.Visibility = System.Windows.Visibility.Visible;
                View.Comment4.Text = Model.WilhelmBaynesComments[currentlyShowing].Read4;
                View.BorderComment4.BringIntoView();
            }
            else
            {
                View.BorderComment4.Visibility = System.Windows.Visibility.Collapsed;
            }
        }

        private void Line3Box_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (View.BorderComment3.Visibility == System.Windows.Visibility.Collapsed)
            {
                View.BorderComment3.Visibility = System.Windows.Visibility.Visible;
                View.Comment3.Text = Model.WilhelmBaynesComments[currentlyShowing].Read3;
                View.BorderComment3.BringIntoView();
            }
            else
            {
                View.BorderComment3.Visibility = System.Windows.Visibility.Collapsed;
            }
        }

        private void Line2Box_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (View.BorderComment2.Visibility == System.Windows.Visibility.Collapsed)
            {
                View.BorderComment2.Visibility = System.Windows.Visibility.Visible;
                View.Comment2.Text = Model.WilhelmBaynesComments[currentlyShowing].Read2;
                View.BorderComment2.BringIntoView();
                ;
            }
            else
            {
                View.BorderComment2.Visibility = System.Windows.Visibility.Collapsed;
            }
        }

        private void SetToLines()
        {
            switch (View.JamesDeKorneTab.IsSelected)
            {
                case true:
                    string keyword = "Line-1";
                    TextRange text = new TextRange(View.jamesDKRTB.Document.ContentStart, View.jamesDKRTB.Document.ContentEnd);
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
                                View.jamesDKRTB.ScrollToVerticalOffset(i * 3);
                            }
                        }
                        current = current.GetNextContextPosition(LogicalDirection.Forward);
                        i++;
                    }
                    break;
                default:
                    View.MainTextViewer.UpdateLayout();
                    View.MainTextViewer.ScrollToVerticalOffset(View.Intro1Box.ActualHeight + View.TheJudgmentBox.ActualHeight + View.Intro2Box.ActualHeight + View.TheImageBox.ActualHeight + View.Intro3Box.ActualHeight + View.AboveBelowBox.ActualHeight + 17);
                    break;
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            SetToLines();
        }

        private void Button_ClickText(object sender, RoutedEventArgs e)
        {
            View.MainTextViewer.ScrollToTop();
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
                    switch (View.JamesDeKorneTab.IsSelected)
                    {
                        case true:
                            View.jamesDKRTB.LineUp();
                            break;
                        case false:
                            View.MainTextViewer.LineUp();
                            break;
                    }
                    break;
                case Key.Down:
                    switch (View.JamesDeKorneTab.IsSelected)
                    {
                        case true:
                            View.jamesDKRTB.LineDown();
                            break;
                        case false:
                            View.MainTextViewer.LineDown();
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
                                if ((hexagramToShow <= 64) && (hexagramToShow > 0))
                                {
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
            int indexToDelete = (View.TracingPanel.Children.IndexOf(sp) - 1) / 2;
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

            int indexToMove = (View.TracingPanel.Children.IndexOf(sp) - 1) / 2;
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
            int indexToMove = (View.TracingPanel.Children.IndexOf(sp) - 1) / 2;
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
            int indexToMove = (View.TracingPanel.Children.IndexOf(sp) - 1) / 2;
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
            View.colorbutton.Visibility = Visibility.Visible;
            View.Colorbar.Visibility = Visibility.Visible;

            MenuItem mnu = sender as MenuItem;
            StackPanel sp = null;
            if (mnu != null)
            {
                sp = ((ContextMenu)mnu.Parent).PlacementTarget as StackPanel;
            }
            SolidColorBrush b = sp.Background as SolidColorBrush;
            if (b.Color.A != 0)
            {
                View.Colorbar.SelectedColor = b.Color;
            }
            int index = (View.TracingPanel.Children.IndexOf(sp) - 1) / 2;
            View.Colorbar.Tag = index;
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
            if (!String.IsNullOrEmpty(View.SearchEntry.Text))
            {
                View.SearchViewer.Visibility = Visibility.Visible;
                string substr = View.SearchEntry.Text;


                /*TextBox newBox = new TextBox();
                newBox.Text = "Hello1";
                newBox.PreviewMouseDown += new MouseButtonEventHandler((s2, e2) => SearchItemClick(s2,e2, 12));
                SearchPanel.Children.Add(newBox);
                SearchPanel.UpdateLayout();
                */

                for (int i = 1; i <= 64; i++)
                {

                    string MainText = SearchTextPortion(Model.iChing[i].Intro1, View.SearchEntry.Text);
                    MainText += SearchTextPortion(Model.iChing[i].TheJudgment, View.SearchEntry.Text);
                    MainText += SearchTextPortion(Model.iChing[i].Intro2, View.SearchEntry.Text);
                    MainText += SearchTextPortion(Model.iChing[i].TheImage, View.SearchEntry.Text);
                    MainText += SearchTextPortion(Model.iChing[i].Intro3, View.SearchEntry.Text);

                    string Lines = SearchLinesPortion(Model.iChing[i].Read1, View.SearchEntry.Text, "1");
                    Lines += SearchLinesPortion(Model.iChing[i].Read2, View.SearchEntry.Text, "2");
                    Lines += SearchLinesPortion(Model.iChing[i].Read3, View.SearchEntry.Text, "3");
                    Lines += SearchLinesPortion(Model.iChing[i].Read4, View.SearchEntry.Text, "4");
                    Lines += SearchLinesPortion(Model.iChing[i].Read5, View.SearchEntry.Text, "5");
                    Lines += SearchLinesPortion(Model.iChing[i].Read6, View.SearchEntry.Text, "6");

                    string Comments = SearchLinesPortion(Model.WilhelmBaynesComments[i].Read1, View.SearchEntry.Text, "1");
                    Comments += SearchLinesPortion(Model.WilhelmBaynesComments[i].Read2, View.SearchEntry.Text, "2");
                    Comments += SearchLinesPortion(Model.WilhelmBaynesComments[i].Read3, View.SearchEntry.Text, "3");
                    Comments += SearchLinesPortion(Model.WilhelmBaynesComments[i].Read4, View.SearchEntry.Text, "4");
                    Comments += SearchLinesPortion(Model.WilhelmBaynesComments[i].Read5, View.SearchEntry.Text, "5");
                    Comments += SearchLinesPortion(Model.WilhelmBaynesComments[i].Read6, View.SearchEntry.Text, "6");




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
                        View.SearchPanel.Children.Add(TitleBox);

                        if (textResult)
                        {
                            TextBox mainTextBox = new TextBox();
                            mainTextBox.Tag = i;
                            mainTextBox.Text = "[Text] " + MainText;
                            mainTextBox.PreviewMouseDown += new MouseButtonEventHandler(SearchItemClick);
                            View.SearchPanel.Children.Add(mainTextBox);
                        }

                        if (linesResult)
                        {
                            TextBox linesBox = new TextBox();
                            linesBox.Tag = i;
                            linesBox.Text = "[Lines] " + Lines;
                            linesBox.PreviewMouseDown += new MouseButtonEventHandler(SearchItemClick);
                            View.SearchPanel.Children.Add(linesBox);
                        }
                        if (commentsResult)
                        {
                            TextBox commentBox = new TextBox();
                            commentBox.Tag = i;
                            commentBox.Text = "[Comments] " + Comments;
                            commentBox.PreviewMouseDown += new MouseButtonEventHandler(SearchItemClick);
                            View.SearchPanel.Children.Add(commentBox);
                        }

                        View.SearchPanel.UpdateLayout();
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
            View.SearchPanel.Children.Clear();
            View.SearchViewer.Visibility = Visibility.Collapsed;
        }


        private void SearchEntry_KeyUp(object sender, KeyEventArgs e)
        {
            View.SearchPanel.Children.Clear();
            if (View.SearchEntry.Text.Length > 2)
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
            foreach (object child in View.TracingPanel.Children)
            {
                if (child is StackPanel)
                {
                    if (Convert.ToString((child as StackPanel).Tag) == "Map" + Convert.ToString(View.TracingPanel.Children.Count))
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
            int int2 = View.TracingPanel.Children.IndexOf(parentPanel);
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
                    View.TracerBtn.Content = "Trace";
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
                    View.TracerBtn.Content = "Finish Tracing";
                    break;
            }

        }

        private void Tb_TextChanged(object sender, TextChangedEventArgs e)
        {
            int index = View.TracingPanel.Children.IndexOf(sender as TextBox) / 2;
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







        private void TabItem_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void TabItem_Loaded(object sender, RoutedEventArgs e)
        {
            View.TracingPanel.Children.Clear();
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
                    View.TracingPanel.Children.Add(tb);

                    StackPanel newPathPanel = new StackPanel();
                    newPathPanel.Orientation = Orientation.Horizontal;
                    newPathPanel.Tag = "Map" + Convert.ToString(View.TracingPanel.Children.Count + 1);
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

                    View.TracingPanel.Children.Add(newPathPanel);

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
            View.colorbutton.Visibility = Visibility.Hidden;
            View.Colorbar.Visibility = Visibility.Hidden;
            Color? color = View.Colorbar.SelectedColor;
            Color ColorRGBA = (Color)System.Windows.Media.ColorConverter.ConvertFromString(color.ToString());
            RouteMaps[Convert.ToInt32(View.Colorbar.Tag)].SPColor = ColorRGBA;
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
            View.JamesDeKorneTab.IsSelected = true;
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
            View.HexagramGrid.Children[0].Opacity = 1;
        }
    }









}



