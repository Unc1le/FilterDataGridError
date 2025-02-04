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

namespace TestDataGrid
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            usersList.ItemsSource = GetTestData();
        }
        public List<TestData> GetTestData()
        {
            return new List<TestData>
            {
                new TestData { Id = 1, Name = "Item 1", Value = 100, Id1 = 3, Name1 = "[f[ff", Value1 = 400, Id2 = 3, Name2 = "[f[ff", Value2 = 400 },
                new TestData { Id = 2, Name = "Item 2", Value = 200, Id1 = 3, Name1 = "[f[ff", Value1 = 400, Id2 = 3, Name2 = "[f[ff", Value2 = 400  },
                 new TestData { Id = 3, Name = "Item 1", Value = 100, Id1 = 3, Name1 = "[f[ff", Value1 = 400, Id2 = 3, Name2 = "[f[ff", Value2 = 400  },
                new TestData { Id = 4, Name = "Item 2", Value = 200, Id1 = 3, Name1 = "[f[ff", Value1 = 400, Id2 = 3, Name2 = "[f[ff", Value2 = 400  },
                 new TestData {Id = 5, Name = "Item 1", Value = 100, Id1 = 3, Name1 = "[f[ff", Value1 = 400, Id2 = 3, Name2 = "[f[ff", Value2 = 400},
                new TestData { Id = 6, Name = "Item 2", Value = 200 },
                 new TestData {Id = 7, Name = "Item 1", Value = 100, Id1 = 3, Name1 = "[f[ff", Value1 = 400, Id2 = 3, Name2 = "[f[ff", Value2 = 400},
                new TestData { Id = 8, Name = "Item 2", Value = 200, Id1 = 3, Name1 = "[f[ff", Value1 = 400, Id2 = 3, Name2 = "[f[ff", Value2 = 400  },
                 new TestData {Id = 9, Name = "Item 1", Value = 100, Id1 = 3, Name1 = "[f[ff", Value1 = 400, Id2 = 3, Name2 = "[f[ff", Value2 = 400},
                new TestData { Id = 10, Name = "Item 2", Value = 200, Id1 = 3, Name1 = "[f[ff", Value1 = 400, Id2 = 3, Name2 = "[f[ff", Value2 = 400  },

            };
        }
    }
    public class TestData
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Value { get; set; }

        public int Id1 { get; set; }
        public string Name1 { get; set; }
        public double Value1 { get; set; }

        public int Id2 { get; set; }
        public string Name2 { get; set; }
        public double Value2 { get; set; }
    }
}