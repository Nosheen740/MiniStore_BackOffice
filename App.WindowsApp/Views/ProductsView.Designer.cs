namespace App.WindowsApp.Views
{
    partial class ProductsView : UserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsView));
            tblProducts = new TableLayoutPanel();
            pnlProducts = new Panel();
            tsProducts = new ToolStrip();
            tsdAdd = new ToolStripButton();
            tsdEdit = new ToolStripButton();
            tsdView = new ToolStripButton();
            tsdDelete = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tsdRefresh = new ToolStripButton();
            pnlFilters = new Panel();
            tblFilter = new TableLayoutPanel();
            lblStockStatus = new Label();
            lblCategory = new Label();
            txtSearch = new TextBox();
            cmbStockStatus = new ComboBox();
            cmbCategory = new ComboBox();
            lblSearch = new Label();
            pnlGrid = new Panel();
            dgvProducts = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colCategory = new DataGridViewTextBoxColumn();
            colPrice = new DataGridViewTextBoxColumn();
            colStock = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            tblProducts.SuspendLayout();
            pnlProducts.SuspendLayout();
            tsProducts.SuspendLayout();
            pnlFilters.SuspendLayout();
            tblFilter.SuspendLayout();
            pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // tblProducts
            // 
            tblProducts.ColumnCount = 1;
            tblProducts.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblProducts.Controls.Add(pnlProducts, 0, 0);
            tblProducts.Controls.Add(pnlFilters, 0, 1);
            tblProducts.Controls.Add(pnlGrid, 0, 2);
            tblProducts.Dock = DockStyle.Fill;
            tblProducts.Location = new Point(0, 0);
            tblProducts.Margin = new Padding(4, 3, 4, 3);
            tblProducts.Name = "tblProducts";
            tblProducts.Padding = new Padding(19, 18, 19, 18);
            tblProducts.RowCount = 3;
            tblProducts.RowStyles.Add(new RowStyle(SizeType.Absolute, 65F));
            tblProducts.RowStyles.Add(new RowStyle(SizeType.Absolute, 97F));
            tblProducts.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblProducts.Size = new Size(642, 400);
            tblProducts.TabIndex = 0;
            tblProducts.Paint += tableLayoutPanel1_Paint;
            // 
            // pnlProducts
            // 
            pnlProducts.BackColor = Color.White;
            pnlProducts.Controls.Add(tsProducts);
            pnlProducts.Dock = DockStyle.Fill;
            pnlProducts.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pnlProducts.Location = new Point(23, 21);
            pnlProducts.Margin = new Padding(4, 3, 4, 3);
            pnlProducts.Name = "pnlProducts";
            pnlProducts.Size = new Size(596, 59);
            pnlProducts.TabIndex = 0;
            pnlProducts.Paint += pnlProducts_Paint;
            // 
            // tsProducts
            // 
            tsProducts.Dock = DockStyle.Fill;
            tsProducts.Items.AddRange(new ToolStripItem[] { tsdAdd, tsdEdit, tsdView, tsdDelete, toolStripSeparator1, tsdRefresh });
            tsProducts.Location = new Point(0, 0);
            tsProducts.Name = "tsProducts";
            tsProducts.Size = new Size(596, 59);
            tsProducts.TabIndex = 0;
            tsProducts.Text = "toolStrip1";
            tsProducts.ItemClicked += toolStrip1_ItemClicked;
            // 
            // tsdAdd
            // 
            tsdAdd.Image = (Image)resources.GetObject("tsdAdd.Image");
            tsdAdd.ImageTransparentColor = Color.Magenta;
            tsdAdd.Name = "tsdAdd";
            tsdAdd.Size = new Size(49, 56);
            tsdAdd.Text = "Add";
            tsdAdd.Click += tsdAdd_Click;
            // 
            // tsdEdit
            // 
            tsdEdit.Image = (Image)resources.GetObject("tsdEdit.Image");
            tsdEdit.ImageTransparentColor = Color.Magenta;
            tsdEdit.Name = "tsdEdit";
            tsdEdit.Size = new Size(47, 56);
            tsdEdit.Text = "Edit";
            tsdEdit.Click += tsdEdit_Click;
            // 
            // tsdView
            // 
            tsdView.Image = (Image)resources.GetObject("tsdView.Image");
            tsdView.ImageTransparentColor = Color.Magenta;
            tsdView.Name = "tsdView";
            tsdView.Size = new Size(52, 56);
            tsdView.Text = "View";
            tsdView.Click += tsdView_Click;
            // 
            // tsdDelete
            // 
            tsdDelete.Image = (Image)resources.GetObject("tsdDelete.Image");
            tsdDelete.ImageTransparentColor = Color.Magenta;
            tsdDelete.Name = "tsdDelete";
            tsdDelete.Size = new Size(60, 56);
            tsdDelete.Text = "Delete";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 59);
            // 
            // tsdRefresh
            // 
            tsdRefresh.Image = (Image)resources.GetObject("tsdRefresh.Image");
            tsdRefresh.ImageTransparentColor = Color.Magenta;
            tsdRefresh.Name = "tsdRefresh";
            tsdRefresh.Size = new Size(66, 56);
            tsdRefresh.Text = "Refresh";
            // 
            // pnlFilters
            // 
            pnlFilters.Controls.Add(tblFilter);
            pnlFilters.Location = new Point(23, 86);
            pnlFilters.Margin = new Padding(4, 3, 4, 3);
            pnlFilters.Name = "pnlFilters";
            pnlFilters.Padding = new Padding(14, 12, 14, 12);
            pnlFilters.Size = new Size(596, 90);
            pnlFilters.TabIndex = 1;
            // 
            // tblFilter
            // 
            tblFilter.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tblFilter.BackColor = Color.White;
            tblFilter.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tblFilter.ColumnCount = 3;
            tblFilter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tblFilter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tblFilter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tblFilter.Controls.Add(lblStockStatus, 2, 0);
            tblFilter.Controls.Add(lblCategory, 1, 0);
            tblFilter.Controls.Add(txtSearch, 0, 1);
            tblFilter.Controls.Add(cmbStockStatus, 2, 1);
            tblFilter.Controls.Add(cmbCategory, 1, 1);
            tblFilter.Controls.Add(lblSearch, 0, 0);
            tblFilter.Dock = DockStyle.Fill;
            tblFilter.Location = new Point(14, 12);
            tblFilter.Margin = new Padding(4, 3, 4, 3);
            tblFilter.Name = "tblFilter";
            tblFilter.RowCount = 2;
            tblFilter.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblFilter.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblFilter.Size = new Size(568, 66);
            tblFilter.TabIndex = 0;
            tblFilter.Paint += tblFilter_Paint;
            // 
            // lblStockStatus
            // 
            lblStockStatus.AutoSize = true;
            lblStockStatus.Dock = DockStyle.Fill;
            lblStockStatus.Location = new Point(401, 1);
            lblStockStatus.Margin = new Padding(4, 0, 4, 0);
            lblStockStatus.Name = "lblStockStatus";
            lblStockStatus.Size = new Size(162, 31);
            lblStockStatus.TabIndex = 2;
            lblStockStatus.Text = "Stock Status";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Dock = DockStyle.Fill;
            lblCategory.Location = new Point(231, 1);
            lblCategory.Margin = new Padding(4, 0, 4, 0);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(161, 31);
            lblCategory.TabIndex = 1;
            lblCategory.Text = "Category";
            // 
            // txtSearch
            // 
            txtSearch.Dock = DockStyle.Fill;
            txtSearch.Location = new Point(5, 36);
            txtSearch.Margin = new Padding(4, 3, 4, 3);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(217, 23);
            txtSearch.TabIndex = 5;
            // 
            // cmbStockStatus
            // 
            cmbStockStatus.Dock = DockStyle.Fill;
            cmbStockStatus.FormattingEnabled = true;
            cmbStockStatus.Location = new Point(401, 36);
            cmbStockStatus.Margin = new Padding(4, 3, 4, 3);
            cmbStockStatus.Name = "cmbStockStatus";
            cmbStockStatus.Size = new Size(162, 23);
            cmbStockStatus.TabIndex = 3;
            // 
            // cmbCategory
            // 
            cmbCategory.Dock = DockStyle.Fill;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(231, 36);
            cmbCategory.Margin = new Padding(4, 3, 4, 3);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(161, 23);
            cmbCategory.TabIndex = 4;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Dock = DockStyle.Fill;
            lblSearch.Location = new Point(5, 1);
            lblSearch.Margin = new Padding(4, 0, 4, 0);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(217, 31);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Search";
            // 
            // pnlGrid
            // 
            pnlGrid.BackColor = Color.White;
            pnlGrid.Controls.Add(dgvProducts);
            pnlGrid.Dock = DockStyle.Fill;
            pnlGrid.Location = new Point(23, 183);
            pnlGrid.Margin = new Padding(4, 3, 4, 3);
            pnlGrid.Name = "pnlGrid";
            pnlGrid.Padding = new Padding(14);
            pnlGrid.Size = new Size(596, 196);
            pnlGrid.TabIndex = 2;
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.AllowUserToResizeRows = false;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.BackgroundColor = Color.White;
            dgvProducts.BorderStyle = BorderStyle.None;
            dgvProducts.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvProducts.ColumnHeadersHeight = 36;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvProducts.Columns.AddRange(new DataGridViewColumn[] { colId, colName, colCategory, colPrice, colStock, colStatus });
            dgvProducts.Dock = DockStyle.Fill;
            dgvProducts.GridColor = Color.Gainsboro;
            dgvProducts.Location = new Point(14, 14);
            dgvProducts.Margin = new Padding(4, 3, 4, 3);
            dgvProducts.MultiSelect = false;
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersVisible = false;
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(568, 168);
            dgvProducts.TabIndex = 0;
            dgvProducts.CellContentClick += dgvProducts_CellContentClick;
            // 
            // colId
            // 
            colId.DataPropertyName = "Id";
            colId.FillWeight = 126.225578F;
            colId.HeaderText = "ID";
            colId.Name = "colId";
            colId.ReadOnly = true;
            // 
            // colName
            // 
            colName.DataPropertyName = "Name";
            colName.FillWeight = 106.598984F;
            colName.HeaderText = "Name";
            colName.Name = "colName";
            colName.ReadOnly = true;
            // 
            // colCategory
            // 
            colCategory.DataPropertyName = "Category";
            colCategory.FillWeight = 94.60364F;
            colCategory.HeaderText = "Category";
            colCategory.Name = "colCategory";
            colCategory.ReadOnly = true;
            // 
            // colPrice
            // 
            colPrice.DataPropertyName = "Price";
            colPrice.FillWeight = 92.9387741F;
            colPrice.HeaderText = "Price";
            colPrice.Name = "colPrice";
            colPrice.ReadOnly = true;
            // 
            // colStock
            // 
            colStock.DataPropertyName = "Stock";
            colStock.FillWeight = 90.97488F;
            colStock.HeaderText = "Stock";
            colStock.Name = "colStock";
            colStock.ReadOnly = true;
            // 
            // colStatus
            // 
            colStatus.DataPropertyName = "Status";
            colStatus.FillWeight = 88.658165F;
            colStatus.HeaderText = "Status";
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            // 
            // ProductsView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tblProducts);
            Margin = new Padding(4, 3, 4, 3);
            Name = "ProductsView";
            Size = new Size(642, 400);
            Load += ProductsView_Load;
            tblProducts.ResumeLayout(false);
            pnlProducts.ResumeLayout(false);
            pnlProducts.PerformLayout();
            tsProducts.ResumeLayout(false);
            tsProducts.PerformLayout();
            pnlFilters.ResumeLayout(false);
            tblFilter.ResumeLayout(false);
            tblFilter.PerformLayout();
            pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblProducts;
        private System.Windows.Forms.Panel pnlProducts;
        private System.Windows.Forms.ToolStrip tsProducts;
        private System.Windows.Forms.ToolStripButton tsdAdd;
        private System.Windows.Forms.ToolStripButton tsdEdit;
        private System.Windows.Forms.ToolStripButton tsdView;
        private System.Windows.Forms.ToolStripButton tsdDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsdRefresh;
        private System.Windows.Forms.Panel pnlFilters;
        private System.Windows.Forms.TableLayoutPanel tblFilter;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblStockStatus;
        private System.Windows.Forms.ComboBox cmbStockStatus;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.DataGridView dgvProducts;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colCategory;
        private DataGridViewTextBoxColumn colPrice;
        private DataGridViewTextBoxColumn colStock;
        private DataGridViewTextBoxColumn colStatus;
    }
}
