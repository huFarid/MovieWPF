using Microsoft.Win32;
using MovieWPF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
        private Movie_DBEntities dataBase = new Movie_DBEntities();
        
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
            
            movies.CreateDate = DateTime.Now;
            dataBase.Movies.Add(movies);
            dataBase.SaveChanges();
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            CboDirector.ItemsSource = dataBase.Directors.ToList();
            CboDirector.SelectedIndex = 0;

        }

        private void BtnPoster_Click(object sender, RoutedEventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Select an Image",
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif",
                Multiselect = false 
            };

            if (openFileDialog.ShowDialog() == true) { 
             string filePath = openFileDialog.FileName;

                try
                {
                    ImgPoster.Source = new BitmapImage(new Uri(filePath));
                }
                catch (Exception exception)
                {
                    MessageBox.Show($"{exception.Message}", "Error",MessageBoxButton.OK, MessageBoxImage.Error);
                }

            }


            

        }
    }
}
