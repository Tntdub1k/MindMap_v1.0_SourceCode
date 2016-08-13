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

namespace iChing
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private iChingNumber[] iChing = new iChingNumber[65];

        public MainWindow()
        {
            InitializeComponent();
            SetupText();
        }

        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
            TitleBox.Content = iChing[1].Title;
            AboveBelowBox.Text = iChing[1].Above + "\n" + iChing[1].Below;
            AboveBelowSymbolsBox.Text = iChing[1].AboveSymbol + "\n" + iChing[1].BelowSymbol;
            Intro1Box.Text = iChing[1].Intro1;
            TheJudgmentBox.Text = iChing[1].TheJudgment;
            Intro2Box.Text = iChing[1].Intro2;
            TheImageBox.Text = iChing[1].TheImage;
            Intro3Box.Text = iChing[1].Intro3;
            Line1Box.Text = iChing[1].Read1;
            Line2Box.Text = iChing[1].Read2;
            Line3Box.Text = iChing[1].Read3;
            Line4Box.Text = iChing[1].Read4;
            Line5Box.Text = iChing[1].Read5;
            Line6Box.Text = iChing[1].Read6;
            Changes1Box.Text = iChing[1].Place1ChangesToNumber + ". " + iChing[1].Place1ChangesToTitle;
            Changes2Box.Text = iChing[1].Place2ChangesToNumber + ". " + iChing[1].Place2ChangesToTitle;
            Changes3Box.Text = iChing[1].Place3ChangesToNumber + ". " + iChing[1].Place3ChangesToTitle;
            Changes4Box.Text = iChing[1].Place4ChangesToNumber + ". " + iChing[1].Place4ChangesToTitle;
            Changes5Box.Text = iChing[1].Place5ChangesToNumber + ". " + iChing[1].Place5ChangesToTitle;
            Changes6Box.Text = iChing[1].Place6ChangesToNumber + ". " + iChing[1].Place6ChangesToTitle;
            Line1BoxSquareCircle.Text = iChing[1].SquareCircle1;
            Line2BoxSquareCircle.Text = iChing[1].SquareCircle2;
            Line3BoxSquareCircle.Text = iChing[1].SquareCircle3;
            Line4BoxSquareCircle.Text = iChing[1].SquareCircle4;
            Line5BoxSquareCircle.Text = iChing[1].SquareCircle5;
            Line6BoxSquareCircle.Text = iChing[1].SquareCircle6;


        }



        private void TextBox1_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Comments.Text = "Comments Text Add";
        }



        private void Yin_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            Place5.Fill = (Brush)FindResource("Yang");
            Place4.Fill = (Brush)FindResource("Yang");
        }

        private void SetupText()
        {
            iChing[1] = new iChingNumber();

            //Hexagram 1
            iChing[1].Title = "1. Ch'ien / The Creative";
            iChing[1].Above = "CH'IEN / THE CREATIVE, HEAVEN";
            iChing[1].Below = "CH'IEN / THE CREATIVE, HEAVEN";
            iChing[1].AboveSymbol = "☰";
            iChing[1].BelowSymbol = "☰";
            iChing[1].Intro1 = "The first hexagram is made up of six unbroken lines.  These unbroken lines stand for the primal power, which is light–giving, active, strong, and of the spirit.  The hexagram is consistently strong in character, and since it is without weakness, its essence is power or energy.  Its image is heaven.  Its energy is represented as unrestricted by any fixed conditions in space and is therefore conceived of as motion.  Time is regarded as the basis of this motion.  Thus the hexagram includes also the power of time and the power of persisting in time, that is, duration."+ Environment.NewLine +
                Environment.NewLine +"The power represented by the hexagram is to be interpreted in a dual sense—in terms of its action on the universe and of its action on the world of men.  In relation to the universe, the hexagram expresses the strong, creative action of the Deity.  In relation to the human world, it denotes the creative action of the holy man or sage, of the ruler or leader of men, who through his power awakens and develops their higher nature.";
            iChing[1].TheJudgment = "THE CREATIVE works sublime success,"+ Environment.NewLine +
                "Furthering through perseverance.";
            iChing[1].Intro2 = "According to the original meaning, the attributes [sublimity, potentiality of success, power to further, perseverance] are paired.  When an individual draws this oracle, it means that success will come to him from the primal depths of the universe and that everything depends upon his seeking his happiness and that of others in one way only, that is, by perseverance in what is right."+ Environment.NewLine + Environment.NewLine +
                "The specific meanings of the four attributes became the subject of speculation at an early date.  The Chinese word here rendered by “sublime” means literally “head,” “origin,” “great.”  This is why Confucius says in explaining it: “Great indeed is the generating power of the Creative; all beings owe their beginning to it.  This power permeates all heaven.”  For this attribute inheres in the other three as well."+ Environment.NewLine + Environment.NewLine +
                "The beginning of all things lies still in the beyond in the form of ideas that have yet to become real.  But the Creative furthermore has power to lend form to these archetypes of ideas.  This is indicated in the word success, and the process is represented by an image from nature: “The clouds pass and the rain does its work, and all individual beings flow into their forms.”"+ Environment.NewLine + Environment.NewLine +
                "Applied to the human world, these attributes show the great man the way to notable success: “Because he sees with great clarity causes and effects, he completes the six steps at the right time and mounts toward heaven on them at the right time, as though on six dragons.”  The six steps are the six different positions given in the hexagram, which are represented later by the dragon symbol.  Here it is shown that the way to success lies in apprehending and giving actuality to the way of the universe [tao], which, as a law running through end and beginning, brings about all phenomena in time.  Thus each step attained forthwith becomes a preparation for the next.  Time is no longer a hindrance but the means of making actual what is potential."+ Environment.NewLine + Environment.NewLine +
                "The act of creation having found expression in the two attributes sublimity and success, the work of conservation is shown to be a continuous actualization and differentiation of form.  This is expressed in the two terms “furthering” (literally, “creating that which accords with the nature of a given being”) and “persevering” (literally, “correct and firm”).  “The course of the Creative alters and shapes beings until each attains its true, specific nature, then it keeps them in conformity with the Great Harmony.  Thus does it show itself to further through perseverance.”"+ Environment.NewLine + Environment.NewLine +
                "In relation to the human sphere, this shows how the great man brings peace and security to the world through his activity in creating order: “He towers high above the multitude of beings, and all lands are united in peace.”"+ Environment.NewLine + Environment.NewLine +
                "Another line of speculation goes still further in separating the words “sublime,” “success,” “furthering,” “perseverance,” and parallels them with the four cardinal virtues in humanity.  To sublimity, which, as the fundamental principle, embraces all the other attributes, it links love.  To the attribute success are linked the mores, which regulate and organize expressions of love and thereby make them successful.  The attribute furthering is correlated with justice, which creates the conditions in which each receives that which accords with his being, that which is due him and which constitutes his happiness.  The attribute perseverance is correlated with wisdom, which discerns the immutable laws of all that happens and can therefore bring about enduring conditions.  These speculations, already broached in the commentary called Wên Yen, later formed the bridge connecting the philosophy of the “five stages (elements) of change,” as laid down in the Book of History (Shu Ching) with the philosophy of the Book of Changes, which is based solely on the polarity of positive and negative principles.  In the course of time this combination of the two systems of thought opened the way for an increasingly intricate number symbolism.";
            iChing[1].TheImage = "The movement of heaven is full of power."+ Environment.NewLine +
                "Thus the superior man makes himself strong and untiring.";
            iChing[1].Intro3 = "Since there is only one heaven, the doubling of the trigram Ch’ien, of which heaven is the image, indicates the movement of heaven.  One complete revolution of heaven makes a day, and the repetition of the trigram means that each day is followed by another.  This creates the idea of time.  Since it is the same heaven moving with untiring power, there is also created the idea of duration both in and beyond time, a movement that never stops nor slackens, just as one day follows another in an unending course.  This duration in time is the image of the power inherent in the Creative.\nWith this image as a model, the sage learns how best to develop himself so that his influence may endure.  He must make himself strong in every way, by consciously casting out all that is inferior and degrading.  Thus he attains that tirelessness which depends upon consciously limiting the fields of his activity.";
            iChing[1].Read1 = "Nine in the beginning means:"+ Environment.NewLine +
                "Hidden Dragon. Do not act.";
            iChing[1].Read2 = "Nine in the second place means:"+ Environment.NewLine +
                "Dragon appearing in the field."+ Environment.NewLine +
                "It furthers one to see the great man.";
            iChing[1].Read3 = "Nine in the third place means:" + Environment.NewLine +
                "All day long the superior man is creatively active." + Environment.NewLine +
                "At nightfall his mind is still beset with cares." + Environment.NewLine +
                "Danger. No blame.";
            iChing[1].Read4 = "Nine in the fourth place means:"+Environment.NewLine+
                "Wavering flight over the depths."+Environment.NewLine+
                "No blame.";
            iChing[1].Read5 = "Nine in the fourth place means:" + Environment.NewLine +
                "Flying Dragon in the heavens." + Environment.NewLine +
                "It furthers one to see the great man.";
            iChing[1].Read6 = "Nine at the top means:" + Environment.NewLine +
                "Arrogant Dragon will have cause to repent."+Environment.NewLine+
                Environment.NewLine+
                "When all the lines are nines,  it means:"+Environment.NewLine+
                "There appears a flight of dragons without heads."+Environment.NewLine+
                "Good fortune.";
            iChing[1].Place1ChangesToNumber = "24";
            iChing[1].Place1ChangesToTitle = "Return (The Turning Point) ䷗";
            iChing[1].Place2ChangesToNumber = "7";
            iChing[1].Place2ChangesToTitle = "The Army ䷆";
            iChing[1].Place3ChangesToNumber = "15";
            iChing[1].Place3ChangesToTitle = "Modesty ䷎";
            iChing[1].Place4ChangesToNumber = "16";
            iChing[1].Place4ChangesToTitle = "Enthusiasm ䷏";
            iChing[1].Place5ChangesToNumber = "8";
            iChing[1].Place5ChangesToTitle = "Holding Together ䷇";
            iChing[1].Place6ChangesToNumber = "23";
            iChing[1].Place6ChangesToTitle = "Splitting Apart ䷖";
            iChing[1].SquareCircle1 = "";
            iChing[1].SquareCircle2 = "";
            iChing[1].SquareCircle3 = "";
            iChing[1].SquareCircle4 = "";
            iChing[1].SquareCircle5 = "○";// ○ □
            iChing[1].SquareCircle6 = "";



 
 
        }


    }




    public class iChingNumber
    {
        public iChingNumber() { }

        public iChingNumber(string title, string above, string below,
            string aboveSymbol, string belowSymbol, string intro1, string theJudgment,
            string intro2, string theImage, string intro3, string read1, string read2,
            string read3, string read4, string read5, string read6, string place1ChangesToNumber,
            string place2ChangesToNumber, string place3ChangesToNumber, string place4ChangesToNumber,
            string place5ChangesToNumber, string place6ChangesToNumber, string place1ChangesToTitle,
            string place2ChangesToTitle, string place3ChangesToTitle, string place4ChangesToTitle,
            string place5ChangesToTitle, string place6ChangesToTitle, string squareCircle1,
            string squareCircle2, string squareCircle3, string squareCircle4, string squareCircle5,
            string squareCircle6) 
        {
            Title = title;
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
        }


        public string Title { get; set; }
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
        public string Place1ChangesToNumber { get; set; }
        public string Place2ChangesToNumber { get; set; }
        public string Place3ChangesToNumber { get; set; }
        public string Place4ChangesToNumber { get; set; }
        public string Place5ChangesToNumber { get; set; }
        public string Place6ChangesToNumber { get; set; }
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

    }
}
