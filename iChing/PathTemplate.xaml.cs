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
    /// Interaction logic for PathTemplate.xaml
    /// </summary>
    public partial class PathTemplate : UserControl
    {
        public bool disabled = false;
        public PathTemplate()
        {
            InitializeComponent();
        }

        private void StackPanel_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {

        }
        
    }
}
