namespace WindowsFormsApp.Views
{
    partial class Products
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Products));
            this.tblProducts = new System.Windows.Forms.TableLayoutPanel();
            this.pnlProducts = new System.Windows.Forms.Panel();
            this.tsProducts = new System.Windows.Forms.ToolStrip();
            this.tsdAdd = new System.Windows.Forms.ToolStripButton();
            this.tsdEdit = new System.Windows.Forms.ToolStripButton();
            this.tsdView = new System.Windows.Forms.ToolStripButton();
            this.tsdDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsdRefresh = new System.Windows.Forms.ToolStripButton();
            this.pnlFilters = new System.Windows.Forms.Panel();
            this.tblFilter = new System.Windows.Forms.TableLayoutPanel();
            this.lblStockStatus = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmbStockStatus = new System.Windows.Forms.ComboBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblProducts.SuspendLayout();
            this.pnlProducts.SuspendLayout();
            this.tsProducts.SuspendLayout();
            this.pnlFilters.SuspendLayout();
            this.tblFilter.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // tblProducts
            // 
            this.tblProducts.ColumnCount = 1;
            this.tblProducts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblProducts.Controls.Add(this.pnlProducts, 0, 0);
            this.tblProducts.Controls.Add(this.pnlFilters, 0, 1);
            this.tblProducts.Controls.Add(this.pnlGrid, 0, 2);
            this.tblProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblProducts.Location = new System.Drawing.Point(0, 0);
            this.tblProducts.Name = "tblProducts";
            this.tblProducts.Padding = new System.Windows.Forms.Padding(16);
            this.tblProducts.RowCount = 3;
            this.tblProducts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tblProducts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tblProducts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblProducts.Size = new System.Drawing.Size(550, 347);
            this.tblProducts.TabIndex = 0;
            this.tblProducts.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // pnlProducts
            // 
            this.pnlProducts.BackColor = System.Drawing.Color.White;
            this.pnlProducts.Controls.Add(this.tsProducts);
            this.pnlProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlProducts.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlProducts.Location = new System.Drawing.Point(19, 19);
            this.pnlProducts.Name = "pnlProducts";
            this.pnlProducts.Size = new System.Drawing.Size(512, 50);
            this.pnlProducts.TabIndex = 0;
            this.pnlProducts.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlProducts_Paint);
            // 
            // tsProducts
            // 
            this.tsProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tsProducts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsdAdd,
            this.tsdEdit,
            this.tsdView,
            this.tsdDelete,
            this.toolStripSeparator1,
            this.tsdRefresh});
            this.tsProducts.Location = new System.Drawing.Point(0, 0);
            this.tsProducts.Name = "tsProducts";
            this.tsProducts.Size = new System.Drawing.Size(512, 50);
            this.tsProducts.TabIndex = 0;
            this.tsProducts.Text = "toolStrip1";
            this.tsProducts.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // tsdAdd
            // 
            this.tsdAdd.Image = ((System.Drawing.Image)(resources.GetObject("tsdAdd.Image")));
            this.tsdAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsdAdd.Name = "tsdAdd";
            this.tsdAdd.Size = new System.Drawing.Size(49, 47);
            this.tsdAdd.Text = "Add";
            // 
            // tsdEdit
            // 
            this.tsdEdit.Image = ((System.Drawing.Image)(resources.GetObject("tsdEdit.Image")));
            this.tsdEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsdEdit.Name = "tsdEdit";
            this.tsdEdit.Size = new System.Drawing.Size(47, 47);
            this.tsdEdit.Text = "Edit";
            // 
            // tsdView
            // 
            this.tsdView.Image = ((System.Drawing.Image)(resources.GetObject("tsdView.Image")));
            this.tsdView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsdView.Name = "tsdView";
            this.tsdView.Size = new System.Drawing.Size(52, 47);
            this.tsdView.Text = "View";
            // 
            // tsdDelete
            // 
            this.tsdDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsdDelete.Image")));
            this.tsdDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsdDelete.Name = "tsdDelete";
            this.tsdDelete.Size = new System.Drawing.Size(60, 47);
            this.tsdDelete.Text = "Delete";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 50);
            // 
            // tsdRefresh
            // 
            this.tsdRefresh.Image = ((System.Drawing.Image)(resources.GetObject("tsdRefresh.Image")));
            this.tsdRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsdRefresh.Name = "tsdRefresh";
            this.tsdRefresh.Size = new System.Drawing.Size(66, 47);
            this.tsdRefresh.Text = "Refresh";
            // 
            // pnlFilters
            // 
            this.pnlFilters.Controls.Add(this.tblFilter);
            this.pnlFilters.Location = new System.Drawing.Point(19, 75);
            this.pnlFilters.Name = "pnlFilters";
            this.pnlFilters.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.pnlFilters.Size = new System.Drawing.Size(512, 78);
            this.pnlFilters.TabIndex = 1;
            // 
            // tblFilter
            // 
            this.tblFilter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblFilter.BackColor = System.Drawing.Color.White;
            this.tblFilter.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tblFilter.ColumnCount = 3;
            this.tblFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tblFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblFilter.Controls.Add(this.lblStockStatus, 2, 0);
            this.tblFilter.Controls.Add(this.lblCategory, 1, 0);
            this.tblFilter.Controls.Add(this.txtSearch, 0, 1);
            this.tblFilter.Controls.Add(this.cmbStockStatus, 2, 1);
            this.tblFilter.Controls.Add(this.cmbCategory, 1, 1);
            this.tblFilter.Controls.Add(this.lblSearch, 0, 0);
            this.tblFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblFilter.Location = new System.Drawing.Point(12, 10);
            this.tblFilter.Name = "tblFilter";
            this.tblFilter.RowCount = 2;
            this.tblFilter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblFilter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblFilter.Size = new System.Drawing.Size(488, 58);
            this.tblFilter.TabIndex = 0;
            this.tblFilter.Paint += new System.Windows.Forms.PaintEventHandler(this.tblFilter_Paint);
            // 
            // lblStockStatus
            // 
            this.lblStockStatus.AutoSize = true;
            this.lblStockStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStockStatus.Location = new System.Drawing.Point(344, 1);
            this.lblStockStatus.Name = "lblStockStatus";
            this.lblStockStatus.Size = new System.Drawing.Size(140, 27);
            this.lblStockStatus.TabIndex = 2;
            this.lblStockStatus.Text = "Stock Status";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCategory.Location = new System.Drawing.Point(198, 1);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(139, 27);
            this.lblCategory.TabIndex = 1;
            this.lblCategory.Text = "Category";
            // 
            // txtSearch
            // 
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearch.Location = new System.Drawing.Point(4, 32);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(187, 20);
            this.txtSearch.TabIndex = 5;
            // 
            // cmbStockStatus
            // 
            this.cmbStockStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbStockStatus.FormattingEnabled = true;
            this.cmbStockStatus.Location = new System.Drawing.Point(344, 32);
            this.cmbStockStatus.Name = "cmbStockStatus";
            this.cmbStockStatus.Size = new System.Drawing.Size(140, 21);
            this.cmbStockStatus.TabIndex = 3;
            // 
            // cmbCategory
            // 
            this.cmbCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(198, 32);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(139, 21);
            this.cmbCategory.TabIndex = 4;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSearch.Location = new System.Drawing.Point(4, 1);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(187, 27);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Search";
            // 
            // pnlGrid
            // 
            this.pnlGrid.BackColor = System.Drawing.Color.White;
            this.pnlGrid.Controls.Add(this.dgvProducts);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(19, 159);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Padding = new System.Windows.Forms.Padding(12);
            this.pnlGrid.Size = new System.Drawing.Size(512, 169);
            this.pnlGrid.TabIndex = 2;
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.AllowUserToResizeRows = false;
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.BackgroundColor = System.Drawing.Color.White;
            this.dgvProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProducts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvProducts.ColumnHeadersHeight = 36;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colName,
            this.colCategory,
            this.colPrice,
            this.colStock,
            this.colStatus});
            this.dgvProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProducts.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvProducts.Location = new System.Drawing.Point(12, 12);
            this.dgvProducts.MultiSelect = false;
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersVisible = false;
            this.dgvProducts.RowHeadersWidth = 51;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(488, 145);
            this.dgvProducts.TabIndex = 0;
            this.dgvProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellContentClick);
            // 
            // colId
            // 
            this.colId.FillWeight = 304.5685F;
            this.colId.HeaderText = "ID";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            // 
            // colName
            // 
            this.colName.FillWeight = 59.08629F;
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colCategory
            // 
            this.colCategory.FillWeight = 59.08629F;
            this.colCategory.HeaderText = "Category";
            this.colCategory.Name = "colCategory";
            this.colCategory.ReadOnly = true;
            // 
            // colPrice
            // 
            this.colPrice.FillWeight = 59.08629F;
            this.colPrice.HeaderText = "Price";
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            // 
            // colStock
            // 
            this.colStock.FillWeight = 59.08629F;
            this.colStock.HeaderText = "Stock";
            this.colStock.Name = "colStock";
            this.colStock.ReadOnly = true;
            // 
            // colStatus
            // 
            this.colStatus.FillWeight = 59.08629F;
            this.colStatus.HeaderText = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tblProducts);
            this.Name = "Products";
            this.Size = new System.Drawing.Size(550, 347);
            this.tblProducts.ResumeLayout(false);
            this.pnlProducts.ResumeLayout(false);
            this.pnlProducts.PerformLayout();
            this.tsProducts.ResumeLayout(false);
            this.tsProducts.PerformLayout();
            this.pnlFilters.ResumeLayout(false);
            this.tblFilter.ResumeLayout(false);
            this.tblFilter.PerformLayout();
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
    }
}
