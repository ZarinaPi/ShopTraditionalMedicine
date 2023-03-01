using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Input;

namespace coursework
{
    /// <summary>
    /// Логика взаимодействия для FormProduct.xaml
    /// </summary>
    public partial class FormProduct : Window
    {
        private Product _currentProduct = new();
        shopContext _context = new();
        public FormProduct()
        {
            InitializeComponent();
            DataContext = _currentProduct;

        }


        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new();

            if (string.IsNullOrWhiteSpace(_currentProduct.NameProduct))
                errors.AppendLine("Укажите название продукта");
            if (string.IsNullOrWhiteSpace(_currentProduct.QuantityProduct))
                errors.AppendLine("Укажите количество продукта");
            if (_currentProduct.IdUnitProduct is < 1 or > 3)
                errors.AppendLine("Укажите число от 1 до 3");
            if (string.IsNullOrWhiteSpace(_currentProduct.PriceProduct))
                errors.AppendLine("Укажите цену за ед. товара");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            if (_currentProduct.IdProduct == 0)
                _context.Products.Add(_currentProduct);
            try
            {
                _context.SaveChanges();
                MessageBox.Show("Информация сохранена!");
                SellerPanel sellerPanel = new();
                Visibility = Visibility.Hidden;
                sellerPanel.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void tbIdUnitProduct_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-3]+").IsMatch(e.Text);
        }
    }
}
