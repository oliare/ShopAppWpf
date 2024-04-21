using System.Windows;

namespace ShopAppWpf
{

    public partial class MainWindow : Window
    {
        private ShopDb db;

        public MainWindow()
        {
            InitializeComponent();
            db = new ShopDb();
        }

        private void viewShopsBtn_Click(object sender, RoutedEventArgs e)
        {
            grid.ItemsSource = db.Shops.ToList();
        }
        private void viewWorkersBtn_Click(object sender, RoutedEventArgs e)
        {
            grid.ItemsSource = db.Workers.ToList();
        }
        private void viewProductsBtn_Click(object sender, RoutedEventArgs e)
        {
            grid.ItemsSource = db.Products.ToList();
        }
    }
}