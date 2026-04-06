//using System.WindowsApp.Forms;
namespace App.WindowsApp.Views
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
            tblDashboard = new TableLayoutPanel();
            pnlRecentOrder = new Panel();
            lvlCustomer = new ListView();
            colCustomerId = new ColumnHeader();
            colCustomer = new ColumnHeader();
            colTotal = new ColumnHeader();
            colStatus = new ColumnHeader();
            label1 = new Label();
            flpkpi = new FlowLayoutPanel();
            pnlSales = new Panel();
            lblSalesV = new Label();
            lblSalesT = new Label();
            pnlOrders = new Panel();
            lblOrdersV = new Label();
            lblOrdersT = new Label();
            pnlRevenue = new Panel();
            lblRevenueV = new Label();
            lblRevenueT = new Label();
            pnlLowStock = new Panel();
            lblLowStock = new Label();
            lvlProduct = new ListView();
            colProduct = new ColumnHeader();
            colStock = new ColumnHeader();
            tblDashboard.SuspendLayout();
            pnlRecentOrder.SuspendLayout();
            flpkpi.SuspendLayout();
            pnlSales.SuspendLayout();
            pnlOrders.SuspendLayout();
            pnlRevenue.SuspendLayout();
            pnlLowStock.SuspendLayout();
            SuspendLayout();
            // 
            // tblDashboard
            // 
            tblDashboard.ColumnCount = 1;
            tblDashboard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblDashboard.Controls.Add(pnlRecentOrder, 0, 2);
            tblDashboard.Controls.Add(flpkpi, 0, 0);
            tblDashboard.Controls.Add(pnlLowStock, 0, 1);
            tblDashboard.Dock = DockStyle.Fill;
            tblDashboard.Location = new Point(0, 0);
            tblDashboard.Margin = new Padding(4, 3, 4, 3);
            tblDashboard.Name = "tblDashboard";
            tblDashboard.RowCount = 3;
            tblDashboard.RowStyles.Add(new RowStyle(SizeType.Absolute, 139F));
            tblDashboard.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblDashboard.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblDashboard.Size = new Size(740, 405);
            tblDashboard.TabIndex = 0;
            tblDashboard.Paint += tableLayoutPanel1_Paint;
            // 
            // pnlRecentOrder
            // 
            pnlRecentOrder.BackColor = Color.White;
            pnlRecentOrder.Controls.Add(lvlCustomer);
            pnlRecentOrder.Controls.Add(label1);
            pnlRecentOrder.Dock = DockStyle.Fill;
            pnlRecentOrder.Location = new Point(4, 275);
            pnlRecentOrder.Margin = new Padding(4, 3, 4, 3);
            pnlRecentOrder.Name = "pnlRecentOrder";
            pnlRecentOrder.Size = new Size(732, 127);
            pnlRecentOrder.TabIndex = 2;
            pnlRecentOrder.Paint += pnlRecentOrder_Paint;
            // 
            // lvlCustomer
            // 
            lvlCustomer.Columns.AddRange(new ColumnHeader[] { colCustomerId, colCustomer, colTotal, colStatus });
            lvlCustomer.Location = new Point(28, 53);
            lvlCustomer.Margin = new Padding(4, 3, 4, 3);
            lvlCustomer.Name = "lvlCustomer";
            lvlCustomer.Size = new Size(691, 55);
            lvlCustomer.TabIndex = 3;
            lvlCustomer.UseCompatibleStateImageBehavior = false;
            lvlCustomer.View = View.Details;
            // 
            // colCustomerId
            // 
            colCustomerId.Text = "CustomerId";
            // 
            // colCustomer
            // 
            colCustomer.Text = "Customer";
            // 
            // colTotal
            // 
            colTotal.Text = "Total";
            // 
            // colStatus
            // 
            colStatus.Text = "status";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 35);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 2;
            label1.Text = "Recent Orders";
            label1.Click += label1_Click;
            // 
            // flpkpi
            // 
            flpkpi.BackColor = Color.White;
            flpkpi.Controls.Add(pnlSales);
            flpkpi.Controls.Add(pnlOrders);
            flpkpi.Controls.Add(pnlRevenue);
            flpkpi.Dock = DockStyle.Fill;
            flpkpi.Location = new Point(4, 3);
            flpkpi.Margin = new Padding(4, 3, 4, 3);
            flpkpi.Name = "flpkpi";
            flpkpi.Size = new Size(732, 133);
            flpkpi.TabIndex = 0;
            // 
            // pnlSales
            // 
            pnlSales.BackColor = Color.White;
            pnlSales.Controls.Add(lblSalesV);
            pnlSales.Controls.Add(lblSalesT);
            pnlSales.Location = new Point(4, 3);
            pnlSales.Margin = new Padding(4, 3, 4, 3);
            pnlSales.Name = "pnlSales";
            pnlSales.Size = new Size(233, 115);
            pnlSales.TabIndex = 0;
            // 
            // lblSalesV
            // 
            lblSalesV.AutoSize = true;
            lblSalesV.BackColor = Color.White;
            lblSalesV.Location = new Point(97, 51);
            lblSalesV.Margin = new Padding(4, 0, 4, 0);
            lblSalesV.Name = "lblSalesV";
            lblSalesV.Size = new Size(25, 15);
            lblSalesV.TabIndex = 1;
            lblSalesV.Text = "163";
            // 
            // lblSalesT
            // 
            lblSalesT.AutoSize = true;
            lblSalesT.BackColor = Color.White;
            lblSalesT.Location = new Point(22, 51);
            lblSalesT.Margin = new Padding(4, 0, 4, 0);
            lblSalesT.Name = "lblSalesT";
            lblSalesT.Size = new Size(33, 15);
            lblSalesT.TabIndex = 0;
            lblSalesT.Text = "Sales";
            // 
            // pnlOrders
            // 
            pnlOrders.BackColor = Color.White;
            pnlOrders.Controls.Add(lblOrdersV);
            pnlOrders.Controls.Add(lblOrdersT);
            pnlOrders.Location = new Point(245, 3);
            pnlOrders.Margin = new Padding(4, 3, 4, 3);
            pnlOrders.Name = "pnlOrders";
            pnlOrders.Size = new Size(233, 115);
            pnlOrders.TabIndex = 1;
            pnlOrders.Paint += pnlOrders_Paint;
            // 
            // lblOrdersV
            // 
            lblOrdersV.AutoSize = true;
            lblOrdersV.BackColor = Color.White;
            lblOrdersV.Location = new Point(130, 51);
            lblOrdersV.Margin = new Padding(4, 0, 4, 0);
            lblOrdersV.Name = "lblOrdersV";
            lblOrdersV.Size = new Size(19, 15);
            lblOrdersV.TabIndex = 3;
            lblOrdersV.Text = "33";
            // 
            // lblOrdersT
            // 
            lblOrdersT.AutoSize = true;
            lblOrdersT.BackColor = Color.White;
            lblOrdersT.Location = new Point(51, 51);
            lblOrdersT.Margin = new Padding(4, 0, 4, 0);
            lblOrdersT.Name = "lblOrdersT";
            lblOrdersT.Size = new Size(37, 15);
            lblOrdersT.TabIndex = 2;
            lblOrdersT.Text = "Order";
            // 
            // pnlRevenue
            // 
            pnlRevenue.BackColor = Color.White;
            pnlRevenue.Controls.Add(lblRevenueV);
            pnlRevenue.Controls.Add(lblRevenueT);
            pnlRevenue.Location = new Point(486, 3);
            pnlRevenue.Margin = new Padding(4, 3, 4, 3);
            pnlRevenue.Name = "pnlRevenue";
            pnlRevenue.Size = new Size(233, 115);
            pnlRevenue.TabIndex = 2;
            // 
            // lblRevenueV
            // 
            lblRevenueV.AutoSize = true;
            lblRevenueV.BackColor = Color.White;
            lblRevenueV.Location = new Point(97, 51);
            lblRevenueV.Margin = new Padding(4, 0, 4, 0);
            lblRevenueV.Name = "lblRevenueV";
            lblRevenueV.Size = new Size(61, 15);
            lblRevenueV.TabIndex = 2;
            lblRevenueV.Text = "37.356PKR";
            // 
            // lblRevenueT
            // 
            lblRevenueT.AutoSize = true;
            lblRevenueT.BackColor = Color.White;
            lblRevenueT.Location = new Point(30, 51);
            lblRevenueT.Margin = new Padding(4, 0, 4, 0);
            lblRevenueT.Name = "lblRevenueT";
            lblRevenueT.Size = new Size(52, 15);
            lblRevenueT.TabIndex = 1;
            lblRevenueT.Text = "Revenue";
            // 
            // pnlLowStock
            // 
            pnlLowStock.BackColor = Color.White;
            pnlLowStock.Controls.Add(lblLowStock);
            pnlLowStock.Controls.Add(lvlProduct);
            pnlLowStock.Dock = DockStyle.Fill;
            pnlLowStock.Location = new Point(4, 142);
            pnlLowStock.Margin = new Padding(4, 3, 4, 3);
            pnlLowStock.Name = "pnlLowStock";
            pnlLowStock.Size = new Size(732, 127);
            pnlLowStock.TabIndex = 1;
            // 
            // lblLowStock
            // 
            lblLowStock.AutoSize = true;
            lblLowStock.Location = new Point(23, 22);
            lblLowStock.Margin = new Padding(4, 0, 4, 0);
            lblLowStock.Name = "lblLowStock";
            lblLowStock.Size = new Size(61, 15);
            lblLowStock.TabIndex = 1;
            lblLowStock.Text = "Low Stock";
            // 
            // lvlProduct
            // 
            lvlProduct.Columns.AddRange(new ColumnHeader[] { colProduct, colStock });
            lvlProduct.Location = new Point(27, 54);
            lvlProduct.Margin = new Padding(4, 3, 4, 3);
            lvlProduct.Name = "lvlProduct";
            lvlProduct.Size = new Size(692, 59);
            lvlProduct.TabIndex = 0;
            lvlProduct.UseCompatibleStateImageBehavior = false;
            lvlProduct.View = View.Details;
            lvlProduct.SelectedIndexChanged += listView1_SelectedIndexChanged_1;
            // 
            // colProduct
            // 
            colProduct.Text = "Produ...";
            // 
            // colStock
            // 
            colStock.Text = "Stock";
            // 
            // DashboardView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tblDashboard);
            Margin = new Padding(4, 3, 4, 3);
            Name = "DashboardView";
            Size = new Size(740, 405);
            tblDashboard.ResumeLayout(false);
            pnlRecentOrder.ResumeLayout(false);
            pnlRecentOrder.PerformLayout();
            flpkpi.ResumeLayout(false);
            pnlSales.ResumeLayout(false);
            pnlSales.PerformLayout();
            pnlOrders.ResumeLayout(false);
            pnlOrders.PerformLayout();
            pnlRevenue.ResumeLayout(false);
            pnlRevenue.PerformLayout();
            pnlLowStock.ResumeLayout(false);
            pnlLowStock.PerformLayout();
            ResumeLayout(false);

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
        private ListView lvlCustomer;
    }
}
