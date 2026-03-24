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
using App.Core.Utilities;
using App.Core.Models;
using App.WindowsApp.Forms;


namespace App.WindowsApp.Views
{
    public partial class ProductsView : UserControl
    {
        IProductService _service;
        BindingSource _dgvbindingSource = new BindingSource();



        public ProductsView(IProductService _ser)
        {
            _service = _ser;
            InitializeComponent();
            dgvProducts.DataSource = _dgvbindingSource;
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tblFilter_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlProducts_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ProductsView_Load(object sender, EventArgs e)
        {
            cmbCategory.Items.Clear();
            cmbCategory.Items.Add("--All--");
            cmbCategory.Items.AddRange(Enum.GetNames(typeof(ProductsCategoryEnum)));
            cmbCategory.SelectedIndex = 0;

            cmbStockStatus.Items.Clear();
            cmbStockStatus.Items.Add("--All--");
            cmbStockStatus.Items.AddRange(Enum.GetNames(typeof(ProductStatusEnum)));
            cmbStockStatus.SelectedIndex = 0;

            if (_service == null)
                return;

            _service.GetAll();
            _dgvbindingSource.DataSource = _service.GetAll();
        }

        private void tsdAdd_Click(object sender, EventArgs e)
        {
           
            ProductForm productForm = new ProductForm(ProductFormModeEnum.Add, null );
            productForm.ShowDialog();

        }

        private void tsdEdit_Click(object sender, EventArgs e)
        {
            Product? selectedProduct = _dgvbindingSource.Current as Product;
            if(selectedProduct != null)
            {
                ProductForm productForm = new ProductForm(ProductFormModeEnum.Edit, selectedProduct);
                productForm.ShowDialog();

            }
            

        }

        private void tsdView_Click(object sender, EventArgs e)
        {
            Product? selectedProduct = _dgvbindingSource.Current as Product;
            if (selectedProduct != null)
            {
                ProductForm productForm = new ProductForm(ProductFormModeEnum.View, selectedProduct);
                productForm.ShowDialog();

            }
        }
    }
}
