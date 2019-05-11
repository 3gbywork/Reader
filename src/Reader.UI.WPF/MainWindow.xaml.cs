using Reader.Model.Types;
using Reader.Source.Zhuishushenqi.Services;
using System.Windows;

namespace Reader.UI.WPF
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.Loaded += MainWindow_Loaded;
        }

        private async void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            var service = new CategoryService();
            Categories categories = await service.GetCategoriesAsync();

            if (!categories.OK)
                return;
        }
    }
}
