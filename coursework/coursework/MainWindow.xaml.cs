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

namespace coursework
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

        private void btnSignIn_Click(object sender, RoutedEventArgs e)
        {
            string login = tbLogin.Text;
            string pass = pbPassword.Password;

            var auth = shopContext.GetContext().Authorizations.Where(x => x.Login == login && x.Password == pass).FirstOrDefault();

            if(tbLogin.Text == "" || pbPassword.Password == "")
            {
                MessageBox.Show("Вы не ввели логин или пароль!");
            }
            else
            {
                if (auth != null)
                {
                    if (auth.Role == "администратор")
                    {
                        AdminPanel adminPanel = new();
                        this.Visibility = Visibility.Hidden;
                        adminPanel.Show();
                    }
                    else if (auth.Role == "продавец")
                    {
                        SellerPanel sellerPanel = new();
                        this.Visibility = Visibility.Hidden;
                        sellerPanel.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Вы ввели не правильно логин или пароль!");
                }
            } 
        }

        public static implicit operator MainWindow(SellerPanel v)
        {
            throw new NotImplementedException();
        }
    }
}
