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

namespace Chapter_7___demo_5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static List<Category> categories = new List<Category>
        {
            new Category{Id = 1, Name = "code 1"},
            new Category{Id = 2, Name = "c++ 2"},
            new Category{Id = 3, Name = "Java 3"},
            new Category{Id = 4, Name = "JavaScript 4"},
        };

        public MainWindow()
        {
            InitializeComponent();
            loadData();
        }

        private void loadData(List<Category> data = null)
        {
            dbCategory.ItemsSource = null;
            if(data == null)
            {
                dbCategory.ItemsSource = categories; // tương đương với dataContext
            }
            else
            {
                dbCategory.ItemsSource = data;
            }
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string name = tbName.Text;
                if (!Int32.TryParse(tbID.Text, out int id)) throw new Exception("ID must input number");

                bool check = categories.FirstOrDefault(x => x.Id == id) != null;
                if (check) throw new Exception("ID was existed");

                categories.Add(new Category { Id = id, Name = name });
                loadData();
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
                if (!Int32.TryParse(tbID.Text, out int id)) throw new Exception("ID must input number");

                var cate = categories.FirstOrDefault(x => x.Id == id);
                if (cate == null) throw new Exception("ID was not existed");

                categories.Remove(cate);
                loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string name = tbName.Text;
                if (!Int32.TryParse(tbID.Text, out int id)) throw new Exception("ID must input number");

                var check = categories.FirstOrDefault(x => x.Id == id) == null;
                if (check) throw new Exception("ID was not existed");

                categories.ForEach(x =>
                {
                    if (x.Id == id)
                    {
                        x.Name = name;
                        return;
                    }
                });
                loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tbID_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("ban da click vao button");
        }

        private void tbSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            string txtSearch = tbSearch.Text.ToLower();
            List<Category> searchCategory = new List<Category>();
            searchCategory = categories.Where(cate => cate.Name.ToLower().Contains(txtSearch)).ToList();
            loadData(searchCategory);
        }
    }
}