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

namespace MovieWPF.UserControls
{
    /// <summary>
    /// Interaction logic for UcImageWithBorder.xaml
    /// </summary>
    public partial class UcImageWithBorder : UserControl
    {

        #region Dependency Properties


        public ImageSource Source
        {
            get { return (ImageSource)GetValue(ImageSourceProperty); }
            set { SetValue(ImageSourceProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Source.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ImageSourceProperty =
            DependencyProperty.Register("Source", typeof(ImageSource), typeof(UcImageWithBorder), new PropertyMetadata(null));





        public object value
        {
            get { return (object)GetValue(valueProperty); }
            set { SetValue(valueProperty, value); }
        }

        // Using a DependencyProperty as the backing store for value.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty valueProperty =
            DependencyProperty.Register("value", typeof(object), typeof(UcImageWithBorder), new PropertyMetadata(null));



        #endregion
        public UcImageWithBorder()
        {
            InitializeComponent();
            this.DataContext = this;
        }
    }
}
