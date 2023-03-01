using System;
using System.Linq;
using System.Windows;

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
                    Window panel = auth.Role == "администратор" ? (Window)new AdminPanel() : new SellerPanel();
                    this.Visibility = Visibility.Hidden;
                    panel.Show();
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
