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
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox1.Text = "Nine at the beginning means:\nHidden Dragon. Do not act.";
            TextBox2.Text = "Nine in the second place means:\nDragon appearing in the field.\nIt furthers one to see the great man.";
        }



        private void TextBox1_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Comments.Text = "Comments Text Add";
        }



        private void Yin_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            Line5.Fill = (Brush)FindResource("Yang");
            Line4.Fill = (Brush)FindResource("Yang");
        }

    }
}
