using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        //AppContext db;
        
        public Window1()
        {
            InitializeComponent();

            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AppContext db = new AppContext();
            List<User> users = db.Users.ToList();
            Lw1.ItemsSource = users;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AppContext db = new AppContext();
            List<Athlet> athlets = db.Athlets.ToList();
            Lw1.ItemsSource = athlets;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Search s = new Search(this);
            s.Show();
            Hide();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            Close();
        }
    }
}
