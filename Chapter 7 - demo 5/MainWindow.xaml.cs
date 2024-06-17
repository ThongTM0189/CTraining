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
            new Category{Id = 1, Name = "Cate 1"},
            new Category{Id = 2, Name = "Cate 2"},
            new Category{Id = 3, Name = "Cate 3"},
            new Category{Id = 4, Name = "Cate 4"},
        };
        public MainWindow()
        {
            InitializeComponent();
            //tbID.IsEnabled = false;
            loadData();
        }

        private void loadData()
        {
            dbCategory.ItemsSource = null;
            dbCategory.ItemsSource = categories;
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (!Int32.TryParse(tbID.Text, out int id))
            {
                MessageBox.Show("ID must input number");
                return;
            }

            Category cate = categories.FirstOrDefault(x => x.Id == id);
            if (cate == null)
            {
                MessageBox.Show("ID was not existed");
                return;
            }

            categories.Remove(cate);
            loadData();
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            string name = tbName.Text;
            if (!Int32.TryParse(tbID.Text, out int id))
            {
                MessageBox.Show("ID must input number");
                return;
            }

            Category cate = categories.FirstOrDefault(x => x.Id == id);
            cate.Name = name;
            categories.ForEach(x =>
            {
                if(x.Id == id)
                {
                    x.Name = name;
                    return;
                }
            });
            loadData();
        }
    }
}