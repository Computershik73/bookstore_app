namespace BookStoreView
{
    partial class BookCreationForm
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
            this.createButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.authorLabel = new System.Windows.Forms.Label();
            this.genreLabel = new System.Windows.Forms.Label();
            this.authorComboBox = new System.Windows.Forms.ComboBox();
            this.genrePanel = new System.Windows.Forms.Panel();
            this.genreTextBox = new System.Windows.Forms.TextBox();
            this.publishingLabel = new System.Windows.Forms.Label();
            this.publishingComboBox = new System.Windows.Forms.ComboBox();
            this.yearLabel = new System.Windows.Forms.Label();
            this.yearPanel = new System.Windows.Forms.Panel();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.costLabel = new System.Windows.Forms.Label();
            this.costPanel = new System.Windows.Forms.Panel();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.pricePanel = new System.Windows.Forms.Panel();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.titlePanel.SuspendLayout();
            this.genrePanel.SuspendLayout();
            this.yearPanel.SuspendLayout();
            this.costPanel.SuspendLayout();
            this.pricePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // createButton
            // 
            this.createButton.BackColor = System.Drawing.Color.White;
            this.createButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.createButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.createButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createButton.Location = new System.Drawing.Point(12, 521);
            this.createButton.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(163, 40);
            this.createButton.TabIndex = 2;
            this.createButton.Text = "Save";
            this.createButton.UseVisualStyleBackColor = false;
            this.createButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.White;
            this.cancelButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.cancelButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelButton.Location = new System.Drawing.Point(181, 521);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(163, 40);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // titleTextBox
            // 
            this.titleTextBox.BackColor = System.Drawing.Color.White;
            this.titleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.titleTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleTextBox.Location = new System.Drawing.Point(9, 7);
            this.titleTextBox.Margin = new System.Windows.Forms.Padding(9, 7, 9, 9);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(312, 22);
            this.titleTextBox.TabIndex = 1;
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleLabel.Location = new System.Drawing.Point(12, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(163, 30);
            this.titleLabel.TabIndex = 4;
            this.titleLabel.Text = "Title:";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // titlePanel
            // 
            this.titlePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.titlePanel.Controls.Add(this.titleTextBox);
            this.titlePanel.Location = new System.Drawing.Point(12, 42);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(332, 40);
            this.titlePanel.TabIndex = 5;
            // 
            // authorLabel
            // 
            this.authorLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authorLabel.Location = new System.Drawing.Point(12, 85);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(163, 30);
            this.authorLabel.TabIndex = 6;
            this.authorLabel.Text = "Author:";
            this.authorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // genreLabel
            // 
            this.genreLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.genreLabel.Location = new System.Drawing.Point(12, 148);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(163, 30);
            this.genreLabel.TabIndex = 7;
            this.genreLabel.Text = "Genre:";
            this.genreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // authorComboBox
            // 
            this.authorComboBox.FormattingEnabled = true;
            this.authorComboBox.Location = new System.Drawing.Point(12, 118);
            this.authorComboBox.Name = "authorComboBox";
            this.authorComboBox.Size = new System.Drawing.Size(332, 27);
            this.authorComboBox.TabIndex = 10;
            // 
            // genrePanel
            // 
            this.genrePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.genrePanel.Controls.Add(this.genreTextBox);
            this.genrePanel.Location = new System.Drawing.Point(12, 181);
            this.genrePanel.Name = "genrePanel";
            this.genrePanel.Size = new System.Drawing.Size(332, 40);
            this.genrePanel.TabIndex = 6;
            // 
            // genreTextBox
            // 
            this.genreTextBox.BackColor = System.Drawing.Color.White;
            this.genreTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.genreTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.genreTextBox.Location = new System.Drawing.Point(9, 7);
            this.genreTextBox.Margin = new System.Windows.Forms.Padding(9, 7, 9, 9);
            this.genreTextBox.Name = "genreTextBox";
            this.genreTextBox.Size = new System.Drawing.Size(312, 22);
            this.genreTextBox.TabIndex = 1;
            // 
            // publishingLabel
            // 
            this.publishingLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.publishingLabel.Location = new System.Drawing.Point(12, 224);
            this.publishingLabel.Name = "publishingLabel";
            this.publishingLabel.Size = new System.Drawing.Size(163, 30);
            this.publishingLabel.TabIndex = 11;
            this.publishingLabel.Text = "Publishing:";
            this.publishingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // publishingComboBox
            // 
            this.publishingComboBox.FormattingEnabled = true;
            this.publishingComboBox.Location = new System.Drawing.Point(12, 257);
            this.publishingComboBox.Name = "publishingComboBox";
            this.publishingComboBox.Size = new System.Drawing.Size(332, 27);
            this.publishingComboBox.TabIndex = 12;
            // 
            // yearLabel
            // 
            this.yearLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yearLabel.Location = new System.Drawing.Point(12, 287);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(163, 30);
            this.yearLabel.TabIndex = 13;
            this.yearLabel.Text = "Publication year:";
            this.yearLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // yearPanel
            // 
            this.yearPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.yearPanel.Controls.Add(this.yearTextBox);
            this.yearPanel.Location = new System.Drawing.Point(12, 320);
            this.yearPanel.Name = "yearPanel";
            this.yearPanel.Size = new System.Drawing.Size(332, 40);
            this.yearPanel.TabIndex = 6;
            // 
            // yearTextBox
            // 
            this.yearTextBox.BackColor = System.Drawing.Color.White;
            this.yearTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.yearTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yearTextBox.Location = new System.Drawing.Point(9, 7);
            this.yearTextBox.Margin = new System.Windows.Forms.Padding(9, 7, 9, 9);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(312, 22);
            this.yearTextBox.TabIndex = 1;
            // 
            // costLabel
            // 
            this.costLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.costLabel.Location = new System.Drawing.Point(12, 363);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(163, 30);
            this.costLabel.TabIndex = 14;
            this.costLabel.Text = "Cost:";
            this.costLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // costPanel
            // 
            this.costPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.costPanel.Controls.Add(this.costTextBox);
            this.costPanel.Location = new System.Drawing.Point(12, 396);
            this.costPanel.Name = "costPanel";
            this.costPanel.Size = new System.Drawing.Size(332, 40);
            this.costPanel.TabIndex = 7;
            // 
            // costTextBox
            // 
            this.costTextBox.BackColor = System.Drawing.Color.White;
            this.costTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.costTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.costTextBox.Location = new System.Drawing.Point(9, 7);
            this.costTextBox.Margin = new System.Windows.Forms.Padding(9, 7, 9, 9);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.Size = new System.Drawing.Size(312, 22);
            this.costTextBox.TabIndex = 1;
            // 
            // priceLabel
            // 
            this.priceLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceLabel.Location = new System.Drawing.Point(12, 439);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(163, 30);
            this.priceLabel.TabIndex = 15;
            this.priceLabel.Text = "Price:";
            this.priceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pricePanel
            // 
            this.pricePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pricePanel.Controls.Add(this.priceTextBox);
            this.pricePanel.Location = new System.Drawing.Point(12, 472);
            this.pricePanel.Name = "pricePanel";
            this.pricePanel.Size = new System.Drawing.Size(332, 40);
            this.pricePanel.TabIndex = 8;
            // 
            // priceTextBox
            // 
            this.priceTextBox.BackColor = System.Drawing.Color.White;
            this.priceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.priceTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceTextBox.Location = new System.Drawing.Point(9, 7);
            this.priceTextBox.Margin = new System.Windows.Forms.Padding(9, 7, 9, 9);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(312, 22);
            this.priceTextBox.TabIndex = 1;
            // 
            // BookCreationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(356, 573);
            this.Controls.Add(this.pricePanel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.costPanel);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.yearPanel);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.publishingComboBox);
            this.Controls.Add(this.publishingLabel);
            this.Controls.Add(this.genrePanel);
            this.Controls.Add(this.authorComboBox);
            this.Controls.Add(this.genreLabel);
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.titlePanel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.createButton);
            this.Font = new System.Drawing.Font("Segoe UI", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "BookCreationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New book";
            this.Load += new System.EventHandler(this.BookCreationForm_Load);
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            this.genrePanel.ResumeLayout(false);
            this.genrePanel.PerformLayout();
            this.yearPanel.ResumeLayout(false);
            this.yearPanel.PerformLayout();
            this.costPanel.ResumeLayout(false);
            this.costPanel.PerformLayout();
            this.pricePanel.ResumeLayout(false);
            this.pricePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.ComboBox authorComboBox;
        private System.Windows.Forms.Panel genrePanel;
        private System.Windows.Forms.TextBox genreTextBox;
        private System.Windows.Forms.Label publishingLabel;
        private System.Windows.Forms.ComboBox publishingComboBox;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Panel yearPanel;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.Panel costPanel;
        private System.Windows.Forms.TextBox costTextBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Panel pricePanel;
        private System.Windows.Forms.TextBox priceTextBox;
    }
}