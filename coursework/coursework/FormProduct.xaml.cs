using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Логика взаимодействия для FormProduct.xaml
    /// </summary>
    public partial class FormProduct : Window
    {
        private Product _currentProduct = new();

        //private shopContext _context;
        //private ProductsV _productsV = new ProductsV();
        //private Product _product = new Product();

        public FormProduct(/*Product selectedProduct shopContext context, object o, SellerPanel sellerPanel*/)
        {
            InitializeComponent();
            //if (selectedProduct != null)
            //    _currentProduct = selectedProduct;
            DataContext = _currentProduct;

            //long? pv = _productsV.IdProduct;
            //long p = _product.IdProduct;

            //if (_productsV.IdProduct == _product.IdProduct)
            //{
            //    _context = context;
            //    _product = (o as Button).DataContext as Product;
            //    tbNameProduct.Text = _product.NameProduct;
            //    tbIdUnitProduct.Text = Convert.ToString(_product.IdUnitProduct);
            //    tbPriceProduct.Text = _product.PriceProduct;
            //    tbQuantityProduct.Text = _product.QuantityProduct;
            //}

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
                shopContext.GetContext().Products.Add(_currentProduct);
            try
            {
                shopContext.GetContext().SaveChanges();
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
