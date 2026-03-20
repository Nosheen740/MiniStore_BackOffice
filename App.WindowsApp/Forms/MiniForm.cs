using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App.Core.Contracts;
using App.Core.Services;
using App.WindowsApp.Views;


namespace App.WindowsApp.Forms
{

    public partial class MiniForm : Form
    {
        private readonly Dictionary<Type, UserControl> _views = new Dictionary<Type, UserControl>();
        IProductService _productService = new InMemoryProductService();
        public MiniForm()
        {
            InitializeComponent();
        }
        //public abstract string getId();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ShowView(() => new DashboardView());
            /* this.pnlContent.Controls.Clear();
             this.pnlContent.Controls.Add(new DashboradView());*/
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            ShowView(() => new ProductsView(_productService));
            //SetActiveNavButton(btnProducts);
            //this.pnlContent.Controls.Clear();
            //this.pnlContent.Controls.Add(new ProductsView());
            //ShowView(() => new ProductsView (_ProductService) )
        }

        private void ShowView<T>(Func<T> factory) where T : UserControl
        {
            //var key = typeof(DashboardView);
            var key = typeof(T);

            if (!_views.TryGetValue(key, out var view))
            {
                view = factory();
                view.Dock = DockStyle.Fill;
                _views[key] = view;
                /*  var view = new T();*/

            }

            if (!pnlContent.Controls.Contains(view))
            {
                pnlContent.Controls.Clear();
                pnlContent.Controls.Add(view);
            }

            view.BringToFront();


        }

        private void pnlContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MiniForm_Load(object sender, EventArgs e)
        {

        }
    }
}
