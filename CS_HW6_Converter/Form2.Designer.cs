namespace CS_HW6_Converter
{
    partial class Form2
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
            this.ClearButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.ConvertToUnitLabel = new System.Windows.Forms.Label();
            this.ConvertToUnitTextBox = new System.Windows.Forms.TextBox();
            this.ConvertFromUnitTextBox = new System.Windows.Forms.TextBox();
            this.ConvertFromUnitLabel = new System.Windows.Forms.Label();
            this.ConversionRatioLabel = new System.Windows.Forms.Label();
            this.ConversionRatioTextBox = new System.Windows.Forms.TextBox();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(11, 174);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(66, 23);
            this.ClearButton.TabIndex = 14;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(85, 203);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(69, 23);
            this.AddButton.TabIndex = 13;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ConvertToUnitLabel
            // 
            this.ConvertToUnitLabel.AutoSize = true;
            this.ConvertToUnitLabel.Location = new System.Drawing.Point(71, 73);
            this.ConvertToUnitLabel.Name = "ConvertToUnitLabel";
            this.ConvertToUnitLabel.Size = new System.Drawing.Size(85, 13);
            this.ConvertToUnitLabel.TabIndex = 12;
            this.ConvertToUnitLabel.Text = "Convert To Unit:";
            // 
            // ConvertToUnitTextBox
            // 
            this.ConvertToUnitTextBox.Location = new System.Drawing.Point(12, 89);
            this.ConvertToUnitTextBox.Name = "ConvertToUnitTextBox";
            this.ConvertToUnitTextBox.Size = new System.Drawing.Size(143, 20);
            this.ConvertToUnitTextBox.TabIndex = 11;
            this.ConvertToUnitTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ConvertFromUnitTextBox
            // 
            this.ConvertFromUnitTextBox.Location = new System.Drawing.Point(15, 40);
            this.ConvertFromUnitTextBox.Name = "ConvertFromUnitTextBox";
            this.ConvertFromUnitTextBox.Size = new System.Drawing.Size(141, 20);
            this.ConvertFromUnitTextBox.TabIndex = 10;
            this.ConvertFromUnitTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ConvertFromUnitLabel
            // 
            this.ConvertFromUnitLabel.AutoSize = true;
            this.ConvertFromUnitLabel.Location = new System.Drawing.Point(67, 24);
            this.ConvertFromUnitLabel.Name = "ConvertFromUnitLabel";
            this.ConvertFromUnitLabel.Size = new System.Drawing.Size(92, 13);
            this.ConvertFromUnitLabel.TabIndex = 8;
            this.ConvertFromUnitLabel.Text = "Convert from Unit:";
            // 
            // ConversionRatioLabel
            // 
            this.ConversionRatioLabel.AutoSize = true;
            this.ConversionRatioLabel.Location = new System.Drawing.Point(70, 123);
            this.ConversionRatioLabel.Name = "ConversionRatioLabel";
            this.ConversionRatioLabel.Size = new System.Drawing.Size(91, 13);
            this.ConversionRatioLabel.TabIndex = 16;
            this.ConversionRatioLabel.Text = "Conversion Ratio:";
            // 
            // ConversionRatioTextBox
            // 
            this.ConversionRatioTextBox.Location = new System.Drawing.Point(11, 139);
            this.ConversionRatioTextBox.Name = "ConversionRatioTextBox";
            this.ConversionRatioTextBox.Size = new System.Drawing.Size(143, 20);
            this.ConversionRatioTextBox.TabIndex = 12;
            this.ConversionRatioTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(10, 203);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(69, 23);
            this.RemoveButton.TabIndex = 17;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(170, 238);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.ConversionRatioLabel);
            this.Controls.Add(this.ConversionRatioTextBox);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.ConvertToUnitLabel);
            this.Controls.Add(this.ConvertToUnitTextBox);
            this.Controls.Add(this.ConvertFromUnitTextBox);
            this.Controls.Add(this.ConvertFromUnitLabel);
            this.Name = "Form2";
            this.Text = "Edit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label ConvertToUnitLabel;
        private System.Windows.Forms.TextBox ConvertToUnitTextBox;
        private System.Windows.Forms.TextBox ConvertFromUnitTextBox;
        private System.Windows.Forms.Label ConvertFromUnitLabel;
        private System.Windows.Forms.Label ConversionRatioLabel;
        private System.Windows.Forms.TextBox ConversionRatioTextBox;
        private System.Windows.Forms.Button RemoveButton;
    }
}