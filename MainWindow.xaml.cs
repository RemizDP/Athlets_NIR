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

namespace WpfApp1
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

        private void OpenRegW(object sender, RoutedEventArgs e)
        {
            
            Reg R = new Reg();
            R.Show();
            Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string login = LoginB.Text.Trim();
            string pass = PassB.Password.Trim();
            

            if (login.Length < 5)
            {
                LoginB.ToolTip = "Логин короче 5 символов";
                LoginB.Background = Brushes.MistyRose;
            }
            else if (pass.Length < 8)
            {
                PassB.ToolTip = "Пароль короче 8 символов";
                PassB.Background = Brushes.MistyRose;
            }
            
            else
            {
                LoginB.ToolTip = "";
                LoginB.Background = Brushes.Transparent;
                PassB.ToolTip = "";
                PassB.Background = Brushes.Transparent;

                User authUser = null;
                using (AppContext db = new AppContext())
                {
                    authUser = db.Users.Where(b => b.Login == login && b.Password == pass).FirstOrDefault();
                }

                if (authUser != null) {
                    Window1 w = new Window1();
                    w.Show();
                    Close();
                }
                else
                    MessageBox.Show("Пользователь не найден");
                
            }


            
        }
    }
}
