namespace App.WindowsApp.Forms
{
    partial class MiniForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            pnlHeader = new Panel();
            flpRight = new FlowLayoutPanel();
            pbUser = new PictureBox();
            lblUser = new Label();
            flpLeft = new FlowLayoutPanel();
            pbLogo = new PictureBox();
            flpNav = new Panel();
            btnSync = new Button();
            btnDashboard = new Button();
            btnSettings = new Button();
            btnLogs = new Button();
            btnProducts = new Button();
            btnOrders = new Button();
            btnReports = new Button();
            pnlContent = new Panel();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            btnCutomer = new Button();
            pnlHeader.SuspendLayout();
            flpRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbUser).BeginInit();
            flpLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            flpNav.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(flpRight);
            pnlHeader.Controls.Add(flpLeft);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(836, 70);
            pnlHeader.TabIndex = 14;
            pnlHeader.Paint += panel1_Paint;
            // 
            // flpRight
            // 
            flpRight.Controls.Add(pbUser);
            flpRight.Controls.Add(lblUser);
            flpRight.Dock = DockStyle.Right;
            flpRight.Location = new Point(726, 0);
            flpRight.Name = "flpRight";
            flpRight.Size = new Size(110, 70);
            flpRight.TabIndex = 0;
            // 
            // pbUser
            // 
            pbUser.Image = Properties.Resources.Admin;
            pbUser.Location = new Point(3, 3);
            pbUser.Name = "pbUser";
            pbUser.Size = new Size(29, 26);
            pbUser.TabIndex = 1;
            pbUser.TabStop = false;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(38, 0);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(43, 15);
            lblUser.TabIndex = 0;
            lblUser.Tag = "";
            lblUser.Text = "Admin";
            // 
            // flpLeft
            // 
            flpLeft.Controls.Add(pbLogo);
            flpLeft.Dock = DockStyle.Left;
            flpLeft.Location = new Point(0, 0);
            flpLeft.Name = "flpLeft";
            flpLeft.Size = new Size(128, 70);
            flpLeft.TabIndex = 0;
            // 
            // pbLogo
            // 
            pbLogo.Image = Properties.Resources.Home;
            pbLogo.Location = new Point(3, 3);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(33, 26);
            pbLogo.TabIndex = 0;
            pbLogo.TabStop = false;
            // 
            // flpNav
            // 
            flpNav.Controls.Add(btnCutomer);
            flpNav.Controls.Add(btnSync);
            flpNav.Controls.Add(btnDashboard);
            flpNav.Controls.Add(btnSettings);
            flpNav.Controls.Add(btnLogs);
            flpNav.Controls.Add(btnProducts);
            flpNav.Controls.Add(btnOrders);
            flpNav.Controls.Add(btnReports);
            flpNav.Dock = DockStyle.Left;
            flpNav.Location = new Point(0, 70);
            flpNav.Name = "flpNav";
            flpNav.Size = new Size(237, 427);
            flpNav.TabIndex = 15;
            // 
            // btnSync
            // 
            btnSync.BackColor = Color.Transparent;
            btnSync.FlatAppearance.BorderSize = 0;
            btnSync.FlatStyle = FlatStyle.Flat;
            btnSync.Image = Properties.Resources.Sync;
            btnSync.ImageAlign = ContentAlignment.MiddleLeft;
            btnSync.Location = new Point(13, 246);
            btnSync.Margin = new Padding(4, 3, 4, 3);
            btnSync.Name = "btnSync";
            btnSync.Size = new Size(200, 40);
            btnSync.TabIndex = 11;
            btnSync.Text = "Sync";
            btnSync.TextAlign = ContentAlignment.MiddleLeft;
            btnSync.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSync.UseVisualStyleBackColor = false;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.Transparent;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.ForeColor = Color.Black;
            btnDashboard.Image = Properties.Resources.Dashboard;
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(13, 24);
            btnDashboard.Margin = new Padding(4, 3, 4, 3);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(200, 40);
            btnDashboard.TabIndex = 7;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnSettings
            // 
            btnSettings.BackColor = Color.Transparent;
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Image = Properties.Resources.Setting;
            btnSettings.ImageAlign = ContentAlignment.MiddleLeft;
            btnSettings.Location = new Point(13, 292);
            btnSettings.Margin = new Padding(4, 3, 4, 3);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(200, 40);
            btnSettings.TabIndex = 13;
            btnSettings.Text = "Settings";
            btnSettings.TextAlign = ContentAlignment.MiddleLeft;
            btnSettings.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSettings.UseVisualStyleBackColor = false;
            btnSettings.Click += button2_Click_1;
            // 
            // btnLogs
            // 
            btnLogs.BackColor = Color.Transparent;
            btnLogs.FlatAppearance.BorderSize = 0;
            btnLogs.FlatStyle = FlatStyle.Flat;
            btnLogs.Image = Properties.Resources.Logs;
            btnLogs.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogs.Location = new Point(13, 338);
            btnLogs.Margin = new Padding(4, 3, 4, 3);
            btnLogs.Name = "btnLogs";
            btnLogs.Size = new Size(200, 40);
            btnLogs.TabIndex = 12;
            btnLogs.Text = "Logs";
            btnLogs.TextAlign = ContentAlignment.MiddleLeft;
            btnLogs.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogs.UseVisualStyleBackColor = false;
            btnLogs.Click += button6_Click;
            // 
            // btnProducts
            // 
            btnProducts.BackColor = Color.Transparent;
            btnProducts.FlatAppearance.BorderSize = 0;
            btnProducts.FlatStyle = FlatStyle.Flat;
            btnProducts.Image = Properties.Resources.Product;
            btnProducts.ImageAlign = ContentAlignment.MiddleLeft;
            btnProducts.Location = new Point(13, 70);
            btnProducts.Margin = new Padding(4, 3, 4, 3);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(200, 40);
            btnProducts.TabIndex = 8;
            btnProducts.Text = "Products";
            btnProducts.TextAlign = ContentAlignment.MiddleLeft;
            btnProducts.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProducts.UseVisualStyleBackColor = false;
            btnProducts.Click += btnProducts_Click;
            // 
            // btnOrders
            // 
            btnOrders.BackColor = Color.Transparent;
            btnOrders.FlatAppearance.BorderSize = 0;
            btnOrders.FlatStyle = FlatStyle.Flat;
            btnOrders.Image = Properties.Resources.Orders;
            btnOrders.ImageAlign = ContentAlignment.MiddleLeft;
            btnOrders.Location = new Point(13, 154);
            btnOrders.Margin = new Padding(4, 3, 4, 3);
            btnOrders.Name = "btnOrders";
            btnOrders.Size = new Size(200, 40);
            btnOrders.TabIndex = 9;
            btnOrders.Text = "Orders";
            btnOrders.TextAlign = ContentAlignment.MiddleLeft;
            btnOrders.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnOrders.UseVisualStyleBackColor = false;
            btnOrders.Click += button3_Click;
            // 
            // btnReports
            // 
            btnReports.BackColor = Color.Transparent;
            btnReports.FlatAppearance.BorderSize = 0;
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Image = Properties.Resources.Report;
            btnReports.ImageAlign = ContentAlignment.MiddleLeft;
            btnReports.Location = new Point(13, 200);
            btnReports.Margin = new Padding(4, 3, 4, 3);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(200, 40);
            btnReports.TabIndex = 10;
            btnReports.Text = "Report";
            btnReports.TextAlign = ContentAlignment.MiddleLeft;
            btnReports.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReports.UseVisualStyleBackColor = false;
            btnReports.Click += button4_Click;
            // 
            // pnlContent
            // 
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(237, 70);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(599, 427);
            pnlContent.TabIndex = 16;
            pnlContent.Paint += pnlContent_Paint;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 497);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(836, 22);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(39, 17);
            toolStripStatusLabel1.Text = "Ready";
            // 
            // btnCutomer
            // 
            btnCutomer.BackColor = Color.Transparent;
            btnCutomer.FlatAppearance.BorderSize = 0;
            btnCutomer.FlatStyle = FlatStyle.Flat;
            btnCutomer.Image = Properties.Resources.Customer;
            btnCutomer.ImageAlign = ContentAlignment.MiddleLeft;
            btnCutomer.Location = new Point(13, 116);
            btnCutomer.Margin = new Padding(4, 3, 4, 3);
            btnCutomer.Name = "btnCutomer";
            btnCutomer.Size = new Size(200, 40);
            btnCutomer.TabIndex = 14;
            btnCutomer.Text = "Customer";
            btnCutomer.TextAlign = ContentAlignment.MiddleLeft;
            btnCutomer.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCutomer.UseVisualStyleBackColor = false;
            btnCutomer.Click += btnCutomer_Click;
            // 
            // MiniForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(836, 519);
            Controls.Add(pnlContent);
            Controls.Add(flpNav);
            Controls.Add(statusStrip1);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "MiniForm";
            Text = "MiniForm";
            Load += MiniForm_Load;
            pnlHeader.ResumeLayout(false);
            flpRight.ResumeLayout(false);
            flpRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbUser).EndInit();
            flpLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            flpNav.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.FlowLayoutPanel flpRight;
        private System.Windows.Forms.FlowLayoutPanel flpLeft;
        private System.Windows.Forms.PictureBox pbUser;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Panel flpNav;
        private System.Windows.Forms.Button btnSync;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnLogs;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private Button btnCutomer;
    }
}