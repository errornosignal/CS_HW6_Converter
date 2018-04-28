namespace CS_HW6_Converter
{
    partial class Form1
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
            this.ConvertFromLabel = new System.Windows.Forms.Label();
            this.ConvertFromTextBox = new System.Windows.Forms.TextBox();
            this.ConvertToTextBox = new System.Windows.Forms.TextBox();
            this.ConvertToComboBox = new System.Windows.Forms.ComboBox();
            this.ConvertToLabel = new System.Windows.Forms.Label();
            this.ConvertButton = new System.Windows.Forms.Button();
            this.EditConversionsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ConvertFromLabel
            // 
            this.ConvertFromLabel.AutoSize = true;
            this.ConvertFromLabel.Location = new System.Drawing.Point(64, 9);
            this.ConvertFromLabel.Name = "ConvertFromLabel";
            this.ConvertFromLabel.Size = new System.Drawing.Size(89, 13);
            this.ConvertFromLabel.TabIndex = 0;
            this.ConvertFromLabel.Text = "Value to Convert:";
            // 
            // ConvertFromTextBox
            // 
            this.ConvertFromTextBox.Location = new System.Drawing.Point(12, 25);
            this.ConvertFromTextBox.Name = "ConvertFromTextBox";
            this.ConvertFromTextBox.Size = new System.Drawing.Size(141, 20);
            this.ConvertFromTextBox.TabIndex = 1;
            this.ConvertFromTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ConvertToTextBox
            // 
            this.ConvertToTextBox.Enabled = false;
            this.ConvertToTextBox.Location = new System.Drawing.Point(10, 111);
            this.ConvertToTextBox.Name = "ConvertToTextBox";
            this.ConvertToTextBox.Size = new System.Drawing.Size(143, 20);
            this.ConvertToTextBox.TabIndex = 3;
            this.ConvertToTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ConvertToComboBox
            // 
            this.ConvertToComboBox.FormattingEnabled = true;
            this.ConvertToComboBox.Location = new System.Drawing.Point(12, 61);
            this.ConvertToComboBox.Name = "ConvertToComboBox";
            this.ConvertToComboBox.Size = new System.Drawing.Size(141, 21);
            this.ConvertToComboBox.TabIndex = 4;
            // 
            // ConvertToLabel
            // 
            this.ConvertToLabel.AutoSize = true;
            this.ConvertToLabel.Location = new System.Drawing.Point(64, 95);
            this.ConvertToLabel.Name = "ConvertToLabel";
            this.ConvertToLabel.Size = new System.Drawing.Size(89, 13);
            this.ConvertToLabel.TabIndex = 5;
            this.ConvertToLabel.Text = "Converted Value:";
            // 
            // ConvertButton
            // 
            this.ConvertButton.Location = new System.Drawing.Point(84, 159);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(69, 23);
            this.ConvertButton.TabIndex = 6;
            this.ConvertButton.Text = "Convert";
            this.ConvertButton.UseVisualStyleBackColor = true;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // EditConversionsButton
            // 
            this.EditConversionsButton.Location = new System.Drawing.Point(12, 159);
            this.EditConversionsButton.Name = "EditConversionsButton";
            this.EditConversionsButton.Size = new System.Drawing.Size(66, 23);
            this.EditConversionsButton.TabIndex = 7;
            this.EditConversionsButton.Text = "Edit";
            this.EditConversionsButton.UseVisualStyleBackColor = true;
            this.EditConversionsButton.Click += new System.EventHandler(this.EditConversionsButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(167, 194);
            this.Controls.Add(this.EditConversionsButton);
            this.Controls.Add(this.ConvertButton);
            this.Controls.Add(this.ConvertToLabel);
            this.Controls.Add(this.ConvertToComboBox);
            this.Controls.Add(this.ConvertToTextBox);
            this.Controls.Add(this.ConvertFromTextBox);
            this.Controls.Add(this.ConvertFromLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ConvertFromLabel;
        private System.Windows.Forms.TextBox ConvertFromTextBox;
        private System.Windows.Forms.TextBox ConvertToTextBox;
        private System.Windows.Forms.ComboBox ConvertToComboBox;
        private System.Windows.Forms.Label ConvertToLabel;
        private System.Windows.Forms.Button ConvertButton;
        private System.Windows.Forms.Button EditConversionsButton;
    }
}

