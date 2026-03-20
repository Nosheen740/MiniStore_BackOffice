namespace WindowsFormsApp.Views
{
    partial class DashboardView
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
            this.tblDashboard = new System.Windows.Forms.TableLayoutPanel();
            this.pnlRecentOrder = new System.Windows.Forms.Panel();
            this.listView2 = new System.Windows.Forms.ListView();
            this.colCustomerId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCustomer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.flpkpi = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlSales = new System.Windows.Forms.Panel();
            this.lblSalesV = new System.Windows.Forms.Label();
            this.lblSalesT = new System.Windows.Forms.Label();
            this.pnlOrders = new System.Windows.Forms.Panel();
            this.lblOrdersV = new System.Windows.Forms.Label();
            this.lblOrdersT = new System.Windows.Forms.Label();
            this.pnlRevenue = new System.Windows.Forms.Panel();
            this.lblRevenueV = new System.Windows.Forms.Label();
            this.lblRevenueT = new System.Windows.Forms.Label();
            this.pnlLowStock = new System.Windows.Forms.Panel();
            this.lblLowStock = new System.Windows.Forms.Label();
            this.lvlProduct = new System.Windows.Forms.ListView();
            this.colProduct = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tblDashboard.SuspendLayout();
            this.pnlRecentOrder.SuspendLayout();
            this.flpkpi.SuspendLayout();
            this.pnlSales.SuspendLayout();
            this.pnlOrders.SuspendLayout();
            this.pnlRevenue.SuspendLayout();
            this.pnlLowStock.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblDashboard
            // 
            this.tblDashboard.ColumnCount = 1;
            this.tblDashboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblDashboard.Controls.Add(this.pnlRecentOrder, 0, 2);
            this.tblDashboard.Controls.Add(this.flpkpi, 0, 0);
            this.tblDashboard.Controls.Add(this.pnlLowStock, 0, 1);
            this.tblDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblDashboard.Location = new System.Drawing.Point(0, 0);
            this.tblDashboard.Name = "tblDashboard";
            this.tblDashboard.RowCount = 3;
            this.tblDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tblDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblDashboard.Size = new System.Drawing.Size(802, 450);
            this.tblDashboard.TabIndex = 0;
            this.tblDashboard.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // pnlRecentOrder
            // 
            this.pnlRecentOrder.BackColor = System.Drawing.Color.White;
            this.pnlRecentOrder.Controls.Add(this.listView2);
            this.pnlRecentOrder.Controls.Add(this.label1);
            this.pnlRecentOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRecentOrder.Location = new System.Drawing.Point(3, 288);
            this.pnlRecentOrder.Name = "pnlRecentOrder";
            this.pnlRecentOrder.Size = new System.Drawing.Size(796, 159);
            this.pnlRecentOrder.TabIndex = 2;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colCustomerId,
            this.colCustomer,
            this.colTotal,
            this.colStatus});
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(24, 46);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(669, 81);
            this.listView2.TabIndex = 3;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // colCustomerId
            // 
            this.colCustomerId.Text = "CustomerId";
            // 
            // colCustomer
            // 
            this.colCustomer.Text = "Customer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Recent Orders";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // flpkpi
            // 
            this.flpkpi.BackColor = System.Drawing.Color.White;
            this.flpkpi.Controls.Add(this.pnlSales);
            this.flpkpi.Controls.Add(this.pnlOrders);
            this.flpkpi.Controls.Add(this.pnlRevenue);
            this.flpkpi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpkpi.Location = new System.Drawing.Point(3, 3);
            this.flpkpi.Name = "flpkpi";
            this.flpkpi.Size = new System.Drawing.Size(796, 114);
            this.flpkpi.TabIndex = 0;
            // 
            // pnlSales
            // 
            this.pnlSales.BackColor = System.Drawing.Color.White;
            this.pnlSales.Controls.Add(this.lblSalesV);
            this.pnlSales.Controls.Add(this.lblSalesT);
            this.pnlSales.Location = new System.Drawing.Point(3, 3);
            this.pnlSales.Name = "pnlSales";
            this.pnlSales.Size = new System.Drawing.Size(200, 100);
            this.pnlSales.TabIndex = 0;
            // 
            // lblSalesV
            // 
            this.lblSalesV.AutoSize = true;
            this.lblSalesV.BackColor = System.Drawing.Color.White;
            this.lblSalesV.Location = new System.Drawing.Point(83, 44);
            this.lblSalesV.Name = "lblSalesV";
            this.lblSalesV.Size = new System.Drawing.Size(25, 13);
            this.lblSalesV.TabIndex = 1;
            this.lblSalesV.Text = "163";
            // 
            // lblSalesT
            // 
            this.lblSalesT.AutoSize = true;
            this.lblSalesT.BackColor = System.Drawing.Color.White;
            this.lblSalesT.Location = new System.Drawing.Point(19, 44);
            this.lblSalesT.Name = "lblSalesT";
            this.lblSalesT.Size = new System.Drawing.Size(33, 13);
            this.lblSalesT.TabIndex = 0;
            this.lblSalesT.Text = "Sales";
            // 
            // pnlOrders
            // 
            this.pnlOrders.BackColor = System.Drawing.Color.White;
            this.pnlOrders.Controls.Add(this.lblOrdersV);
            this.pnlOrders.Controls.Add(this.lblOrdersT);
            this.pnlOrders.Location = new System.Drawing.Point(209, 3);
            this.pnlOrders.Name = "pnlOrders";
            this.pnlOrders.Size = new System.Drawing.Size(200, 100);
            this.pnlOrders.TabIndex = 1;
            this.pnlOrders.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlOrders_Paint);
            // 
            // lblOrdersV
            // 
            this.lblOrdersV.AutoSize = true;
            this.lblOrdersV.BackColor = System.Drawing.Color.White;
            this.lblOrdersV.Location = new System.Drawing.Point(111, 44);
            this.lblOrdersV.Name = "lblOrdersV";
            this.lblOrdersV.Size = new System.Drawing.Size(19, 13);
            this.lblOrdersV.TabIndex = 3;
            this.lblOrdersV.Text = "33";
            // 
            // lblOrdersT
            // 
            this.lblOrdersT.AutoSize = true;
            this.lblOrdersT.BackColor = System.Drawing.Color.White;
            this.lblOrdersT.Location = new System.Drawing.Point(44, 44);
            this.lblOrdersT.Name = "lblOrdersT";
            this.lblOrdersT.Size = new System.Drawing.Size(33, 13);
            this.lblOrdersT.TabIndex = 2;
            this.lblOrdersT.Text = "Order";
            // 
            // pnlRevenue
            // 
            this.pnlRevenue.BackColor = System.Drawing.Color.White;
            this.pnlRevenue.Controls.Add(this.lblRevenueV);
            this.pnlRevenue.Controls.Add(this.lblRevenueT);
            this.pnlRevenue.Location = new System.Drawing.Point(415, 3);
            this.pnlRevenue.Name = "pnlRevenue";
            this.pnlRevenue.Size = new System.Drawing.Size(200, 100);
            this.pnlRevenue.TabIndex = 2;
            // 
            // lblRevenueV
            // 
            this.lblRevenueV.AutoSize = true;
            this.lblRevenueV.BackColor = System.Drawing.Color.White;
            this.lblRevenueV.Location = new System.Drawing.Point(83, 44);
            this.lblRevenueV.Name = "lblRevenueV";
            this.lblRevenueV.Size = new System.Drawing.Size(62, 13);
            this.lblRevenueV.TabIndex = 2;
            this.lblRevenueV.Text = "37.356PKR";
            // 
            // lblRevenueT
            // 
            this.lblRevenueT.AutoSize = true;
            this.lblRevenueT.BackColor = System.Drawing.Color.White;
            this.lblRevenueT.Location = new System.Drawing.Point(26, 44);
            this.lblRevenueT.Name = "lblRevenueT";
            this.lblRevenueT.Size = new System.Drawing.Size(51, 13);
            this.lblRevenueT.TabIndex = 1;
            this.lblRevenueT.Text = "Revenue";
            // 
            // pnlLowStock
            // 
            this.pnlLowStock.BackColor = System.Drawing.Color.White;
            this.pnlLowStock.Controls.Add(this.lblLowStock);
            this.pnlLowStock.Controls.Add(this.lvlProduct);
            this.pnlLowStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLowStock.Location = new System.Drawing.Point(3, 123);
            this.pnlLowStock.Name = "pnlLowStock";
            this.pnlLowStock.Size = new System.Drawing.Size(796, 159);
            this.pnlLowStock.TabIndex = 1;
            // 
            // lblLowStock
            // 
            this.lblLowStock.AutoSize = true;
            this.lblLowStock.Location = new System.Drawing.Point(20, 19);
            this.lblLowStock.Name = "lblLowStock";
            this.lblLowStock.Size = new System.Drawing.Size(58, 13);
            this.lblLowStock.TabIndex = 1;
            this.lblLowStock.Text = "Low Stock";
            // 
            // lvlProduct
            // 
            this.lvlProduct.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colProduct,
            this.colStock});
            this.lvlProduct.HideSelection = false;
            this.lvlProduct.Location = new System.Drawing.Point(23, 47);
            this.lvlProduct.Name = "lvlProduct";
            this.lvlProduct.Size = new System.Drawing.Size(670, 89);
            this.lvlProduct.TabIndex = 0;
            this.lvlProduct.UseCompatibleStateImageBehavior = false;
            this.lvlProduct.View = System.Windows.Forms.View.Details;
            this.lvlProduct.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged_1);
            // 
            // colProduct
            // 
            this.colProduct.Text = "Produ...";
            // 
            // colStock
            // 
            this.colStock.Text = "Stock";
            // 
            // colTotal
            // 
            this.colTotal.Text = "Total";
            // 
            // colStatus
            // 
            this.colStatus.Text = "status";
            // 
            // DashboardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tblDashboard);
            this.Name = "DashboardView";
            this.Size = new System.Drawing.Size(802, 450);
            this.tblDashboard.ResumeLayout(false);
            this.pnlRecentOrder.ResumeLayout(false);
            this.pnlRecentOrder.PerformLayout();
            this.flpkpi.ResumeLayout(false);
            this.pnlSales.ResumeLayout(false);
            this.pnlSales.PerformLayout();
            this.pnlOrders.ResumeLayout(false);
            this.pnlOrders.PerformLayout();
            this.pnlRevenue.ResumeLayout(false);
            this.pnlRevenue.PerformLayout();
            this.pnlLowStock.ResumeLayout(false);
            this.pnlLowStock.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblDashboard;
        private System.Windows.Forms.FlowLayoutPanel flpkpi;
        private System.Windows.Forms.Panel pnlSales;
        private System.Windows.Forms.Panel pnlOrders;
        private System.Windows.Forms.Panel pnlRevenue;
        private System.Windows.Forms.Label lblSalesV;
        private System.Windows.Forms.Label lblSalesT;
        private System.Windows.Forms.Label lblOrdersV;
        private System.Windows.Forms.Label lblOrdersT;
        private System.Windows.Forms.Label lblRevenueV;
        private System.Windows.Forms.Label lblRevenueT;
        private System.Windows.Forms.Panel pnlLowStock;
        private System.Windows.Forms.Panel pnlRecentOrder;
        private System.Windows.Forms.ListView lvlProduct;
        private System.Windows.Forms.Label lblLowStock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader colProduct;
        private System.Windows.Forms.ColumnHeader colStock;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader colCustomerId;
        private System.Windows.Forms.ColumnHeader colCustomer;
        private System.Windows.Forms.ColumnHeader colTotal;
        private System.Windows.Forms.ColumnHeader colStatus;
    }
}
