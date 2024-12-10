using MovieWPF.Models;
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

namespace MovieWPF.View
{
    /// <summary>
    /// Interaction logic for vwMovieAddOrEdit.xaml
    /// </summary>
    public partial class vwMovieAddOrEdit : Window
    {

        public Movies movies = new Movies();
        public vwMovieAddOrEdit()
        {
            InitializeComponent();
            this.DataContext = movies;
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();

        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
