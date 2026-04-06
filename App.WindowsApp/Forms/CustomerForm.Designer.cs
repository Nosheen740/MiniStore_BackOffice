namespace App.WindowsApp.Forms
{
    partial class CustomerForm
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
            components = new System.ComponentModel.Container();
            tlpCutomer = new TableLayoutPanel();
            txtId = new TextBox();
            lblId = new Label();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            lblPhone = new Label();
            txtName = new TextBox();
            lblName = new Label();
            lblAddress = new Label();
            lblEmail = new Label();
            txtAddress = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            flpCustomer = new FlowLayoutPanel();
            btnSave = new Button();
            btnCancel = new Button();
            tlpCutomer.SuspendLayout();
            flpCustomer.SuspendLayout();
            SuspendLayout();
            // 
            // tlpCutomer
            // 
            tlpCutomer.ColumnCount = 2;
            tlpCutomer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.87179F));
            tlpCutomer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85.12821F));
            tlpCutomer.Controls.Add(txtId, 1, 4);
            tlpCutomer.Controls.Add(lblId, 0, 4);
            tlpCutomer.Controls.Add(txtEmail, 1, 2);
            tlpCutomer.Controls.Add(txtPhone, 1, 1);
            tlpCutomer.Controls.Add(lblPhone, 0, 1);
            tlpCutomer.Controls.Add(txtName, 1, 0);
            tlpCutomer.Controls.Add(lblName, 0, 0);
            tlpCutomer.Controls.Add(lblAddress, 0, 3);
            tlpCutomer.Controls.Add(lblEmail, 0, 2);
            tlpCutomer.Controls.Add(txtAddress, 1, 3);
            tlpCutomer.Dock = DockStyle.Top;
            tlpCutomer.Location = new Point(0, 0);
            tlpCutomer.Name = "tlpCutomer";
            tlpCutomer.RowCount = 5;
            tlpCutomer.RowStyles.Add(new RowStyle(SizeType.Percent, 14.7392063F));
            tlpCutomer.RowStyles.Add(new RowStyle(SizeType.Percent, 14.7392054F));
            tlpCutomer.RowStyles.Add(new RowStyle(SizeType.Percent, 14.7392054F));
            tlpCutomer.RowStyles.Add(new RowStyle(SizeType.Percent, 41.04237F));
            tlpCutomer.RowStyles.Add(new RowStyle(SizeType.Percent, 14.7400122F));
            tlpCutomer.Size = new Size(585, 175);
            tlpCutomer.TabIndex = 0;
            tlpCutomer.Paint += tlpCutomer_Paint;
            // 
            // txtId
            // 
            txtId.Dock = DockStyle.Fill;
            txtId.Location = new Point(89, 149);
            txtId.Name = "txtId";
            txtId.Size = new Size(493, 23);
            txtId.TabIndex = 4;
            txtId.TextChanged += txtId_TextChanged_1;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Dock = DockStyle.Fill;
            lblId.Location = new Point(3, 146);
            lblId.Name = "lblId";
            lblId.Size = new Size(80, 29);
            lblId.TabIndex = 4;
            lblId.Text = "Id";
            // 
            // txtEmail
            // 
            txtEmail.Dock = DockStyle.Fill;
            txtEmail.Location = new Point(89, 53);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(493, 23);
            txtEmail.TabIndex = 8;
            // 
            // txtPhone
            // 
            txtPhone.Dock = DockStyle.Fill;
            txtPhone.Location = new Point(89, 28);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(493, 23);
            txtPhone.TabIndex = 3;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Dock = DockStyle.Fill;
            lblPhone.Location = new Point(3, 25);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(80, 25);
            lblPhone.TabIndex = 4;
            lblPhone.Text = "Phone";
            // 
            // txtName
            // 
            txtName.Dock = DockStyle.Fill;
            txtName.Location = new Point(89, 3);
            txtName.Name = "txtName";
            txtName.Size = new Size(493, 23);
            txtName.TabIndex = 3;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Dock = DockStyle.Fill;
            lblName.Location = new Point(3, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(80, 25);
            lblName.TabIndex = 1;
            lblName.Text = "Name";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Dock = DockStyle.Fill;
            lblAddress.Location = new Point(3, 75);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(80, 71);
            lblAddress.TabIndex = 7;
            lblAddress.Text = "Address";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Dock = DockStyle.Fill;
            lblEmail.Location = new Point(3, 50);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(80, 25);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "Email";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(89, 78);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.ScrollBars = ScrollBars.Vertical;
            txtAddress.Size = new Size(492, 65);
            txtAddress.TabIndex = 9;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // flpCustomer
            // 
            flpCustomer.Controls.Add(btnSave);
            flpCustomer.Controls.Add(btnCancel);
            flpCustomer.Dock = DockStyle.Bottom;
            flpCustomer.FlowDirection = FlowDirection.RightToLeft;
            flpCustomer.Location = new Point(0, 279);
            flpCustomer.Name = "flpCustomer";
            flpCustomer.Size = new Size(585, 53);
            flpCustomer.TabIndex = 3;
            // 
            // btnSave
            // 
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Image = Properties.Resources.Save;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(484, 9);
            btnSave.Margin = new Padding(9);
            btnSave.Name = "btnSave";
            btnSave.Padding = new Padding(3);
            btnSave.Size = new Size(92, 40);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.Image = Properties.Resources.cancel;
            btnCancel.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancel.Location = new Point(374, 9);
            btnCancel.Margin = new Padding(9);
            btnCancel.Name = "btnCancel";
            btnCancel.Padding = new Padding(3);
            btnCancel.Size = new Size(92, 40);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(585, 332);
            Controls.Add(flpCustomer);
            Controls.Add(tlpCutomer);
            Name = "CustomerForm";
            Load += CustomerForm_Load;
            tlpCutomer.ResumeLayout(false);
            tlpCutomer.PerformLayout();
            flpCustomer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpCutomer;
        private TextBox txtName;
        private Label lblName;
        private ContextMenuStrip contextMenuStrip1;
        private Label lblEmail;
        private Label lblPhone;
        private Label lblAddress;
        private TextBox txtAddress;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private FlowLayoutPanel flpCustomer;
        private Button btnSave;
        private Button btnCancel;
        private TextBox txtId;
        private Label lblId;
    }
}