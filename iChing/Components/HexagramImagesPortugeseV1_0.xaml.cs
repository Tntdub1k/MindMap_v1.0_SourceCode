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
    /// Interaction logic for HexagramImagesPortugeseV1_0.xaml

    /// </summary>
    public partial class HexagramImagesPortugeseV1_0 : UserControl
    {

        private int _currentlyShowing;
        public static string AssemblyDirectory
        {
            get
            {
                string codeBase = System.Reflection.Assembly.GetExecutingAssembly().CodeBase;
                UriBuilder uri = new UriBuilder(codeBase);
                string path = Uri.UnescapeDataString(uri.Path);
                return System.IO.Path.GetDirectoryName(path);
            }
        }


        public int currentlyShowing {
            get { return _currentlyShowing; }
            set {
                _currentlyShowing = value;
                updateControl();
            }
        }
    
        public void updateControl()
        {

            //this.image.Source =  new BitmapImage(new Uri(_currentlyShowing+".jpg", UriKind.Relative));
            BitmapImage img = (this.FindResource(_currentlyShowing.ToString()) as BitmapImage);
            this.image.Source = img;
            //this.UpdateLayout();

        }

        public HexagramImagesPortugeseV1_0()
        {
            InitializeComponent();
            this.image.Stretch = Stretch.Fill;
            this.image.StretchDirection = StretchDirection.Both;
        }
    }
}
