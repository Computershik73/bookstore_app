namespace BookStoreView
{
    partial class AddressCreationForm
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
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.countryLabel = new System.Windows.Forms.Label();
            this.countryPanel = new System.Windows.Forms.Panel();
            this.stateLabel = new System.Windows.Forms.Label();
            this.statePanel = new System.Windows.Forms.Panel();
            this.stateTextBox = new System.Windows.Forms.TextBox();
            this.cityLabel = new System.Windows.Forms.Label();
            this.cityPanel = new System.Windows.Forms.Panel();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.streetLabel = new System.Windows.Forms.Label();
            this.streetPanel = new System.Windows.Forms.Panel();
            this.streetTextBox = new System.Windows.Forms.TextBox();
            this.buildingLabel = new System.Windows.Forms.Label();
            this.buildingPanel = new System.Windows.Forms.Panel();
            this.buildingTextBox = new System.Windows.Forms.TextBox();
            this.postalCodeLabel = new System.Windows.Forms.Label();
            this.postalCodePanel = new System.Windows.Forms.Panel();
            this.postalCodeTextBox = new System.Windows.Forms.TextBox();
            this.countryPanel.SuspendLayout();
            this.statePanel.SuspendLayout();
            this.cityPanel.SuspendLayout();
            this.streetPanel.SuspendLayout();
            this.buildingPanel.SuspendLayout();
            this.postalCodePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // createButton
            // 
            this.createButton.BackColor = System.Drawing.Color.White;
            this.createButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.createButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.createButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createButton.Location = new System.Drawing.Point(12, 471);
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
            this.cancelButton.Location = new System.Drawing.Point(181, 471);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(163, 40);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // countryTextBox
            // 
            this.countryTextBox.BackColor = System.Drawing.Color.White;
            this.countryTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.countryTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countryTextBox.Location = new System.Drawing.Point(9, 7);
            this.countryTextBox.Margin = new System.Windows.Forms.Padding(9, 7, 9, 9);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(312, 22);
            this.countryTextBox.TabIndex = 1;
            // 
            // countryLabel
            // 
            this.countryLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countryLabel.Location = new System.Drawing.Point(12, 9);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(163, 30);
            this.countryLabel.TabIndex = 4;
            this.countryLabel.Text = "Country:";
            this.countryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // countryPanel
            // 
            this.countryPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.countryPanel.Controls.Add(this.countryTextBox);
            this.countryPanel.Location = new System.Drawing.Point(12, 42);
            this.countryPanel.Name = "countryPanel";
            this.countryPanel.Size = new System.Drawing.Size(332, 40);
            this.countryPanel.TabIndex = 5;
            // 
            // stateLabel
            // 
            this.stateLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stateLabel.Location = new System.Drawing.Point(12, 85);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(163, 30);
            this.stateLabel.TabIndex = 6;
            this.stateLabel.Text = "State:";
            this.stateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statePanel
            // 
            this.statePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.statePanel.Controls.Add(this.stateTextBox);
            this.statePanel.Location = new System.Drawing.Point(12, 118);
            this.statePanel.Name = "statePanel";
            this.statePanel.Size = new System.Drawing.Size(332, 40);
            this.statePanel.TabIndex = 6;
            // 
            // stateTextBox
            // 
            this.stateTextBox.BackColor = System.Drawing.Color.White;
            this.stateTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.stateTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stateTextBox.Location = new System.Drawing.Point(9, 7);
            this.stateTextBox.Margin = new System.Windows.Forms.Padding(9, 7, 9, 9);
            this.stateTextBox.Name = "stateTextBox";
            this.stateTextBox.Size = new System.Drawing.Size(312, 22);
            this.stateTextBox.TabIndex = 1;
            // 
            // cityLabel
            // 
            this.cityLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cityLabel.Location = new System.Drawing.Point(12, 161);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(163, 30);
            this.cityLabel.TabIndex = 7;
            this.cityLabel.Text = "City:";
            this.cityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cityPanel
            // 
            this.cityPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cityPanel.Controls.Add(this.cityTextBox);
            this.cityPanel.Location = new System.Drawing.Point(12, 194);
            this.cityPanel.Name = "cityPanel";
            this.cityPanel.Size = new System.Drawing.Size(332, 40);
            this.cityPanel.TabIndex = 7;
            // 
            // cityTextBox
            // 
            this.cityTextBox.BackColor = System.Drawing.Color.White;
            this.cityTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cityTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cityTextBox.Location = new System.Drawing.Point(9, 7);
            this.cityTextBox.Margin = new System.Windows.Forms.Padding(9, 7, 9, 9);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(312, 22);
            this.cityTextBox.TabIndex = 1;
            // 
            // streetLabel
            // 
            this.streetLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.streetLabel.Location = new System.Drawing.Point(12, 237);
            this.streetLabel.Name = "streetLabel";
            this.streetLabel.Size = new System.Drawing.Size(163, 30);
            this.streetLabel.TabIndex = 8;
            this.streetLabel.Text = "Street:";
            this.streetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // streetPanel
            // 
            this.streetPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.streetPanel.Controls.Add(this.streetTextBox);
            this.streetPanel.Location = new System.Drawing.Point(12, 270);
            this.streetPanel.Name = "streetPanel";
            this.streetPanel.Size = new System.Drawing.Size(332, 40);
            this.streetPanel.TabIndex = 8;
            // 
            // streetTextBox
            // 
            this.streetTextBox.BackColor = System.Drawing.Color.White;
            this.streetTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.streetTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.streetTextBox.Location = new System.Drawing.Point(9, 7);
            this.streetTextBox.Margin = new System.Windows.Forms.Padding(9, 7, 9, 9);
            this.streetTextBox.Name = "streetTextBox";
            this.streetTextBox.Size = new System.Drawing.Size(312, 22);
            this.streetTextBox.TabIndex = 1;
            // 
            // buildingLabel
            // 
            this.buildingLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buildingLabel.Location = new System.Drawing.Point(12, 313);
            this.buildingLabel.Name = "buildingLabel";
            this.buildingLabel.Size = new System.Drawing.Size(163, 30);
            this.buildingLabel.TabIndex = 9;
            this.buildingLabel.Text = "Building:";
            this.buildingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buildingPanel
            // 
            this.buildingPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.buildingPanel.Controls.Add(this.buildingTextBox);
            this.buildingPanel.Location = new System.Drawing.Point(12, 346);
            this.buildingPanel.Name = "buildingPanel";
            this.buildingPanel.Size = new System.Drawing.Size(332, 40);
            this.buildingPanel.TabIndex = 9;
            // 
            // buildingTextBox
            // 
            this.buildingTextBox.BackColor = System.Drawing.Color.White;
            this.buildingTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.buildingTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buildingTextBox.Location = new System.Drawing.Point(9, 7);
            this.buildingTextBox.Margin = new System.Windows.Forms.Padding(9, 7, 9, 9);
            this.buildingTextBox.Name = "buildingTextBox";
            this.buildingTextBox.Size = new System.Drawing.Size(312, 22);
            this.buildingTextBox.TabIndex = 1;
            // 
            // postalCodeLabel
            // 
            this.postalCodeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.postalCodeLabel.Location = new System.Drawing.Point(12, 389);
            this.postalCodeLabel.Name = "postalCodeLabel";
            this.postalCodeLabel.Size = new System.Drawing.Size(163, 30);
            this.postalCodeLabel.TabIndex = 10;
            this.postalCodeLabel.Text = "Postal Code:";
            this.postalCodeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // postalCodePanel
            // 
            this.postalCodePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.postalCodePanel.Controls.Add(this.postalCodeTextBox);
            this.postalCodePanel.Location = new System.Drawing.Point(12, 422);
            this.postalCodePanel.Name = "postalCodePanel";
            this.postalCodePanel.Size = new System.Drawing.Size(332, 40);
            this.postalCodePanel.TabIndex = 10;
            // 
            // postalCodeTextBox
            // 
            this.postalCodeTextBox.BackColor = System.Drawing.Color.White;
            this.postalCodeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.postalCodeTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.postalCodeTextBox.Location = new System.Drawing.Point(9, 7);
            this.postalCodeTextBox.Margin = new System.Windows.Forms.Padding(9, 7, 9, 9);
            this.postalCodeTextBox.Name = "postalCodeTextBox";
            this.postalCodeTextBox.Size = new System.Drawing.Size(312, 22);
            this.postalCodeTextBox.TabIndex = 1;
            // 
            // AddressCreationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(356, 523);
            this.Controls.Add(this.postalCodePanel);
            this.Controls.Add(this.postalCodeLabel);
            this.Controls.Add(this.buildingPanel);
            this.Controls.Add(this.buildingLabel);
            this.Controls.Add(this.streetPanel);
            this.Controls.Add(this.streetLabel);
            this.Controls.Add(this.cityPanel);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.statePanel);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.countryPanel);
            this.Controls.Add(this.countryLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.createButton);
            this.Font = new System.Drawing.Font("Segoe UI", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddressCreationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New address";
            this.Load += new System.EventHandler(this.AddressCreationForm_Load);
            this.countryPanel.ResumeLayout(false);
            this.countryPanel.PerformLayout();
            this.statePanel.ResumeLayout(false);
            this.statePanel.PerformLayout();
            this.cityPanel.ResumeLayout(false);
            this.cityPanel.PerformLayout();
            this.streetPanel.ResumeLayout(false);
            this.streetPanel.PerformLayout();
            this.buildingPanel.ResumeLayout(false);
            this.buildingPanel.PerformLayout();
            this.postalCodePanel.ResumeLayout(false);
            this.postalCodePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.Panel countryPanel;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.Panel statePanel;
        private System.Windows.Forms.TextBox stateTextBox;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Panel cityPanel;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.Label streetLabel;
        private System.Windows.Forms.Panel streetPanel;
        private System.Windows.Forms.TextBox streetTextBox;
        private System.Windows.Forms.Label buildingLabel;
        private System.Windows.Forms.Panel buildingPanel;
        private System.Windows.Forms.TextBox buildingTextBox;
        private System.Windows.Forms.Label postalCodeLabel;
        private System.Windows.Forms.Panel postalCodePanel;
        private System.Windows.Forms.TextBox postalCodeTextBox;
    }
}