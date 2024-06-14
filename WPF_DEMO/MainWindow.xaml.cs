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
using WPF_DEMO.DataAccess;

namespace WPF_DEMO
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private WpfproductContext context;
        public MainWindow()
        {
            context = new WpfproductContext();
            InitializeComponent();
            tbId.IsEnabled = false;
            LoadData();
        }

        private void LoadData()
        {
            lvData.ItemsSource = context.Products.ToList();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Product newProduct = GetProductInView(true);
                context.Products.Add(newProduct);
                context.SaveChanges();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private Product GetProductInView(bool isAdd = false)
        {
            Product product = new Product
            {
                Name = tbName.Text,
                Brand = tbBrand.Text,
                Prive = decimal.Parse(tbPrice.Text)
            };

            if (!isAdd)
            {
                product.Id = Int32.Parse(tbId.Text);
            }

            return product;
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Product productUpdate = GetProductInView(false);
                var oldProduct = context.Products.FirstOrDefault(x => x.Id == productUpdate.Id);
                if (oldProduct != null)
                {
                    oldProduct.Name = productUpdate.Name;
                    oldProduct.Brand = productUpdate.Brand;
                    oldProduct.Prive = productUpdate.Prive;
                    context.Products.Update(oldProduct);
                    context.SaveChanges();
                    LoadData();
                    return;
                }
                MessageBox.Show("product is not existed");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Product productUpdate = GetProductInView(false);
                var oldProduct = context.Products.FirstOrDefault(x => x.Id == productUpdate.Id);
                if (oldProduct != null)
                {
                    context.Products.Remove(oldProduct);
                    context.SaveChanges();
                    LoadData();
                    resetTextBox();
                    return;
                }
                MessageBox.Show("product is not existed");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void resetTextBox()
        {
            tbBrand.Text = "";
            tbId.Text = "";
            tbName.Text = "";
            tbPrice.Text = "";
        }
    }
}