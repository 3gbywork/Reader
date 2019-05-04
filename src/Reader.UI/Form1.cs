using System;
using System.Windows.Forms;

namespace Reader.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Load += Form1_LoadAsync;
        }

        private void Form1_LoadAsync(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(new CategoryPage());
        }
    }
}
