using System;
using System.Linq;
using System.Windows;

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
            OrderDG.ItemsSource = _context.OrdersVs.ToList();
        }

        private void UpdateProductDG()
        {
            ProductDG.ItemsSource = _context.ProductsVs.ToList();
        }

        private void ShowOtherWindow(Window window)
        {
            this.Visibility = Visibility.Hidden;
            window.Show();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            ShowOtherWindow(new MainWindow());
        }

        private void AddProduct_Click(object sender, RoutedEventArgs e)
        {
            ShowOtherWindow(new FormProduct());
        }

        private void DeleteProduct_Click(object sender, RoutedEventArgs e)
        {
            
            var productsForRemoving = ProductDG.SelectedItems.Cast<Product>().ToList();

            if (MessageBox.Show($"Вы точно хотите удалить {productsForRemoving.Count()} элементов?", "Внимание",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    _context.Products.RemoveRange(productsForRemoving);
                    _context.SaveChanges();
                    MessageBox.Show("Данные удалены!");
                    UpdateProductDG();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void Window_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if(Visibility == Visibility.Visible)
            {
                _context.ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                UpdateProductDG();
            }
        }

        
        private void btnUpdateProduct_Click(object sender, RoutedEventArgs e)
        {
            ShowOtherWindow(new FormProduct());
        }
    }
}
