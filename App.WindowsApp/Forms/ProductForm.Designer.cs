namespace App.WindowsApp.Forms
{
    partial class ProductForm
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
            tlpProductForm = new TableLayoutPanel();
            lblPrice = new Label();
            lblStack = new Label();
            lblStatus = new Label();
            lblID = new Label();
            txtName = new TextBox();
            nuPrice = new NumericUpDown();
            cmbProductStatus = new ComboBox();
            txtId = new TextBox();
            nuStock = new NumericUpDown();
            lblName = new Label();
            lblCategory = new Label();
            cmbCategory = new ComboBox();
            flpProductForm = new FlowLayoutPanel();
            btnCancel = new Button();
            btnSave = new Button();
            flpProduct = new FlowLayoutPanel();
            pnlProduct = new Panel();
            tlpProductForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nuPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nuStock).BeginInit();
            flpProduct.SuspendLayout();
            pnlProduct.SuspendLayout();
            SuspendLayout();
            // 
            // tlpProductForm
            // 
            tlpProductForm.ColumnCount = 2;
            tlpProductForm.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 74F));
            tlpProductForm.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 26F));
            tlpProductForm.Controls.Add(lblPrice, 0, 2);
            tlpProductForm.Controls.Add(lblStack, 0, 3);
            tlpProductForm.Controls.Add(lblStatus, 0, 4);
            tlpProductForm.Controls.Add(lblID, 0, 5);
            tlpProductForm.Controls.Add(txtName, 1, 0);
            tlpProductForm.Controls.Add(nuPrice, 1, 2);
            tlpProductForm.Controls.Add(cmbProductStatus, 1, 4);
            tlpProductForm.Controls.Add(txtId, 1, 5);
            tlpProductForm.Controls.Add(nuStock, 1, 3);
            tlpProductForm.Controls.Add(lblName, 0, 0);
            tlpProductForm.Controls.Add(lblCategory, 0, 1);
            tlpProductForm.Controls.Add(cmbCategory, 1, 1);
            tlpProductForm.Location = new Point(12, 12);
            tlpProductForm.Name = "tlpProductForm";
            tlpProductForm.RowCount = 6;
            tlpProductForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tlpProductForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            tlpProductForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            tlpProductForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpProductForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpProductForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 149F));
            tlpProductForm.Size = new Size(538, 183);
            tlpProductForm.TabIndex = 0;
            tlpProductForm.Paint += tableLayoutPanel1_Paint;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Dock = DockStyle.Fill;
            lblPrice.Location = new Point(3, 60);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(68, 31);
            lblPrice.TabIndex = 2;
            lblPrice.Text = "Price";
            // 
            // lblStack
            // 
            lblStack.AutoSize = true;
            lblStack.Dock = DockStyle.Fill;
            lblStack.Location = new Point(3, 91);
            lblStack.Name = "lblStack";
            lblStack.Size = new Size(68, 30);
            lblStack.TabIndex = 3;
            lblStack.Text = "Stock";
            lblStack.Click += label4_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Dock = DockStyle.Fill;
            lblStatus.Location = new Point(3, 121);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(68, 30);
            lblStatus.TabIndex = 4;
            lblStatus.Text = "Status";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Dock = DockStyle.Top;
            lblID.Location = new Point(3, 151);
            lblID.Name = "lblID";
            lblID.Size = new Size(68, 15);
            lblID.TabIndex = 5;
            lblID.Text = "ID";
            // 
            // txtName
            // 
            txtName.Dock = DockStyle.Fill;
            txtName.Location = new Point(77, 3);
            txtName.Name = "txtName";
            txtName.Size = new Size(458, 23);
            txtName.TabIndex = 6;
            // 
            // nuPrice
            // 
            nuPrice.Dock = DockStyle.Fill;
            nuPrice.Location = new Point(77, 63);
            nuPrice.Name = "nuPrice";
            nuPrice.Size = new Size(458, 23);
            nuPrice.TabIndex = 8;
            // 
            // cmbProductStatus
            // 
            cmbProductStatus.Dock = DockStyle.Fill;
            cmbProductStatus.FormattingEnabled = true;
            cmbProductStatus.Location = new Point(77, 124);
            cmbProductStatus.Name = "cmbProductStatus";
            cmbProductStatus.Size = new Size(458, 23);
            cmbProductStatus.TabIndex = 9;
            // 
            // txtId
            // 
            txtId.Dock = DockStyle.Fill;
            txtId.Location = new Point(77, 154);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(458, 23);
            txtId.TabIndex = 10;
            // 
            // nuStock
            // 
            nuStock.Dock = DockStyle.Fill;
            nuStock.Location = new Point(77, 94);
            nuStock.Name = "nuStock";
            nuStock.Size = new Size(458, 23);
            nuStock.TabIndex = 11;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Dock = DockStyle.Fill;
            lblName.Location = new Point(3, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(68, 29);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            lblName.Click += label1_Click;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Dock = DockStyle.Fill;
            lblCategory.Location = new Point(3, 29);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(68, 31);
            lblCategory.TabIndex = 1;
            lblCategory.Text = "Category";
            lblCategory.Click += lblCategory_Click;
            // 
            // cmbCategory
            // 
            cmbCategory.Dock = DockStyle.Fill;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(77, 32);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(458, 23);
            cmbCategory.TabIndex = 7;
            // 
            // flpProductForm
            // 
            flpProductForm.AutoSize = true;
            flpProductForm.BackColor = Color.White;
            flpProductForm.Dock = DockStyle.Bottom;
            flpProductForm.Location = new Point(0, 323);
            flpProductForm.Name = "flpProductForm";
            flpProductForm.RightToLeft = RightToLeft.Yes;
            flpProductForm.Size = new Size(566, 0);
            flpProductForm.TabIndex = 1;
            // 
            // btnCancel
            // 
            btnCancel.AutoSize = true;
            btnCancel.BackColor = Color.White;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancel.Location = new Point(391, 3);
            btnCancel.Margin = new Padding(10, 3, 3, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(138, 37);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSave.BackColor = Color.White;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(248, 1);
            btnSave.Margin = new Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.Padding = new Padding(5, 0, 5, 0);
            btnSave.RightToLeft = RightToLeft.No;
            btnSave.Size = new Size(129, 40);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // flpProduct
            // 
            flpProduct.Controls.Add(pnlProduct);
            flpProduct.Location = new Point(12, 268);
            flpProduct.Name = "flpProduct";
            flpProduct.Size = new Size(535, 49);
            flpProduct.TabIndex = 4;
            // 
            // pnlProduct
            // 
            pnlProduct.Controls.Add(btnCancel);
            pnlProduct.Controls.Add(btnSave);
            pnlProduct.Location = new Point(3, 3);
            pnlProduct.Name = "pnlProduct";
            pnlProduct.Size = new Size(532, 44);
            pnlProduct.TabIndex = 0;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(566, 323);
            Controls.Add(flpProduct);
            Controls.Add(flpProductForm);
            Controls.Add(tlpProductForm);
            Name = "ProductForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ProductForm";
            Load += ProductForm_Load;
            tlpProductForm.ResumeLayout(false);
            tlpProductForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nuPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)nuStock).EndInit();
            flpProduct.ResumeLayout(false);
            pnlProduct.ResumeLayout(false);
            pnlProduct.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tlpProductForm;
        private Label lblName;
        private Label lblCategory;
        private Label lblStack;
        private Label lblPrice;
        private Label l;
        private Label lblID;
        private TextBox txtName;
        private ComboBox cmbCategory;
        private NumericUpDown nuPrice;
        private ComboBox cmbProductStatus;
        private TextBox txtId;
        private Label lblStatus;
        private FlowLayoutPanel flpProductForm;
        private NumericUpDown nuStock;
        private Button btnSave;
        private Button btnCancel;
        private FlowLayoutPanel flpProduct;
        private Panel pnlProduct;
    }
}