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
        private int currentlyShowing = 0;

        public MainWindow()
        {
            InitializeComponent();
            SetupText();
        }

        private void updateApplication()
        {
            TitleBox.Content = iChing[currentlyShowing].Title;
            AboveBelowBox.Text = iChing[currentlyShowing].Above + "\n" + iChing[currentlyShowing].Below;
            AboveBelowSymbolsBox.Text = iChing[currentlyShowing].AboveSymbol + "\n" + iChing[currentlyShowing].BelowSymbol;
            Intro1Box.Text = iChing[currentlyShowing].Intro1;
            TheJudgmentBox.Text = iChing[currentlyShowing].TheJudgment;
            Intro2Box.Text = iChing[currentlyShowing].Intro2;
            TheImageBox.Text = iChing[currentlyShowing].TheImage;
            Intro3Box.Text = iChing[currentlyShowing].Intro3;
            Line1Box.Text = iChing[currentlyShowing].Read1;
            Line2Box.Text = iChing[currentlyShowing].Read2;
            Line3Box.Text = iChing[currentlyShowing].Read3;
            Line4Box.Text = iChing[currentlyShowing].Read4;
            Line5Box.Text = iChing[currentlyShowing].Read5;
            Line6Box.Text = iChing[currentlyShowing].Read6;
            Changes2Box.Text = iChing[currentlyShowing].Place2ChangesToNumber + ". " + iChing[currentlyShowing].Place2ChangesToTitle;
            Changes3Box.Text = iChing[currentlyShowing].Place3ChangesToNumber + ". " + iChing[currentlyShowing].Place3ChangesToTitle;
            Changes4Box.Text = iChing[currentlyShowing].Place4ChangesToNumber + ". " + iChing[currentlyShowing].Place4ChangesToTitle;
            Changes5Box.Text = iChing[currentlyShowing].Place5ChangesToNumber + ". " + iChing[currentlyShowing].Place5ChangesToTitle;
            Changes6Box.Text = iChing[currentlyShowing].Place6ChangesToNumber + ". " + iChing[currentlyShowing].Place6ChangesToTitle;
            Changes1Box.Text = iChing[currentlyShowing].Place1ChangesToNumber + ". " + iChing[currentlyShowing].Place1ChangesToTitle;
            Line1BoxSquareCircle.Text = iChing[currentlyShowing].SquareCircle1;
            Line2BoxSquareCircle.Text = iChing[currentlyShowing].SquareCircle2;
            Line3BoxSquareCircle.Text = iChing[currentlyShowing].SquareCircle3;
            Line4BoxSquareCircle.Text = iChing[currentlyShowing].SquareCircle4;
            Line5BoxSquareCircle.Text = iChing[currentlyShowing].SquareCircle5;
            Line6BoxSquareCircle.Text = iChing[currentlyShowing].SquareCircle6;

        }

        private void TextBox1_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Comments.Text = "Comments Text Add";
        }

        private void Place1_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            if (Place1.Fill == (Brush)FindResource("Yang")) { Place1.Fill = (Brush)FindResource("Yin"); }
            else { Place1.Fill = (Brush)FindResource("Yang"); }
            currentlyShowing = iChing[currentlyShowing].Place1ChangesToNumber;
            updateApplication();
        }

        private void Place2_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            if (Place2.Fill == (Brush)FindResource("Yang")) { Place2.Fill = (Brush)FindResource("Yin"); }
            else { Place2.Fill = (Brush)FindResource("Yang"); }
            currentlyShowing = iChing[currentlyShowing].Place2ChangesToNumber;
            updateApplication();
        }

        private void Place3_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            if (Place3.Fill == (Brush)FindResource("Yang")) { Place3.Fill = (Brush)FindResource("Yin"); }
            else { Place3.Fill = (Brush)FindResource("Yang"); }
            currentlyShowing = iChing[currentlyShowing].Place3ChangesToNumber;
            updateApplication();
        }

        private void Place4_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            if (Place4.Fill == (Brush)FindResource("Yang")) { Place4.Fill = (Brush)FindResource("Yin"); }
            else { Place4.Fill = (Brush)FindResource("Yang"); }
            currentlyShowing = iChing[currentlyShowing].Place4ChangesToNumber;
            updateApplication();
        }

        private void Place5_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            if (Place5.Fill == (Brush)FindResource("Yang")) { Place5.Fill = (Brush)FindResource("Yin"); }
            else { Place5.Fill = (Brush)FindResource("Yang"); }
            currentlyShowing = iChing[currentlyShowing].Place5ChangesToNumber;
            updateApplication();
        }

        private void Place6_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            if (Place6.Fill == (Brush)FindResource("Yang")) { Place6.Fill = (Brush)FindResource("Yin"); }
            else { Place6.Fill = (Brush)FindResource("Yang"); }
            currentlyShowing = iChing[currentlyShowing].Place6ChangesToNumber;
            updateApplication();
        }

        private void SetupText()
        {
            for (int i = 0; i <= 64; i++)
            {
                iChing[i] = new iChingNumber();
            }

            int Hexagram;


            Hexagram = 1;
            iChing[Hexagram].Title = "1. Ch'ien / The Creative";
            iChing[Hexagram].Above = "CH'IEN / THE CREATIVE, HEAVEN";
            iChing[Hexagram].Below = "CH'IEN / THE CREATIVE, HEAVEN";
            iChing[Hexagram].AboveSymbol = "☰";
            iChing[Hexagram].BelowSymbol = "☰";
            iChing[Hexagram].Intro1 = "The first hexagram is made up of six unbroken lines.  These unbroken lines stand for the primal power, which is light–giving, active, strong, and of the spirit.  The hexagram is consistently strong in character, and since it is without weakness, its essence is power or energy.  Its image is heaven.  Its energy is represented as unrestricted by any fixed conditions in space and is therefore conceived of as motion.  Time is regarded as the basis of this motion.  Thus the hexagram includes also the power of time and the power of persisting in time, that is, duration."+ Environment.NewLine +
                Environment.NewLine +"The power represented by the hexagram is to be interpreted in a dual sense—in terms of its action on the universe and of its action on the world of men.  In relation to the universe, the hexagram expresses the strong, creative action of the Deity.  In relation to the human world, it denotes the creative action of the holy man or sage, of the ruler or leader of men, who through his power awakens and develops their higher nature.";
            iChing[Hexagram].TheJudgment = "THE CREATIVE works sublime success,"+ Environment.NewLine +
                "Furthering through perseverance.";
            iChing[Hexagram].Intro2 = "According to the original meaning, the attributes [sublimity, potentiality of success, power to further, perseverance] are paired.  When an individual draws this oracle, it means that success will come to him from the primal depths of the universe and that everything depends upon his seeking his happiness and that of others in one way only, that is, by perseverance in what is right."+ Environment.NewLine + Environment.NewLine +
                "The specific meanings of the four attributes became the subject of speculation at an early date.  The Chinese word here rendered by “sublime” means literally “head,” “origin,” “great.”  This is why Confucius says in explaining it: “Great indeed is the generating power of the Creative; all beings owe their beginning to it.  This power permeates all heaven.”  For this attribute inheres in the other three as well."+ Environment.NewLine + Environment.NewLine +
                "The beginning of all things lies still in the beyond in the form of ideas that have yet to become real.  But the Creative furthermore has power to lend form to these archetypes of ideas.  This is indicated in the word success, and the process is represented by an image from nature: “The clouds pass and the rain does its work, and all individual beings flow into their forms.”"+ Environment.NewLine + Environment.NewLine +
                "Applied to the human world, these attributes show the great man the way to notable success: “Because he sees with great clarity causes and effects, he completes the six steps at the right time and mounts toward heaven on them at the right time, as though on six dragons.”  The six steps are the six different positions given in the hexagram, which are represented later by the dragon symbol.  Here it is shown that the way to success lies in apprehending and giving actuality to the way of the universe [tao], which, as a law running through end and beginning, brings about all phenomena in time.  Thus each step attained forthwith becomes a preparation for the next.  Time is no longer a hindrance but the means of making actual what is potential."+ Environment.NewLine + Environment.NewLine +
                "The act of creation having found expression in the two attributes sublimity and success, the work of conservation is shown to be a continuous actualization and differentiation of form.  This is expressed in the two terms “furthering” (literally, “creating that which accords with the nature of a given being”) and “persevering” (literally, “correct and firm”).  “The course of the Creative alters and shapes beings until each attains its true, specific nature, then it keeps them in conformity with the Great Harmony.  Thus does it show itself to further through perseverance.”"+ Environment.NewLine + Environment.NewLine +
                "In relation to the human sphere, this shows how the great man brings peace and security to the world through his activity in creating order: “He towers high above the multitude of beings, and all lands are united in peace.”"+ Environment.NewLine + Environment.NewLine +
                "Another line of speculation goes still further in separating the words “sublime,” “success,” “furthering,” “perseverance,” and parallels them with the four cardinal virtues in humanity.  To sublimity, which, as the fundamental principle, embraces all the other attributes, it links love.  To the attribute success are linked the mores, which regulate and organize expressions of love and thereby make them successful.  The attribute furthering is correlated with justice, which creates the conditions in which each receives that which accords with his being, that which is due him and which constitutes his happiness.  The attribute perseverance is correlated with wisdom, which discerns the immutable laws of all that happens and can therefore bring about enduring conditions.  These speculations, already broached in the commentary called Wên Yen, later formed the bridge connecting the philosophy of the “five stages (elements) of change,” as laid down in the Book of History (Shu Ching) with the philosophy of the Book of Changes, which is based solely on the polarity of positive and negative principles.  In the course of time this combination of the two systems of thought opened the way for an increasingly intricate number symbolism.";
            iChing[Hexagram].TheImage = "The movement of heaven is full of power."+ Environment.NewLine +
                "Thus the superior man makes himself strong and untiring.";
            iChing[Hexagram].Intro3 = "Since there is only one heaven, the doubling of the trigram Ch’ien, of which heaven is the image, indicates the movement of heaven.  One complete revolution of heaven makes a day, and the repetition of the trigram means that each day is followed by another.  This creates the idea of time.  Since it is the same heaven moving with untiring power, there is also created the idea of duration both in and beyond time, a movement that never stops nor slackens, just as one day follows another in an unending course.  This duration in time is the image of the power inherent in the Creative.\nWith this image as a model, the sage learns how best to develop himself so that his influence may endure.  He must make himself strong in every way, by consciously casting out all that is inferior and degrading.  Thus he attains that tirelessness which depends upon consciously limiting the fields of his activity.";
            iChing[Hexagram].Read1 = "Nine in the beginning means:"+ Environment.NewLine +
                "Hidden Dragon. Do not act.";
            iChing[Hexagram].Read2 = "Nine in the second place means:"+ Environment.NewLine +
                "Dragon appearing in the field."+ Environment.NewLine +
                "It furthers one to see the great man.";
            iChing[Hexagram].Read3 = "Nine in the third place means:" + Environment.NewLine +
                "All day long the superior man is creatively active." + Environment.NewLine +
                "At nightfall his mind is still beset with cares." + Environment.NewLine +
                "Danger. No blame.";
            iChing[Hexagram].Read4 = "Nine in the fourth place means:"+Environment.NewLine+
                "Wavering flight over the depths."+Environment.NewLine+
                "No blame.";
            iChing[Hexagram].Read5 = "Nine in the fifth place means:" + Environment.NewLine +
                "Flying Dragon in the heavens." + Environment.NewLine +
                "It furthers one to see the great man.";
            iChing[Hexagram].Read6 = "Nine at the top means:" + Environment.NewLine +
                "Arrogant Dragon will have cause to repent."+Environment.NewLine+
                Environment.NewLine+
                "When all the lines are nines,  it means:"+Environment.NewLine+
                "There appears a flight of dragons without heads."+Environment.NewLine+
                "Good fortune.";
            iChing[Hexagram].Place1ChangesToNumber = 44;
            iChing[Hexagram].Place1ChangesToTitle = "Coming to Meet ䷫";
            iChing[Hexagram].Place2ChangesToNumber = 13;
            iChing[Hexagram].Place2ChangesToTitle = "Fellowship with Men ䷌";
            iChing[Hexagram].Place3ChangesToNumber = 10;
            iChing[Hexagram].Place3ChangesToTitle = "Treading (Conduct) ䷉";
            iChing[Hexagram].Place4ChangesToNumber = 9;
            iChing[Hexagram].Place4ChangesToTitle = "The Taming Power of the Small ䷈";
            iChing[Hexagram].Place5ChangesToNumber = 14;
            iChing[Hexagram].Place5ChangesToTitle = "Possesion in Great Measure ䷍";
            iChing[Hexagram].Place6ChangesToNumber = 43;
            iChing[Hexagram].Place6ChangesToTitle = "Break-Through (Resoluteness) ䷪";
            iChing[Hexagram].SquareCircle1 = "";
            iChing[Hexagram].SquareCircle2 = "";
            iChing[Hexagram].SquareCircle3 = "";
            iChing[Hexagram].SquareCircle4 = "";
            iChing[Hexagram].SquareCircle5 = "○";// ○ □
            iChing[Hexagram].SquareCircle6 = "";

            Hexagram = 2;
            iChing[Hexagram].Title = "2. K'un / The Receptive";
            iChing[Hexagram].Above = "K’UN  /  THE RECEPTIVE, EARTH";
            iChing[Hexagram].Below = "K’UN  /  THE RECEPTIVE, EARTH";
            iChing[Hexagram].AboveSymbol = "☷";
            iChing[Hexagram].BelowSymbol = "☷";
            iChing[Hexagram].Intro1 = "This hexagram is made up of broken lines only.  The broken line represents the dark, yielding, receptive primal power of yin.  The attribute of the hexagram is devotion; its image is the earth.  It is the perfect complement of THE CREATIVE—the complement, not the opposite, for the Receptive does not combat the Creative but completes it.  It represents nature in contrast to spirit, earth in contrast to heaven, space as against time, the female–maternal as against the male–paternal.  However, as applied to human affairs, the principle of this complementary relationship is found not only in the relation between man and woman, but also in that between prince and minister and between father and son.  Indeed, even in the individual this duality appears in the coexistence of the spiritual world and the world of the senses."+ Environment.NewLine + Environment.NewLine +
                "But strictly speaking there is no real dualism here, because there is a clearly defined hierarchic relationship between the two principles.  In itself of course the Receptive is just as important as the Creative, but the attribute of devotion defines the place occupied by this primal power in relation to the Creative.  For the Receptive must be activated and led by the Creative; then it is productive of good.  Only when it abandons this position and tries to stand as an equal side by side with the Creative, does it become evil.  The result then is opposition to and struggle against the Creative, which is productive of evil to both.";
            iChing[Hexagram].TheJudgment = "THE RECEPTIVE brings about sublime success,"+ Environment.NewLine +
                "Furthering through the perseverance of a mare."+ Environment.NewLine +
                "If the superior man undertakes something and tries to lead,"+ Environment.NewLine +
                "He goes astray; But if he follows, he finds guidance."+ Environment.NewLine +
                "It is favorable to find friends in the west and south,"+ Environment.NewLine +
                "To forego friends in the east and north."+ Environment.NewLine +
                "Quiet perseverance brings good fortune.";
            iChing[Hexagram].Intro2 = "The four fundamental aspects of the Creative—“sublime success, furthering through perseverance”—are also attributed to the Receptive.  Here, however, the perseverance is more closely defined: it is that of a mare.  The Receptive connotes spatial reality in contrast to the spiritual potentiality of the Creative.  The potential becomes real and the spiritual becomes spatial through a specifically qualifying definition.  Thus the qualification, “of a mare,” is here added to the idea of perseverance.  The horse belongs to earth just as the dragon belongs to heaven.  Its tireless roaming over the plains is taken as a symbol of the vast expanse of the earth.  This is the symbol chosen because the mare combines the strength and swiftness of the horse with the gentleness and devotion of the cow."+ Environment.NewLine + Environment.NewLine +
                "Only because nature in its myriad forms corresponds with the myriad impulses of the Creative can it make these impulses real.  Nature’s richness lies in its power to nourish all living things; its greatness lies in its power to give them beauty and splendor.  Thus it prospers all that lives.  It is the Creative that begets things, but they are brought to birth by the Receptive.  Applied to human affairs, therefore, what the hexagram indicates is action in conformity with the situation.  The person in question is not in an independent position, but is acting as an assistant.  This means that he must achieve something.  It is not his task to try to lead—that would only make him lose the way—but to let himself be led.  If he knows how to meet fate with an attitude of acceptance, he is sure to find the right guidance.  The superior man lets himself be guided; he does not go ahead blindly, but learns from the situation what is demanded of him and then follows this intimation from fate."+ Environment.NewLine + Environment.NewLine +
                "Since there is something to be accomplished, we need friends and helpers in the hour of toil and effort, once the ideas to be realized are firmly set.  The time of toil and effort is indicated by the west and south, for west and south symbolize the place where the Receptive works for the Creative, as nature does in summer and autumn.  If in that situation one does not mobilize all one’s powers, the work to be accomplished will not be done.  Hence to find friends there means to find guidance.  But in addition to the time of toil and effort, there is also a time of planning, and for this we need this solitude.  The east symbolized the place where a man receives orders from his master, and the north the place where he reports on what he has done.  At that time he must be alone and objective.  In this sacred hour he must do without companions, so that the purity of the moment may not be spoiled by fictional hates and favoritism.";
            iChing[Hexagram].TheImage = "The earth’s condition is receptive devotion."+ Environment.NewLine +
                "Thus the superior man who has breadth of character"+ Environment.NewLine +
                "Carries the outer world.";
            iChing[Hexagram].Intro3 = "Just as there is only one heaven, so too there is only one earth.  In the hexagram of heaven the doubling of the trigram implies duration in time, but in the hexagram of earth the doubling connotes the solidity and extension in space by virtue of which the earth is able to carry and preserve all things that live and move upon it.  The earth in its devotion carries all things, good and evil, without exception.  In the same way the superior man gives to his character breadth, purity, and sustaining power, so that he is able both to support and to bear with people and things.";
            iChing[Hexagram].Read1 = "Six at the beginning means:"+ Environment.NewLine +
                "When there is hoarfrost underfoot,"+ Environment.NewLine +
                "Solid ice is not far off.";
            iChing[Hexagram].Read2 = "Six in the second place means:"+ Environment.NewLine +
                "Straight, square, great."+ Environment.NewLine +
                "Without purpose,"+ Environment.NewLine +
                "Yet nothing remains unfurthered.";
            iChing[Hexagram].Read3 ="Six in the third place means:"+ Environment.NewLine +
                "Hidden lines."+ Environment.NewLine +
                "One is able to remain persevering."+ Environment.NewLine +
                "If by chance you are in the service of a king,"+ Environment.NewLine +
                "Seek not works, but bring to completion.";
            iChing[Hexagram].Read4 ="Six in the fourth place means:"+ Environment.NewLine +
                "A tied–up sack.  No blame, no praise.";
            iChing[Hexagram].Read5 = "Six in the fifth place means:"+ Environment.NewLine +
                "A yellow lower garment brings supreme good fortune.";
            iChing[Hexagram].Read6 = "Six at the top means:"+ Environment.NewLine +
                "Dragons fight in the meadow."+ Environment.NewLine +
                "Their blood is black and yellow."+ Environment.NewLine + Environment.NewLine +
                "When all the lines are sixes, it means:"+ Environment.NewLine + 
                "Lasting perseverance furthers.";
            iChing[Hexagram].Place1ChangesToNumber = 24;
            iChing[Hexagram].Place1ChangesToTitle = "Return (The Turning Point) ䷗";
            iChing[Hexagram].Place2ChangesToNumber = 7;
            iChing[Hexagram].Place2ChangesToTitle = "The Army ䷆";
            iChing[Hexagram].Place3ChangesToNumber = 15;
            iChing[Hexagram].Place3ChangesToTitle = "Modesty ䷎";
            iChing[Hexagram].Place4ChangesToNumber = 16;
            iChing[Hexagram].Place4ChangesToTitle = "Enthusiasm ䷏";
            iChing[Hexagram].Place5ChangesToNumber = 8;
            iChing[Hexagram].Place5ChangesToTitle = "Holding Together (Union) ䷇";
            iChing[Hexagram].Place6ChangesToNumber = 23;
            iChing[Hexagram].Place6ChangesToTitle = "Splitting Apart ䷖";
            iChing[Hexagram].SquareCircle1 = "";
            iChing[Hexagram].SquareCircle2 ="○";
            iChing[Hexagram].SquareCircle3 = "";
            iChing[Hexagram].SquareCircle4 = "";
            iChing[Hexagram].SquareCircle5 = "";// ○ □
            iChing[Hexagram].SquareCircle6 = "";

            Hexagram = 3;
            iChing[Hexagram].Title = "3.  Chun / Difficulty at the Beginning";
            iChing[Hexagram].Above = "K’AN  /  THE ABYSMAL, WATER";
            iChing[Hexagram].Below = "CHÊN  /  THE AROUSING, THUNDER";
            iChing[Hexagram].AboveSymbol = "☵";
            iChing[Hexagram].BelowSymbol = "☳";
            iChing[Hexagram].Intro1 = "The name of the hexagram, Chun, really connotes a blade of grass pushing against an obstacle as it sprouts out of the earth—hence the meaning, “difficulty at the beginning.”  The hexagram indicates the way in which heaven and earth bring forth individual beings.  It is their first meeting, which is beset with difficulties.  The lower trigram Chên is the Arousing; its motion is upward and its image is thunder.  The upper trigram K’an stands for the Abysmal, the dangerous.  Its motion is downward and its image is rain.  The situation points to teeming, chaotic profusion; thunder and rain fill the air.  But the chaos clears up.  While the Abysmal sinks, the upward movement eventually passes beyond the danger.  A thunderstorm brings release from tension, and all things breathe freely again.";
            iChing[Hexagram].TheJudgment = "DIFFICULTY AT THE BEGINNING works supreme success,"+ Environment.NewLine + 
                "Furthering through perseverance."+ Environment.NewLine +
                "Nothing should be undertaken."+ Environment.NewLine + 
                "It furthers one to appoint helpers.";
            iChing[Hexagram].Intro2 = "Times of growth are beset with difficulties.  They resemble a first birth.  But these difficulties arise from the very profusion of all that is struggling to attain form.  Everything is in motion: therefore if one perseveres there is a prospect of great success, in spite of the existing danger.  When it is a man’s fate to undertake such new beginnings, everything is still unformed, dark.  Hence he must hold back, because any premature move might bring disaster.  Likewise, it is very important not to remain alone; in order to overcome the chaos he needs helpers.  This is not to say, however, that he himself should look on passively at what is happening.  He must lend his hand and participate with inspiration and guidance.";
            iChing[Hexagram].TheImage = "Clouds and thunder:"+ Environment.NewLine + 
                "The image of DIFFICULTY AT THE BEGINNING."+ Environment.NewLine + 
                "Thus the superior man"+ Environment.NewLine + 
                "Brings order out of confusion.";
            iChing[Hexagram].Intro3 = "Clouds and thunder are represented by definite decorative lines; this means that in the chaos of difficulty at the beginning, order is already implicit.  So too the superior man has to arrange and organize the inchoate profusion of such times of beginning, just as one sorts out silk threads from a knotted tangle and binds them into skeins.  In order to find one’s place in the infinity of being, one must be able both to separate and to unite.";
            iChing[Hexagram].Read1 = "Nine at the beginning means:" + Environment.NewLine + 
                "Hesitation and hindrance."+ Environment.NewLine + 
                "It furthers one to remain persevering."+ Environment.NewLine +
                "It furthers one to appoint helpers.";
            iChing[Hexagram].Read2 = "Six in the second place means:" + Environment.NewLine + 
                "Difficulties pile up." + Environment.NewLine + 
                "Horse and wagon part." + Environment.NewLine + 
                "He is not a robber;"  + Environment.NewLine + 
                "He wants to woo when the time comes." + Environment.NewLine + 
                "The maiden is chaste," + Environment.NewLine + 
                "She does not pledge herself." + Environment.NewLine + 
                "Ten years—then she pledges herself.";
            iChing[Hexagram].Read3 = "Six in the third place means:"+ Environment.NewLine + 
                "Whoever hunts deer without the forester"+ Environment.NewLine + 
                "Only loses his way in the forest."+ Environment.NewLine + 
                "The superior man understands the signs of the time" + Environment.NewLine + 
                "And prefers to desist."+ Environment.NewLine + 
                "To go on brings humiliation.";
            iChing[Hexagram].Read4 = "Six in the fourth place means:"+ Environment.NewLine + 
                "Horse and wagon part."+ Environment.NewLine + 
                "Strive for union."+ Environment.NewLine + 
                "To go brings good fortune."+ Environment.NewLine + 
                "Everything acts to further.";
            iChing[Hexagram].Read5 = "Nine in the fifth place means:"+ Environment.NewLine +
                "Difficulties in blessing."+ Environment.NewLine +
                "A little perseverance brings good fortune."+ Environment.NewLine +
                "Great perseverance brings misfortune."; 
            iChing[Hexagram].Read6 = "Six at the top means:"+ Environment.NewLine +
                "Horse and wagon part."+ Environment.NewLine +
                "Bloody tears flow."; 
            iChing[Hexagram].Place1ChangesToNumber = 8;
            iChing[Hexagram].Place1ChangesToTitle = "Holding Together (Union) ䷇";
            iChing[Hexagram].Place2ChangesToNumber = 60;
            iChing[Hexagram].Place2ChangesToTitle = "Limitation ䷻";
            iChing[Hexagram].Place3ChangesToNumber =  63;
            iChing[Hexagram].Place3ChangesToTitle = "After Completion ䷾";
            iChing[Hexagram].Place4ChangesToNumber = 17;
            iChing[Hexagram].Place4ChangesToTitle = "Following ䷐";
            iChing[Hexagram].Place5ChangesToNumber = 24;
            iChing[Hexagram].Place5ChangesToTitle = "Return (The Turning Point) ䷗";
            iChing[Hexagram].Place6ChangesToNumber = 42;
            iChing[Hexagram].Place6ChangesToTitle = "Increase ䷩";
            iChing[Hexagram].SquareCircle1 = "○";
            iChing[Hexagram].SquareCircle2 = "";
            iChing[Hexagram].SquareCircle3 = "";
            iChing[Hexagram].SquareCircle4 = "";
            iChing[Hexagram].SquareCircle5 = "○";// ○ □
            iChing[Hexagram].SquareCircle6 = "";
            
            /*
            Hexagram = 2;
            iChing[Hexagram].Title = ;
            iChing[Hexagram].Above = ;
            iChing[Hexagram].Below = ;
            iChing[Hexagram].AboveSymbol = ;
            iChing[Hexagram].BelowSymbol = ;
            iChing[Hexagram].Intro1 =
            + Environment.NewLine + Environment.NewLine +
            + Environment.NewLine + Environment.NewLine +
            + Environment.NewLine + Environment.NewLine +
            + Environment.NewLine + Environment.NewLine +
            iChing[Hexagram].TheJudgment = + Environment.NewLine + 
            iChing[Hexagram].Intro2 = 
            + Environment.NewLine + Environment.NewLine +
            + Environment.NewLine + Environment.NewLine +
            + Environment.NewLine + Environment.NewLine +
            + Environment.NewLine + Environment.NewLine +
            iChing[Hexagram].TheImage = + Environment.NewLine + 
            iChing[Hexagram].Intro3 =
            + Environment.NewLine + Environment.NewLine +
            + Environment.NewLine + Environment.NewLine +
            + Environment.NewLine + Environment.NewLine +
            + Environment.NewLine + Environment.NewLine +
            iChing[Hexagram].Read1 = + Environment.NewLine + 
            iChing[Hexagram].Read2 = + Environment.NewLine + 
            iChing[Hexagram].Read3 = + Environment.NewLine + 
            iChing[Hexagram].Read4 = + Environment.NewLine + 
            iChing[Hexagram].Read5 = + Environment.NewLine + 
            iChing[Hexagram].Read6 = + Environment.NewLine + 
            iChing[Hexagram].Place1ChangesToNumber = ;
            iChing[Hexagram].Place1ChangesToTitle = ;
            iChing[Hexagram].Place2ChangesToNumber = ;
            iChing[Hexagram].Place2ChangesToTitle = ;
            iChing[Hexagram].Place3ChangesToNumber = ;
            iChing[Hexagram].Place3ChangesToTitle = ;
            iChing[Hexagram].Place4ChangesToNumber = ;
            iChing[Hexagram].Place4ChangesToTitle = ;
            iChing[Hexagram].Place5ChangesToNumber = ;
            iChing[Hexagram].Place5ChangesToTitle = ;
            iChing[Hexagram].Place6ChangesToNumber = ;
            iChing[Hexagram].Place6ChangesToTitle = ;
            iChing[Hexagram].SquareCircle1 = "";
            iChing[Hexagram].SquareCircle2 = "";
            iChing[Hexagram].SquareCircle3 = "";
            iChing[Hexagram].SquareCircle4 = "";
            iChing[Hexagram].SquareCircle5 = "";// ○ □
            iChing[Hexagram].SquareCircle6 = "";
            */

            Hexagram = 43;
            iChing[Hexagram].Title = "43. Kuai / Break-Through (Resoluteness)";
            iChing[Hexagram].Above = "TUI  /  THE JOYOUS, LAKE";
            iChing[Hexagram].Below = "CH'IEN / THE CREATIVE, HEAVEN";
            iChing[Hexagram].AboveSymbol = "☱";
            iChing[Hexagram].BelowSymbol = "☰";
            iChing[Hexagram].Intro1 = "This hexagram signifies on the one hand a break–through after a long accumulation of tension, as a swollen river breaks through its dikes, or in the manner of a cloudburst.  On the other hand, applied to human conditions, it refers to the time when inferior people gradually begin to disappear.  Their influence is on the wane; as a result of resolute action, a change in conditions occurs, a break–through.  The hexagram is linked with the third month [April–May].";
            iChing[Hexagram].TheJudgment = "BREAK–THROUGH.  One must resolutely make the matter known" + Environment.NewLine +
                "At the court of the king." + Environment.NewLine +
                "It must be announced truthfully.  Danger." + Environment.NewLine +
                "It is necessary to notify one’s own city." + Environment.NewLine +
                "It does not further to resort to arms." + Environment.NewLine +
                "It furthers one to undertake something.";
            iChing[Hexagram].Intro2 = "Even if only one inferior man is occupying a ruling position in a city, he is able to oppress superior men.  Even a single passion still lurking in the heart has power to obscure reason.  Passion and reason cannot exist side by side—therefore fight without quarter is necessary if the good is to prevail." + Environment.NewLine + Environment.NewLine +
                "In a resolute struggle of the good against evil, there are, however, definite rules that must not be disregarded, if it is to succeed.  First, resolution must be based on a union of strength and friendliness.  Second, a compromise with evil is not possible; evil must under all circumstances be openly discredited.  Nor must our own passions and shortcomings be glossed over.  Third, the struggle must not be carried on directly by force.  If evil is branded, it thinks of weapons, and if we do it the favor of fighting against it blow for blow, we lose in the end because thus we ourselves get entangled in hatred and passion.  Therefore it is important to begin at home, to be on guard in our own persons against the faults we have branded.  In this way, finding no opponent, the sharp edges of the weapons of evil becomes dulled.  For the same reasons we should not combat our own faults directly.  As long as we wrestle with them, they continue victorious.  Finally, the best way to fight evil is to make energetic progress in the good.";
            iChing[Hexagram].TheImage = "The lake has risen up to heaven:" + Environment.NewLine +
                "The image of BREAK–THROUGH." + Environment.NewLine +
                "Thus the superior man" + Environment.NewLine +
                "Dispenses riches downward" + Environment.NewLine +
                "And refrains from resting on his virtue.";
            iChing[Hexagram].Intro3 = "When the water of a lake has risen up to heaven, there is reason to fear a cloudburst.  Taking this as a warning, the superior man forestalls a violent collapse.  If a man were to pile up riches for himself alone, without considering others, he would certainly experience a collapse.  For all gathering is followed by dispersion.  Therefore the superior man begins to distribute while he is accumulating.  In the same way, in developing his character he takes care not to become hardened in obstinacy but to remain receptive to impressions by help of strict and continuous self–examination.";
            iChing[Hexagram].Read1 = "Nine in the beginning means:" + Environment.NewLine +
                "Mighty in the forward-striding toes." + Environment.NewLine +
                "When one goes and is not equal to the task," + Environment.NewLine +
                "One makes a mistake.";
            iChing[Hexagram].Read2 = "Nine in the second place means:"+ Environment.NewLine +
                "A cry of alarm. Arms at evening and at night." + Environment.NewLine +
                "Fear nothing.";
            iChing[Hexagram].Read3 = "Nine in the third place means:" + Environment.NewLine +
                "To be powerful in the cheekbones" + Environment.NewLine +
                "Brings misfortune." + Environment.NewLine +
                "The superior man is firmly resolved." + Environment.NewLine +
                "He walks alone and is caught in the rain." + Environment.NewLine +
                "He is bespattered," + Environment.NewLine +
                "And people murmur against him." + Environment.NewLine +
                "No blame";
            iChing[Hexagram].Read4 = "Nine in the fourth place means:"+Environment.NewLine+
                "There is no skin on his thighs," + Environment.NewLine +
                "And walking comes hard." + Environment.NewLine +
                "If a man were to let himself be led like sheep," + Environment.NewLine +
                "Remorse would disappear." + Environment.NewLine +
                "But if these words are heard" + Environment.NewLine +
                "They will not be believed.";
            iChing[Hexagram].Read5 = "Nine in the fifth place means:" + Environment.NewLine +
                "In dealing with weeds,"+ Environment.NewLine +
                "Firm resolution is necessary."+ Environment.NewLine +
                "Walking in the middle" + Environment.NewLine +
                "Remains free of blame.";
            iChing[Hexagram].Read6 = "Six at the top means:" + Environment.NewLine +
                "No cry." + Environment.NewLine +
                "In the end misofortune comes.";
            iChing[Hexagram].Place1ChangesToNumber = 28;
            iChing[Hexagram].Place1ChangesToTitle = "Preponderance of the Great ䷛";
            iChing[Hexagram].Place2ChangesToNumber = 49;
            iChing[Hexagram].Place2ChangesToTitle = "Revolution (Molting) ䷰";
            iChing[Hexagram].Place3ChangesToNumber = 58;
            iChing[Hexagram].Place3ChangesToTitle = "The Joyous, Lake ䷹";
            iChing[Hexagram].Place4ChangesToNumber = 5;
            iChing[Hexagram].Place4ChangesToTitle = "Waiting (Nourishment) ䷄";
            iChing[Hexagram].Place5ChangesToNumber = 34;
            iChing[Hexagram].Place5ChangesToTitle = "The Power of the Great ䷡";
            iChing[Hexagram].Place6ChangesToNumber = 1;
            iChing[Hexagram].Place6ChangesToTitle = "The Creative, Heaven ䷀";
            iChing[Hexagram].SquareCircle1 = "";
            iChing[Hexagram].SquareCircle2 = "";
            iChing[Hexagram].SquareCircle3 = "";
            iChing[Hexagram].SquareCircle4 = "";
            iChing[Hexagram].SquareCircle5 = "○";// ○ □
            iChing[Hexagram].SquareCircle6 = "□";


            currentlyShowing = 3;
            updateApplication();
 
        }


        


    }




    public class iChingNumber
    {
        public iChingNumber() { }

        public iChingNumber(string title, string above, string below,
            string aboveSymbol, string belowSymbol, string intro1, string theJudgment,
            string intro2, string theImage, string intro3, string read1, string read2,
            string read3, string read4, string read5, string read6, int place1ChangesToNumber,
            int place2ChangesToNumber, int place3ChangesToNumber, int place4ChangesToNumber,
            int place5ChangesToNumber, int place6ChangesToNumber, string place1ChangesToTitle,
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

    }
}
