namespace BookStoreView
{
    partial class OrderCreationForm
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
            this.customerLabel = new System.Windows.Forms.Label();
            this.customerComboBox = new System.Windows.Forms.ComboBox();
            this.booksGridView = new System.Windows.Forms.DataGridView();
            this.componentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookTitleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookAuthorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookCountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.booksLabel = new System.Windows.Forms.Label();
            this.addBookButton = new System.Windows.Forms.Button();
            this.updateBookButton = new System.Windows.Forms.Button();
            this.deleteBookButton = new System.Windows.Forms.Button();
            this.refreshBooksButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.booksGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // customerLabel
            // 
            this.customerLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customerLabel.Location = new System.Drawing.Point(12, 9);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(163, 30);
            this.customerLabel.TabIndex = 8;
            this.customerLabel.Text = "Customer:";
            this.customerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // customerComboBox
            // 
            this.customerComboBox.FormattingEnabled = true;
            this.customerComboBox.Location = new System.Drawing.Point(12, 42);
            this.customerComboBox.Name = "customerComboBox";
            this.customerComboBox.Size = new System.Drawing.Size(332, 27);
            this.customerComboBox.TabIndex = 9;
            // 
            // booksGridView
            // 
            this.booksGridView.AllowUserToAddRows = false;
            this.booksGridView.AllowUserToDeleteRows = false;
            this.booksGridView.AllowUserToResizeRows = false;
            this.booksGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.booksGridView.BackgroundColor = System.Drawing.Color.White;
            this.booksGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.booksGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.componentID,
            this.bookTitleColumn,
            this.bookAuthorColumn,
            this.bookCountColumn});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.booksGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.booksGridView.Location = new System.Drawing.Point(12, 156);
            this.booksGridView.MultiSelect = false;
            this.booksGridView.Name = "booksGridView";
            this.booksGridView.ReadOnly = true;
            this.booksGridView.Size = new System.Drawing.Size(670, 250);
            this.booksGridView.TabIndex = 10;
            // 
            // componentID
            // 
            this.componentID.HeaderText = "ID";
            this.componentID.Name = "componentID";
            this.componentID.ReadOnly = true;
            this.componentID.Visible = false;
            // 
            // bookTitleColumn
            // 
            this.bookTitleColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bookTitleColumn.FillWeight = 80F;
            this.bookTitleColumn.HeaderText = "Title";
            this.bookTitleColumn.Name = "bookTitleColumn";
            this.bookTitleColumn.ReadOnly = true;
            // 
            // bookAuthorColumn
            // 
            this.bookAuthorColumn.HeaderText = "Author";
            this.bookAuthorColumn.Name = "bookAuthorColumn";
            this.bookAuthorColumn.ReadOnly = true;
            // 
            // bookCountColumn
            // 
            this.bookCountColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bookCountColumn.FillWeight = 20F;
            this.bookCountColumn.HeaderText = "Count";
            this.bookCountColumn.Name = "bookCountColumn";
            this.bookCountColumn.ReadOnly = true;
            // 
            // booksLabel
            // 
            this.booksLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.booksLabel.Location = new System.Drawing.Point(12, 72);
            this.booksLabel.Name = "booksLabel";
            this.booksLabel.Size = new System.Drawing.Size(163, 30);
            this.booksLabel.TabIndex = 15;
            this.booksLabel.Text = "Books:";
            this.booksLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // addBookButton
            // 
            this.addBookButton.BackColor = System.Drawing.Color.White;
            this.addBookButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.addBookButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.addBookButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBookButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addBookButton.Location = new System.Drawing.Point(12, 103);
            this.addBookButton.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.addBookButton.Name = "addBookButton";
            this.addBookButton.Size = new System.Drawing.Size(163, 40);
            this.addBookButton.TabIndex = 11;
            this.addBookButton.Text = "Add";
            this.addBookButton.UseVisualStyleBackColor = false;
            this.addBookButton.Click += new System.EventHandler(this.AddComponentButton_Click);
            // 
            // updateBookButton
            // 
            this.updateBookButton.BackColor = System.Drawing.Color.White;
            this.updateBookButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.updateBookButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.updateBookButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBookButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateBookButton.Location = new System.Drawing.Point(181, 103);
            this.updateBookButton.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.updateBookButton.Name = "updateBookButton";
            this.updateBookButton.Size = new System.Drawing.Size(163, 40);
            this.updateBookButton.TabIndex = 12;
            this.updateBookButton.Text = "Update";
            this.updateBookButton.UseVisualStyleBackColor = false;
            this.updateBookButton.Click += new System.EventHandler(this.UpdateComponentButton_Click);
            // 
            // deleteBookButton
            // 
            this.deleteBookButton.BackColor = System.Drawing.Color.White;
            this.deleteBookButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.deleteBookButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.deleteBookButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBookButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteBookButton.Location = new System.Drawing.Point(350, 103);
            this.deleteBookButton.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.deleteBookButton.Name = "deleteBookButton";
            this.deleteBookButton.Size = new System.Drawing.Size(163, 40);
            this.deleteBookButton.TabIndex = 13;
            this.deleteBookButton.Text = "Delete";
            this.deleteBookButton.UseVisualStyleBackColor = false;
            this.deleteBookButton.Click += new System.EventHandler(this.DeleteComponentButton_Click);
            // 
            // refreshBooksButton
            // 
            this.refreshBooksButton.BackColor = System.Drawing.Color.White;
            this.refreshBooksButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.refreshBooksButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.refreshBooksButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshBooksButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.refreshBooksButton.Location = new System.Drawing.Point(519, 103);
            this.refreshBooksButton.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.refreshBooksButton.Name = "refreshBooksButton";
            this.refreshBooksButton.Size = new System.Drawing.Size(163, 40);
            this.refreshBooksButton.TabIndex = 14;
            this.refreshBooksButton.Text = "Refresh list";
            this.refreshBooksButton.UseVisualStyleBackColor = false;
            this.refreshBooksButton.Click += new System.EventHandler(this.RefreshComponentsButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.White;
            this.cancelButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.cancelButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelButton.Location = new System.Drawing.Point(350, 419);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(332, 40);
            this.cancelButton.TabIndex = 17;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.СancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.White;
            this.saveButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.saveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.Location = new System.Drawing.Point(12, 419);
            this.saveButton.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(332, 40);
            this.saveButton.TabIndex = 16;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // OrderCreationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(694, 471);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.booksLabel);
            this.Controls.Add(this.addBookButton);
            this.Controls.Add(this.updateBookButton);
            this.Controls.Add(this.deleteBookButton);
            this.Controls.Add(this.refreshBooksButton);
            this.Controls.Add(this.booksGridView);
            this.Controls.Add(this.customerComboBox);
            this.Controls.Add(this.customerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "OrderCreationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New order";
            this.Load += new System.EventHandler(this.OrderCreationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.booksGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.ComboBox customerComboBox;
        private System.Windows.Forms.DataGridView booksGridView;
        private System.Windows.Forms.Label booksLabel;
        private System.Windows.Forms.Button addBookButton;
        private System.Windows.Forms.Button updateBookButton;
        private System.Windows.Forms.Button deleteBookButton;
        private System.Windows.Forms.Button refreshBooksButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn componentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookTitleColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookAuthorColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookCountColumn;
    }
}