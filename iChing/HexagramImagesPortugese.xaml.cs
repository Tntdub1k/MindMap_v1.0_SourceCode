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
    /// Interaction logic for HexagramImagesPortugese.xaml

     /// </summary>
    public partial class HexagramImagesPortugese : UserControl
    {
        private int _currentlyShowing;
        private string path = "Hexagram Images";
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

        public HexagramImagesPortugese()
        {
            InitializeComponent();
            this.image.Stretch = Stretch.Fill;
            this.image.StretchDirection = StretchDirection.Both;
        }
    }
}
