using Reader.Model.Types;
using Reader.Source.Zhuishushenqi.Services;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Reader.UI.WPF.Views
{
    /// <summary>
    /// CategoryPage.xaml 的交互逻辑
    /// </summary>
    public partial class CategoryPage : Page
    {
        public CategoryPage()
        {
            InitializeComponent();

            this.Loaded += CategoryPage_Loaded;
        }

        private async void CategoryPage_Loaded(object sender, RoutedEventArgs e)
        {
            var service = new CategoryService();
            Categories categories = await service.GetCategoriesAsync();
            var service2 = new SubcategoryService();
            Subcategories subcategories = await service2.GetSubcategoriesAsync();

            if (!categories.OK)
                return;

            var male = new TreeViewItem
            {
                Header = "男生"
            };
            AddSubitems(male, nameof(male), categories.Male, subcategories.Male);

            var female = new TreeViewItem
            {
                Header = "女生"
            };
            AddSubitems(female, nameof(female), categories.Female, subcategories.Female);

            var picture = new TreeViewItem
            {
                Header = "漫画"
            };
            AddSubitems(picture, nameof(picture), categories.Picture, subcategories.Picture);

            var press = new TreeViewItem
            {
                Header = "出版"
            };
            AddSubitems(press, nameof(press), categories.Press, subcategories.Press);

            this.category.Items.Add(male);
            this.category.Items.Add(female);
            this.category.Items.Add(picture);
            this.category.Items.Add(press);
        }

        private void AddSubitems(TreeViewItem parent, string gender, IList<Category> categories, IList<Subcategory> subcategories)
        {
            var keyValues = subcategories.ToDictionary(k => k.Major, v => v.Mins);
            foreach (var category in categories)
            {
                var treeViewItem = new TreeViewItem
                {
                    Header = $"{category.Name} ({category.BookCount})",
                };
                parent.Items.Add(treeViewItem);

                if (keyValues.TryGetValue(category.Name, out IList<string> value))
                {
                    foreach (var subCategory in value)
                    {
                        var subTreeViewItem = new TreeViewItem
                        {
                            Header = subCategory,
                            Tag = $"{gender}/{category.Name}/{subCategory}"
                        };
                        treeViewItem.Items.Add(subTreeViewItem);
                    }
                }
            }
        }

        private async void TreeView_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            if (sender is TreeView treeView)
            {
                if (treeView.SelectedItem is TreeViewItem item)
                {
                    if (null != item.Tag)
                    {
                        var cb = type.SelectedItem as ComboBoxItem;
                        if (cb == null)
                            return;
                        string[] args = item.Tag.ToString().Split('/');
                        string strType = cb.Tag.ToString();
                        var service = new BooksService();
                        BooksBrief books = await service.GetBooksBriefAsync(args[0], strType, args[1], args[2], 0, 20);
                        if (!books.OK)
                            return;
                        foreach (var book in books.Books)
                        {
                            var listItem = new ListBoxItem();
                            listItem.Content = book.Title;
                            listItem.Tag = book;
                            this.books.Items.Add(listItem);
                        }
                    }
                }
            }
        }

        private void Books_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {

        }
    }
}
