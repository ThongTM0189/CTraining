using PE.DataAccess;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PE
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        WpfproductContext wpfproductContext;
        public MainWindow()
        {
            wpfproductContext = new WpfproductContext();
            InitializeComponent();
            loadData(wpfproductContext.Products.ToList());
        }

        void loadData(List<Product> list)
        {
            lvData.ItemsSource = null;
            lvData.ItemsSource = list;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (!Decimal.TryParse(tbPrice.Text, out decimal price))
                    throw new Exception("Price is not correct format");
                
                Product product = new Product()
                {
                    Name = tbName.Text,
                    Brand = tbBrand.Text,
                    Prive = price
                };

                wpfproductContext.Products.Add(product);
                wpfproductContext.SaveChanges();
                loadData(wpfproductContext.Products.ToList());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ADD event");
            }
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (!Int32.TryParse(tbId.Text, out int id))
                    throw new Exception("ID is not correct format");

                var pro = searchByid(id);

                if (!Decimal.TryParse(tbPrice.Text, out decimal price))
                    throw new Exception("Price is not correct format");

                pro.Name = tbName.Text;
                pro.Prive = price;
                pro.Brand = tbBrand.Text;

                wpfproductContext.Products.Update(pro);
                wpfproductContext.SaveChanges();
                loadData(wpfproductContext.Products.ToList());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update event");
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (!Int32.TryParse(tbId.Text, out int id))
                    throw new Exception("ID is not correct format");

                var pro = searchByid(id);
                MessageBoxResult result = MessageBox.Show($"Do you wannt delete {pro.Name}", "Delete Comfirm", MessageBoxButton.YesNo, MessageBoxImage.Question);

                if (result == MessageBoxResult.No) return;

                wpfproductContext.Products.Remove(pro);
                wpfproductContext.SaveChanges();
                loadData(wpfproductContext.Products.ToList());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete event");
            }
        }

        Product searchByid(int id)
        {
            var pro = wpfproductContext.Products.FirstOrDefault(x => x.Id == id);
            if (pro == null) throw new Exception("Product is not existed");
            return pro;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string search = tbSearch.Text.ToLower();
            var listSearch = wpfproductContext.Products.Where(x => x.Name.ToLower().Contains(search)).ToList();
            loadData(listSearch);
        }

        private void btnFilterPrice_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (!Decimal.TryParse(tbPriceStart.Text, out decimal priceStart) || 
                    !Decimal.TryParse(tbPriceEnd.Text, out decimal priceEnd))
                    throw new Exception("Price is not correct format");

                var list = wpfproductContext.Products.Where(x => x.Prive > priceStart && x.Prive < priceEnd).ToList();
                loadData(list);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Filter event");
            }
        }
    }
}