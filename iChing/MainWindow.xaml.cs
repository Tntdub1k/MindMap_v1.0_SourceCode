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
    
        public MainWindow()
        {

            InitializeComponent();
#warning Does initializecomponent wait for all the objects to be loaded/created before going on? Should maybe add a different thread and some kind of progress bar/wait until components are loaded before continuing.


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

        private void Window_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {

        }
    } }

