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

namespace Snake.Windows
{
    public partial class ExitWindow : Window
    {
        public ExitWindow()
        {
            InitializeComponent();
        }

        #region MOUSE ENTER/LEAVE BUTTONS
        private void Yes_Button_MouseEnter(object sender, MouseEventArgs e)
        {
            Yes_Label.Visibility = Visibility.Collapsed;
            Yes_Image.Visibility = Visibility.Visible;
        }

        private void Yes_Button_MouseLeave(object sender, MouseEventArgs e)
        {
            Yes_Image.Visibility = Visibility.Collapsed;
            Yes_Label.Visibility = Visibility.Visible;
        }

        private void No_Button_MouseEnter(object sender, MouseEventArgs e)
        {
            No_Label.Visibility = Visibility.Collapsed;
            No_Image.Visibility = Visibility.Visible;
        }

        private void No_Button_MouseLeave(object sender, MouseEventArgs e)
        {
            No_Image.Visibility = Visibility.Collapsed;
            No_Label.Visibility = Visibility.Visible;
        }
        #endregion MOUSE ENTER/LEAVE BUTTONS

        #region BUTTONS CLICKS
        private void YesButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void NoButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        #endregion BUTTONS CLICKS
    }
}
