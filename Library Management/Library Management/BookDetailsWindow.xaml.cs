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
using System.Windows.Shapes;

namespace Library_Management
{
    /// <summary>
    /// Interaction logic for BookDetailsWindow.xaml
    /// </summary>
    public partial class BookDetailsWindow : Window
    {
        public BookDetailsWindow()
        {
            InitializeComponent();
            this.Loaded += BookDetailsWindow_Loaded;
        }

        private void BookDetailsWindow_Loaded(object sender, RoutedEventArgs e)
        {
            // Set the window size dynamically after it loads
            this.Width = 500;  
            this.Height =375; 

            // Optionally, center the window on the screen
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }
    }
}
