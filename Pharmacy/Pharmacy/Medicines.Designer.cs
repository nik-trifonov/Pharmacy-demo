
namespace Pharmacy
{
    partial class Medicines
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
            this.DGVMedicines = new System.Windows.Forms.DataGridView();
            this.txtMedicineName = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtManufacturerName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtManufacturerId = new System.Windows.Forms.ComboBox();
            this.txtMedicineType = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnManufacturer = new System.Windows.Forms.Button();
            this.btnMedicines = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnSellers = new System.Windows.Forms.Button();
            this.btnSelling = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMedicines)).BeginInit();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVMedicines
            // 
            this.DGVMedicines.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.DGVMedicines.BackgroundColor = System.Drawing.Color.White;
            this.DGVMedicines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVMedicines.GridColor = System.Drawing.SystemColors.ControlText;
            this.DGVMedicines.Location = new System.Drawing.Point(0, 255);
            this.DGVMedicines.Name = "DGVMedicines";
            this.DGVMedicines.RowHeadersWidth = 51;
            this.DGVMedicines.RowTemplate.Height = 24;
            this.DGVMedicines.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVMedicines.Size = new System.Drawing.Size(867, 375);
            this.DGVMedicines.TabIndex = 14;
            this.DGVMedicines.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVMedicines_CellContentClick);
            // 
            // txtMedicineName
            // 
            this.txtMedicineName.Location = new System.Drawing.Point(0, 141);
            this.txtMedicineName.Name = "txtMedicineName";
            this.txtMedicineName.Size = new System.Drawing.Size(177, 32);
            this.txtMedicineName.TabIndex = 9;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(537, 191);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(179, 58);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(317, 191);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(179, 58);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(96, 191);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(179, 58);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(704, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(206, 23);
            this.label6.TabIndex = 4;
            this.label6.Text = "Manufacturer Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(346, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 23);
            this.label5.TabIndex = 3;
            this.label5.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Medicine Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Medicine Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Medicine Details";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.txtManufacturerName);
            this.panel2.Controls.Add(this.txtPrice);
            this.panel2.Controls.Add(this.txtQuantity);
            this.panel2.Controls.Add(this.txtManufacturerId);
            this.panel2.Controls.Add(this.txtMedicineType);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.DGVMedicines);
            this.panel2.Controls.Add(this.txtMedicineName);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(347, 89);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(910, 633);
            this.panel2.TabIndex = 27;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // txtManufacturerName
            // 
            this.txtManufacturerName.Location = new System.Drawing.Point(708, 140);
            this.txtManufacturerName.Name = "txtManufacturerName";
            this.txtManufacturerName.Size = new System.Drawing.Size(176, 32);
            this.txtManufacturerName.TabIndex = 21;
            this.txtManufacturerName.TextChanged += new System.EventHandler(this.txtManufacturerName_TextChanged);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(447, 140);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(74, 32);
            this.txtPrice.TabIndex = 20;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(350, 140);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(74, 32);
            this.txtQuantity.TabIndex = 19;
            // 
            // txtManufacturerId
            // 
            this.txtManufacturerId.FormattingEnabled = true;
            this.txtManufacturerId.Location = new System.Drawing.Point(541, 142);
            this.txtManufacturerId.Name = "txtManufacturerId";
            this.txtManufacturerId.Size = new System.Drawing.Size(142, 31);
            this.txtManufacturerId.TabIndex = 18;
            this.txtManufacturerId.SelectedIndexChanged += new System.EventHandler(this.txtManufacturerId_SelectedIndexChanged);
            this.txtManufacturerId.SelectionChangeCommitted += new System.EventHandler(this.txtManufacturerId_SelectionChangeCommitted);
            // 
            // txtMedicineType
            // 
            this.txtMedicineType.FormattingEnabled = true;
            this.txtMedicineType.Items.AddRange(new object[] {
            "Capsule",
            "Pain Killer",
            "Tablets"});
            this.txtMedicineType.Location = new System.Drawing.Point(188, 141);
            this.txtMedicineType.Name = "txtMedicineType";
            this.txtMedicineType.Size = new System.Drawing.Size(121, 31);
            this.txtMedicineType.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(533, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(165, 23);
            this.label10.TabIndex = 16;
            this.label10.Text = "Manufacturer Id";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(457, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 23);
            this.label9.TabIndex = 15;
            this.label9.Text = "Rate";
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
            this.flowLayoutPanel1.Location = new System.Drawing.Point(5, -14);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(336, 748);
            this.flowLayoutPanel1.TabIndex = 26;
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
            this.btnMedicines.BackColor = System.Drawing.Color.LimeGreen;
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
            this.btnCustomers.BackColor = System.Drawing.SystemColors.Window;
            this.btnCustomers.Location = new System.Drawing.Point(3, 486);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(170, 58);
            this.btnCustomers.TabIndex = 4;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.UseVisualStyleBackColor = false;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnSellers
            // 
            this.btnSellers.BackColor = System.Drawing.SystemColors.Window;
            this.btnSellers.Location = new System.Drawing.Point(3, 550);
            this.btnSellers.Name = "btnSellers";
            this.btnSellers.Size = new System.Drawing.Size(170, 58);
            this.btnSellers.TabIndex = 5;
            this.btnSellers.Text = "Sellers";
            this.btnSellers.UseVisualStyleBackColor = false;
            this.btnSellers.Click += new System.EventHandler(this.btnSellers_Click);
            // 
            // btnSelling
            // 
            this.btnSelling.BackColor = System.Drawing.SystemColors.Window;
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1226, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 23);
            this.label8.TabIndex = 30;
            this.label8.Text = "X";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(572, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(385, 28);
            this.label7.TabIndex = 29;
            this.label7.Text = "Pharmacy Management System";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(530, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 28);
            this.label4.TabIndex = 28;
            this.label4.Text = " ";
            // 
            // Medicines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(1262, 721);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Medicines";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Medicines";
            ((System.ComponentModel.ISupportInitialize)(this.DGVMedicines)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVMedicines;
        private System.Windows.Forms.TextBox txtMedicineName;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnManufacturer;
        private System.Windows.Forms.Button btnMedicines;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnSellers;
        private System.Windows.Forms.Button btnSelling;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox txtManufacturerId;
        private System.Windows.Forms.ComboBox txtMedicineType;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtManufacturerName;
    }
}