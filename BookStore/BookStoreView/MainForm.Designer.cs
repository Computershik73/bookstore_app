namespace BookStoreView
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.addressesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.warehousesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.booksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.authorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.publishingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshOrdersButton = new System.Windows.Forms.Button();
            this.getPaidButton = new System.Windows.Forms.Button();
            this.completeButton = new System.Windows.Forms.Button();
            this.startPreparingButton = new System.Windows.Forms.Button();
            this.confirmButton = new System.Windows.Forms.Button();
            this.ordersGridView = new System.Windows.Forms.DataGridView();
            this.createButton = new System.Windows.Forms.Button();
            this.mainMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.BackColor = System.Drawing.Color.Transparent;
            this.mainMenuStrip.Dock = System.Windows.Forms.DockStyle.Left;
            this.mainMenuStrip.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addressesToolStripMenuItem,
            this.warehousesToolStripMenuItem,
            this.booksToolStripMenuItem,
            this.authorsToolStripMenuItem,
            this.publishingsToolStripMenuItem,
            this.customersToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mainMenuStrip.Size = new System.Drawing.Size(113, 492);
            this.mainMenuStrip.TabIndex = 1;
            this.mainMenuStrip.Text = "mainMenuStrip";
            // 
            // addressesToolStripMenuItem
            // 
            this.addressesToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.addressesToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 10, 0, 5);
            this.addressesToolStripMenuItem.Name = "addressesToolStripMenuItem";
            this.addressesToolStripMenuItem.Size = new System.Drawing.Size(100, 25);
            this.addressesToolStripMenuItem.Text = "Addresses";
            this.addressesToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addressesToolStripMenuItem.Click += new System.EventHandler(this.AddressesToolStripMenuItem_Click);
            // 
            // warehousesToolStripMenuItem
            // 
            this.warehousesToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.warehousesToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.warehousesToolStripMenuItem.Name = "warehousesToolStripMenuItem";
            this.warehousesToolStripMenuItem.Size = new System.Drawing.Size(100, 25);
            this.warehousesToolStripMenuItem.Text = "Warehouses";
            this.warehousesToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.warehousesToolStripMenuItem.Click += new System.EventHandler(this.WarehousesToolStripMenuItem_Click);
            // 
            // booksToolStripMenuItem
            // 
            this.booksToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            this.booksToolStripMenuItem.Size = new System.Drawing.Size(100, 25);
            this.booksToolStripMenuItem.Text = "Books";
            this.booksToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.booksToolStripMenuItem.Click += new System.EventHandler(this.BooksToolStripMenuItem_Click);
            // 
            // authorsToolStripMenuItem
            // 
            this.authorsToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.authorsToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.authorsToolStripMenuItem.Name = "authorsToolStripMenuItem";
            this.authorsToolStripMenuItem.Size = new System.Drawing.Size(100, 25);
            this.authorsToolStripMenuItem.Text = "Authors";
            this.authorsToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.authorsToolStripMenuItem.Click += new System.EventHandler(this.AuthorsToolStripMenuItem_Click);
            // 
            // publishingsToolStripMenuItem
            // 
            this.publishingsToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.publishingsToolStripMenuItem.Name = "publishingsToolStripMenuItem";
            this.publishingsToolStripMenuItem.Size = new System.Drawing.Size(100, 25);
            this.publishingsToolStripMenuItem.Text = "Publishings";
            this.publishingsToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.publishingsToolStripMenuItem.Click += new System.EventHandler(this.PublishingsToolStripMenuItem_Click);
            // 
            // customersToolStripMenuItem
            // 
            this.customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            this.customersToolStripMenuItem.Size = new System.Drawing.Size(100, 25);
            this.customersToolStripMenuItem.Text = "Customers";
            this.customersToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customersToolStripMenuItem.Click += new System.EventHandler(this.CustomersToolStripMenuItem_Click);
            // 
            // refreshOrdersButton
            // 
            this.refreshOrdersButton.BackColor = System.Drawing.Color.White;
            this.refreshOrdersButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.refreshOrdersButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.refreshOrdersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshOrdersButton.Location = new System.Drawing.Point(1109, 242);
            this.refreshOrdersButton.Name = "refreshOrdersButton";
            this.refreshOrdersButton.Size = new System.Drawing.Size(163, 40);
            this.refreshOrdersButton.TabIndex = 11;
            this.refreshOrdersButton.Text = "Refresh list";
            this.refreshOrdersButton.UseVisualStyleBackColor = false;
            this.refreshOrdersButton.Click += new System.EventHandler(this.RefreshOrdersButton_Click);
            // 
            // getPaidButton
            // 
            this.getPaidButton.BackColor = System.Drawing.Color.White;
            this.getPaidButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.getPaidButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.getPaidButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getPaidButton.Location = new System.Drawing.Point(1109, 196);
            this.getPaidButton.Name = "getPaidButton";
            this.getPaidButton.Size = new System.Drawing.Size(163, 40);
            this.getPaidButton.TabIndex = 10;
            this.getPaidButton.Text = "Paid";
            this.getPaidButton.UseVisualStyleBackColor = false;
            this.getPaidButton.Click += new System.EventHandler(this.GetPaidButton_Click);
            // 
            // completeButton
            // 
            this.completeButton.BackColor = System.Drawing.Color.White;
            this.completeButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.completeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.completeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.completeButton.Location = new System.Drawing.Point(1109, 150);
            this.completeButton.Name = "completeButton";
            this.completeButton.Size = new System.Drawing.Size(163, 40);
            this.completeButton.TabIndex = 9;
            this.completeButton.Text = "Complete";
            this.completeButton.UseVisualStyleBackColor = false;
            this.completeButton.Click += new System.EventHandler(this.CompleteButton_Click);
            // 
            // startPreparingButton
            // 
            this.startPreparingButton.BackColor = System.Drawing.Color.White;
            this.startPreparingButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.startPreparingButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.startPreparingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startPreparingButton.Location = new System.Drawing.Point(1109, 104);
            this.startPreparingButton.Name = "startPreparingButton";
            this.startPreparingButton.Size = new System.Drawing.Size(163, 40);
            this.startPreparingButton.TabIndex = 7;
            this.startPreparingButton.Text = "Start Processing";
            this.startPreparingButton.UseVisualStyleBackColor = false;
            this.startPreparingButton.Click += new System.EventHandler(this.StartPreparingButton_Click);
            // 
            // confirmButton
            // 
            this.confirmButton.BackColor = System.Drawing.Color.White;
            this.confirmButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.confirmButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.confirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmButton.Location = new System.Drawing.Point(1109, 58);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(163, 40);
            this.confirmButton.TabIndex = 8;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = false;
            this.confirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // ordersGridView
            // 
            this.ordersGridView.AllowUserToAddRows = false;
            this.ordersGridView.AllowUserToDeleteRows = false;
            this.ordersGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.ordersGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ordersGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ordersGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ordersGridView.BackgroundColor = System.Drawing.Color.White;
            this.ordersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ordersGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.ordersGridView.Location = new System.Drawing.Point(144, 12);
            this.ordersGridView.MultiSelect = false;
            this.ordersGridView.Name = "ordersGridView";
            this.ordersGridView.Size = new System.Drawing.Size(959, 468);
            this.ordersGridView.TabIndex = 6;
            // 
            // createButton
            // 
            this.createButton.BackColor = System.Drawing.Color.White;
            this.createButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.createButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.createButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createButton.Location = new System.Drawing.Point(1109, 12);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(163, 40);
            this.createButton.TabIndex = 12;
            this.createButton.Text = "New order";
            this.createButton.UseVisualStyleBackColor = false;
            this.createButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1284, 492);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.refreshOrdersButton);
            this.Controls.Add(this.getPaidButton);
            this.Controls.Add(this.completeButton);
            this.Controls.Add(this.startPreparingButton);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.ordersGridView);
            this.Controls.Add(this.mainMenuStrip);
            this.Font = new System.Drawing.Font("Segoe UI", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mainMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book Store";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem booksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem warehousesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addressesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem authorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem publishingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customersToolStripMenuItem;
        private System.Windows.Forms.Button refreshOrdersButton;
        private System.Windows.Forms.Button getPaidButton;
        private System.Windows.Forms.Button completeButton;
        private System.Windows.Forms.Button startPreparingButton;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.DataGridView ordersGridView;
        private System.Windows.Forms.Button createButton;
    }
}