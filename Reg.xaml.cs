using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Reg.xaml
    /// </summary>
    public partial class Reg : Window
    {
        AppContext db;
        public Reg()
        {
            InitializeComponent();
            db = new AppContext();
        }

        private void OpenRegW(object sender, RoutedEventArgs e)
        {
            
            MainWindow M = new MainWindow();
            M.Show();
            Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string login = LoginB.Text.Trim();
            string pass = PassB.Password.Trim();
            string pass2 = PassB.Password.Trim();
            string email = EmailB.Text.Trim().ToLower();
            
            if (login.Length<5)
            {
                LoginB.ToolTip = "Логин короче 5 символов";
                LoginB.Background = Brushes.MistyRose;
            }
            else if (pass.Length<8) 
            {
                PassB.ToolTip = "Пароль короче 8 символов";
                PassB.Background = Brushes.MistyRose;
            }
            else if (pass!=pass2)
            {
                PassB2.ToolTip = "Пароли не совпадают";
                PassB2.Background = Brushes.MistyRose;
            }
            else if (email.Length<5 || !email.Contains("@") || !email.Contains("."))
            {
                EmailB.ToolTip = "email введен некорректно";
                EmailB.Background = Brushes.MistyRose;
            }
            else
            {
                LoginB.ToolTip = "";
                LoginB.Background = Brushes.Transparent;
                PassB.ToolTip = "";
                PassB.Background = Brushes.Transparent;
                PassB2.ToolTip = "";
                PassB2.Background = Brushes.Transparent;
                EmailB.ToolTip = "";
                EmailB.Background = Brushes.Transparent;
            }

            User user = new User(login, pass, email);
            db.Users.Add(user);
            db.SaveChanges();

            Window1 w = new Window1();
            w.Show();
            Close();

        }
    }
}
