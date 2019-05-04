using Reader.Model.Types;
using Reader.Source.Zhuishushenqi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reader.UI
{
    public partial class CategoryPage : UserControl
    {
        public CategoryPage()
        {
            InitializeComponent();

            this.Load += CategoryPage_Load;
        }

        private async void CategoryPage_Load(object sender, EventArgs e)
        {
            await InitAsync();

        }

        private async Task InitAsync()
        {
            var service = new CategoryService();
            Categories categories = await service.GetCategoriesAsync();

            if (!categories.OK)
                return;

            var male = new TabPage("男生");
            male.Controls.Add(CreateSubcategories(categories.Male));
            var female = new TabPage("女生");
            female.Controls.Add(CreateSubcategories(categories.Female));
            this.tabControl1.Controls.Clear();
            this.tabControl1.Controls.Add(male);
            this.tabControl1.Controls.Add(female);
        }

        private Control CreateSubcategories(IList<Category> categories)
        {
            var control = new ListBox();
            control.Items.AddRange(categories.Select(c => $"{c.Name}\r\n{c.BookCount}").ToArray());
            return control;
        }
    }
}
