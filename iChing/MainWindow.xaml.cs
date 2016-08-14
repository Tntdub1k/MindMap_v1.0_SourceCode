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
            TitleBox.Content = iChing[currentlyShowing].ChiTitle + " ~ " +iChing[currentlyShowing].EngTitle;
            AboveBelowBox.Text = "above "+iChing[currentlyShowing].Above + "\nbelow " + iChing[currentlyShowing].Below;
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
            Changes1Box.Text = iChing[currentlyShowing].Place1ChangesToNumber + ". " + iChing[iChing[currentlyShowing].Place1ChangesToNumber].EngTitle + " " + iChing[iChing[currentlyShowing].Place1ChangesToNumber].Hex;
            Changes2Box.Text = iChing[currentlyShowing].Place2ChangesToNumber + ". " + iChing[iChing[currentlyShowing].Place2ChangesToNumber].EngTitle + " " + iChing[iChing[currentlyShowing].Place2ChangesToNumber].Hex;
            Changes3Box.Text = iChing[currentlyShowing].Place3ChangesToNumber + ". " + iChing[iChing[currentlyShowing].Place3ChangesToNumber].EngTitle + " " + iChing[iChing[currentlyShowing].Place3ChangesToNumber].Hex;
            Changes4Box.Text = iChing[currentlyShowing].Place4ChangesToNumber + ". " + iChing[iChing[currentlyShowing].Place4ChangesToNumber].EngTitle + " " + iChing[iChing[currentlyShowing].Place4ChangesToNumber].Hex;
            Changes5Box.Text = iChing[currentlyShowing].Place5ChangesToNumber + ". " + iChing[iChing[currentlyShowing].Place5ChangesToNumber].EngTitle + " " + iChing[iChing[currentlyShowing].Place5ChangesToNumber].Hex;
            Changes6Box.Text = iChing[currentlyShowing].Place6ChangesToNumber + ". " + iChing[iChing[currentlyShowing].Place6ChangesToNumber].EngTitle + " " + iChing[iChing[currentlyShowing].Place6ChangesToNumber].Hex;
            Line1BoxSquareCircle.Text = iChing[currentlyShowing].SquareCircle1;
            Line2BoxSquareCircle.Text = iChing[currentlyShowing].SquareCircle2;
            Line3BoxSquareCircle.Text = iChing[currentlyShowing].SquareCircle3;
            Line4BoxSquareCircle.Text = iChing[currentlyShowing].SquareCircle4;
            Line5BoxSquareCircle.Text = iChing[currentlyShowing].SquareCircle5;
            Line6BoxSquareCircle.Text = iChing[currentlyShowing].SquareCircle6;
            
            //Update hexagram places
            if (iChing[currentlyShowing].Code != null) { 
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
                else { Place6.Fill = (Brush)FindResource("Yin"); };
            }
            else { MessageBox.Show("Not yet defined"); }

        }

        private void TextBox1_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Comments.Text = "Comments Text Add";
        }

        private void Place1_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            currentlyShowing = iChing[currentlyShowing].Place1ChangesToNumber;
            updateApplication();
        }

        private void Place2_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            currentlyShowing = iChing[currentlyShowing].Place2ChangesToNumber;
            updateApplication();
        }

        private void Place3_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            currentlyShowing = iChing[currentlyShowing].Place3ChangesToNumber;
            updateApplication();
        }

        private void Place4_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            currentlyShowing = iChing[currentlyShowing].Place4ChangesToNumber;
            updateApplication();
        }

        private void Place5_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            currentlyShowing = iChing[currentlyShowing].Place5ChangesToNumber;
            updateApplication();
        }

        private void Place6_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
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
            iChing[Hexagram].EngTitle = "The Creative (Heaven)";
            iChing[Hexagram].ChiTitle = "Ch'ien";
            iChing[Hexagram].Hex = "䷀";
            iChing[Hexagram].Code = new int[] {1,1,1,1,1,1};
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
            iChing[Hexagram].EngTitle = "The Receptive (Earth)";
            iChing[Hexagram].ChiTitle = "K'un";
            iChing[Hexagram].Hex = "䷁";
            iChing[Hexagram].Code = new int[] { 0, 0, 0, 0, 0, 0 };
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
            iChing[Hexagram].EngTitle = "Difficulty at the Beginning";
            iChing[Hexagram].ChiTitle = "Chun";
            iChing[Hexagram].Hex = "䷂";
            iChing[Hexagram].Code = new int[] { 1, 0, 0, 0, 1, 0 };
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

            Hexagram = 4;
            iChing[Hexagram].EngTitle = "Youthful Folly";
            iChing[Hexagram].ChiTitle = "Mêng";
            iChing[Hexagram].Hex = "䷃";
            iChing[Hexagram].Code = new int[] { 0, 1, 0, 0, 0, 1 };
            iChing[Hexagram].Above = "KÊN  /  KEEPING STILL, MOUNTAIN";
            iChing[Hexagram].Below = "K’AN  /  THE ABYSMAL, WATER";
            iChing[Hexagram].AboveSymbol = "☶";
            iChing[Hexagram].BelowSymbol = "☵";
            iChing[Hexagram].Intro1 = "In this hexagram we are reminded of youth and folly in two different ways.  The image of the upper trigram, Kên, is the mountain, that of the lower, K’an, is water; the spring rising at the foot of the mountain is the image of inexperienced youth.  Keeping still is the attribute of the upper trigram; that of the lower is the abyss, danger.  Stopping in perplexity on the brink of a dangerous abyss is a symbol of the folly of youth.  However, the two trigrams also show the way of overcoming the follies of youth.  Water is something that of necessity flows on.  When the spring gushes forth, it does not know at first where it will go.  But its steady flow fills up the deep place blocking its progress, and success is attained.";
            iChing[Hexagram].TheJudgment = "YOUTHFUL FOLLY has success." + Environment.NewLine + 
            "It is not I who seek the young fool;"+ Environment.NewLine + 
            "The young fool seeks me."+ Environment.NewLine + 
            "At the first oracle I inform him."+ Environment.NewLine + 
            "If he asks two or three times, it is importunity."+ Environment.NewLine + 
            "If he importunes, I give him no information."+ Environment.NewLine + 
            "Perseverance furthers.";
            iChing[Hexagram].Intro2 = "In the time of youth, folly is not an evil.  One may succeed in spite of it, provided one finds an experienced teacher and has the right attitude toward him.  This means, first of all, that the youth himself must be conscious of his lack of experience and must seek out the teacher.  Without this modesty and this interest there is no guarantee that he has the necessary receptivity, which should express itself in respectful acceptance of the teacher.  This is the reason why the teacher must wait to be sought out instead of offering himself.  Only thus can the instruction take place at the right time and in the right way." + Environment.NewLine + Environment.NewLine +
            "A teacher’s answer to the question of a pupil ought to be clear and definite like that expected from an oracle; thereupon it ought to be accepted as a key for resolution of doubts and a basis for decision.  If mistrustful or unintelligent questioning is kept up, it serves only to annoy the teacher.  He does well to ignore it in silence, just as the oracle gives one answer only and refuses to be tempted by questions implying doubt."+ Environment.NewLine + Environment.NewLine +
            "Given addition a perseverance that never slackens until the points are mastered one by one, real success is sure to follow.  Thus the hexagram counsels the teacher as well as the pupil.";
            iChing[Hexagram].TheImage = "A spring wells up at the foot of the mountain:"+ Environment.NewLine + 
            "The image of YOUTH."+ Environment.NewLine +
            "Thus the superior man fosters his character"+ Environment.NewLine +
            "By thoroughness in all that he does.";
            iChing[Hexagram].Intro3 = "A spring succeeds in flowing on and escapes stagnation by filling up all the hollow places in its path.  In the same way character is developed by thoroughness that skips nothing but, like water, gradually and steadily fills up all gaps and so flows onward.";
            iChing[Hexagram].Read1 = "Six at the beginning means:"+ Environment.NewLine + 
            "To make a fool develop"+ Environment.NewLine +
            "It furthers one to apply discipline."+ Environment.NewLine +
            "The fetters should be removed."+ Environment.NewLine +
            "To go on in this way brings humiliation.";
            iChing[Hexagram].Read2 = "Nine in the second place means:"+ Environment.NewLine + 
            "To bear with fools in kindliness brings good fortune."+ Environment.NewLine +
            "To know how to take women"+ Environment.NewLine +
            "Brings good fortune."+ Environment.NewLine +
            "The son is capable of taking charge of the household.";
            iChing[Hexagram].Read3 = "Six in the third place means:"+ Environment.NewLine + 
            "Take not a maiden who, when she sees a man of bronze,"+ Environment.NewLine +
            "Loses possession of herself."+ Environment.NewLine +
            "Nothing furthers.";
            iChing[Hexagram].Read4 = "Six in the fourth place means:" + Environment.NewLine + 
            "Entangled folly brings humiliation.";
            iChing[Hexagram].Read5 = "Six in the fifth place means:" + Environment.NewLine + 
            "Childlike folly brings good fortune.";
            iChing[Hexagram].Read6 = "Nine at the top means:" + Environment.NewLine + 
            "In punishing folly"+ Environment.NewLine +
            "It does not further one"
            + Environment.NewLine + "To commit transgressions."
            + Environment.NewLine + "The only thing that furthers"
            + Environment.NewLine + "Is to prevent transgressions.";
            iChing[Hexagram].SquareCircle1 = "";
            iChing[Hexagram].SquareCircle2 = "○";
            iChing[Hexagram].SquareCircle3 = "";
            iChing[Hexagram].SquareCircle4 = "";
            iChing[Hexagram].SquareCircle5 = "○";// ○ □
            iChing[Hexagram].SquareCircle6 = "";
            iChing[Hexagram].Place1ChangesToNumber = 41;
            iChing[Hexagram].Place1ChangesToTitle = "Decrease ䷨";
            iChing[Hexagram].Place2ChangesToNumber = 23;
            iChing[Hexagram].Place2ChangesToTitle = "Splitting Apart ䷖";
            iChing[Hexagram].Place3ChangesToNumber = 18;
            iChing[Hexagram].Place3ChangesToTitle = "Work on what has been Spoiled (Decay) ䷑";
            iChing[Hexagram].Place4ChangesToNumber = 29;
            iChing[Hexagram].Place4ChangesToTitle = "The Abysmal (Water) ䷜";
            iChing[Hexagram].Place5ChangesToNumber = 59;
            iChing[Hexagram].Place5ChangesToTitle = "Dispersion (Dissolution) ䷺";
            iChing[Hexagram].Place6ChangesToNumber = 7;
            iChing[Hexagram].Place6ChangesToTitle = "The Army ䷆";

            
            Hexagram = 5;
            iChing[Hexagram].EngTitle = "Waiting (Nourishment)";
            iChing[Hexagram].ChiTitle = "Hsü";
            iChing[Hexagram].Hex = "䷄";
            iChing[Hexagram].Code = new int[] { 1, 1, 1, 0, 1, 0 };
            iChing[Hexagram].Above = "K’AN  /  THE ABYSMAL, WATER ";
            iChing[Hexagram].Below = "CH’IEN  /  THE CREATIVE, HEAVEN";
            iChing[Hexagram].AboveSymbol = "☵";
            iChing[Hexagram].BelowSymbol = "☰";
            iChing[Hexagram].Intro1 = "All beings have need of nourishment from above.  But the gift of food comes in its own time, and for this one must wait.  This hexagram shows the clouds in the heavens, giving rain to refresh all that grows and to provide mankind with food and drink.  The rain will come in its own time.  We cannot make it come; we have to wait for it.  The idea of waiting is further suggested by the attributes of the two trigrams—strength within, danger in front.  Strength in the face of danger does not plunge ahead but bides its time, whereas weakness in the face of danger grows agitated and has not the patience to wait.";
            iChing[Hexagram].TheJudgment = "WAITING.  If you are sincere,"
            + Environment.NewLine + "You have light and success."
            + Environment.NewLine + "Perseverance brings good fortune."
            + Environment.NewLine + "It furthers one to cross the great water.";
            iChing[Hexagram].Intro2 = "Waiting is not mere empty hoping.  It has the inner certainty of reaching the goal.  Such certainty alone gives that light which leads to success.  This leads to the perseverance that brings good fortune and bestows power to cross the great water."
            + Environment.NewLine + Environment.NewLine + "One is faced with a danger that has to be overcome.  Weakness and impatience can do nothing.  Only a strong man can stand up to his fate, for his inner security enables him to endure to the end.  This strength shows itself in uncompromising truthfulness [with himself].  It is only when we have the courage to face things exactly as they are, without any sort of self–deception or illusion, that a light will develop out of events, by which the path to success may be recognized.  This recognition must be followed by resolute and persevering action.  For only the man who goes to meet his fate resolutely is equipped to deal with it adequately.  Then he will be able to cross the great water—that is to say, he will be capable of making the necessary decision and of surmounting the danger.";
            iChing[Hexagram].TheImage = "Clouds rise up to heaven:" 
            + Environment.NewLine + "The image of WAITING."
            + Environment.NewLine + "Thus the superior man eats and drinks,"
            + Environment.NewLine + "Is joyous and of good cheer.";
            iChing[Hexagram].Intro3 = "When clouds rise in the sky, it is a sign that it will rain.  There is nothing to do but to wait until after the rain falls.  It is the same in life when destiny is at work.  We should not worry and seek to shape the future by interfering in things before the time is ripe.  We should quietly fortify the body with food and drink and the mind with gladness and good cheer.  Fate comes when it will, and thus we are ready.";
            iChing[Hexagram].Read1 =  "Nine at the beginning means:"
            + Environment.NewLine + "Waiting in the meadow."
            + Environment.NewLine + "It furthers one to abide in what endures."
            + Environment.NewLine + "No blame.";
            iChing[Hexagram].Read2 = "Nine in the second place means:"
            + Environment.NewLine + "Waiting on the sand."
            + Environment.NewLine + "There is some gossip."
            + Environment.NewLine + "The end brings good fortune.";
            iChing[Hexagram].Read3 ="Nine in the third place means:"
            + Environment.NewLine + "Waiting in the mud"
            + Environment.NewLine + "Brings about the arrival of the enemy.";
            iChing[Hexagram].Read4 = "Six in the fourth place means:"
            + Environment.NewLine + "Waiting in blood."
            + Environment.NewLine + "Get out of the pit.";
            iChing[Hexagram].Read5 = "Nine in the fifth place means:"
            + Environment.NewLine + "Waiting at meat and drink."
            + Environment.NewLine + "Perseverance brings good fortune."
            + Environment.NewLine 
            + Environment.NewLine +"This line references   Chien  /  OBSTRUCTION  (39)";
            iChing[Hexagram].Read6 = "Six at the top means:" 
            + Environment.NewLine + "One falls into the pit."
            + Environment.NewLine + "Three uninvited guests arrive."
            + Environment.NewLine + "Honor them, and in the end there will be good fortune.";
            iChing[Hexagram].SquareCircle1 = "";
            iChing[Hexagram].SquareCircle2 = "";
            iChing[Hexagram].SquareCircle3 = "";
            iChing[Hexagram].SquareCircle4 = "";
            iChing[Hexagram].SquareCircle5 = "○";// ○ □
            iChing[Hexagram].SquareCircle6 = "";
            iChing[Hexagram].Place1ChangesToNumber = 48;
            iChing[Hexagram].Place1ChangesToTitle = "The Well ䷯";
            iChing[Hexagram].Place2ChangesToNumber = 63;
            iChing[Hexagram].Place2ChangesToTitle = "After Completion ䷾";
            iChing[Hexagram].Place3ChangesToNumber = 60;
            iChing[Hexagram].Place3ChangesToTitle = "Limitation ䷻";
            iChing[Hexagram].Place4ChangesToNumber = 43;
            iChing[Hexagram].Place4ChangesToTitle = "Break-Through (Resoluteness) ䷪";
            iChing[Hexagram].Place5ChangesToNumber = 11;
            iChing[Hexagram].Place5ChangesToTitle = "Peace ䷊";
            iChing[Hexagram].Place6ChangesToNumber = 9;
            iChing[Hexagram].Place6ChangesToTitle = "The Taming Power of the Small ䷈";

            Hexagram = 6;
            iChing[Hexagram].EngTitle = "Conflict";
            iChing[Hexagram].ChiTitle = "Sung";
            iChing[Hexagram].Hex = "䷅";
            iChing[Hexagram].Code = new int[] { 0, 1, 0, 1, 1, 1 };
            iChing[Hexagram].Above = "CH’IEN  /  THE CREATIVE, HEAVEN ";
            iChing[Hexagram].Below = "K’AN  /  THE ABYSMAL, WATER";
            iChing[Hexagram].AboveSymbol = "☰";
            iChing[Hexagram].BelowSymbol = "☵";
            iChing[Hexagram].Intro1 = "The upper trigram, whose image is heaven, has an upward movement; the lower trigram, water, in accordance with its nature, tends downward.  Thus the two halves move away from each other, giving rise to the idea of conflict."
            + Environment.NewLine + Environment.NewLine +"The attribute of the Creative is strength, that of the Abysmal is danger, guile.  Where cunning has force before it, there is conflict."
            + Environment.NewLine + Environment.NewLine +"A third indication of conflict, in terms of character, is presented by the combination of deep cunning within and fixed determination outwardly.  A person of this character will certainly be quarrelsome.";
            iChing[Hexagram].TheJudgment = "CONFLICT.  You are sincere"
            + Environment.NewLine + "And are being obstructed."
            + Environment.NewLine + "A cautious halt halfway brings good fortune."
            + Environment.NewLine + "Going through to the end brings misfortune."
            + Environment.NewLine + "It furthers one to see the great man."
            + Environment.NewLine + "It does not further one to cross the great water.";
            iChing[Hexagram].Intro2 = "Conflict develops when one feels himself to be in the right and runs into opposition.  If one is not convinced of being in the right, opposition leads to craftiness or high–handed encroachment but not to open conflict."
            + Environment.NewLine + Environment.NewLine + "If a man is entangled in a conflict, his only salvation lies in being so clear–headed and inwardly strong that he is always ready to come to terms by meeting the opponent halfway.  To carry one the conflict to the bitter end has evil effects even when one is the right, because the enmity is then perpetuated.  It is important to see the great man, that is, an impartial man whose authority is great enough to terminate the conflict amicably or assure a just decision.  In times of strife, crossing the great water is to be avoided, that is, dangerous enterprises are not to be begun, because in order to be successful they require concerted unity of forces.  Conflict within weakens the power to conquer danger without.";
            iChing[Hexagram].TheImage = "Heaven and water go their opposite ways:"
            + Environment.NewLine + "The image of CONFLICT."
            + Environment.NewLine + "Thus in all his transactions the superior man"
            + Environment.NewLine + "Carefully considers the beginning.";
            iChing[Hexagram].Intro3 = "The image indicates that the causes of conflict are latent in the opposing tendencies of the two trigrams.  Once these opposing tendencies appear, conflict is inevitable.  To avoid it, therefore, everything must be taken carefully into consideration in the very beginning.  If rights and duties are exactly defined, or if, in a group, the spiritual trends of the individuals harmonize, the cause of conflict is removed in advance.";
            iChing[Hexagram].Read1 = "Six at at the beginning means:"
            + Environment.NewLine + "If one does not perpetuate the affair,"
            + Environment.NewLine + "There is a little gossip."
            + Environment.NewLine + "In the end, good fortune comes.";
            iChing[Hexagram].Read2 = "Nine in the second place means:"
            + Environment.NewLine + "One cannot engage in conflict;"
            + Environment.NewLine + "One returns home, gives way."
            + Environment.NewLine + "The people of his town,"
            + Environment.NewLine + "Three hundred households,"
            + Environment.NewLine + "Remain free of guilt.";
            iChing[Hexagram].Read3 = "Six in the third place means:"
            + Environment.NewLine + "To nourish oneself on ancient virtue induces perseverance."
            + Environment.NewLine + "Danger.  In the end, good fortune comes."
            + Environment.NewLine + "If by chance you are in the service of a king,"
            + Environment.NewLine + "Seek not works.";
            iChing[Hexagram].Read4 = "Nine in the fourth place means:"
            + Environment.NewLine + "One cannot engage in conflict."
            + Environment.NewLine + "One turns back and submits to fate,"
            + Environment.NewLine + "Changes one’s attitude,"
            + Environment.NewLine + "And finds peace in perseverance."
            + Environment.NewLine + "Good fortune.";
            iChing[Hexagram].Read5 = "Nine in the fifth place means:" 
            + Environment.NewLine + "To contend before him"
            + Environment.NewLine + "Brings supreme good fortune.";
            iChing[Hexagram].Read6 = "Nine at the top means:"
            + Environment.NewLine + "Even if by chance a leather belt is bestowed on one,"
            + Environment.NewLine + "By the end of a morning"
            + Environment.NewLine + "It will have been snatched away three times.";
            iChing[Hexagram].SquareCircle1 = "";
            iChing[Hexagram].SquareCircle2 = "";
            iChing[Hexagram].SquareCircle3 = "";
            iChing[Hexagram].SquareCircle4 = "";
            iChing[Hexagram].SquareCircle5 = "○";// ○ □
            iChing[Hexagram].SquareCircle6 = "";
            iChing[Hexagram].Place1ChangesToNumber = 10;
            iChing[Hexagram].Place1ChangesToTitle = "Treading (Conduct) ䷉";
            iChing[Hexagram].Place2ChangesToNumber = 12;
            iChing[Hexagram].Place2ChangesToTitle = "Standstill (Stagnation) ䷋";
            iChing[Hexagram].Place3ChangesToNumber = 44;
            iChing[Hexagram].Place3ChangesToTitle = "Coming to Meet ䷫";
            iChing[Hexagram].Place4ChangesToNumber = 59;
            iChing[Hexagram].Place4ChangesToTitle = "Dispersion (Dissolution) ䷺";
            iChing[Hexagram].Place5ChangesToNumber = 64;
            iChing[Hexagram].Place5ChangesToTitle = "Before Completion ䷿";
            iChing[Hexagram].Place6ChangesToNumber = 47;
            iChing[Hexagram].Place6ChangesToTitle = "Oppression (Exhaustion) ䷮";

            
            Hexagram = 7;
            iChing[Hexagram].EngTitle = "The Army";
            iChing[Hexagram].ChiTitle = "Shih";
            iChing[Hexagram].Hex = "䷆";
            iChing[Hexagram].Code = new int[]{0,1,0,0,0,0};
            iChing[Hexagram].Above = "K’UN  /  THE RECEPTIVE, EARTH";
            iChing[Hexagram].Below = "K’AN  /  THE ABYSMAL, WATER";
            iChing[Hexagram].AboveSymbol = "☷";
            iChing[Hexagram].BelowSymbol = "☵";
            iChing[Hexagram].Intro1 ="This hexagram is made up of the trigrams K’an, water, and K’un, earth, and thus it symbolizes the ground water stored up in the earth.  In the same way military strength is stored up in the mass of the people—invisible in times of peace but always ready for use as a source of power.  The attributes of the two trigrams are danger inside and obedience outside.  This points to the nature of an army, which at the core is dangerous while discipline and obedience must prevail outside.	";
            iChing[Hexagram].TheJudgment = "THE ARMY.  The army needs perseverance"	+ Environment.NewLine +
                "And a strong man."	+ Environment.NewLine + 
                "Good fortune without blame.";
            iChing[Hexagram].Intro2 = "	An army is a mass that needs organization in order to become a fighting force.   Without strict discipline nothing can be accomplished, but this discipline must not be achieved by force.  It requires a strong man who captures the hearts of the people and awakens their enthusiasm.  In order that he may develop his abilities he needs the complete confidence of his ruler, who must entrust him with full responsibility as long as the war lasts.  But war is always a dangerous thing and brings with it destruction and devastation.  Therefore it should not be resorted to rashly but, like a poisonous drug, should be used as a last recourse.	"	+ Environment.NewLine + Environment.NewLine +
                "The justifying cause of war, and clear and intelligible war aims, ought to be explained to the people by an experienced leader.  Unless there is a quite definite war aim to which the people can consciously pledge themselves, the unity and strength of conviction that lead to victory will not be forthcoming.  But the leader must also look to it that the passion of war and the delirium of victory do not give rise to unjust acts that will not meet with general approval..  If justice and perseverance are the basis of action, all goes well.";
            iChing[Hexagram].TheImage = "In the middle of the earth is water:"	+ Environment.NewLine + 
                "The image of THE ARMY.	"	+ Environment.NewLine + 
                "Thus the superior man increases his masses	"	+ Environment.NewLine + 
                "By generosity toward the people.";
            iChing[Hexagram].Intro3 = "Ground water is invisibly present within the earth.  In the same way the military power of a people is invisibly present in the masses.  When danger threatens, every peasant becomes a soldier; when the war ends, he goes back to his plow.  He who is generous toward the people wins their love, and a people living under a mild rule becomes strong and powerful.  Only a people economically strong can be important in military power.  Such power must therefore be cultivated by improving the economic condition of the people and by humane government.  Only when there is this invisible bond between government and people, so that the people are sheltered by their government as ground water is sheltered by the earth, is it possible to wage a victorious war.	"	;
            iChing[Hexagram].Read1 = "Six at the beginning means:"	+ Environment.NewLine + 
                "An army must set forth in proper order."	+ Environment.NewLine + 
                "If the order is not good, misfortune threatens."	;
            iChing[Hexagram].Read2 = "Nine in the second place means:"	+ Environment.NewLine + 
                "In the midst of the army.	"	+ Environment.NewLine + 
                "Good fortune.  No blame.	"	+ Environment.NewLine + 
                "The king bestows a triple decoration.	"	;
            iChing[Hexagram].Read3 = "Six in the third place means:	"	+ Environment.NewLine + 
                "Perchance the army carries corpses in the wagon.	"	+ Environment.NewLine + 
                "Misfortune."	;
            iChing[Hexagram].Read4 = "Six in the fourth place means:	"	+ Environment.NewLine + 
                "The army retreats.  No blame.	"	;
            iChing[Hexagram].Read5 = "Six in the fifth place means:	"	+ Environment.NewLine + 
                "There is game in the field.	"	+ Environment.NewLine + 
                "It furthers one to catch it.	"	+ Environment.NewLine + 
                "Without blame.	"	+ Environment.NewLine + 
                "Let the eldest lead the army.	"	+ Environment.NewLine + 
                "The younger transports corpses;	"	+ Environment.NewLine + 
                "Then perseverance brings misfortune.	"	;
            iChing[Hexagram].Read6 = "Six at the top means:	"	+ Environment.NewLine + 
                "The great prince issues commands,	"	+ Environment.NewLine + 
                "Founds states, vests families with fiefs.	"	+ Environment.NewLine + 
                "Inferior people should not be employed.	"	;
            iChing[Hexagram].SquareCircle1 = "";
            iChing[Hexagram].SquareCircle2 = "○";
            iChing[Hexagram].SquareCircle3 = "";
            iChing[Hexagram].SquareCircle4 = "";
            iChing[Hexagram].SquareCircle5 = "○";// ○ □
            iChing[Hexagram].SquareCircle6 = "";
            iChing[Hexagram].Place1ChangesToNumber = 19;
            iChing[Hexagram].Place1ChangesToTitle = "Approach ䷒";
            iChing[Hexagram].Place2ChangesToNumber = 2;
            iChing[Hexagram].Place2ChangesToTitle = "The Receptive (Earth) ䷁";
            iChing[Hexagram].Place3ChangesToNumber = 46;
            iChing[Hexagram].Place3ChangesToTitle = "Pushing Upward ䷭";
            iChing[Hexagram].Place4ChangesToNumber = 40;
            iChing[Hexagram].Place4ChangesToTitle = "Deliverance ䷧";
            iChing[Hexagram].Place5ChangesToNumber = 29;
            iChing[Hexagram].Place5ChangesToTitle = "The Abysmal (Water) ䷜";
            iChing[Hexagram].Place6ChangesToNumber = 4;
            iChing[Hexagram].Place6ChangesToTitle = "Youthful Folly ䷃";

            Hexagram = 8;
            iChing[Hexagram].EngTitle = "Holding Together (Union)";
            iChing[Hexagram].ChiTitle = "Pi";
            iChing[Hexagram].Hex = "䷇";
            iChing[Hexagram].Code = new int[]{0,0,0,0,1,0};
            iChing[Hexagram].Above = "K’AN  /  THE ABYSMAL, WATER ";
            iChing[Hexagram].Below = "K’UN  /  THE RECEPTIVE, EARTH";
            iChing[Hexagram].AboveSymbol = "☵";
            iChing[Hexagram].BelowSymbol = "☷";
            iChing[Hexagram].Intro1 = "The waters on the surface of the earth flow together wherever they can, as for example in the ocean, where all the rivers come together.  Symbolically this connotes holding together and the laws that regulate it.  The same idea is suggested by the fact that all the lines of the hexagram except the fifth, the place of the ruler, are yielding.  The yielding lines hold together because they are influenced by a man of strong will in the leading position, a man who is their center of union.  Moreover, this strong and guiding personality in turn holds together with the others, finding in them the complement of his own nature.	"	;
            iChing[Hexagram].TheJudgment = "HOLDING TOGETHER brings good fortune.	"	+ Environment.NewLine + 
                "Inquire of the oracle once again	"	+ Environment.NewLine + 
                "Whether you possess sublimity, constancy, and perseverance;	"	+ Environment.NewLine + 
                "Then there is no blame.	"	+ Environment.NewLine + 
                "Those who are uncertain gradually join.	"	+ Environment.NewLine + 
                "Whoever comes too late	"	+ Environment.NewLine + 
                "Meets with misfortune."	;
            iChing[Hexagram].Intro2 = "What is required is that we unite with others, in order that all may complement and aid one another through holding together.  But such holding together calls for a central figure around whom other persons may unite.  To become a center of influence holding people together is a grave matter and fraught with great responsibility.  It requires greatness of spirit, consistency, and strength.  Therefore let him who wishes to gather others about him ask himself whether he is equal to the undertaking, for anyone attempting the task without a real calling for it only makes confusion worse than if no union at all had taken place.	"	+ Environment.NewLine + Environment.NewLine + 
                "If a man has recognized the necessity for union and does not feel strong enough to function as the center, it is his duty to become a member of some other organic fellowship.	"	;
            iChing[Hexagram].TheImage = "On the earth is water:	"	+ Environment.NewLine + 
                "The image of HOLDING TOGETHER.	"	+ Environment.NewLine + 
                "Thus the kings of antiquity	"	+ Environment.NewLine + 
                "Bestowed the different states as fiefs	"	+ Environment.NewLine + 
                "And cultivated friendly relations	"	+ Environment.NewLine + 
                "With the feudal lords.	"	;
            iChing[Hexagram].Intro3 = "Water fills up all the empty places on the earth and clings fast to it.  The social organization of ancient China was based on this principle of the holding together of dependents and rulers.  Water flows to unite with water, because all parts of it are subject to the same laws.  So too should human society hold together through a community of interests that allows each individual to feel himself a member of a whole.  The central power of a social organization must see to it that every member finds that his true interest lies in holding together with it, as was the case in the paternal relationship between king and vassals in ancient China.	"	;
            iChing[Hexagram].Read1 = 
                "Six at the beginning means:	"	+ Environment.NewLine + 
                "Hold to him in truth and loyalty;	"	+ Environment.NewLine + 
                "This is without blame.	"	+ Environment.NewLine + 
                "Truth, like a full earthen bowl:	"	+ Environment.NewLine + 
                "Thus in the end	"	+ Environment.NewLine + 
                "Good fortune comes from without.	"	;
            iChing[Hexagram].Read2 = 
                "Six in the second place means:	"	+ Environment.NewLine + 
                "Hold to him inwardly.	"	+ Environment.NewLine + 
                "Perseverance brings good fortune.	"	;
            iChing[Hexagram].Read3 =
                "Six in the third place means:	"	+ Environment.NewLine + 
                "You hold together with the wrong people.	"	;
            iChing[Hexagram].Read4 = 
                "Six in the fourth place means:	"	+ Environment.NewLine + 
                "Hold to him outwardly also.	"	+ Environment.NewLine + 
                "Perseverance brings good fortune.	"	;
            iChing[Hexagram].Read5 = 
                "Nine in the fifth place means:	"	+ Environment.NewLine + 
                "Manifestation of holding together.	"	+ Environment.NewLine + 
                "In the hunt the king uses beaters on three sides only	"	+ Environment.NewLine + 
                "And forgoes game that runs off in front.	"	+ Environment.NewLine + 
                "The citizens need no warning.	"	+ Environment.NewLine + 
                "Good fortune.	"	;
            iChing[Hexagram].Read6 = "Six at the top means:	"	+ Environment.NewLine + 
                "Misfortune.	"	;
            iChing[Hexagram].SquareCircle1 = "";
            iChing[Hexagram].SquareCircle2 = "";
            iChing[Hexagram].SquareCircle3 = "";
            iChing[Hexagram].SquareCircle4 = "";
            iChing[Hexagram].SquareCircle5 = "○";// ○ □
            iChing[Hexagram].SquareCircle6 = "";
            iChing[Hexagram].Place1ChangesToNumber = 3;
            iChing[Hexagram].Place1ChangesToTitle = "Difficulty at the Beginning ䷂";
            iChing[Hexagram].Place2ChangesToNumber = 29;
            iChing[Hexagram].Place2ChangesToTitle = "The Abysmal (Water) ䷜";
            iChing[Hexagram].Place3ChangesToNumber = 39;
            iChing[Hexagram].Place3ChangesToTitle = "Obstruction ䷦";
            iChing[Hexagram].Place4ChangesToNumber = 45;
            iChing[Hexagram].Place4ChangesToTitle = "Gathering Together (Massing) ䷬";
            iChing[Hexagram].Place5ChangesToNumber = 2;
            iChing[Hexagram].Place5ChangesToTitle = "The Receptive (Earth) ䷁";
            iChing[Hexagram].Place6ChangesToNumber = 20;
            iChing[Hexagram].Place6ChangesToTitle = "Contemplation (View) ䷓";

            Hexagram = 9;
            iChing[Hexagram].EngTitle = "The Taming Power of the Small";
            iChing[Hexagram].ChiTitle = "Hsiao Ch’u";
            iChing[Hexagram].Hex = "䷈";
            iChing[Hexagram].Code = new int[]{1,1,1,0,1,1};
            iChing[Hexagram].Above = "SUN  /  THE GENTLE, WIND";
            iChing[Hexagram].Below = "CH’IEN  /  THE CREATIVE, HEAVEN";
            iChing[Hexagram].AboveSymbol = "☴";
            iChing[Hexagram].BelowSymbol = "☰";
            iChing[Hexagram].Intro1 = "This hexagram means the force of the small—the power of the shadowy—that restrains, tames, impedes.  A weak line in the fourth place, that of the minister, holds the five strong lines in check.  In the Image it is the wind blowing across the sky.  The wind restrains the clouds, the rising breath of the Creative, and makes them grow dense, but as yet is not strong enough to turn them to rain.  The hexagram presents a configuration of circumstances in which a strong element is temporarily held in leash by a weak element.  It is only through gentleness that this can have a successful outcome.";
            iChing[Hexagram].TheJudgment = "THE TAMING POWER OF THE SMALL"+ Environment.NewLine +  
                "Has success."+ Environment.NewLine + 
                "Dense clouds, no rain from our western region.";
            iChing[Hexagram].Intro2 = "This image refers to the state of affairs in China at the time when King Wên, who came originally from the west, was in the east at the court of the reigning tyrant Chou Hsin.  The moment for action on a large scale had not yet arrived.  King Wên could only keep the tyrant somewhat in check by friendly persuasion.  Hence the image of many clouds, promising moisture and blessing to the land, although as yet no rain falls.  The situation is not unfavorable; there is a prospect of ultimate success, but there are still obstacles in the way, and we can merely take preparatory measures.  Only through the small means of friendly persuasion can we exert any influence.  The time has not yet come for sweeping measures.  However, we may be able, to a limited extent, to act as a restraining and subduing influence.  To carry out our purpose we need firm determination within and gentleness and adaptability in external relations.";
            iChing[Hexagram].TheImage = "The wind drives across heaven:"+ Environment.NewLine + 
                "The image of THE TAMING POWER OF THE SMALL."+ Environment.NewLine + 
                "Thus the superior man"+ Environment.NewLine + 
                "Refines the outward aspect of his nature.";
            iChing[Hexagram].Intro3 = "The wind can indeed drive the clouds together in the sky; yet, being nothing but air, without solid body, it does not produce great or lasting effects.  So also an individual, in times when he can produce no great effect in the outer world, can do nothing except refine the expression of his nature in small ways.";
            iChing[Hexagram].Read1 = "Nine at the beginning means:"+ Environment.NewLine + 
                "Return to the way."+ Environment.NewLine + 
                "How could there be blame in this?"+ Environment.NewLine + 
                "Good fortune.";
            iChing[Hexagram].Read2 = "Nine in the second place means:"+ Environment.NewLine + 
                "He allows himself to be drawn into returning."+ Environment.NewLine + 
                "Good fortune.";
            iChing[Hexagram].Read3 = "Nine in the third place means:"+ Environment.NewLine + 
                "The spokes burst out of the wagon wheels."+ Environment.NewLine + 
                "Man and wife roll their eyes.";
            iChing[Hexagram].Read4 = "Six in the fourth place means:"+ Environment.NewLine + 
                "If you are sincere, blood vanishes and fear gives way."+ Environment.NewLine + 
                "No blame.";
            iChing[Hexagram].Read5 = "Nine in the fifth place means:"+ Environment.NewLine + 
                "If you are sincere and loyally attached,"+ Environment.NewLine + 
                "You are rich in your neighbor.";   
            iChing[Hexagram].Read6 = "Nine at the top means:"+ Environment.NewLine + 
                "The rain comes, there is rest."+ Environment.NewLine + 
                "This is due to the lasting effect of character."+ Environment.NewLine + 
                "Perseverance brings the woman into danger."+ Environment.NewLine + 
                "The moon is nearly full."+ Environment.NewLine + 
                "If the superior man persists,"+ Environment.NewLine + 
                "Misfortune comes.";
            iChing[Hexagram].SquareCircle1 = "";
            iChing[Hexagram].SquareCircle2 = "";
            iChing[Hexagram].SquareCircle3 = "";
            iChing[Hexagram].SquareCircle4 = "□";
            iChing[Hexagram].SquareCircle5 = "○";// ○ □
            iChing[Hexagram].SquareCircle6 = "";
            iChing[Hexagram].Place1ChangesToNumber = 57 ;
            iChing[Hexagram].Place1ChangesToTitle = "The Gentle (The Penetrating, Wind) ䷸";
            iChing[Hexagram].Place2ChangesToNumber = 37;
            iChing[Hexagram].Place2ChangesToTitle = "The Family (The Clan) ䷤";
            iChing[Hexagram].Place3ChangesToNumber = 61;
            iChing[Hexagram].Place3ChangesToTitle = "Inner Truth ䷼";
            iChing[Hexagram].Place4ChangesToNumber = 1;
            iChing[Hexagram].Place4ChangesToTitle = "The Creative (Heaven) ䷀";
            iChing[Hexagram].Place5ChangesToNumber = 26;
            iChing[Hexagram].Place5ChangesToTitle = "The Taming Power of the Great ䷙";
            iChing[Hexagram].Place6ChangesToNumber = 5;
            iChing[Hexagram].Place6ChangesToTitle = "Waiting (Nourishment)";

            
            Hexagram = 10;
            iChing[Hexagram].EngTitle = "Treading (Conduct)";
            iChing[Hexagram].ChiTitle = "Lü";
            iChing[Hexagram].Hex = "䷉";
            iChing[Hexagram].Code = new int[]{1,1,0,1,1,1};
            iChing[Hexagram].Above = "CH’IEN  /  THE CREATIVE, HEAVEN ";
            iChing[Hexagram].Below = "TUI  /  THE JOYOUS, LAKE";
            iChing[Hexagram].AboveSymbol = "☰";
            iChing[Hexagram].BelowSymbol = "☱";
            iChing[Hexagram].Intro1 = "The name of the hexagram means on the one hand the right way of conducting oneself.  Heaven, the father, is above, and the lake, the youngest daughter, is below.  This shows the difference between high and low, upon which composure correct social conduct, depends.  On the other hand, the word for the name of the hexagram, TREADING, means literally treading upon something.  The small and cheerful [Tui] treads upon the large and strong [Ch’ien].  The direction of movement of the two primary trigrams is upward.  The fact that the strong treads on the weak is not mentioned in the Book of Changes, because it is taken for granted.  For the weak to take a stand against the strong is not dangerous here, because it happens in good humor [Tui] and without presumption, so that the strong man is not irritated but takes it all in good part.";
            iChing[Hexagram].TheJudgment = "TREADING.  Treading upon the tail of the tiger."+ Environment.NewLine + 
                "It does not bite the man.  Success.";
            iChing[Hexagram].Intro2 = "The situation is really difficult.  That which is strongest and that which is weakest are close together.  The weak follows behind the strong and worries it.  The strong, however, acquiesces and does not hurt the weak, because the contact is in good humor and harmless."+ Environment.NewLine + Environment.NewLine + 
                "In terms of a human situation, one is handling wild, intractable people.  In such a case one’s purpose will be achieved if one behaves with decorum.  Pleasant manners succeed even with irritable people.";
            iChing[Hexagram].TheImage = "Heaven above, the lake below:"+ Environment.NewLine + 
                "The image of TREADING."+ Environment.NewLine + 
                "Thus the superior man discriminates between high and low,"+ Environment.NewLine + 
                "And thereby fortifies the thinking of the people.";
            iChing[Hexagram].Intro3 = "Heaven and the lake show a difference of elevation that inheres in the natures of the two, hence no envy arises.  Among mankind also there are necessarily differences of elevation; it is impossible to bring about universal equality.  But it is important that differences in social rank should not be arbitrary and unjust, for if this occurs, envy and class struggle are the inevitable consequences.  If, on the other hand, external differences in rank correspond with differences in inner worth, and if inner worth forms the criterion of external rank, people acquiesce and order reigns in society.";
            iChing[Hexagram].Read1 = "Nine at the beginning means:"+ Environment.NewLine + 
                "Simple conduct.  Progress without blame.";
            iChing[Hexagram].Read2 = "Nine in the second place means:"+ Environment.NewLine + 
                "Treading a smooth, level course."+ Environment.NewLine + 
                "The perseverance of a dark man"+ Environment.NewLine + 
                "Brings good fortune.";
            iChing[Hexagram].Read3 = "Six in the third place means:"+ Environment.NewLine + 
                "A one–eyed man is able to see,"+ Environment.NewLine + 
                "A lame man is able to tread."+ Environment.NewLine + 
                "He treads on the tail of the tiger."+ Environment.NewLine + 
                "The tiger bites the man."+ Environment.NewLine + 
                "Misfortune."+ Environment.NewLine + 
                "Thus does a warrior act on behalf of his great prince.";
            iChing[Hexagram].Read4 = "Nine in the fourth place means:"+ Environment.NewLine + 
                "He treads on the tail of the tiger."+ Environment.NewLine + 
                "Caution and circumspection"+ Environment.NewLine + 
                "Lead ultimately to good fortune.";
            iChing[Hexagram].Read5 = "Nine in the fifth place means:"+ Environment.NewLine + 
                "Resolute conduct."+ Environment.NewLine + 
                "Perseverance with awareness of danger.";
            iChing[Hexagram].Read6 = "Nine at the top means:"+ Environment.NewLine + 
                "Look to your conduct and weigh the favorable signs."+ Environment.NewLine + 
                "When everything is fulfilled, supreme good fortune comes.";
            iChing[Hexagram].SquareCircle1 = "";
            iChing[Hexagram].SquareCircle2 = "";
            iChing[Hexagram].SquareCircle3 = "□";
            iChing[Hexagram].SquareCircle4 = "";
            iChing[Hexagram].SquareCircle5 = "○";// ○ □
            iChing[Hexagram].SquareCircle6 = "";
            iChing[Hexagram].Place1ChangesToNumber = 6;
            iChing[Hexagram].Place1ChangesToTitle = "Conflict ䷅";
            iChing[Hexagram].Place2ChangesToNumber = 25;
            iChing[Hexagram].Place2ChangesToTitle = "Innocence (The Unexpected) ䷘";
            iChing[Hexagram].Place3ChangesToNumber = 1;
            iChing[Hexagram].Place3ChangesToTitle = "The Creative (Heaven) ䷀";
            iChing[Hexagram].Place4ChangesToNumber = 61;
            iChing[Hexagram].Place4ChangesToTitle = "Inner Truth ䷼";
            iChing[Hexagram].Place5ChangesToNumber = 38;
            iChing[Hexagram].Place5ChangesToTitle = "Opposition ䷥";
            iChing[Hexagram].Place6ChangesToNumber = 58;
            iChing[Hexagram].Place6ChangesToTitle = "The Joyous (Lake) ䷹";

            Hexagram = 11;
            iChing[Hexagram].EngTitle = "Peace";
            iChing[Hexagram].ChiTitle = "T’ai";
            iChing[Hexagram].Hex = "䷊";
            iChing[Hexagram].Code = new int[]{1,1,1,0,0,0};
            iChing[Hexagram].Above = "K’UN  /  THE RECEPTIVE, EARTH ";
            iChing[Hexagram].Below = "CH’IEN  /  THE CREATIVE, HEAVEN";
            iChing[Hexagram].AboveSymbol = "☷";
            iChing[Hexagram].BelowSymbol = "☰";
            iChing[Hexagram].Intro1 = "The Receptive, which moves downward, stands above; the Creative, which moves upward, is below.  Hence their influences meet and are in harmony, so that all living things bloom and prosper.  This hexagram belongs to the first month (February–March), at which time the forces of nature prepare the new spring.";
            iChing[Hexagram].TheJudgment = "PEACE.  The small departs,"+ Environment.NewLine +
                "The great approaches."+ Environment.NewLine +
                "Good fortune.  Success.";
            iChing[Hexagram].Intro2 = "This hexagram denotes a time in nature when heaven seems to be on earth.  Heaven has placed itself beneath the earth, and so their powers unite in deep harmony.  Then peace and blessing descend upon all living things."+ Environment.NewLine + Environment.NewLine + 
                "In the world of man it is a time of social harmony; those in high places show favor to the lowly, and the lowly and inferior in their turn are well disposed toward the highly placed.  There is an end to all feuds."+ Environment.NewLine + Environment.NewLine + 
                "Inside, at the center, in the key position, is the light principle; the dark principle is outside.  Thus the light has a powerful influence, while the dark is submissive.  In this way each receives its due.  When the good elements of society occupy a central position and are in control, the evil elements come under their influence and change for the better.  When the spirit of heaven rules in man, his animal nature also comes under its influence and takes its appropriate place."+ Environment.NewLine + Environment.NewLine + 
                "The individual lines enter the hexagram from below and leave it again at the top.  Here the small, weak, and evil elements are about to take their departure, while the great, strong, and good elements are moving up.  This brings good fortune and success.";
            iChing[Hexagram].TheImage = "Heaven and earth unite: the image of PEACE."+ Environment.NewLine +
                "Thus the ruler"+ Environment.NewLine +
                "Divides and completes the course of heaven and earth;"+ Environment.NewLine +
                "He furthers and regulates the gifts of heaven and earth,"+ Environment.NewLine +
                "And so aids the people.";
            iChing[Hexagram].Intro3 = "Heaven and earth are in contact and combine their influences, producing a time of universal flowering and prosperity.  This stream of energy must be regulated by the ruler of men.  It is done by a process of division.  Thus men divide the uniform flow of time into the seasons, according to the succession of natural phenomena, and mark off infinite space by the points of the compass.  In this way nature in its overwhelming profusion of phenomena is bounded and controlled.  One the other hand, nature must be furthered in her productiveness.  This is done by adjusting the products to the right time and the right place, which increases the natural yield.  This controlling and furthering activity of man in his relation to nature is the work on nature that rewards him.";
            iChing[Hexagram].Read1 = "Nine at the beginning means:"+ Environment.NewLine +
                "When ribbon grass is pulled up, the sod comes with it."+ Environment.NewLine +
                "Each according to his kind."+ Environment.NewLine +
                "Undertakings bring good fortune.";
            iChing[Hexagram].Read2 = "Nine in the second place means:"+ Environment.NewLine +
                "Bearing with the uncultured in gentleness,"+ Environment.NewLine +
                "Fording the river with resolution,"+ Environment.NewLine +
                "Not neglecting what is distant,"+ Environment.NewLine +
                "Not regarding one’s companions:"+ Environment.NewLine +
                "Thus one may manage to walk in the middle.";
            iChing[Hexagram].Read3 = "Nine in the third place means:"+ Environment.NewLine +
                "No plain not followed by a slope."+ Environment.NewLine +
                "No going not followed by a return."+ Environment.NewLine +
                "He who remains persevering in danger"+ Environment.NewLine +
                "Is without blame."+ Environment.NewLine +
                "Do not complain about this truth;"+ Environment.NewLine +
                "Enjoy the good fortune you still possess.";
            iChing[Hexagram].Read4 = "Six in the fourth place means:"+ Environment.NewLine +
                "He flutters down, not boasting of his wealth,"+ Environment.NewLine +
                "Together with his neighbor,"+ Environment.NewLine +
                "Guileless and sincere.";
            iChing[Hexagram].Read5 = "Six in the fifth place means:"+ Environment.NewLine +
                "The sovereign I"+ Environment.NewLine +
                "Gives his daughter in marriage."+ Environment.NewLine +
                "This brings blessing"+ Environment.NewLine +
                "And supreme good fortune.";
            iChing[Hexagram].Read6 = "The wall falls back into the moat."+ Environment.NewLine +
                "Use no army now."+ Environment.NewLine +
                "Make your commands known within your own town."+ Environment.NewLine +
                "Perseverance brings humiliation.";
            iChing[Hexagram].SquareCircle1 = "";
            iChing[Hexagram].SquareCircle2 = "○";
            iChing[Hexagram].SquareCircle3 = "";
            iChing[Hexagram].SquareCircle4 = "";
            iChing[Hexagram].SquareCircle5 = "○";// ○ □
            iChing[Hexagram].SquareCircle6 = "";
            iChing[Hexagram].Place1ChangesToNumber = 46;
            iChing[Hexagram].Place1ChangesToTitle = "Pushing Upwards ䷭";
            iChing[Hexagram].Place2ChangesToNumber = 36;
            iChing[Hexagram].Place2ChangesToTitle = "Darkening of the Light ䷣";
            iChing[Hexagram].Place3ChangesToNumber = 19;
            iChing[Hexagram].Place3ChangesToTitle = "Approach ䷒";
            iChing[Hexagram].Place4ChangesToNumber = 34;
            iChing[Hexagram].Place4ChangesToTitle = "The Power of the Great ䷡";
            iChing[Hexagram].Place5ChangesToNumber = 5;
            iChing[Hexagram].Place5ChangesToTitle = "Waiting (Nourishment) ䷄";
            iChing[Hexagram].Place6ChangesToNumber = 26;
            iChing[Hexagram].Place6ChangesToTitle = "The Taming Power of the Great ䷙";
            
            Hexagram = 12;
            iChing[Hexagram].EngTitle = "Standstill (Stagnation)";
            iChing[Hexagram].ChiTitle = "P’i";
            iChing[Hexagram].Hex = "䷋";
            iChing[Hexagram].Code = new int[]{0,0,0,1,1,1};
            iChing[Hexagram].Above = "CH’IEN  /  THE CREATIVE, HEAVEN";
            iChing[Hexagram].Below = "K’UN  /  THE RECEPTIVE, EARTH";
            iChing[Hexagram].AboveSymbol = "☰";
            iChing[Hexagram].BelowSymbol = "☷";
            iChing[Hexagram].Intro1 = "This hexagram is the opposite of the preceding one.  Heaven is above, drawing farther and farther away, while the earth below sinks farther into the depths.  The creative powers are not in relation.  It is a time of standstill and decline.  This hexagram is linked with the seventh month (August–September), when the year has passed its zenith and autumnal decay is setting in.";
            iChing[Hexagram].TheJudgment = "STANDSTILL.  Evil people do not further"+ Environment.NewLine +
                "The perseverance of the superior man."+ Environment.NewLine +
                "The great departs; the small approaches.";
            iChing[Hexagram].Intro2 = "Heaven and earth are out of communion and all things are benumbed.  What is above has no relation to what is below, and on earth confusion and disorder prevail.  The dark power is within, the light power is without.  Weakness is within, harshness without.  Within are the inferior, and without are the superior.  The way of inferior people is in ascent; the way of superior people is one the decline.  But the superior people do not allow themselves to be turned from their principles.  If the possibility of exerting influence is closed to them, they nevertheless remain faithful to their principles and withdraw into seclusion.";
            iChing[Hexagram].TheImage = "Heaven and earth do not unite:"+ Environment.NewLine +
                "The image of STANDSTILL."+ Environment.NewLine +
                "Thus the superior man falls back upon his inner worth"+ Environment.NewLine +
                "In order to escape the difficulties."+ Environment.NewLine +
                "He does not permit himself to be honored with revenue.";
            iChing[Hexagram].Intro3 = "When, owing to the influence of inferior men, mutual mistrust prevails in public life, fruitful activity is rendered impossible, because the fundaments are wrong.  Therefore the superior man knows what he must do under such circumstances; he does not allow himself to be tempted by dazzling offers to take part in public activities.  This would only expose him to danger, since he cannot assent to the meanness of the others.  He therefore hides his worth and withdraws into seclusion.";
            iChing[Hexagram].Read1 = "Six at the beginning means:"+ Environment.NewLine +
                "When ribbon grass is pulled up, the sod comes with it."+ Environment.NewLine +
                "Each according to his kind."+ Environment.NewLine +
                "Perseverance brings good fortune and success.";
            iChing[Hexagram].Read2 = "Six in the second place means:"+ Environment.NewLine +
                "They bear and endure;"+ Environment.NewLine +
                "This means good fortune for inferior people."+ Environment.NewLine +
                "The standstill serves to help the great man to attain success.";
            iChing[Hexagram].Read3 = "Six in the third place means:"+ Environment.NewLine +
                "They bear shame.";
            iChing[Hexagram].Read4 = "Nine in the fourth place means:"+ Environment.NewLine +
                "He who acts at the command of the highest"+ Environment.NewLine +
                "Remains without blame." + Environment.NewLine +
                "Those of like mind partake of the blessing.";
            iChing[Hexagram].Read5 = "Nine in the fifth place means:"+ Environment.NewLine +
                "Standstill is giving way."+ Environment.NewLine +
                "Good fortune for the great man."+ Environment.NewLine +
                "“What if it should fail, what if it should fail?”"+ Environment.NewLine +
                "In this way he ties it to a cluster of mulberry shoots.";
            iChing[Hexagram].Read6 = "Nine at the top means:"+ Environment.NewLine +
                "The standstill comes to an end."+ Environment.NewLine +
                "First standstill, then good fortune.";
            iChing[Hexagram].SquareCircle1 = "";
            iChing[Hexagram].SquareCircle2 = "□";
            iChing[Hexagram].SquareCircle3 = "";
            iChing[Hexagram].SquareCircle4 = "";
            iChing[Hexagram].SquareCircle5 = "○";// ○ □
            iChing[Hexagram].SquareCircle6 = "";
            iChing[Hexagram].Place1ChangesToNumber = 25;
            iChing[Hexagram].Place2ChangesToNumber = 6;
            iChing[Hexagram].Place3ChangesToNumber = 33;
            iChing[Hexagram].Place4ChangesToNumber = 20;
            iChing[Hexagram].Place5ChangesToNumber = 35;
            iChing[Hexagram].Place6ChangesToNumber = 45;
            
            
            Hexagram = 13;
            iChing[Hexagram].EngTitle = "Fellowship with Men";
            iChing[Hexagram].ChiTitle = "T’ung Jên";
            iChing[Hexagram].Hex = "䷌";
            iChing[Hexagram].Code = new int[]{1,0,1,1,1,1};
            iChing[Hexagram].Above = "CH’IEN  /  THE CREATIVE, HEAVEN";
            iChing[Hexagram].Below = "LI  /  THE CLINGING, FLAME";
            iChing[Hexagram].AboveSymbol = "☰";
            iChing[Hexagram].BelowSymbol = "☲";
            iChing[Hexagram].Intro1 = "The image of the upper trigram Ch’ien is heaven, and that of the lower, Li, is flame.  It is the nature of fire to flame up to heaven.  This gives the idea of fellowship.  It is the second line that, by virtue of its central character, unites the five strong lines around it.  This hexagram forms a complement to Shih, THE ARMY (7).  In the latter, danger is within and obedience without—the character of a warlike army, which, in order to hold together, needs one strong man among the many who are weak.  Here, clarity is within and strength without—the character of a peaceful union of men, which, in order to hold together, needs one yielding nature among many firm persons.";
            iChing[Hexagram].TheJudgment = "FELLOWSHIP WITH MEN in the open."+ Environment.NewLine +
                "Success."+ Environment.NewLine +
                "It furthers one to cross the great water."+ Environment.NewLine +
                "The perseverance of the superior man furthers.";
            iChing[Hexagram].Intro2 = "True fellowship among men must be based upon a concern that is universal.  It is not the private interests of the individual that create lasting fellowship among men, but rather the goals of humanity.  That is why it is said that fellowship with men in the open succeeds.  If unity of this kind prevails, even difficult and dangerous tasks, such as crossing the great water, can be accomplished.  But in order to bring about this sort of fellowship, a persevering and enlightened leader is needed—a man with clear, convincing, and inspiring aims and the strength to carry them out.  (The inner trigram means clarity; the outer, strength.)";
            iChing[Hexagram].TheImage = "Heaven together with fire:"+ Environment.NewLine +
                "The image of FELLOWSHIP WITH MEN."+ Environment.NewLine +
                "Thus the superior man organizes the clans"+ Environment.NewLine +
                "And makes distinctions between things.";
            iChing[Hexagram].Intro3 = "Heaven has the same direction of movement as fire, yet it is different from fire.  Just as the luminaries in the sky serve for the systematic division and arrangement of time, so human society and all things that really belong together must be organically arranged.  Fellowship should not be a mere mingling of individuals or of things—that would be chaos, not fellowship.  If fellowship is to lead to order, there must be organization within diversity.";
            iChing[Hexagram].Read1 = "Nine at the beginning means:"+ Environment.NewLine +
                "Fellowship with men at the gate."+ Environment.NewLine +
                "No blame.";
            iChing[Hexagram].Read2 = "Six in the second place means:"+ Environment.NewLine +
                "Fellowship with men in the clan."+ Environment.NewLine +
                "Humiliation.";
            iChing[Hexagram].Read3 = "Nine in the third place means:"+ Environment.NewLine +
                "He hides weapons in the thicket;"+ Environment.NewLine +
                "He climbs the high hill in front of it."+ Environment.NewLine +
                "For three years he does not rise up.";
            iChing[Hexagram].Read4 = "Nine in the fourth place means:"+ Environment.NewLine +
                "He climbs up on his wall; he cannot attack."+ Environment.NewLine +
                "Good fortune.";
            iChing[Hexagram].Read5 = "Nine in the fifth place means:"+ Environment.NewLine +
                "Men bound in fellowship first weep and lament,"+ Environment.NewLine +
                "But afterward they laugh."+ Environment.NewLine +
                "After great struggles they succeed in meeting.";
            iChing[Hexagram].Read6 = "Nine at the top means:"+ Environment.NewLine +
                "Fellowship with men in the meadow."+ Environment.NewLine +
                "No remorse.";
            iChing[Hexagram].SquareCircle1 = "";
            iChing[Hexagram].SquareCircle2 = "○";
            iChing[Hexagram].SquareCircle3 = "";
            iChing[Hexagram].SquareCircle4 = "";
            iChing[Hexagram].SquareCircle5 = "○";// ○ □
            iChing[Hexagram].SquareCircle6 = "";
            iChing[Hexagram].Place1ChangesToNumber = 33;
            iChing[Hexagram].Place2ChangesToNumber = 1;
            iChing[Hexagram].Place3ChangesToNumber = 25;
            iChing[Hexagram].Place4ChangesToNumber = 37;
            iChing[Hexagram].Place5ChangesToNumber = 30;
            iChing[Hexagram].Place6ChangesToNumber = 49;
            
            
            Hexagram = 14;
            iChing[Hexagram].EngTitle = "Possession in Great Measure";
            iChing[Hexagram].ChiTitle = "Ta Yu";
            iChing[Hexagram].Hex = "䷍";
            iChing[Hexagram].Code = new int[]{1,1,1,1,0,1};
            iChing[Hexagram].Above = "LI  /  THE CLINGING, FLAME";
            iChing[Hexagram].Below = "CH’IEN  /  THE CREATIVE, HEAVEN";
            iChing[Hexagram].AboveSymbol = "☲";
            iChing[Hexagram].BelowSymbol = "☰";
            iChing[Hexagram].Intro1 = "The fire in heaven above shines far, and all things stand out in the light and become manifest.  The weak fifth line occupies the place of honor, and all the strong lines are in accord with it.  All things come to the man who is modest and kind in a high position.";
            iChing[Hexagram].TheJudgment = "POSSESSION IN GREAT MEASURE."+ Environment.NewLine +
                "Supreme success.";
            iChing[Hexagram].Intro2 = "The two trigrams indicate that strength and clarity unite.  Possession in great measure is determined by fate and accords with the time.  How is it possible that the weak line has power to hold the strong lines fast and to possess them?  It is done by virtue of unselfish modesty.  The time is favorable—a time of strength within, clarity and culture without.  Power is expressing itself in graceful and controlled way.  This brings supreme success and wealth."; 
            iChing[Hexagram].TheImage = "Fire in heaven above:"+ Environment.NewLine +
                "The image of POSSESSION IN GREAT MEASURE."+ Environment.NewLine +
                "Thus the superior man curbs evil and furthers good,"+ Environment.NewLine +
                "And thereby obeys the benevolent will of heaven.";
            iChing[Hexagram].Intro3 = "The sun in heaven above, shedding light over everything on earth, is the image of possession on a grand scale.  But a possession of this sort must be administered properly.  The sun brings both evil and good into the light of day.  Man must combat and curb the evil, and must favor and promote the good.  Only in this way does he fulfill the benevolent will of God, who desires only good and not evil.";
            iChing[Hexagram].Read1 = "Nine at the beginning means:"+ Environment.NewLine +
                "No relationship with what is harmful;"+ Environment.NewLine +
                "There is no blame in this."+ Environment.NewLine +
                "If one remains conscious of difficulty,"+ Environment.NewLine +
                "One remains without blame.";
            iChing[Hexagram].Read2 = "Nine in the second place means:"+ Environment.NewLine +
                "A big wagon for loading."+ Environment.NewLine +
                "One may undertake something."+ Environment.NewLine +
                "No blame.";
            iChing[Hexagram].Read3 = "Nine in the third place means:"+ Environment.NewLine +
                "A prince offers it to the Son of Heaven."+ Environment.NewLine +
                "A petty man cannot do this.";
            iChing[Hexagram].Read4 = "Nine in the fourth place means:"+ Environment.NewLine +
                "He makes a difference"+ Environment.NewLine +
                "Between himself and his neighbor."+ Environment.NewLine +
                "No blame.";
            iChing[Hexagram].Read5 = "Six in the fifth place means:"+ Environment.NewLine +
                "He whose truth is accessible, yet dignified,"+ Environment.NewLine +
                "Has good fortune.";
            iChing[Hexagram].Read6 = "Nine at the top means:"+ Environment.NewLine +
                "He is blessed by heaven."+ Environment.NewLine +
                "Good fortune."+ Environment.NewLine +
                "Nothing that does not further.";
            iChing[Hexagram].SquareCircle1 = "";
            iChing[Hexagram].SquareCircle2 = "";
            iChing[Hexagram].SquareCircle3 = "";
            iChing[Hexagram].SquareCircle4 = "";
            iChing[Hexagram].SquareCircle5 = "○";// ○ □
            iChing[Hexagram].SquareCircle6 = "";
            iChing[Hexagram].Place1ChangesToNumber = 50;
            iChing[Hexagram].Place2ChangesToNumber = 30;
            iChing[Hexagram].Place3ChangesToNumber = 38;
            iChing[Hexagram].Place4ChangesToNumber = 26;
            iChing[Hexagram].Place5ChangesToNumber = 1;
            iChing[Hexagram].Place6ChangesToNumber = 34;
            
            Hexagram = 15;
            iChing[Hexagram].EngTitle = "Modesty";
            iChing[Hexagram].ChiTitle = "Ch’ien";
            iChing[Hexagram].Hex = "䷎";
            iChing[Hexagram].Code = new int[]{0,0,1,0,0,0};
            iChing[Hexagram].Above = "K’UN  /  THE RECEPTIVE, EARTH";
            iChing[Hexagram].Below = "KÊN  /  KEEPING STILL, MOUNTAIN";
            iChing[Hexagram].AboveSymbol = "☷";
            iChing[Hexagram].BelowSymbol = "☶";
            iChing[Hexagram].Intro1 = "This hexagram is made up of the trigrams Kên Keeping Still, mountain, and K’un.  The mountain is the youngest son of the Creative, the representative of heaven and earth.  It dispenses the blessings of heaven, the clouds and rain that gather round its summit, and thereafter shines forth radiant with heavenly light.  This shows what modesty is and how it functions in great and strong men.  K’un, the earth, stands above.  Lowliness is a quality of the earth: this is the very reason why it appears in this hexagram as exalted, by being placed above the mountain.  This shows how modesty functions in lowly, simple people: they are lifted up by it.";
            iChing[Hexagram].TheJudgment = "MODESTY creates success."+ Environment.NewLine +
                "The superior man carries things through.";
            iChing[Hexagram].Intro2 = "It is the law of heaven to make fullness empty and to make full what is modest; when the sun is at its zenith, it must, according to the law of heaven, turn toward its setting, and at its nadir it rises toward a new dawn.  In obedience to the same law, the moon when it is full begins to wane, and when empty of light it waxes again.  This heavenly law works itself out in the fates of men also.  It is the law of earth to alter the full and to contribute to the modest.  High mountains are worn down by the waters, and the valleys are filled up.  It is the law of fate to undermine what is full and to prosper the modest.  And men also hate fullness and love the modest."+ Environment.NewLine +Environment.NewLine +
                "The destinies of men are subject to immutable laws that must fulfill themselves.  But man has it in his power to shape his fate, according as his behavior exposes him to the influence of benevolent or of destructive forces.  When a man holds a high position and is nevertheless modest, he shines with the light of wisdom; if he is in a lowly position and is modest, he cannot be passed by.  Thus the superior man can carry out his work to the end without boasting of what he has achieved.";
            iChing[Hexagram].TheImage = "Within the earth, a mountain:"+ Environment.NewLine +
                "The image of MODESTY."+ Environment.NewLine +
                "Thus the superior man reduces that which is too much,"+ Environment.NewLine +
                "And augments that which is too little."+ Environment.NewLine +
                "He weighs things and makes them equal.";
            iChing[Hexagram].Intro3 = "The wealth of the earth in which a mountain is hidden is not visible to the eye, because the depths are offset by the height of the mountain.  Thus high and low complement each other, and the result is the plain.  Here an effect that it took a long time to achieve, but that in the end seems easy of accomplishment and self–evident, is used as the image of modesty.  The superior man does the same thing when he establishes order in the world; he equalizes the extremes that are the source of social discontent and thereby creates just and equable conditions.";
            iChing[Hexagram].Read1 = "Six at the beginning means:"+ Environment.NewLine +
                "A superior man modest about his modesty"+ Environment.NewLine +
                "May cross the great water."+ Environment.NewLine +
                "Good fortune.";
            iChing[Hexagram].Read2 = "Six in the second place means:"+ Environment.NewLine +
                "Modesty that comes to expression."+ Environment.NewLine +
                "Perseverance brings good fortune.";
            iChing[Hexagram].Read3 = "Nine in the third place means:"+ Environment.NewLine +
                "A superior man of modesty and merit"+ Environment.NewLine +
                "Carries things to conclusion."+ Environment.NewLine +
                "Good fortune.";
            iChing[Hexagram].Read4 = "Six in the fourth place means:"+ Environment.NewLine +
                "Nothing that would not further modesty"+ Environment.NewLine +
                "In movement.";
            iChing[Hexagram].Read5 = "Six in the fifth place means:"+ Environment.NewLine +
                "No boasting of wealth before one’s neighbor."+ Environment.NewLine +
                "It is favorable to attack with force."+ Environment.NewLine +
                "Nothing that would not further.";
            iChing[Hexagram].Read6 = "Six at the top means:"+ Environment.NewLine +
                "Modesty that comes to expression."+ Environment.NewLine +
                "It is favorable to set armies marching"+ Environment.NewLine +
                "To chastise one’s own city and one’s country.";
            iChing[Hexagram].SquareCircle1 = "";
            iChing[Hexagram].SquareCircle2 = "";
            iChing[Hexagram].SquareCircle3 = "○";
            iChing[Hexagram].SquareCircle4 = "";
            iChing[Hexagram].SquareCircle5 = "";// ○ □
            iChing[Hexagram].SquareCircle6 = "";
            iChing[Hexagram].Place1ChangesToNumber = 36;
            iChing[Hexagram].Place2ChangesToNumber = 46;
            iChing[Hexagram].Place3ChangesToNumber = 2;
            iChing[Hexagram].Place4ChangesToNumber = 62;
            iChing[Hexagram].Place5ChangesToNumber = 39;
            iChing[Hexagram].Place6ChangesToNumber = 52;
            
            Hexagram = 16;
            iChing[Hexagram].EngTitle = "Enthusiasm";
            iChing[Hexagram].ChiTitle = "Yü";
            iChing[Hexagram].Hex = "䷏";
            iChing[Hexagram].Code = new int[]{0,0,0,1,0,0};
            iChing[Hexagram].Above = "CHÊN  /  THE AROUSING, THUNDER";
            iChing[Hexagram].Below = "K’UN  /  THE RECEPTIVE, EARTH";
            iChing[Hexagram].AboveSymbol = "☳";
            iChing[Hexagram].BelowSymbol = "☷";
            iChing[Hexagram].Intro1 = "The strong line in the fourth place, that of the leading official, meets with response and obedience from all the other lines, which are all weak.  The attribute of the upper trigram, Chên, is movement; the attributes of K’un, the lower, are obedience and devotion.  This begins a movement that meets with devotion and therefore inspires enthusiasm, carrying all with it.  Of great importance, furthermore, is the law of movement along the line of least resistance, which in this hexagram is enunciated as the law for natural events and for human life.";
            iChing[Hexagram].TheJudgment = "ENTHUSIASM.  It furthers one to install helpers"+ Environment.NewLine +
                "And to set armies marching.";
            iChing[Hexagram].Intro2 = "The time of ENTHUSIASM derives from the fact that there is at hand an eminent man who is in sympathy with the spirit of the people and acts in accord with it.  Hence he finds universal and willing obedience.  To arouse enthusiasm it is necessary for a man to adjust himself and his ordinances to the character of those whom he has to lead.  The inviolability of natural laws rests on this principle of movement along the line of least resistance.  These laws are not forces external to things but represent the harmony of movement immanent in them.  That is why the celestial bodies do not deviate from their orbits and why all events in nature occur with fixed regularity.  It is the same with human society: only such laws as are rooted in popular sentiment can be enforced, while laws violating this sentiment merely arouse resentment."+ Environment.NewLine +Environment.NewLine +
                "Again, it is enthusiasm that enables us to install helpers for the completion of an undertaking without fear of secret opposition.  It is enthusiasm too that can unify mass movements, as in war, so that they achieve victory.";
            iChing[Hexagram].TheImage = "Thunder comes resounding out of the earth:"+ Environment.NewLine +
                "The image of ENTHUSIASM."+ Environment.NewLine +
                "Thus the ancient kings made music"+ Environment.NewLine +
                "In order to honor merit,"+ Environment.NewLine +
                "And offered it with splendor"+ Environment.NewLine +
                "To the Supreme Deity,"+ Environment.NewLine +
                "Inviting their ancestors to be present.";
            iChing[Hexagram].Intro3 = "When, at the beginning of summer, thunder—electrical energy—comes rushing forth from the earth again, and the first thunderstorm refreshes nature, a prolonged state of tension is resolved.  Joy and relief make themselves felt.  So too, music has power to ease tension within the heart and to loosen the grip of obscure emotions.  The enthusiasm of the heart expresses itself involuntarily in a burst of song, in dance and rhythmic movement of the body.  From immemorial times the inspiring effect of the invisible sound that moves all hearts, and draws them together, has mystified mankind."+ Environment.NewLine +Environment.NewLine +
                "Rulers have made use of this natural taste for music; they elevated and regulated it.  Music was looked upon as something serious and holy, designed to purify the feelings of men.  It fell to music to glorify the virtues of heroes and thus to construct a bridge to the world of the unseen.  In the temple men drew near to God with music and pantomimes (out of this later the theater developed).  Religious feeling for the Creator of the world was united with the most sacred of human feelings, that of reverence for the ancestors.  The ancestors were invited to these divine services as guests of the Ruler of Heaven and as representatives of humanity in the higher regions.  This uniting of the human past with the Divinity in solemn moments of religious inspiration established the bond between God and man.  The ruler who revered the Divinity in revering his ancestors became thereby the Son of Heaven, in whom the heavenly and the earthly world met in mystical contact."+ Environment.NewLine +Environment.NewLine +
                "These ideas are the final summation of Chinese culture.  Confucius has said of the great sacrifice at which these rites were performed: “He who could wholly comprehend this sacrifice could rule the world as though it were spinning on his hand.”";
            iChing[Hexagram].Read1 = "Six at the beginning means:"+ Environment.NewLine +
                "Enthusiasm that expresses itself"+ Environment.NewLine +
                "Brings misfortune.";
            iChing[Hexagram].Read2 = "Six in the second place means:"+ Environment.NewLine +
                "Firm as a rock.  Not a whole day."+ Environment.NewLine +
                "Perseverance brings good fortune.";
            iChing[Hexagram].Read3 = "Six in the third place means:"+ Environment.NewLine +
                "Enthusiasm that looks upward creates remorse."+ Environment.NewLine +
                "Hesitation brings remorse.";
            iChing[Hexagram].Read4 = "Nine in the fourth place means:"+ Environment.NewLine +
                "The source of enthusiasm."+ Environment.NewLine +
                "He achieves great things."+ Environment.NewLine +
                "Doubt not."+ Environment.NewLine +
                "You gather friends around you"+ Environment.NewLine +
                "As a hair clasp gathers the hair.";
            iChing[Hexagram].Read5 = 
                "Six in the fifth place means:"+ Environment.NewLine +
                "Persistently ill, and still does not die.";
            iChing[Hexagram].Read6 = 
                "Six at the top means:"+ Environment.NewLine +
                "Deluded enthusiasm."+ Environment.NewLine +
                "But if after completion one changes,"+ Environment.NewLine +
                "There is no blame.";
            iChing[Hexagram].SquareCircle1 = "";
            iChing[Hexagram].SquareCircle2 = "";
            iChing[Hexagram].SquareCircle3 = "";
            iChing[Hexagram].SquareCircle4 = "○";
            iChing[Hexagram].SquareCircle5 = "";// ○ □
            iChing[Hexagram].SquareCircle6 = "";
            iChing[Hexagram].Place1ChangesToNumber = 51;
            iChing[Hexagram].Place2ChangesToNumber = 40;
            iChing[Hexagram].Place3ChangesToNumber = 62;
            iChing[Hexagram].Place4ChangesToNumber = 2;
            iChing[Hexagram].Place5ChangesToNumber = 45;
            iChing[Hexagram].Place6ChangesToNumber = 35;
            
            Hexagram = 17;
            iChing[Hexagram].EngTitle = "Following";
            iChing[Hexagram].ChiTitle = "Sui";
            iChing[Hexagram].Hex = "䷐";
            iChing[Hexagram].Code = new int[]{1,0,0,1,1,0};
            iChing[Hexagram].Above = "TUI  /  THE JOYOUS, LAKE";
            iChing[Hexagram].Below = "CHÊN  /  THE AROUSING, THUNDER";
            iChing[Hexagram].AboveSymbol = "☱";
            iChing[Hexagram].BelowSymbol = "☳";
            iChing[Hexagram].Intro1 = "The trigram Tui, the Joyous, whose attribute is gladness, is above; Chên, the Arousing, which has the attribute of movement, is below.  Joy in movement induces following.  The Joyous is the youngest daughter, while the Arousing is the eldest son.  An older man defers to a young girl and shows her consideration.  By this he moves her to follow him.";
            iChing[Hexagram].TheJudgment = "FOLLOWING has supreme success."+ Environment.NewLine +
                "Perseverance furthers.  No blame.";
            iChing[Hexagram].Intro2 = "In order to obtain a following one must first know how to adapt oneself.  If a man would rule he must first learn to serve, for only in this way does he secure from those below him the joyous assent that is necessary if they are to follow him.  If he has to obtain a following by force or cunning, by conspiracy or by creating factions, he invariably arouses resistance, which obstructs willing adherence.  But even joyous movement can lead to evil consequences, hence the added stipulation, “Perseverance furthers”—that is, consistency in doing right—together with “No blame.”  Just as we should not ask others to follow us unless this condition is fulfilled, so it is only under this condition that we can in turn follow others without coming to harm."+ Environment.NewLine +Environment.NewLine +
                "The thought of obtaining a following through adaptation to the demands of the time is a great and significant idea; this is why the appended judgment is so favorable.";
            iChing[Hexagram].TheImage = "Thunder in the middle of the lake:"+ Environment.NewLine +
                "The image of FOLLOWING."+ Environment.NewLine +
                "Thus the superior man at nightfall"+ Environment.NewLine +
                "Goes indoors for rest and recuperation.";
            iChing[Hexagram].Intro3 = "In the autumn electricity withdraws into the earth again and rests.  Here it is the thunder in the middle of the lake that serves as the image—thunder in its winter rest, not thunder in motion.  The idea of following in the sense of adaptation to the demands of the time grows out of this image.  Thunder in the middle of the lake indicates times of darkness and rest.  Similarly, a superior man, after being tirelessly active all day, allows himself rest and recuperation at night.  No situation can become favorable until one is able to adapt to it and does not wear himself out with mistaken resistance.";
            iChing[Hexagram].Read1 = "Nine at the beginning means:"+ Environment.NewLine +
                "The standard is changing."+ Environment.NewLine +
                "Perseverance brings good fortune."+ Environment.NewLine +
                "To go out of the door in company"+ Environment.NewLine +
                "Produces deeds.";
            iChing[Hexagram].Read2 = "Six in the second place means:"+ Environment.NewLine +
                "If one clings to the little boy,"+ Environment.NewLine +
                "One loses the strong man.";
            iChing[Hexagram].Read3 =
                "Six in the third place means:"+ Environment.NewLine +
                "If one clings to the strong man,"+ Environment.NewLine +
                "One loses the little boy."+ Environment.NewLine +
                "Through following one finds what one seeks."+ Environment.NewLine +
                "It furthers one to remain persevering.";
            iChing[Hexagram].Read4 = "Nine in the fourth place means:"+ Environment.NewLine +
                "Following creates success."+ Environment.NewLine +
                "Perseverance brings misfortune."+ Environment.NewLine +
                "To go one’s way with sincerity brings clarity."+ Environment.NewLine +
                "How could there be blame in this?";
            iChing[Hexagram].Read5 = "Nine in the fifth place means:"+ Environment.NewLine +
                "Sincere in the good.  Good fortune.";
            iChing[Hexagram].Read6 = "Six at the top means:"+ Environment.NewLine +
                "He meets with firm allegiance"+ Environment.NewLine +
                "And is still further bound."+ Environment.NewLine +
                "The king introduces him"+ Environment.NewLine +
                "To the Western Mountain.";
            iChing[Hexagram].SquareCircle1 = "○";
            iChing[Hexagram].SquareCircle2 = "";
            iChing[Hexagram].SquareCircle3 = "";
            iChing[Hexagram].SquareCircle4 = "";
            iChing[Hexagram].SquareCircle5 = "○";// ○ □
            iChing[Hexagram].SquareCircle6 = "";
            iChing[Hexagram].Place1ChangesToNumber = 45;
            iChing[Hexagram].Place2ChangesToNumber = 58;
            iChing[Hexagram].Place3ChangesToNumber = 49;
            iChing[Hexagram].Place4ChangesToNumber = 3;
            iChing[Hexagram].Place5ChangesToNumber = 51;
            iChing[Hexagram].Place6ChangesToNumber = 25;
            
            Hexagram = 18;
            iChing[Hexagram].EngTitle = "Work on what has been Spoiled (Decay)";
            iChing[Hexagram].ChiTitle = "Ku";
            iChing[Hexagram].Hex = "䷑";
            iChing[Hexagram].Code = new int[]{0,1,1,0,0,1};
            iChing[Hexagram].Above = "KÊN  /  KEEPING STILL, MOUNTAIN";
            iChing[Hexagram].Below = "SUN  /  THE GENTLE, WIND";
            iChing[Hexagram].AboveSymbol = "☶";
            iChing[Hexagram].BelowSymbol = "☴";
            iChing[Hexagram].Intro1 = "The Chinese character ku represents a bowl in whose contents worms are breeding.  This means decay.  It is come about because the gentle indifference in the lower trigram has come together with the rigid inertia of the upper, and the result is stagnation.  Since this implies guilt, the conditions embody a demand for removal of the cause.  Hence the meaning of the hexagram is not simply “what has been spoiled” but “work on what has been spoiled.”";
            iChing[Hexagram].TheJudgment = "WORK ON WHAT HAS BEEN SPOILED"+ Environment.NewLine +
                "Has supreme success."+ Environment.NewLine +
                "It furthers one to cross the great water."+ Environment.NewLine +
                "Before the starting point, three days."+ Environment.NewLine +
                "After the starting point, three days.";
            iChing[Hexagram].Intro2 = "What has been spoiled through man’s fault can be made good again through man’s work.  It is not immutable fate, as in the time of STANDSTILL, that has caused the state of corruption, but rather the abuse of human freedom.  Work toward improving conditions promises well, because it accords the possibilities of the time.  We must not recoil from work and danger—symbolized by crossing of the great water—but must take hold energetically.  Success depends, however, on proper deliberation.  This is expressed by the lines, “Before the starting point, three days.  After the starting point, three days.”  We must first know the causes of corruption before we can do away with them; hence it is necessary to be cautious during the time before the start.  Then we must see to it that the new way is safely entered upon, so that a relapse may be avoided; therefore we must pay attention to the time after the start.  Decisiveness and energy must take the place of inertia and indifference that have led to decay, in order that the ending may be followed by a new beginning.";
            iChing[Hexagram].TheImage = "The wind blows low on the mountain:"+ Environment.NewLine +
                "The image of DECAY."+ Environment.NewLine +
                "Thus the superior man stirs up the people"+ Environment.NewLine +
                "And strengthens their spirit.";
            iChing[Hexagram].Intro3 = "When the wind blows low on the mountain, it is thrown back and spoils the vegetation.  This contains a challenge to improvement.  It is the same with debasing attitudes and fashions; they corrupt human society.  His methods likewise must be derived from the two trigrams, but in such a way that their effects unfold in orderly sequence.  The superior man must first remove stagnation by stirring up public opinion, as the wind stirs everything, and must strengthen and tranquillize the character of the people, as the mountain gives tranquillity and nourishment to all that grows in its vicinity.";
            iChing[Hexagram].Read1 = "Six in the beginning means:"+ Environment.NewLine +
                "Setting right what has been spoiled by the father."+ Environment.NewLine +
                "If there is a son,"+ Environment.NewLine +
                "No blame rests upon the departed father."+ Environment.NewLine +
                "Danger.  In the end good fortune.";
            iChing[Hexagram].Read2 = "Nine in the second place means:"+ Environment.NewLine +
                "Setting right what has been spoiled by the mother."+ Environment.NewLine +
                "One must not be too persevering.";
            iChing[Hexagram].Read3 = "Nine in the third place means:"+ Environment.NewLine +
                "Setting right what has been spoiled by the father."+ Environment.NewLine +
                "There will be a little remorse."+ Environment.NewLine +
                "No great blame.";
            iChing[Hexagram].Read4 = "Six in the fourth place means:"+ Environment.NewLine +
                "Tolerating what has been spoiled by the father."+ Environment.NewLine +
                "In continuing one sees humiliation.";
            iChing[Hexagram].Read5 = "Six in the fifth place means:"+ Environment.NewLine +
                "Setting right what has been spoiled by the father."+ Environment.NewLine +
                "One meets with praise.";
            iChing[Hexagram].Read6 = "Nine at the top means:"+ Environment.NewLine +
                "He does not serve kings and princes,"+ Environment.NewLine +
                "Sets himself higher goals.";
            iChing[Hexagram].SquareCircle1 = "";
            iChing[Hexagram].SquareCircle2 = "";
            iChing[Hexagram].SquareCircle3 = "";
            iChing[Hexagram].SquareCircle4 = "";
            iChing[Hexagram].SquareCircle5 = "○";// ○ □
            iChing[Hexagram].SquareCircle6 = "";
            iChing[Hexagram].Place1ChangesToNumber = 26;
            iChing[Hexagram].Place2ChangesToNumber = 52;
            iChing[Hexagram].Place3ChangesToNumber = 4;
            iChing[Hexagram].Place4ChangesToNumber = 50;
            iChing[Hexagram].Place5ChangesToNumber = 57;
            iChing[Hexagram].Place6ChangesToNumber = 46;
            
            
            Hexagram = 19;
            iChing[Hexagram].EngTitle = "Approach";
            iChing[Hexagram].ChiTitle = "Lin";
            iChing[Hexagram].Hex = "䷒";
            iChing[Hexagram].Code = new int[]{1,1,0,0,0,0};
            iChing[Hexagram].Above = "K’UN  /  THE RECEPTIVE, EARTH";
            iChing[Hexagram].Below = "TUI  /  THE JOYOUS, LAKE";
            iChing[Hexagram].AboveSymbol = "☷";
            iChing[Hexagram].BelowSymbol = "☱";
            iChing[Hexagram].Intro1 = "The Chinese word lin has a range of meanings that is not exhausted by any single word of another language.  The ancient explanations in the Book of Changes give as its first meaning, “becoming great.”  What becomes great are the two strong lines growing into the hexagram from below; the light–giving power expands with them.  The meaning is then further extended to include the concept of approach, especially the approach of what is strong and highly placed in relation to what is lower.  Finally the meaning includes the attitude of condescension of a man in high position toward the people, and in general the setting to work on affairs.  This hexagram is linked with the twelfth month (January–February), when, after the winter solstice, the light power begins to ascend again.";
            iChing[Hexagram].TheJudgment = "APPROACH has supreme success."+ Environment.NewLine +
                "Perseverance furthers."+ Environment.NewLine +
                "When the eighth month comes,"+ Environment.NewLine +
                "There will be misfortune.";
            iChing[Hexagram].Intro2 = "The hexagram as a whole points to a time of joyous, hopeful progress.  Spring is approaching.  Joy and forbearance bring high and low nearer together.  Success is certain.  But we must work with determination and perseverance to make full use of the propitiousness of the time.  And one thing more: spring does not last forever.  In the eighth month the aspects are reversed.  Then only two strong, light lines are left; these do not advance but are in retreat (see next hexagram).  We must take heed of this change in good time.  If we meet evil before it becomes reality—before it has even begun to stir—we can master it.";
            iChing[Hexagram].TheImage = "The earth above the lake:"+ Environment.NewLine +
                "The image of APPROACH."+ Environment.NewLine +
                "Thus the superior man is inexhaustible"+ Environment.NewLine +
                "In his will to teach,"+ Environment.NewLine +
                "And without limits"+ Environment.NewLine +
                "In his tolerance and protection of the people.";
            iChing[Hexagram].Intro3 = "The earth borders upon the lake from above.  This symbolizes the approach and condescension of the man of higher position to those beneath him.  The two parts of the image indicate what his attitude toward these people will be.  Just as the lake is inexhaustible in depth, so the sage is inexhaustible in his readiness to teach mankind, and just as the earth is boundlessly wide, sustaining and caring for all creatures on it, so the sage sustains and cares for all people and excludes no part of humanity.";
            iChing[Hexagram].Read1 = "Nine at the beginning means:"+ Environment.NewLine +
                "Joint approach."+ Environment.NewLine +
                "Perseverance brings good fortune.";
            iChing[Hexagram].Read2 = "Nine in the second place means:"+ Environment.NewLine +
                "Joint approach."+ Environment.NewLine +
                "Good fortune."+ Environment.NewLine +
                "Everything furthers.";
            iChing[Hexagram].Read3 = "Six in the third place means:"+ Environment.NewLine +
                "Comfortable approach."+ Environment.NewLine +
                "Nothing that would further."+ Environment.NewLine +
                "If one is induced to grieve over it,"+ Environment.NewLine +
                "One becomes free of blame.";
            iChing[Hexagram].Read4 = "Six in the fourth place means:"+ Environment.NewLine +
                "Complete approach."+ Environment.NewLine +
                "No blame.";
            iChing[Hexagram].Read5 = "Six in the fifth place means:"+ Environment.NewLine +
                "Wise approach."+ Environment.NewLine +
                "This is right for a great prince."+ Environment.NewLine +
                "Good fortune.";
            iChing[Hexagram].Read6 = "Six at the top means:"+ Environment.NewLine +
                "Great hearted approach."+ Environment.NewLine +
                "Good fortune.  No blame.";
            iChing[Hexagram].SquareCircle1 = "○";
            iChing[Hexagram].SquareCircle2 = "○";
            iChing[Hexagram].SquareCircle3 = "";
            iChing[Hexagram].SquareCircle4 = "";
            iChing[Hexagram].SquareCircle5 = "";// ○ □
            iChing[Hexagram].SquareCircle6 = "";
            iChing[Hexagram].Place1ChangesToNumber = 7;
            iChing[Hexagram].Place2ChangesToNumber = 24;
            iChing[Hexagram].Place3ChangesToNumber = 11;
            iChing[Hexagram].Place4ChangesToNumber = 54;
            iChing[Hexagram].Place5ChangesToNumber = 60;
            iChing[Hexagram].Place6ChangesToNumber = 41;
            
            
            Hexagram = 20;
            iChing[Hexagram].EngTitle = "Contemplation (View)";
            iChing[Hexagram].ChiTitle = "Kuan";
            iChing[Hexagram].Hex = "䷓";
            iChing[Hexagram].Code = new int[]{0,0,0,0,1,1};
            iChing[Hexagram].Above = "SUN  /  THE GENTLE, WIND";
            iChing[Hexagram].Below = "K’UN  /  THE RECEPTIVE, EARTH";
            iChing[Hexagram].AboveSymbol = "☴";
            iChing[Hexagram].BelowSymbol = "☷";
            iChing[Hexagram].Intro1 = "A slight variation of tonal stress gives the Chinese name for this hexagram a double meaning.  It means both contemplating and being seen, in the sense of being an example.  These ideas are suggested by the fact that the hexagram can be understood as picturing a type of tower characteristic of ancient China."+ Environment.NewLine +Environment.NewLine +
                "A tower of this kind commanded a wide view of the country; at the same time, when situated on a mountain, it became a landmark that could be seen for miles around.  Thus the hexagram shows a ruler who contemplates the law of heaven above him and the ways of the people below, and who, by means of good government, sets a lofty example to the masses."+ Environment.NewLine +Environment.NewLine +
                "This hexagram is linked with the eight month (September–October).  The light–giving power retreats and the dark power is again on the increase.  However, this aspect is not material in the interpretation of the hexagram as a whole.";
            iChing[Hexagram].TheJudgment = "CONTEMPLATION.  The ablution has been made,"+ Environment.NewLine +
                "But not yet the offering."+ Environment.NewLine +
                "Full of trust they look up to him.";
            iChing[Hexagram].Intro2 = "The sacrificial ritual in China began with an ablution and a libation by which the Deity was invoked, after which the sacrifice was offered.  The moment of time between these two ceremonies is the most sacred of all, the moment of deepest inner concentration.  If piety is sincere and expressive of real faith, the contemplation of it has a transforming and awe–inspiring effect on those who witness it."+ Environment.NewLine +Environment.NewLine +
                "Thus also in nature a holy seriousness is to be seen in the fact that natural occurrences are uniformly subject to law.  Contemplation of the divine meaning underlying the workings of the universe gives to the man who is called upon to influence others the means of producing like effects.  This requires that power of inner concentration which religious contemplation develops in great men strong in faith.  It enables them to apprehend the mysterious and divine laws of life, and by means of profoundest inner concentration they give expression to these laws in their own persons.  Thus a hidden spiritual power emanates from them, influencing and dominating others without their being aware of how it happens.";
            iChing[Hexagram].TheImage = "The wind blows over the earth:"+ Environment.NewLine +
                "The image of CONTEMPLATION."+ Environment.NewLine +
                "Thus the kings of old visited the regions of the world,"+ Environment.NewLine +
                "Contemplated the people,"+ Environment.NewLine +
                "And gave them instruction.";
            iChing[Hexagram].Intro3 = "When the wind blows over the earth it goes far and wide, and the grass must bend to its power.  These two occurrences find confirmation in the hexagram.  The two images are used to symbolize a practice of the kings of old; in making regular journeys the ruler could, in the first place, survey his realm and make certain that none of the existing usages of the people escaped notice; in the second, he could exert influence through which such customs as were unsuitable could be changed"+ Environment.NewLine +Environment.NewLine +
                "All of this points to the power possessed by a superior personality.  On the one hand, such a man will have a view of the real sentiments of the great mass of humanity and therefore cannot be deceived; on the other, he will impress the people so profoundly, by his mere existence and by the impact of his personality, that they will be swayed by him as the grass by the wind.";
            iChing[Hexagram].Read1 = "Six at the beginning means:"+ Environment.NewLine +
                "Boylike contemplation."+ Environment.NewLine +
                "For an inferior man, no blame."+ Environment.NewLine +
                "For a superior man, humiliation.";
            iChing[Hexagram].Read2 = "Six in the second place means:"+ Environment.NewLine +
                "Contemplation through the crack of the door."+ Environment.NewLine +
                "Furthering for the perseverance of a woman.";
            iChing[Hexagram].Read3 = "Six in the third place means:"+ Environment.NewLine +
                "Contemplation of my life"+ Environment.NewLine +
                "Decides the choice"+ Environment.NewLine +
                "Between advance and retreat.";
            iChing[Hexagram].Read4 = "Six in the fourth place means:"+ Environment.NewLine +
                "Contemplation of the light of the kingdom."+ Environment.NewLine +
                "It furthers one to exert influence as the guest of a king";
            iChing[Hexagram].Read5 = "Nine in the fifth place means:"+ Environment.NewLine +
                "Contemplation of my life."+ Environment.NewLine +
                "The superior man is without blame.";
            iChing[Hexagram].Read6 = "Nine at the top means:"+ Environment.NewLine +
                "Contemplation of his life."+ Environment.NewLine +
                "The superior man is without blame.";
            iChing[Hexagram].SquareCircle1 = "";
            iChing[Hexagram].SquareCircle2 = "";
            iChing[Hexagram].SquareCircle3 = "";
            iChing[Hexagram].SquareCircle4 = "";
            iChing[Hexagram].SquareCircle5 = "○";// ○ □
            iChing[Hexagram].SquareCircle6 = "○";
            iChing[Hexagram].Place1ChangesToNumber = 42;
            iChing[Hexagram].Place2ChangesToNumber = 59;
            iChing[Hexagram].Place3ChangesToNumber = 53;
            iChing[Hexagram].Place4ChangesToNumber = 9;
            iChing[Hexagram].Place5ChangesToNumber = 23;
            iChing[Hexagram].Place6ChangesToNumber = 8;
            
            Hexagram = 21;
            iChing[Hexagram].EngTitle = "Biting Through";
            iChing[Hexagram].ChiTitle = "Shih Ho";
            iChing[Hexagram].Hex = "䷔";
            iChing[Hexagram].Code = new int[]{1,0,0,1,0,1};
            iChing[Hexagram].Above = "LI  /  THE CLINGING, FIRE";
            iChing[Hexagram].Below = "CHÊN  /  THE AROUSING, THUNDER";
            iChing[Hexagram].AboveSymbol = "☲";
            iChing[Hexagram].BelowSymbol = "☳";
            iChing[Hexagram].Intro1 = "This hexagram represents an open mouth (cf. hexagram 27) with an obstruction (in the fourth place) between the teeth.  As a result the lips cannot meet.  To bring them together one must bite energetically through the obstacle.  Since the hexagram is made up of the trigrams for thunder and for lightning, it indicates how obstacles are forcibly removed in nature.  Energetic biting through overcomes the obstacle that prevents joining of the lips; the storm with its thunder and lightning overcomes the disturbing tension in nature.  Recourse to law and penalties overcomes the disturbances of harmonious social life caused by criminals and slanderers.  The theme of this hexagram is a criminal lawsuit, in contradistinction to that of Sung, CONFLICT (6), which refers to civil suits.";
            iChing[Hexagram].TheJudgment = "BITING THROUGH has success."+ Environment.NewLine +
                "It is favorable to let justice be administered.";
            iChing[Hexagram].Intro2 = "When an obstacle to union arises, energetic biting through brings success.  This is true in all situations.  Whenever unity cannot be established, the obstruction is due to a talebearer and traitor who is interfering and blocking the way.  To prevent permanent injury, vigorous measures must be taken at once.  Deliberate obstruction of this sort does not vanish of its own accord.  Judgment and punishment are required to deter or obviate it."+ Environment.NewLine +Environment.NewLine +
                "However, it is important to proceed in the right way.  The hexagram combines Li, clarity, and Chên, excitement.  Li is yielding, Chên is hard.  Unqualified hardness and excitement would be too violent in meting out punishment; unqualified clarity and gentleness would be too weak.  The two together create the just measure.  It is of moment that the man who makes the decisions (represented by the fifth line) is gentle by nature, while he commands respect by his conduct in his position.";
            iChing[Hexagram].TheImage = "Thunder and lighting:"+ Environment.NewLine +
                "The image of BITING THROUGH."+ Environment.NewLine +
                "Thus the kings of former times made firm the laws"+ Environment.NewLine +
                "Through clearly defined penalties.";
            iChing[Hexagram].Intro3 = "Penalties are the individual applications of the law.  The laws specify the penalties.  Clarity prevails when mild and severe penalties are differentiated, according to the nature of the crimes.  This is symbolized by the clarity of lightning.  The law is strengthened by a just application of penalties.  This is symbolized by the terror of thunder.  This clarity and severity have the effect of instilling respect; it is not that the penalties are ends in themselves.  The obstructions in the social life of man increase when there is a lack of clarity in the penal codes and slackness in executing them.  The only way to strengthen the law is to make it clear and to make penalties certain and swift.";
            iChing[Hexagram].Read1 = "Nine at the beginning means:"+ Environment.NewLine +
                "His feet are fastened in the stocks,"+ Environment.NewLine +
                "So that his toes disappear."+ Environment.NewLine +
                "No blame.";
            iChing[Hexagram].Read2 = "Six in the second place means:"+ Environment.NewLine +
                "Bites through tender meat,"+ Environment.NewLine +
                "So that his nose disappears"+ Environment.NewLine +
                "No blame.";
            iChing[Hexagram].Read3 = "Six in the third place means:"+ Environment.NewLine +
                "Bites on old dried meat"+ Environment.NewLine +
                "And strikes on something poisonous."+ Environment.NewLine +
                "Slight humiliation.  No blame.";
            iChing[Hexagram].Read4 = "Nine in the fourth place means:"+ Environment.NewLine +
                "Bites on dried gristly meat."+ Environment.NewLine +
                "Receives metal arrows."+ Environment.NewLine +
                "It furthers one to be mindful of difficulties"+ Environment.NewLine +
                "And to be persevering."+ Environment.NewLine +
                "Good fortune.";
            iChing[Hexagram].Read5 = "Six in the fifth place means:"+ Environment.NewLine +
                "Bites on dried lean meat."+ Environment.NewLine +
                "Receives yellow gold."+ Environment.NewLine +
                "Perseveringly aware of danger."+ Environment.NewLine +
                "No blame.";
            iChing[Hexagram].Read6 = "Nine at the top means:"+ Environment.NewLine +
                "His neck is fastened in the wooden cangue,"+ Environment.NewLine +
                "So that his ears disappear."+ Environment.NewLine +
                "Misfortune.";
            iChing[Hexagram].SquareCircle1 = "";
            iChing[Hexagram].SquareCircle2 = "";
            iChing[Hexagram].SquareCircle3 = "";
            iChing[Hexagram].SquareCircle4 = "";
            iChing[Hexagram].SquareCircle5 = "○";// ○ □
            iChing[Hexagram].SquareCircle6 = "";
            iChing[Hexagram].Place1ChangesToNumber = 35;
            iChing[Hexagram].Place2ChangesToNumber = 38;
            iChing[Hexagram].Place3ChangesToNumber = 30;
            iChing[Hexagram].Place4ChangesToNumber = 27;
            iChing[Hexagram].Place5ChangesToNumber = 25;
            iChing[Hexagram].Place6ChangesToNumber = 51;
            
            
            Hexagram = 22;
            iChing[Hexagram].EngTitle = "Grace";
            iChing[Hexagram].ChiTitle = "Pi";
            iChing[Hexagram].Hex = "䷕";
            iChing[Hexagram].Code = new int[]{1,0,1,0,0,1};
            iChing[Hexagram].Above = "KÊN  /  KEEPING STILL, MOUNTAIN";
            iChing[Hexagram].Below = "LI  /  THE CLINGING, FIRE";
            iChing[Hexagram].AboveSymbol = "☶";
            iChing[Hexagram].BelowSymbol = "☲";
            iChing[Hexagram].Intro1 = "This hexagram shows a fire that breaks out of the secret depths of the earth and, blazing up, illuminates and beautifies the mountain, the heavenly heights.  Grace—beauty of form—is necessary in any union if it is to be well ordered and pleasing rather than disordered and chaotic.";
            iChing[Hexagram].TheJudgment = "GRACE has success."+ Environment.NewLine +
                "In small matters"+ Environment.NewLine +
                "It is favorable to undertake something.";
            iChing[Hexagram].Intro2 = "Grace brings success.  However, it is not the essential or fundamental thing; it is only the ornament and therefore be used sparingly and only in little things.  In the lower trigram of fire a yielding line comes between two strong lines and makes them beautiful, but the strong lines are the essential content and the weak line is the beautifying form.  In the upper trigram of the mountain, the strong line takes the lead, so that here again the strong element must be regarded as the decisive factor.  In nature we see in the sky the strong light of the sun; the life of the world depends on it.  But this strong, essential thing is changed and given pleasing variety by the moon and the stars.  In human affairs, aesthetic form comes into being when traditions exist that, strong and abiding like mountains, are made pleasing by a lucid beauty.  By contemplating the forms existing in the heavens we come to understand time and its changing demands.  Through contemplation of the forms existing in human society it becomes possible to shape the world.";
            iChing[Hexagram].TheImage = "Fire at the foot of the mountain:"+ Environment.NewLine +
                "The image of GRACE."+ Environment.NewLine +
                "Thus does the superior man proceed"+ Environment.NewLine +
                "When clearing up current affairs."+ Environment.NewLine +
                "But he dare not decide controversial issues in this way.";
            iChing[Hexagram].Intro3 = "The fire, whose light illuminates the mountain and makes it pleasing, does not shine far; in the same way, beautiful form suffices to brighten and to throw light upon matters of lesser moment, but important questions cannot be decided in this way.  They require greater earnestness.";
            iChing[Hexagram].Read1 = "Nine at the beginning means:"+ Environment.NewLine +
                "He lends grace to his toes, leaves the carriage, and walks.";
            iChing[Hexagram].Read2 = "Six in the second place means:"+ Environment.NewLine +
                "Lends grace to the beard on his chin.";
            iChing[Hexagram].Read3 = "Nine in the third place means:"+ Environment.NewLine +
                "Graceful and moist."+ Environment.NewLine +
                "Constant perseverance brings good fortune.";
            iChing[Hexagram].Read4 = "Six in the fourth place means:"+ Environment.NewLine +
                "Grace or simplicity?"+ Environment.NewLine +
                "A white horse comes as if on wings."+ Environment.NewLine +
                "He is not a robber,"+ Environment.NewLine +
                "He will woo at the right time.";
            iChing[Hexagram].Read5 = "Six in the fifth place means:"+ Environment.NewLine +
                "Grace in hills and gardens."+ Environment.NewLine +
                "The roll of silk is meager and small."+ Environment.NewLine +
                "Humiliation, but in the end good fortune.";
            iChing[Hexagram].Read6 = "Nine at the top means:"+ Environment.NewLine +
                "Simple grace.  No blame.";
            iChing[Hexagram].SquareCircle1 = "";
            iChing[Hexagram].SquareCircle2 = "○";
            iChing[Hexagram].SquareCircle3 = "";
            iChing[Hexagram].SquareCircle4 = "";
            iChing[Hexagram].SquareCircle5 = "";// ○ □
            iChing[Hexagram].SquareCircle6 = "○";
            iChing[Hexagram].Place1ChangesToNumber = 52;
            iChing[Hexagram].Place2ChangesToNumber = 26;
            iChing[Hexagram].Place3ChangesToNumber = 27;
            iChing[Hexagram].Place4ChangesToNumber = 30;
            iChing[Hexagram].Place5ChangesToNumber = 37;
            iChing[Hexagram].Place6ChangesToNumber = 36;
            
            
            Hexagram = 23;
            iChing[Hexagram].EngTitle = "Splitting Apart";
            iChing[Hexagram].ChiTitle = "Po";
            iChing[Hexagram].Hex = "䷖";
            iChing[Hexagram].Code = new int[]{0,0,0,0,0,1};
            iChing[Hexagram].Above = "KÊN  /  KEEPING STILL, MOUNTAIN";
            iChing[Hexagram].Below = "K’UN  /  THE RECEPTIVE, EARTH";
            iChing[Hexagram].AboveSymbol = "☶";
            iChing[Hexagram].BelowSymbol = "☷";
            iChing[Hexagram].Intro1 = "The dark lines are about to mount upward and overthrow the last firm, light line by exerting a disintegrating influence on it.  The inferior, dark forces overcome what is superior and strong, not by direct means, but by undermining it gradually and imperceptibly, so that it finally collapses."+ Environment.NewLine +Environment.NewLine +
                "The lines of the hexagram present the image of a house, the top line being the roof, and because the roof is being shattered the house collapses.  The hexagram belongs to the ninth month (October–November).  The yin power pushes up ever more powerfully and is about to supplant the yang power altogether.";
            iChing[Hexagram].TheJudgment = "SPLITTING APART.  It does not further one"+ Environment.NewLine +
                "To go anywhere.";
            iChing[Hexagram].Intro2 = "This pictures a time when inferior people are pushing forward and are about to crowd out the few remaining strong and superior men.  Under these circumstances, which are due to the time, it is not favorable for the superior man to undertake anything."+ Environment.NewLine +Environment.NewLine +
                "The right behavior in such adverse times is to be deduced from the images and their attributes.  The lower trigram stands for the earth, whose attributes are docility and devotion.  The upper trigram stands for the mountain, whose attribute is stillness.  This suggests that one should submit to the bad time and remain quiet.  For it is a question not of man’s doing but of time conditions, which, according to the laws of heaven, show an alternation of increase and decrease, fullness and emptiness.  It is impossible to counteract these conditions of the time.  Hence it is not cowardice but wisdom to submit and avoid action.";
            iChing[Hexagram].TheImage = "The mountain rests on the earth:"+ Environment.NewLine +
                "The image of SPLITTING APART."+ Environment.NewLine +
                "Thus those above can ensure their position"+ Environment.NewLine +
                "Only by giving generously to those below.";
            iChing[Hexagram].Intro3 = "The mountain rests on the earth.  When it is steep and narrow, lacking a broad base, it must topple over.  Its position is strong only when it rises out of the earth broad and great, not proud and steep.  So likewise those who rule rest on the broad foundation of the people.  They too should be generous and benevolent, like the earth that carries all.  Then they will make their position as secure as a mountain is in its tranquillity.";
            iChing[Hexagram].Read1 = "Six at the beginning means:"+ Environment.NewLine +
                "The leg of the bed is split."+ Environment.NewLine +
                "Those who persevere are destroyed."+ Environment.NewLine +
                "Misfortune.";
            iChing[Hexagram].Read2 = "Six in the second place means:"+ Environment.NewLine +
                "The bed is split at the edge."+ Environment.NewLine +
                "Those who persevere are destroyed."+ Environment.NewLine +
                "Misfortune.";
            iChing[Hexagram].Read3 = "Six in the third place means:"+ Environment.NewLine +
                "He splits with them.  No blame.";
            iChing[Hexagram].Read4 = "Six in the fourth place means:"+ Environment.NewLine +
                "The bed is split up to the skin."+ Environment.NewLine +
                "Misfortune.";
            iChing[Hexagram].Read5 = "Six in the fifth place means:"+ Environment.NewLine +
                "A shoal of fishes.  Favor comes through the court ladies."+ Environment.NewLine +
                "Everything acts to further.";
            iChing[Hexagram].Read6 = "Nine at the top means:"+ Environment.NewLine +
                "There is a large fruit still uneaten."+ Environment.NewLine +
                "The superior man receives a carriage."+ Environment.NewLine +
                "The house of the inferior man is split apart.";
            iChing[Hexagram].SquareCircle1 = "";
            iChing[Hexagram].SquareCircle2 = "";
            iChing[Hexagram].SquareCircle3 = "";
            iChing[Hexagram].SquareCircle4 = "";
            iChing[Hexagram].SquareCircle5 = "";// ○ □
            iChing[Hexagram].SquareCircle6 = "○";
            iChing[Hexagram].Place1ChangesToNumber = 27;
            iChing[Hexagram].Place2ChangesToNumber = 4;
            iChing[Hexagram].Place3ChangesToNumber = 52;
            iChing[Hexagram].Place4ChangesToNumber = 35;
            iChing[Hexagram].Place5ChangesToNumber = 20;
            iChing[Hexagram].Place6ChangesToNumber = 2;
            
            Hexagram = 24;
            iChing[Hexagram].EngTitle = "Return (The Turning Point)";
            iChing[Hexagram].ChiTitle = "Fu";
            iChing[Hexagram].Hex = "䷗";
            iChing[Hexagram].Code = new int[]{1,0,0,0,0,0};
            iChing[Hexagram].Above = "K’UN  /  THE RECEPTIVE, EARTH";
            iChing[Hexagram].Below = "CHÊN  /  THE AROUSING, THUNDER";
            iChing[Hexagram].AboveSymbol = "☷";
            iChing[Hexagram].BelowSymbol = "☳";
            iChing[Hexagram].Intro1 = "The idea of a turning point arises from the fact that after the dark lines have pushed all of the light lines upward and out of the hexagram, another light line enters the hexagram from below.  The time of darkness is past.  The winter solstice brings the victory of light.  This hexagram is linked with the eleventh month, the month of the solstice (December–January).";
            iChing[Hexagram].TheJudgment = "RETURN.  Success."+ Environment.NewLine +
                "Going out and coming in without error."+ Environment.NewLine +
                "Friends come without blame."+ Environment.NewLine +
                "To and fro goes the way."+ Environment.NewLine +
                "On the seventh day comes return."+ Environment.NewLine +
                "It furthers one to have somewhere to go.";
            iChing[Hexagram].Intro2 = "After a time of decay comes the turning point.  The powerful light that has been banished returns.  There is movement, but it is not brought about by force.  The upper trigram K’un is characterized by devotion; thus the movement is natural, arising spontaneously.  For this reason the transformation of the old becomes easy.  The old is discarded and the new is introduced.  Both measures accord with the time; therefore no harm results.  Societies of people sharing the same views are formed.  But since these groups come together in full public knowledge and are in harmony with the time, all selfish separatist tendencies are excluded, and no mistake is made.  The idea of RETURN is based on the course of nature.  The movement is cyclic, and the course completes itself.  Therefore it is not necessary to hasten anything artificially.  Everything comes of itself at the appointed time.  This is the meaning of heaven and earth."+ Environment.NewLine +Environment.NewLine +
                "All movements are accomplished in six stages, and the seventh brings return.  Thus the winter solstice, with which the decline of the year begins, comes in the seventh month after the summer solstice; so too sunrise comes in the seventh double hour after sunset.  Therefore seven is the number of the young light, and it arises when six, the number of the great darkness, is increased by one.  In this way the state of rest gives place to movement.";
            iChing[Hexagram].TheImage = "Thunder within the earth:"+ Environment.NewLine +
                "The image of THE TURNING POINT."+ Environment.NewLine +
                "Thus the kings of antiquity closed the passes"+ Environment.NewLine +
                "At the time of solstice."+ Environment.NewLine +
                "Merchants and strangers did not go about,"+ Environment.NewLine +
                "And the ruler"+ Environment.NewLine +
                "Did not travel through the provinces.";
            iChing[Hexagram].Intro3 ="The winter solstice has always been celebrated in China as the resting time of the year—a custom that survives in the time of rest observed at the new year.  In winter the life energy, symbolized by thunder, the Arousing, is still underground.  Movement is just at its beginning; therefore it must be strengthened by rest so that it will not be dissipated by being used prematurely.  This principle, i.e., of allowing energy that is renewing itself to be reinforced by rest, applies to all similar situations.  The return of health after illness, the return of understanding after an estrangement: everything must be treated tenderly and with care at the beginning, so that the return may lead to a flowering.";
            iChing[Hexagram].Read1 = "Nine at the beginning means:"+ Environment.NewLine +
                "Return from a short distance."+ Environment.NewLine +
                "No need for remorse."+ Environment.NewLine +
                "Great good fortune.";
            iChing[Hexagram].Read2 = "Six in the second place means:"+ Environment.NewLine +
                "Quiet return.  Good fortune.";
            iChing[Hexagram].Read3 = "Six in the third place means:"+ Environment.NewLine +
                "Repeated return.  Danger.  No blame.";
            iChing[Hexagram].Read4 = "Six in the fourth place means:"+ Environment.NewLine +
                "Walking in the midst of others,"+ Environment.NewLine +
                "One returns alone.";
            iChing[Hexagram].Read5 = "Six in the fifth place means:"+ Environment.NewLine +
                "Noblehearted return.  No remorse.";
            iChing[Hexagram].Read6 = "Six at the top means:"+ Environment.NewLine +
                "Missing the return.  Misfortune."+ Environment.NewLine +
                "Misfortune from within and without."+ Environment.NewLine +
                "If armies are set marching in this way,"+ Environment.NewLine +
                "One will in the end suffer a great defeat,"+ Environment.NewLine +
                "Disastrous for the ruler of the country."+ Environment.NewLine +
                "For ten years"+ Environment.NewLine +
                "It will not be possible to attack again.";
            iChing[Hexagram].SquareCircle1 = "○";
            iChing[Hexagram].SquareCircle2 = "";
            iChing[Hexagram].SquareCircle3 = "";
            iChing[Hexagram].SquareCircle4 = "";
            iChing[Hexagram].SquareCircle5 = "";// ○ □
            iChing[Hexagram].SquareCircle6 = "";
            iChing[Hexagram].Place1ChangesToNumber = 2;
            iChing[Hexagram].Place2ChangesToNumber = 19;
            iChing[Hexagram].Place3ChangesToNumber = 36;
            iChing[Hexagram].Place4ChangesToNumber = 51;
            iChing[Hexagram].Place5ChangesToNumber = 3;
            iChing[Hexagram].Place6ChangesToNumber = 27;
            
            Hexagram = 25;
            iChing[Hexagram].EngTitle = "Innocence (The Unexpected)";
            iChing[Hexagram].ChiTitle = "Wu Wang";
            iChing[Hexagram].Hex = "䷘";
            iChing[Hexagram].Code = new int[]{1,0,0,1,1,1};
            iChing[Hexagram].Above = "CH’IEN  /  THE CREATIVE, HEAVEN";
            iChing[Hexagram].Below = "CHÊN  /  THE AROUSING, THUNDER";
            iChing[Hexagram].AboveSymbol = "☰";
            iChing[Hexagram].BelowSymbol = "☳";
            iChing[Hexagram].Intro1 = "Ch’ien, heaven is above; Chên, movement, is below.  The lower trigram Chên is under the influence of the strong line it has received from above, from heaven.  When, in accord with this, movement follows the law of heaven, man is innocent and without guile.  His mind is natural and true, unshadowed by reflection or ulterior designs.  For wherever conscious purpose is to be seen, there the truth and innocence of nature have been lost.  Nature that is not directed by the spirit is not true but degenerate nature.  Starting out with the idea of the natural, the train of thought in part goes somewhat further and thus the hexagram includes also the idea of the unintentional or unexpected.";
            iChing[Hexagram].TheJudgment = "INNOCENCE.  Supreme success."+ Environment.NewLine +
                "Perseverance furthers."+ Environment.NewLine +
                "If someone is not as he should be,"+ Environment.NewLine +
                "He has misfortune,"+ Environment.NewLine +
                "And it does not further him"+ Environment.NewLine +
                "To undertake anything.";
            iChing[Hexagram].Intro2 = "Man has received from heaven a nature innately good, to guide him in all his movements.  By devotion to this divine spirit within himself, he attains an unsullied innocence that leads him to do right with instinctive sureness and without any ulterior thought of reward and personal advantage.  This instinctive certainty brings about supreme success and “furthers through perseverance.”  However, not everything instinctive is nature in this higher sense of the word, but only that which is right and in accord with the will of heaven.  Without this quality of rightness, an unreflecting, instinctive way of acting brings only misfortune.  Confucius says about this: “He who departs from innocence, what does he come to? Heaven’s will and blessing do not go with his deeds.”";
            iChing[Hexagram].TheImage = "Under heaven thunder rolls:"+ Environment.NewLine +
                "All things attain the natural state of innocence."+ Environment.NewLine +
                "Thus the kings of old,"+ Environment.NewLine +
                "Rich in virtue, and in harmony with the time,"+ Environment.NewLine +
                "Fostered and nourished all beings.";
            iChing[Hexagram].Intro3 = "In springtime when thunder, life energy, begins to move again under the heavens, everything sprouts and grows, and all beings receive from the creative activity of nature the childlike innocence of their original state.  So it is with the good rulers of mankind: drawing on the spiritual wealth at their command, they take care of all forms of life and all forms of culture and do everything to further them, and at the proper time";
            iChing[Hexagram].Read1 = "Nine at the beginning means:"+ Environment.NewLine +
                "Innocent behavior brings good fortune.";
            iChing[Hexagram].Read2 = "Six in the second place means:"+ Environment.NewLine +
                "If one does not count on the harvest while plowing,"+ Environment.NewLine +
                "Nor on the use of the ground while clearing it,"+ Environment.NewLine +
                "It furthers one to undertake something.";
            iChing[Hexagram].Read3 = "Six in the third place means:"+ Environment.NewLine +
                "Undeserved misfortune."+ Environment.NewLine +
                "The cow that was tethered by someone"+ Environment.NewLine +
                "Is the wanderer’s gain, the citizen’s loss";
            iChing[Hexagram].Read4 = "Nine in the fourth place means:"+ Environment.NewLine +
                "He who can be persevering"+ Environment.NewLine +
                "Remains without blame.";
            iChing[Hexagram].Read5 = "Nine in the fifth place means:"+ Environment.NewLine +
                "Use no medicine in an illness"+ Environment.NewLine +
                "Incurred through no fault of your own."+ Environment.NewLine +
                "It will pass of itself.";
            iChing[Hexagram].Read6 = "Nine at the top means"+ Environment.NewLine +
                "Innocent action brings misfortune."+ Environment.NewLine +
                "Nothing furthers.";
            iChing[Hexagram].SquareCircle1 = "○";
            iChing[Hexagram].SquareCircle2 = "";
            iChing[Hexagram].SquareCircle3 = "";
            iChing[Hexagram].SquareCircle4 = "";
            iChing[Hexagram].SquareCircle5 = "○";// ○ □
            iChing[Hexagram].SquareCircle6 = "";
            iChing[Hexagram].Place1ChangesToNumber = 12;
            iChing[Hexagram].Place2ChangesToNumber = 10;
            iChing[Hexagram].Place3ChangesToNumber = 13;
            iChing[Hexagram].Place4ChangesToNumber = 42;
            iChing[Hexagram].Place5ChangesToNumber = 21;
            iChing[Hexagram].Place6ChangesToNumber = 17;
            
             
            Hexagram = 26;
            iChing[Hexagram].EngTitle = "The Taming Power of the Great";
            iChing[Hexagram].ChiTitle = "Ta Ch’u";
            iChing[Hexagram].Hex = "䷙";
            iChing[Hexagram].Code = new int[]{1,1,1,0,0,1};
            iChing[Hexagram].Above = "KÊN  /  KEEPING STILL, MOUNTAIN";
            iChing[Hexagram].Below = "CH’IEN  /  THE CREATIVE, HEAVEN";
            iChing[Hexagram].AboveSymbol = "☶";
            iChing[Hexagram].BelowSymbol = "☰";
            iChing[Hexagram].Intro1 = "The Creative is tamed by Kên, Keeping Still.  This produces great power, a situation in contrast to that of the ninth hexagram, Hsiao Ch’u, THE TAMING POWER OF THE SMALL, in which the Creative is tamed by the Gentle alone.  There one weak line must tame five strong lines, but here four strong lines are restrained by two weak lines; in addition to a minister, there is a prince, and the restraining power therefore is far stronger."+ Environment.NewLine + Environment.NewLine +
                "The hexagram has a threefold meaning, expressing different aspects of the concept “holding firm.”  Heaven within the mountain gives the idea of holding firm in the sense of holding together; the trigram Kên which holds the trigram Ch’ien still, gives the idea of holding firm in the sense of holding back; the third idea is that of holding firm in the sense of caring for and nourishing.  This last is suggested by the fact that a strong line at the top, which is the ruler of the hexagram, is honored and tended as a sage.  The third of these meanings also attaches specifically to this strong line at the top, which represents the sage.";
            iChing[Hexagram].TheJudgment = "THE TAMING POWER OF THE GREAT."+ Environment.NewLine +
                "Perseverance furthers."+ Environment.NewLine +
                "Not eating at home brings good fortune."+ Environment.NewLine +
                "It furthers one to cross the great water.";
            iChing[Hexagram].Intro2 = "To hold firmly to great creative powers and store them up, as set forth in this hexagram, there is need of a strong, clear–headed man who is honored by the ruler.  The trigram Ch’ien points to strong creative power; Kên indicates firmness and truth.  Both point to light and clarity and to the daily renewal of character.  Only through such daily self–renewal can a man continue at the height of his powers.  Force of habit helps to keep order in quiet times; but in periods when there is a great storing up of energy, everything depends on the power of the personality.  However, since the worthy are honored, as in the case of the strong personality entrusted with leadership by the ruler, it is an advantage not to eat at home but rather to earn one’s bread by entering upon public office.  Such a man is in harmony with heaven; therefore even great and difficult undertakings, such as crossing the great water, succeed.";
            iChing[Hexagram].TheImage = "Heaven within the mountain:"+ Environment.NewLine +
                "The image of THE TAMING POWER OF THE GREAT."+ Environment.NewLine +
                "Thus the superior man acquaints himself with many sayings of antiquity"+ Environment.NewLine +
                "And many deeds of the past,"+ Environment.NewLine +
                "In order to strengthen his character thereby.";
            iChing[Hexagram].Intro3 = "Heaven within the mountain points to hidden treasures.  In the words and deeds of the past there lies hidden a treasure that men may use to strengthen and elevate their own characters.  The way to study the past is not to confine oneself to mere knowledge of history but, through application of this knowledge, to give actuality to the past.";
            iChing[Hexagram].Read1 = "Nine at the beginning means:"+ Environment.NewLine +
                "Danger is at hand.  It furthers one to desist.";
            iChing[Hexagram].Read2 = "Nine in the second place means:"+ Environment.NewLine +
                "The axletrees are taken from the wagon."+ Environment.NewLine + Environment.NewLine +
                "This line references the   third line in THE TAMING POWER OF THE SMALL  (9)";
            iChing[Hexagram].Read3 = "Nine in the third place means:"+ Environment.NewLine +
                "A good horse that follows others."+ Environment.NewLine +
                "Awareness of danger,"+ Environment.NewLine +
                "With perseverance, furthers."+ Environment.NewLine +
                "Practice chariot driving and armed defense daily."+ Environment.NewLine +
                "It furthers one to have somewhere to go.";
            iChing[Hexagram].Read4 = "Six in the fourth place means:"+ Environment.NewLine +
                "The headboard of a young bull."+ Environment.NewLine +
                "Great good fortune.";
            iChing[Hexagram].Read5 = "Six in the fifth place means:"+ Environment.NewLine +
                "The tusk of a gelded boar."+ Environment.NewLine +
                "Good fortune.";
            iChing[Hexagram].Read6 = "Nine at the top means:"+ Environment.NewLine +
                "One attains the way of heaven.  Success.";
            iChing[Hexagram].SquareCircle1 = "";
            iChing[Hexagram].SquareCircle2 = "";
            iChing[Hexagram].SquareCircle3 = "";
            iChing[Hexagram].SquareCircle4 = "";
            iChing[Hexagram].SquareCircle5 = "○";// ○ □
            iChing[Hexagram].SquareCircle6 = "○";
            iChing[Hexagram].Place1ChangesToNumber = 18;
            iChing[Hexagram].Place2ChangesToNumber = 22;
            iChing[Hexagram].Place3ChangesToNumber = 41;
            iChing[Hexagram].Place4ChangesToNumber = 14;
            iChing[Hexagram].Place5ChangesToNumber = 9;
            iChing[Hexagram].Place6ChangesToNumber = 11;
            
            
            Hexagram = 27;
            iChing[Hexagram].EngTitle = "Corners of the Mouth (Providing Nourishment)";
            iChing[Hexagram].ChiTitle = "I";
            iChing[Hexagram].Hex = "䷚";
            iChing[Hexagram].Code = new int[]{1,0,0,0,0,1};
            iChing[Hexagram].Above = "KÊN  /  KEEPING STILL, MOUNTAIN";
            iChing[Hexagram].Below = "CHÊN  /  THE AROUSING, THUNDER";
            iChing[Hexagram].AboveSymbol = "☶";
            iChing[Hexagram].BelowSymbol = "☳";
            iChing[Hexagram].Intro1 = "This hexagram is a picture of an open mouth; above and below are firm lines of the lips, and between them the opening.  Starting with the mouth, through which we take food for nourishment, the thought leads to nourishment itself.  Nourishment of oneself, specifically of the body, is represented in the three lower lines, while the three upper lines represent nourishment and care of others, in a higher, spiritual sense.";
            iChing[Hexagram].TheJudgment = "THE CORNERS OF THE MOUTH."+ Environment.NewLine +
                "Perseverance brings good fortune."+ Environment.NewLine +
                "Pay heed to the providing of nourishment"+ Environment.NewLine +
                "And to what a man seeks"+ Environment.NewLine +
                "To fill his own mouth with.";
            iChing[Hexagram].Intro2 = "In bestowing care and nourishment, it is important that the right people should be taken care of and that we should attend to our own nourishment in the right way.  If we wish to know what anyone is like, we have only to observe on whom he bestows his care and what sides of his own nature he cultivates and nourishes.  Nature nourishes all creatures.  The great man fosters and takes care of superior men, in order to take care of all men through them.  Mencius says about this: If we wish to know whether anyone is superior or not, we need only observe what part of his being he regards as especially important.  The body has superior and inferior, important and unimportant parts.  We must not injure important parts for the sake of the unimportant, nor must we injure the superior parts for the sake of the inferior.  He who cultivates the inferior parts of his nature is an inferior man.  He who cultivates the superior parts of his nature is a superior man.";
            iChing[Hexagram].TheImage = "At the foot of the mountain, thunder:"+ Environment.NewLine +
                "The image of PROVIDING NOURISHMENT."+ Environment.NewLine +
                "Thus the superior man is careful of his words"+ Environment.NewLine +
                "And temperate in eating and drinking.";
            iChing[Hexagram].Intro3 = "“God comes forth in the sign of the Arousing”: when in the spring the life forces stir again, all things comes into being anew.  “He brings to perfection in the sign of Keeping Still”: thus in the early spring, when the seeds fall to earth, all things are made ready.  This is an image of providing nourishment through movement and tranquillity.  The superior man takes it as a pattern for the nourishment and cultivation of his character.  Words are a movement going from within outward.  Eating and drinking are movements from without inward.  Both kinds of movement can be modified by tranquillity.  For tranquillity keeps the words that come out of the mouth from exceeding proper measure, and keeps the food that goes into the mouth from exceeding its proper measure.  Thus character is cultivated.";
            iChing[Hexagram].Read1 = "Nine at the beginning means:"+ Environment.NewLine +
                "You let your magic tortoise go,"+ Environment.NewLine +
                "And look at me with the corners of your mouth drooping."+ Environment.NewLine +
                "Misfortune.";
            iChing[Hexagram].Read2 = "Six in the second place means:"+ Environment.NewLine +
                "Turning to the summit for nourishment,"+ Environment.NewLine +
                "Deviating from the path"+ Environment.NewLine +
                "To seek nourishment from the hill."+ Environment.NewLine +
                "Continuing to do this brings misfortune.";
            iChing[Hexagram].Read3 = "Six in the third place means:"+ Environment.NewLine +
                "Turning away from nourishment."+ Environment.NewLine +
                "Perseverance brings misfortune."+ Environment.NewLine +
                "Do not act thus for ten years."+ Environment.NewLine +
                "Nothing serves to further.";
            iChing[Hexagram].Read4 = "Six in the fourth place means:"+ Environment.NewLine +
                "Turning to the summit"+ Environment.NewLine +
                "For provision of nourishment"+ Environment.NewLine +
                "Brings good fortune."+ Environment.NewLine +
                "Spying about with sharp eyes"+ Environment.NewLine +
                "Like a tiger with insatiable craving."+ Environment.NewLine +
                "No blame.";
            iChing[Hexagram].Read5 = "Six in the fifth place means:"+ Environment.NewLine +
                "Turning away from the path."+ Environment.NewLine +
                "To remain persevering brings good fortune."+ Environment.NewLine +
                "One should not cross the great water.";
            iChing[Hexagram].Read6 = "Nine at the top means:"+ Environment.NewLine +
                "The source of nourishment."+ Environment.NewLine +
                "Awareness of danger brings good fortune."+ Environment.NewLine +
                "It furthers one to cross the great water.";
            iChing[Hexagram].SquareCircle1 = "";
            iChing[Hexagram].SquareCircle2 = "";
            iChing[Hexagram].SquareCircle3 = "";
            iChing[Hexagram].SquareCircle4 = "";
            iChing[Hexagram].SquareCircle5 = "○";// ○ □
            iChing[Hexagram].SquareCircle6 = "○";
            iChing[Hexagram].Place1ChangesToNumber = 23;
            iChing[Hexagram].Place2ChangesToNumber = 41;
            iChing[Hexagram].Place3ChangesToNumber = 22;
            iChing[Hexagram].Place4ChangesToNumber = 21;
            iChing[Hexagram].Place5ChangesToNumber = 42;
            iChing[Hexagram].Place6ChangesToNumber = 24;
            
            
            Hexagram = 28;
            iChing[Hexagram].EngTitle = "Preponderance of the Great";
            iChing[Hexagram].ChiTitle = "Ta Kuo";
            iChing[Hexagram].Hex = "䷛";
            iChing[Hexagram].Code = new int[]{0,1,1,1,1,0};
            iChing[Hexagram].Above = "TUI  /  THE JOYOUS, LAKE ";
            iChing[Hexagram].Below = "SUN  /  THE GENTLE, WIND, WOOD";
            iChing[Hexagram].AboveSymbol = "☱";
            iChing[Hexagram].BelowSymbol = "☴";
            iChing[Hexagram].Intro1 = "This hexagram consists of four strong lines inside and two weak lines outside.  When the strong are outside and the weak inside, all is well and there is nothing out of balance, nothing extraordinary in the situation.  Here, however, the opposite is the case.  The hexagram represents a beam that is thick and heavy in the middle but too weak at the ends.  This is a condition that cannot last; it must be changed, must pass, or misfortune will result.";
            iChing[Hexagram].TheJudgment = "PREPONDERANCE OF THE GREAT."+ Environment.NewLine +
                "The ridgepole sags to the breaking point."+ Environment.NewLine +
                "It furthers one to have somewhere to go."+ Environment.NewLine +
                "Success.";
            iChing[Hexagram].Intro2 = "The weight of the great is excessive.  The load is too heavy for the strength of the supports.  The ridgepole on which the whole roof rests, sags to the breaking point, because its supporting ends are too weak for the load they bear.  It is an exceptional time and situation; therefore extraordinary measures are demanded.  It is necessary to find a way of transition as quickly as possible, and to take action.  This promises success.  For although the strong element is in excess, it is in the middle, that is, at the center of gravity, so that a revolution is not to be feared.  Nothing is to be achieved by forcible measures.  The problem must be solved by gentle penetration to the meaning of the situation (as is suggested by the attribute of the inner trigram, Sun); then the change–over to other conditions will be successful.  It demands real superiority; therefore the time when the great preponderates is a momentous time."; 
            iChing[Hexagram].TheImage = "The lake rises above the trees:"+ Environment.NewLine +
                "The image of PREPONDERANCE OF THE GREAT."+ Environment.NewLine +
                "Thus the superior man, when he stands alone,"+ Environment.NewLine +
                "Is unconcerned,"+ Environment.NewLine +
                "And if he has to renounce the world,"+ Environment.NewLine +
                "He is undaunted.";
            iChing[Hexagram].Intro3 = "Extraordinary times when the great preponderates are like floodtimes when the lake rises over the treetops.  But such conditions are temporary.  The two trigrams indicate the attitude proper to such exceptional times: the symbol of the trigram Sun is the tree, which stands firm even though it stands alone, and the attribute of Tui is joyousness, which remains undaunted even if it must renounce the world.";
            iChing[Hexagram].Read1 = "Six at the beginning means:"+ Environment.NewLine +
                "To spread white rushes underneath."+ Environment.NewLine +
                "No blame.";
            iChing[Hexagram].Read2 = "Nine in the second place means:"+ Environment.NewLine +
                "A dry poplar sprouts at the root."+ Environment.NewLine +
                "An older man takes a young wife."+ Environment.NewLine +
                "Everything furthers.";
            iChing[Hexagram].Read3 = "Nine in the third place means:"+ Environment.NewLine +
                "The ridgepole sags to the breaking point."+ Environment.NewLine +
                "Misfortune.";
            iChing[Hexagram].Read4 =
                "Nine in the fourth place means:"+ Environment.NewLine +
                "The ridgepole is braced. Good fortune."+ Environment.NewLine +
                "If there are ulterior motives, it is humiliating.";
            iChing[Hexagram].Read5 = "Nine in the fifth place means:"+ Environment.NewLine +
                "A withered poplar puts forth flowers."+ Environment.NewLine +
                "An older woman takes a husband."+ Environment.NewLine +
                "No blame.  No praise.";
            iChing[Hexagram].Read6 = "Six at the top means:"+ Environment.NewLine +
                "One must go through the water."+ Environment.NewLine +
                "It goes over one’s head."+ Environment.NewLine +
                "Misfortune.  No blame.";
            iChing[Hexagram].SquareCircle1 = "";
            iChing[Hexagram].SquareCircle2 = "○";
            iChing[Hexagram].SquareCircle3 = "";
            iChing[Hexagram].SquareCircle4 = "○";
            iChing[Hexagram].SquareCircle5 = "";// ○ □
            iChing[Hexagram].SquareCircle6 = "";
            iChing[Hexagram].Place1ChangesToNumber = 43;
            iChing[Hexagram].Place2ChangesToNumber = 31;
            iChing[Hexagram].Place3ChangesToNumber = 47;
            iChing[Hexagram].Place4ChangesToNumber = 48;
            iChing[Hexagram].Place5ChangesToNumber = 32;
            iChing[Hexagram].Place6ChangesToNumber = 44;
            
             
            Hexagram = 29;
            iChing[Hexagram].EngTitle = "The Abysmal (Water)";
            iChing[Hexagram].ChiTitle = "K’an";
            iChing[Hexagram].Hex = "䷜";
            iChing[Hexagram].Code = new int[]{0,1,0,0,1,0};
            iChing[Hexagram].Above = "K’AN  /  THE ABYSMAL, WATER";
            iChing[Hexagram].Below = "K’AN  /  THE ABYSMAL, WATER";
            iChing[Hexagram].AboveSymbol = "☵";
            iChing[Hexagram].BelowSymbol = "☵";
            iChing[Hexagram].Intro1 = "This hexagram consists of a doubling of the trigram K’an.  It is one of the eight hexagrams in which doubling occurs.  The trigram K’an means a plunging in.  A yang line has plunged in between two yin lines and is closed in by them like water in a ravine.  The trigram K’an is also the middle son.  The Receptive has obtained the middle line of the Creative, and thus K’an develops.  As an image it represents water, the water that comes from above and is in motion on earth in streams and rivers, giving rise to all life on earth."+ Environment.NewLine +Environment.NewLine +
                "In man’s world K’an represents the heart, the soul locked up within the body, the principle of light inclosed in the dark—that is, reason.  The name of the hexagram, because the trigram is doubled, has the additional meaning, “repetition of danger.”  Thus the hexagram is intended to designate an objective situation to which one must become accustomed, not a subjective attitude.  For danger due to a subjective attitude means either foolhardiness or guile.  Hence too a ravine is used to symbolize danger; it is a situation in which a man is in the same pass as the water in a ravine, and, like the water, he can escape if he behaves correctly.";
            iChing[Hexagram].TheJudgment = "The Abysmal repeated."+ Environment.NewLine +
                "If you are sincere, you have success in your heart,"+ Environment.NewLine +
                "And whatever you do succeeds.";
            iChing[Hexagram].Intro2 = "Through repetition of danger we grow accustomed to it.  Water sets the example for the right conduct under such circumstances.  It flows on and on, and merely fills up all the places through which it flows; it does not shrink from any dangerous spot nor from any plunge, and nothing can make it lose its own essential nature.  It remains true to itself under all conditions.  Thus likewise, if one is sincere when confronted with difficulties, the heart can penetrate the meaning of the situation.  And once we have gained inner mastery of a problem, it will come about naturally that the action we take will succeed.  In danger all that counts is really carrying out all that has to be done—thoroughness—and going forward, in order not to perish through tarrying in the danger."+ Environment.NewLine +Environment.NewLine +
                "Properly used, danger can have an important meaning as a protective measure.  Thus heaven has its perilous height protecting it against every attempt at invasion, and earth has its mountains and bodies of water, separating countries by their dangers.  Thus also rulers make use of danger to protect themselves against attacks from without and against turmoil within.";
            iChing[Hexagram].TheImage = "Water flows on uninterruptedly and reaches its goal:"+ Environment.NewLine +
                "The image of the Abysmal repeated."+ Environment.NewLine +
                "Thus the superior man walks in lasting virtue"+ Environment.NewLine +
                "And carries on the business of teaching.";
            iChing[Hexagram].Intro3 = "Water reaches its goal by flowing continually.  It fills up every depression before it flows on.  The superior man follows its example; he is concerned that goodness should be an established attribute of character rather than an accidental and isolated occurrence.  So likewise in teaching others everything depends on consistency, for it is only through repetition that the pupil makes the material his own.";
            iChing[Hexagram].Read1 = "Six at the beginning means:"+ Environment.NewLine +
                "Repetition of the Abysmal."+ Environment.NewLine +
                "In the abyss one falls into a pit."+ Environment.NewLine +
                "Misfortune.";
            iChing[Hexagram].Read2 = "Nine in the second place means:"+ Environment.NewLine +
                "The abyss is dangerous."+ Environment.NewLine +
                "One should strive to attain small things only.";
            iChing[Hexagram].Read3 = "Six in the third place means:"+ Environment.NewLine +
                "Forward and backward, abyss on abyss."+ Environment.NewLine +
                "In danger like this, pause at first and wait,"+ Environment.NewLine +
                "Otherwise you will fall into a pit in the abyss."+ Environment.NewLine +
                "Do not act this way.";
            iChing[Hexagram].Read4 = "Six in the fourth place means:"+ Environment.NewLine +
                "A jug of wine, a bowl of rice with it;"+ Environment.NewLine +
                "Earthen vessels"+ Environment.NewLine +
                "Simply handed in through the Window."+ Environment.NewLine +
                "There is certainly no blame in this.";
            iChing[Hexagram].Read5 = "Nine in the fifth place means:"+ Environment.NewLine +
                "The abyss is not filled to overflowing,"+ Environment.NewLine +
                "It is filled only to the rim."+ Environment.NewLine +
                "No blame.";
            iChing[Hexagram].Read6 = "Six at the top means:"+ Environment.NewLine +
                "Bound with cords and ropes,"+ Environment.NewLine +
                "Shut in between thorn–hedged prison walls:"+ Environment.NewLine +
                "For three years one does not find the way."+ Environment.NewLine +
                "Misfortune.";
            iChing[Hexagram].SquareCircle1 = "";
            iChing[Hexagram].SquareCircle2 = "○";
            iChing[Hexagram].SquareCircle3 = "";
            iChing[Hexagram].SquareCircle4 = "";
            iChing[Hexagram].SquareCircle5 = "○";// ○ □
            iChing[Hexagram].SquareCircle6 = "";
            iChing[Hexagram].Place1ChangesToNumber = 60;
            iChing[Hexagram].Place2ChangesToNumber = 8;
            iChing[Hexagram].Place3ChangesToNumber = 48;
            iChing[Hexagram].Place4ChangesToNumber = 47;
            iChing[Hexagram].Place5ChangesToNumber = 7;
            iChing[Hexagram].Place6ChangesToNumber = 59;
            
            
            Hexagram = 30;
            iChing[Hexagram].EngTitle = "The Clinging  (Fire)";
            iChing[Hexagram].ChiTitle = "Li";
            iChing[Hexagram].Hex = "䷝";
            iChing[Hexagram].Code = new int[]{1,0,1,1,0,1};
            iChing[Hexagram].Above = "LI  /  THE CLINGING, FIRE ";
            iChing[Hexagram].Below = "LI  /  THE CLINGING, FIRE ";
            iChing[Hexagram].AboveSymbol = "☲";
            iChing[Hexagram].BelowSymbol = "☲";
            iChing[Hexagram].Intro1 = "This hexagram is another double sign.  The trigram Li means “to cling to something,” and also “brightness.”  A dark line clings to two light lines, one above and one below—the image of an empty space between two strong lines, whereby the two strong lines are made bright.  The trigram represents the middle daughter.  The Creative has incorporated the central line of the Receptive, and thus Li develops.  As an image, it is fire.  Fire has no definite form but clings to the burning object and thus is bright.  As water pours down from heaven, so fire flames up from the earth.  While K’an means the soul shut within the body, Li stands for nature in its radiance.";
            iChing[Hexagram].TheJudgment = "THE CLINGING.  Perseverance furthers."+ Environment.NewLine +
                "It brings success."+ Environment.NewLine +
                "Care of the cow brings good fortune.";
            iChing[Hexagram].Intro2 = "What is dark clings to what is light and so enhances the brightness of the latter.  A luminous thing giving out light must have within itself something that perseveres; otherwise it will in time burn itself out.  Everything that gives light is dependent on something to which it clings, in order that it may continue to shine."+ Environment.NewLine +Environment.NewLine +
                "Thus the sun and moon cling to heaven, and grain, grass, and trees cling to the earth.  So too the twofold clarity of the dedicated man clings to what is right and thereby can shape the world.  Human life on earth is conditioned and unfree, and when man recognizes this limitation and makes himself dependent upon the harmonious and beneficent forces of the cosmos, he achieves success.  The cow is the symbol of extreme docility.  By cultivating in himself an attitude of compliance and voluntary dependence, man acquires clarity without sharpness and finds his place in the world.";
            iChing[Hexagram].TheImage = "That which is bright rises twice:"+ Environment.NewLine +
                "The image of FIRE."+ Environment.NewLine +
                "Thus the great man, by perpetuating this brightness,"+ Environment.NewLine +
                "Illumines the four quarters of the world.";
            iChing[Hexagram].Intro3 = "Each of the two trigrams represents the sun in the course of a day.  The two together represent the repeated movement of the sun, the function of light with respect to time.  The great man continues the work of nature in the human world.  Through the clarity of his nature he causes the light to spread farther and farther and to penetrate the nature of man ever more deeply.";
            iChing[Hexagram].Read1 = "Nine at the beginning means:"+ Environment.NewLine +
                "The footprints run crisscross."+ Environment.NewLine +
                "If one is seriously intent, no blame.";
            iChing[Hexagram].Read2 = "Six in the second place means:"+ Environment.NewLine +
                "Yellow light.  Supreme good fortune.";
            iChing[Hexagram].Read3 = "Nine in the third place means:"+ Environment.NewLine +
                "In the light of the setting sun,"+ Environment.NewLine +
                "Men either beat the pot and sing"+ Environment.NewLine +
                "Or loudly bewail the approach of old age."+ Environment.NewLine +
                "Misfortune.";
            iChing[Hexagram].Read4 = "Nine in the fourth place means:"+ Environment.NewLine +
                "Its coming is sudden;"+ Environment.NewLine +
                "It flames up, dies down, is thrown away.";
            iChing[Hexagram].Read5 = "Six in the fifth place means:"+ Environment.NewLine +
                "Tears in floods, sighing and lamenting."+ Environment.NewLine +
                "Good fortune.";
            iChing[Hexagram].Read6 = "The king used him to march forth and chastise."+ Environment.NewLine +
                "Then it is best to kill the leaders"+ Environment.NewLine +
                "And take captive the followers.  No blame.";
            iChing[Hexagram].SquareCircle1 = "";
            iChing[Hexagram].SquareCircle2 = "○";
            iChing[Hexagram].SquareCircle3 = "";
            iChing[Hexagram].SquareCircle4 = "";
            iChing[Hexagram].SquareCircle5 = "○";// ○ □
            iChing[Hexagram].SquareCircle6 = "";
            iChing[Hexagram].Place1ChangesToNumber = 56;
            iChing[Hexagram].Place2ChangesToNumber = 14;
            iChing[Hexagram].Place3ChangesToNumber = 21;
            iChing[Hexagram].Place4ChangesToNumber = 22;
            iChing[Hexagram].Place5ChangesToNumber = 13;
            iChing[Hexagram].Place6ChangesToNumber = 55;
            
            
            Hexagram = 31;
            iChing[Hexagram].EngTitle = "Influence (Wooing)";
            iChing[Hexagram].ChiTitle = "Hsien";
            iChing[Hexagram].Hex = "䷞";
            iChing[Hexagram].Code = new int[]{0,0,1,1,1,0};
            iChing[Hexagram].Above = "TUI  /  THE JOYOUS, LAKE ";
            iChing[Hexagram].Below = "KÊN  /  KEEPING STILL, MOUNTAIN";
            iChing[Hexagram].AboveSymbol = "☱";
            iChing[Hexagram].BelowSymbol = "☶";
            iChing[Hexagram].Intro1 = "The name of the hexagram means “universal,” “general,” and in a figurative sense “to influence,” “to stimulate.”  The upper trigram is Tui, the Joyous; the lower is Kên, Keeping Still.  By its persistent, quiet influence, the lower, rigid trigram stimulates the upper, weak trigram, which responds to this stimulation cheerfully and joyously.  Kên, the lower trigram, is the youngest son; the upper, Tui, is the youngest daughter.  Thus the universal mutual attraction between the sexes is represented.  In courtship, the masculine principle must seize the initiative and place itself below the feminine principle."+ Environment.NewLine +Environment.NewLine +
                "Just as the first part of book I begins with the hexagrams of heaven and earth, the foundations of all that exists, the second part begins with the hexagrams of courtship and marriage, the foundations of all social relationships.";
            iChing[Hexagram].TheJudgment = "Influence.  Success."+ Environment.NewLine +
                "Perseverance furthers."+ Environment.NewLine +
                "To take a maiden to wife brings good fortune.";
            iChing[Hexagram].Intro2 = "The weak element is above, the strong below; hence their powers attract each other, so that they unite.  This brings about success, for all success depends on the effect of mutual attraction.  By keeping still within while experiencing joy without, one can prevent the joy from going to excess and hold it within proper bounds.  This is the meaning of the added admonition, “Perseverance furthers,” for it is perseverance that makes the difference between seduction and courtship; in the latter the strong man takes a position inferior to that of the weak girl and shows consideration for her.  This attraction between affinities is a general law of nature.  Heaven and earth attract each other and thus all creatures come into being.  Through such attraction the sage influences men’s hearts, and thus the world attains peace.  From the attractions they exert we can learn the nature of all beings in heaven and on earth.";
            iChing[Hexagram].TheImage = "A lake on the mountain:"+ Environment.NewLine +
                "The image of influence"+ Environment.NewLine +
                "Thus the superior man encourages people to approach him"+ Environment.NewLine +
                "By his readiness to receive them.";
            iChing[Hexagram].Intro3 = "A mountain with a lake on its summit is stimulated by the moisture from the lake.  It has this advantage because its summit does not jut out as a peak but is sunken.  The image counsels that the mind should be kept humble and free, so that it may remain receptive to good advice.  People soon give up counseling a man who thinks that he knows everything better than anyone else.";
            iChing[Hexagram].Read1 = "Six at the beginning means:"+ Environment.NewLine +
                "The influence shows itself in the big toe.";
            iChing[Hexagram].Read2 = "Six in the second place means:"+ Environment.NewLine +
                "The influence shows itself in the calves of the legs."+ Environment.NewLine +
                "Misfortune."+ Environment.NewLine +
                "Tarrying brings good fortune.";
            iChing[Hexagram].Read3 = "Nine in the third place means:"+ Environment.NewLine +
                "The influence shows itself in the thighs."+ Environment.NewLine +
                "Holds to that which follows it."+ Environment.NewLine +
                "To continue is humiliating.";
            iChing[Hexagram].Read4 = "Nine in the fourth place means:"+ Environment.NewLine +
                "Perseverance brings good fortune."+ Environment.NewLine +
                "Remorse disappears."+ Environment.NewLine +
                "If a man is agitated in mind,"+ Environment.NewLine +
                "And his thoughts go hither and thither,"+ Environment.NewLine +
                "Only those friends"+ Environment.NewLine +
                "On whom he fixes his conscious thoughts"+ Environment.NewLine +
                "Will follow.";
            iChing[Hexagram].Read5 = "Nine in the fifth place means:"+ Environment.NewLine +
                "The influence shows itself in the back of the neck."+ Environment.NewLine +
                "No remorse.";
            iChing[Hexagram].Read6 = "Six at the top means:"+ Environment.NewLine +
                "The influence shows itself in the jaws, cheeks, and tongue.";
            iChing[Hexagram].SquareCircle1 = "";
            iChing[Hexagram].SquareCircle2 = "";
            iChing[Hexagram].SquareCircle3 = "";
            iChing[Hexagram].SquareCircle4 = "○";
            iChing[Hexagram].SquareCircle5 = "○";// ○ □
            iChing[Hexagram].SquareCircle6 = "";
            iChing[Hexagram].Place1ChangesToNumber = 49;
            iChing[Hexagram].Place2ChangesToNumber = 28;
            iChing[Hexagram].Place3ChangesToNumber = 45;
            iChing[Hexagram].Place4ChangesToNumber = 39;
            iChing[Hexagram].Place5ChangesToNumber = 62;
            iChing[Hexagram].Place6ChangesToNumber = 33;
            

            /*
             
            Hexagram = ;
            iChing[Hexagram].EngTitle = "";
            iChing[Hexagram].ChiTitle = "";
            iChing[Hexagram].Hex = "";
            iChing[Hexagram].Code = new int[]{};
            iChing[Hexagram].Above = "";
            iChing[Hexagram].Below = "";
            iChing[Hexagram].AboveSymbol = "";
            iChing[Hexagram].BelowSymbol = "";
            iChing[Hexagram].Intro1 =
            iChing[Hexagram].TheJudgment = 
            iChing[Hexagram].Intro2 = 
            iChing[Hexagram].TheImage = 
            iChing[Hexagram].Intro3 =
            iChing[Hexagram].Read1 = 
            iChing[Hexagram].Read2 = 
            iChing[Hexagram].Read3 =
            iChing[Hexagram].Read4 = 
            iChing[Hexagram].Read5 = 
            iChing[Hexagram].Read6 = 
            iChing[Hexagram].SquareCircle1 = "";
            iChing[Hexagram].SquareCircle2 = "";
            iChing[Hexagram].SquareCircle3 = "";
            iChing[Hexagram].SquareCircle4 = "";
            iChing[Hexagram].SquareCircle5 = "";// ○ □
            iChing[Hexagram].SquareCircle6 = "";
            iChing[Hexagram].Place1ChangesToNumber = ;
            iChing[Hexagram].Place2ChangesToNumber = ;
            iChing[Hexagram].Place3ChangesToNumber = ;
            iChing[Hexagram].Place4ChangesToNumber = ;
            iChing[Hexagram].Place5ChangesToNumber = ;
            iChing[Hexagram].Place6ChangesToNumber = ;
            
             */


            Hexagram = 43;
            iChing[Hexagram].EngTitle = "Break-Through (Resoluteness)";
            iChing[Hexagram].ChiTitle = "Kuai";
            iChing[Hexagram].Hex = "䷪";
            iChing[Hexagram].Code = new int[] { 1, 1, 1, 1, 1, 0 };
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
            iChing[Hexagram].SquareCircle5 = "○";// ○ □ ◻ 
            iChing[Hexagram].SquareCircle6 = "□";

            Random rand = new Random();
            int randInt = rand.Next(1, 29); 
            currentlyShowing = randInt;
            updateApplication();
 
        }


        


    }




    public class iChingNumber
    {
        public iChingNumber() { }

        public iChingNumber(string engTitle, string chiTitle, string hex, string above, string below,
            string aboveSymbol, string belowSymbol, string intro1, string theJudgment,
            string intro2, string theImage, string intro3, string read1, string read2,
            string read3, string read4, string read5, string read6, int place1ChangesToNumber,
            int place2ChangesToNumber, int place3ChangesToNumber, int place4ChangesToNumber,
            int place5ChangesToNumber, int place6ChangesToNumber, string place1ChangesToTitle,
            string place2ChangesToTitle, string place3ChangesToTitle, string place4ChangesToTitle,
            string place5ChangesToTitle, string place6ChangesToTitle, string squareCircle1,
            string squareCircle2, string squareCircle3, string squareCircle4, string squareCircle5,
            string squareCircle6, int[] code ) 
        {
            EngTitle = engTitle;
            ChiTitle = chiTitle;
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
        public string Hex { get; set; }
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
}
