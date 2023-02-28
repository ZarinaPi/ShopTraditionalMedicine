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

namespace coursework
{
    /// <summary>
    /// Логика взаимодействия для SellerPanel.xaml
    /// </summary>
    public partial class SellerPanel : Window
    {
        public shopContext _context = new shopContext();


        public SellerPanel()
        {
            InitializeComponent();
            OrderDG.ItemsSource = shopContext.GetContext().OrdersVs.ToList();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new();
            this.Visibility = Visibility.Hidden;
            mainWindow.Show();
        }

        private void AddProduct_Click(object sender, RoutedEventArgs e)
        {
            //FormProduct formProduct = new(null);
            FormProduct formProduct = new();
            this.Visibility = Visibility.Hidden;
            formProduct.Show();
        }

        private void DeleteProduct_Click(object sender, RoutedEventArgs e)
        {
            
            var productsForRemoving = ProductDG.SelectedItems.Cast<Product>().ToList();

            if (MessageBox.Show($"Вы точно хотите удалить {productsForRemoving.Count()} элементов?", "Внимание",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes);
            try
            {
                shopContext.GetContext().Products.RemoveRange(productsForRemoving);
                shopContext.GetContext().SaveChanges();
                MessageBox.Show("Данные удалены!");

                ProductDG.ItemsSource = shopContext.GetContext().ProductsVs.ToList();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void ReadProduct_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Window_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if(Visibility == Visibility.Visible)
            {
                shopContext.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                ProductDG.ItemsSource = shopContext.GetContext().ProductsVs.ToList();
            }
        }

        
        private void btnUpdateProduct_Click(object sender, RoutedEventArgs e)
        {

            //FormProduct formProduct = new((sender as Button).DataContext as Product);
            FormProduct formProduct = new();
            //formProduct.ShowDialog();
            this.Visibility = Visibility.Hidden;
            formProduct.Show();
        }
    }
}
