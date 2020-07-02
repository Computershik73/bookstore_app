namespace BookStoreView
{
    partial class CustomerCreationForm
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
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.firstNamePanel = new System.Windows.Forms.Panel();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.lastNamePanel = new System.Windows.Forms.Panel();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.phonePanel = new System.Windows.Forms.Panel();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.emailPanel = new System.Windows.Forms.Panel();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.firstNamePanel.SuspendLayout();
            this.lastNamePanel.SuspendLayout();
            this.phonePanel.SuspendLayout();
            this.emailPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // createButton
            // 
            this.createButton.BackColor = System.Drawing.Color.White;
            this.createButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.createButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.createButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createButton.Location = new System.Drawing.Point(12, 323);
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
            this.cancelButton.Location = new System.Drawing.Point(181, 323);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(163, 40);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.BackColor = System.Drawing.Color.White;
            this.firstNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.firstNameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstNameTextBox.Location = new System.Drawing.Point(9, 7);
            this.firstNameTextBox.Margin = new System.Windows.Forms.Padding(9, 7, 9, 9);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(312, 22);
            this.firstNameTextBox.TabIndex = 1;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstNameLabel.Location = new System.Drawing.Point(12, 9);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(163, 30);
            this.firstNameLabel.TabIndex = 4;
            this.firstNameLabel.Text = "First name:";
            this.firstNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // firstNamePanel
            // 
            this.firstNamePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.firstNamePanel.Controls.Add(this.firstNameTextBox);
            this.firstNamePanel.Location = new System.Drawing.Point(12, 42);
            this.firstNamePanel.Name = "firstNamePanel";
            this.firstNamePanel.Size = new System.Drawing.Size(332, 40);
            this.firstNamePanel.TabIndex = 5;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastNameLabel.Location = new System.Drawing.Point(12, 85);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(163, 30);
            this.lastNameLabel.TabIndex = 6;
            this.lastNameLabel.Text = "Last Name:";
            this.lastNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lastNamePanel
            // 
            this.lastNamePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lastNamePanel.Controls.Add(this.lastNameTextBox);
            this.lastNamePanel.Location = new System.Drawing.Point(12, 118);
            this.lastNamePanel.Name = "lastNamePanel";
            this.lastNamePanel.Size = new System.Drawing.Size(332, 40);
            this.lastNamePanel.TabIndex = 6;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.BackColor = System.Drawing.Color.White;
            this.lastNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lastNameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastNameTextBox.Location = new System.Drawing.Point(9, 7);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(9, 7, 9, 9);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(312, 22);
            this.lastNameTextBox.TabIndex = 1;
            // 
            // phoneLabel
            // 
            this.phoneLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneLabel.Location = new System.Drawing.Point(12, 161);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(163, 30);
            this.phoneLabel.TabIndex = 7;
            this.phoneLabel.Text = "Phone number:";
            this.phoneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // phonePanel
            // 
            this.phonePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phonePanel.Controls.Add(this.phoneTextBox);
            this.phonePanel.Location = new System.Drawing.Point(12, 194);
            this.phonePanel.Name = "phonePanel";
            this.phonePanel.Size = new System.Drawing.Size(332, 40);
            this.phonePanel.TabIndex = 7;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.BackColor = System.Drawing.Color.White;
            this.phoneTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phoneTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneTextBox.Location = new System.Drawing.Point(9, 7);
            this.phoneTextBox.Margin = new System.Windows.Forms.Padding(9, 7, 9, 9);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(312, 22);
            this.phoneTextBox.TabIndex = 1;
            // 
            // emailLabel
            // 
            this.emailLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailLabel.Location = new System.Drawing.Point(12, 237);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(163, 30);
            this.emailLabel.TabIndex = 8;
            this.emailLabel.Text = "Email:";
            this.emailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // emailPanel
            // 
            this.emailPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailPanel.Controls.Add(this.emailTextBox);
            this.emailPanel.Location = new System.Drawing.Point(12, 270);
            this.emailPanel.Name = "emailPanel";
            this.emailPanel.Size = new System.Drawing.Size(332, 40);
            this.emailPanel.TabIndex = 8;
            // 
            // emailTextBox
            // 
            this.emailTextBox.BackColor = System.Drawing.Color.White;
            this.emailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailTextBox.Location = new System.Drawing.Point(9, 7);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(9, 7, 9, 9);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(312, 22);
            this.emailTextBox.TabIndex = 1;
            // 
            // CustomerCreationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(356, 375);
            this.Controls.Add(this.emailPanel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.phonePanel);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.lastNamePanel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNamePanel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.createButton);
            this.Font = new System.Drawing.Font("Segoe UI", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CustomerCreationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New customer";
            this.Load += new System.EventHandler(this.CustomerCreationForm_Load);
            this.firstNamePanel.ResumeLayout(false);
            this.firstNamePanel.PerformLayout();
            this.lastNamePanel.ResumeLayout(false);
            this.lastNamePanel.PerformLayout();
            this.phonePanel.ResumeLayout(false);
            this.phonePanel.PerformLayout();
            this.emailPanel.ResumeLayout(false);
            this.emailPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Panel firstNamePanel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Panel lastNamePanel;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Panel phonePanel;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Panel emailPanel;
        private System.Windows.Forms.TextBox emailTextBox;
    }
}