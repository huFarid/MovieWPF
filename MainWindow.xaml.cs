using MovieWPF.UserControls;
using MovieWPF.View;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading;
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
using WPFCustomMessageBox;

namespace MovieWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
            Thread.Sleep(1000);

            foreach (UIElement child in SpMovieList.Children)
            {
                child.MouseDown += Child_MouseDown;
                child.MouseWheel += Child_MouseWheel;
                
                
            }
        }

        private void Child_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            if (e.Delta > 0)
            {
                scrollViewrMovieList.LineLeft();

            }
            else
            {
                scrollViewrMovieList.LineRight();

            }                
        }

        private void Child_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var uc = (UserControl)sender;
            
            if (uc.Content is Border border)
            {
                MessageBox.Show($"{border.Tag}");

            }

           
        }

        private void RecTop_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            { this.DragMove(); }

            if (e.MiddleButton == MouseButtonState.Pressed)
            {
                this.WindowState = this.WindowState == WindowState.Maximized
                                      ? WindowState.Normal 
                                      : WindowState.Maximized;
            }
        }

        private void BtnMinimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;

        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();

        }

        private void BtnMoveLeft_Click(object sender, RoutedEventArgs e)
        {
            var scrollAmount = 100;
            scrollViewrMovieList.ScrollToHorizontalOffset(scrollViewrMovieList.HorizontalOffset-scrollAmount);   
        }

        private void BtnMoveRight_Click(object sender, RoutedEventArgs e)
        {
            var scrollAmount = 100;
            scrollViewrMovieList.ScrollToHorizontalOffset(scrollViewrMovieList.HorizontalOffset + scrollAmount);

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void btnRemoveMovie_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnAddMovie_Click(object sender, RoutedEventArgs e)
        {
            var vw = new vwMovieAddOrEdit()
            {
                Owner = this,

            };
            vw.ShowDialog();
        }

        //private void btnUpdateWidth_Click(object sender, RoutedEventArgs e)
        //{
        //    BindingExpression changeWidth = tbxWidth.GetBindingExpression(TextBox.TextProperty);
        //    changeWidth.UpdateSource();
        //}
    }
}
