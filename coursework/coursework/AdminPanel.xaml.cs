using System.Linq;
using System.Windows;

namespace coursework
{
    /// <summary>
    /// Логика взаимодействия для AdminPanel.xaml
    /// </summary>
    public partial class AdminPanel : Window
    {
        public AdminPanel()
        {
            InitializeComponent();
            UserDG.ItemsSource = shopContext.GetContext().UsersVs.ToList();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new();
            this.Visibility = Visibility.Hidden;
            mainWindow.Show();
        }
    }
}
