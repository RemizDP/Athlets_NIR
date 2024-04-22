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
using AthletsLibrary;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Search.xaml
    /// </summary>
    public partial class Search : Window
    {
        Window1 parent;
        public Search(Window1 p )
        {
            this.parent = p;
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AppContext db = new AppContext();
            List<Athlet> athlets = db.Athlets.ToList();

            var sorted = from a in athlets
                         orderby a.Age
                         select a;

            Lw1.ItemsSource = sorted;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            parent.Show();
            Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            AppContext db = new AppContext();
            List<Athlet> athlets = db.Athlets.ToList();

            var sorted = from a in athlets
                         orderby a.Tituls descending
                         select a;

            Lw1.ItemsSource = sorted;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            AppContext db = new AppContext();
            List<Athlet> athlets = db.Athlets.ToList();

            var sorted = from a in athlets
                         orderby a.Height descending
                         select a;

            Lw1.ItemsSource = sorted;
        }

        private void Lw1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
