
namespace Pharmacy
{
    partial class Selling
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Selling));
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtCustomerId1 = new System.Windows.Forms.TextBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.DGVMedicineList = new System.Windows.Forms.DataGridView();
            this.txtCustomerName = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtCustomerId = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.DGVTransactions = new System.Windows.Forms.DataGridView();
            this.LblTotal = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.DGVBill = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMedicine = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnManufacturer = new System.Windows.Forms.Button();
            this.btnMedicines = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnSelling = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSellers = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LblSellerName = new System.Windows.Forms.Label();
            this.PrintPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.PrintDocument = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMedicineList)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVBill)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(267, 147);
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(161, 32);
            this.txtPrice.TabIndex = 16;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(267, 87);
            this.txtQuantity.Multiline = true;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(161, 32);
            this.txtQuantity.TabIndex = 11;
            // 
            // txtCustomerId1
            // 
            this.txtCustomerId1.Location = new System.Drawing.Point(345, 448);
            this.txtCustomerId1.Name = "txtCustomerId1";
            this.txtCustomerId1.Size = new System.Drawing.Size(235, 32);
            this.txtCustomerId1.TabIndex = 9;
            this.txtCustomerId1.TextChanged += new System.EventHandler(this.txtCustomerId_SellectionChangedCommitted);
            this.txtCustomerId1.StyleChanged += new System.EventHandler(this.txtCustomerId_SellectionChangedCommitted);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(706, 251);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(179, 32);
            this.btnPrint.TabIndex = 8;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(142, 251);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(161, 30);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Add to Bill";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(263, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 23);
            this.label5.TabIndex = 3;
            this.label5.Text = "Quantity";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(371, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 23);
            this.label10.TabIndex = 37;
            this.label10.Text = "Sellings";
            // 
            // DGVMedicineList
            // 
            this.DGVMedicineList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.DGVMedicineList.BackgroundColor = System.Drawing.Color.White;
            this.DGVMedicineList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVMedicineList.GridColor = System.Drawing.SystemColors.ControlText;
            this.DGVMedicineList.Location = new System.Drawing.Point(3, 336);
            this.DGVMedicineList.Name = "DGVMedicineList";
            this.DGVMedicineList.RowHeadersWidth = 51;
            this.DGVMedicineList.RowTemplate.Height = 24;
            this.DGVMedicineList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVMedicineList.Size = new System.Drawing.Size(425, 314);
            this.DGVMedicineList.TabIndex = 14;
            this.DGVMedicineList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVMedicineList_CellContentClick);
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.FormattingEnabled = true;
            this.txtCustomerName.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.txtCustomerName.Location = new System.Drawing.Point(3, 148);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(235, 31);
            this.txtCustomerName.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1211, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 23);
            this.label8.TabIndex = 42;
            this.label8.Text = "X";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(263, 122);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 23);
            this.label11.TabIndex = 15;
            this.label11.Text = "Price";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.txtCustomerId);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.DGVTransactions);
            this.panel2.Controls.Add(this.LblTotal);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.DGVBill);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtMedicine);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtPrice);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.DGVMedicineList);
            this.panel2.Controls.Add(this.txtCustomerName);
            this.panel2.Controls.Add(this.txtQuantity);
            this.panel2.Controls.Add(this.txtCustomerId1);
            this.panel2.Controls.Add(this.btnPrint);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(368, 96);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(898, 662);
            this.panel2.TabIndex = 39;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.FormattingEnabled = true;
            this.txtCustomerId.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.txtCustomerId.Location = new System.Drawing.Point(0, 87);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.Size = new System.Drawing.Size(235, 31);
            this.txtCustomerId.TabIndex = 25;
            this.txtCustomerId.SelectionChangeCommitted += new System.EventHandler(this.txtCustomerId_SelectionChangeCommitted);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(604, 307);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(129, 23);
            this.label14.TabIndex = 24;
            this.label14.Text = "Transactions";
            // 
            // DGVTransactions
            // 
            this.DGVTransactions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.DGVTransactions.BackgroundColor = System.Drawing.Color.White;
            this.DGVTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVTransactions.GridColor = System.Drawing.SystemColors.ControlText;
            this.DGVTransactions.Location = new System.Drawing.Point(460, 333);
            this.DGVTransactions.Name = "DGVTransactions";
            this.DGVTransactions.RowHeadersWidth = 51;
            this.DGVTransactions.RowTemplate.Height = 24;
            this.DGVTransactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVTransactions.Size = new System.Drawing.Size(425, 311);
            this.DGVTransactions.TabIndex = 23;
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Location = new System.Drawing.Point(475, 260);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(105, 23);
            this.LblTotal.TabIndex = 22;
            this.LblTotal.Text = "Total in Rs";
            this.LblTotal.Click += new System.EventHandler(this.label13_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(655, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 23);
            this.label12.TabIndex = 21;
            this.label12.Text = "Bill";
            // 
            // DGVBill
            // 
            this.DGVBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.DGVBill.BackgroundColor = System.Drawing.Color.White;
            this.DGVBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVBill.GridColor = System.Drawing.SystemColors.ControlText;
            this.DGVBill.Location = new System.Drawing.Point(460, 48);
            this.DGVBill.Name = "DGVBill";
            this.DGVBill.RowHeadersWidth = 51;
            this.DGVBill.RowTemplate.Height = 24;
            this.DGVBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVBill.Size = new System.Drawing.Size(425, 197);
            this.DGVBill.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(150, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 23);
            this.label6.TabIndex = 19;
            this.label6.Text = "Medicine List";
            // 
            // txtMedicine
            // 
            this.txtMedicine.Location = new System.Drawing.Point(142, 219);
            this.txtMedicine.Multiline = true;
            this.txtMedicine.Name = "txtMedicine";
            this.txtMedicine.Size = new System.Drawing.Size(161, 32);
            this.txtMedicine.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 23);
            this.label3.TabIndex = 17;
            this.label3.Text = "Medicine";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(170, 23);
            this.label9.TabIndex = 5;
            this.label9.Text = "Customer Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Billing Module";
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.White;
            this.btnDashboard.Location = new System.Drawing.Point(3, 294);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(170, 58);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnManufacturer
            // 
            this.btnManufacturer.BackColor = System.Drawing.Color.White;
            this.btnManufacturer.Location = new System.Drawing.Point(3, 358);
            this.btnManufacturer.Name = "btnManufacturer";
            this.btnManufacturer.Size = new System.Drawing.Size(170, 58);
            this.btnManufacturer.TabIndex = 2;
            this.btnManufacturer.Text = "Manufacturer";
            this.btnManufacturer.UseVisualStyleBackColor = false;
            this.btnManufacturer.Click += new System.EventHandler(this.btnManufacturer_Click);
            // 
            // btnMedicines
            // 
            this.btnMedicines.BackColor = System.Drawing.Color.White;
            this.btnMedicines.Location = new System.Drawing.Point(3, 422);
            this.btnMedicines.Name = "btnMedicines";
            this.btnMedicines.Size = new System.Drawing.Size(170, 58);
            this.btnMedicines.TabIndex = 3;
            this.btnMedicines.Text = "Medicines";
            this.btnMedicines.UseVisualStyleBackColor = false;
            this.btnMedicines.Click += new System.EventHandler(this.btnMedicines_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.BackColor = System.Drawing.Color.White;
            this.btnCustomers.Location = new System.Drawing.Point(3, 486);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(170, 58);
            this.btnCustomers.TabIndex = 4;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.UseVisualStyleBackColor = false;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnSelling
            // 
            this.btnSelling.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSelling.Location = new System.Drawing.Point(3, 614);
            this.btnSelling.Name = "btnSelling";
            this.btnSelling.Size = new System.Drawing.Size(170, 58);
            this.btnSelling.TabIndex = 6;
            this.btnSelling.Text = "Selling";
            this.btnSelling.UseVisualStyleBackColor = false;
            this.btnSelling.Click += new System.EventHandler(this.btnSelling_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.Window;
            this.btnLogout.Location = new System.Drawing.Point(3, 678);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(170, 58);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel1.Controls.Add(this.btnDashboard);
            this.flowLayoutPanel1.Controls.Add(this.btnManufacturer);
            this.flowLayoutPanel1.Controls.Add(this.btnMedicines);
            this.flowLayoutPanel1.Controls.Add(this.btnCustomers);
            this.flowLayoutPanel1.Controls.Add(this.btnSellers);
            this.flowLayoutPanel1.Controls.Add(this.btnSelling);
            this.flowLayoutPanel1.Controls.Add(this.btnLogout);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(14, 10);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(348, 748);
            this.flowLayoutPanel1.TabIndex = 38;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pharmacy.Properties.Resources.IST_19117_00986;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(331, 285);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnSellers
            // 
            this.btnSellers.BackColor = System.Drawing.Color.White;
            this.btnSellers.Location = new System.Drawing.Point(3, 550);
            this.btnSellers.Name = "btnSellers";
            this.btnSellers.Size = new System.Drawing.Size(170, 58);
            this.btnSellers.TabIndex = 5;
            this.btnSellers.Text = "Sellers";
            this.btnSellers.UseVisualStyleBackColor = false;
            this.btnSellers.Click += new System.EventHandler(this.btnSellers_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(539, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 28);
            this.label4.TabIndex = 40;
            this.label4.Text = " ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(618, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(385, 28);
            this.label7.TabIndex = 41;
            this.label7.Text = "Pharmacy Management System";
            // 
            // LblSellerName
            // 
            this.LblSellerName.AutoSize = true;
            this.LblSellerName.Location = new System.Drawing.Point(1052, 13);
            this.LblSellerName.Name = "LblSellerName";
            this.LblSellerName.Size = new System.Drawing.Size(128, 23);
            this.LblSellerName.TabIndex = 43;
            this.LblSellerName.Text = "Seller Name";
            // 
            // PrintPreviewDialog
            // 
            this.PrintPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.PrintPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.PrintPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.PrintPreviewDialog.Document = this.PrintDocument;
            this.PrintPreviewDialog.Enabled = true;
            this.PrintPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("PrintPreviewDialog.Icon")));
            this.PrintPreviewDialog.Name = "PrintPreviewDialog";
            this.PrintPreviewDialog.Visible = false;
            // 
            // PrintDocument
            // 
            this.PrintDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument_PrintPage);
            // 
            // Selling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(1280, 768);
            this.Controls.Add(this.LblSellerName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Selling";
            this.Text = "Selling";
            ((System.ComponentModel.ISupportInitialize)(this.DGVMedicineList)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTransactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVBill)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView DGVMedicineList;
        private System.Windows.Forms.ComboBox txtCustomerName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnManufacturer;
        private System.Windows.Forms.Button btnMedicines;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnSelling;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnSellers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView DGVBill;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMedicine;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView DGVTransactions;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Label LblSellerName;
        private System.Windows.Forms.PrintPreviewDialog PrintPreviewDialog;
        private System.Drawing.Printing.PrintDocument PrintDocument;
        private System.Windows.Forms.TextBox txtCustomerId1;
        private System.Windows.Forms.ComboBox txtCustomerId;
    }
}