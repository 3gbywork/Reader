using CommonUtility.Command;
using System;
using System.Windows;
using System.Windows.Input;

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

            MenuItemCommand = new RelayCommand<string>((param) =>
            {
                if ("category" == param)
                    this.mainFrame.Navigate(new Uri("/Views/CategoryPage.xaml", UriKind.Relative));
                else if ("ranking" == param)
                    this.mainFrame.Navigate(new Uri(""));
            });

            this.DataContext = this;
        }

        public ICommand MenuItemCommand { get; set; }
    }
}
