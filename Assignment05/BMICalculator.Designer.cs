namespace Assignment05
{
    partial class BMICalculator
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.HeightInput = new System.Windows.Forms.TextBox();
            this.MetricRadioButton = new System.Windows.Forms.RadioButton();
            this.ImperialRadioButton = new System.Windows.Forms.RadioButton();
            this.WeightInput = new System.Windows.Forms.TextBox();
            this.CalculateBMIButton = new System.Windows.Forms.Button();
            this.BMIResultsTextBox = new System.Windows.Forms.TextBox();
            this.BMIScaleResults = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.WeightLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.HeightLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.HeightInput, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.MetricRadioButton, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.ImperialRadioButton, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.WeightInput, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.CalculateBMIButton, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.BMIResultsTextBox, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.BMIScaleResults, 0, 7);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.903134F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.46439F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.903134F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.46439F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.793447F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.85897F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.24502F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.36752F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(278, 409);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // WeightLabel
            // 
            this.WeightLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WeightLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.WeightLabel, 2);
            this.WeightLabel.Location = new System.Drawing.Point(46, 86);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(186, 36);
            this.WeightLabel.TabIndex = 5;
            this.WeightLabel.Text = "My Weight:";
            // 
            // HeightLabel
            // 
            this.HeightLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.HeightLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.HeightLabel, 2);
            this.HeightLabel.Location = new System.Drawing.Point(49, 0);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(179, 36);
            this.HeightLabel.TabIndex = 3;
            this.HeightLabel.Text = "My Height:";
            // 
            // HeightInput
            // 
            this.HeightInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.HeightInput, 2);
            this.HeightInput.Location = new System.Drawing.Point(59, 39);
            this.HeightInput.Name = "HeightInput";
            this.HeightInput.Size = new System.Drawing.Size(160, 45);
            this.HeightInput.TabIndex = 4;
            this.HeightInput.TextChanged += new System.EventHandler(this.HeightInput_TextChanged);
            // 
            // MetricRadioButton
            // 
            this.MetricRadioButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MetricRadioButton.AutoSize = true;
            this.MetricRadioButton.Location = new System.Drawing.Point(4, 175);
            this.MetricRadioButton.Name = "MetricRadioButton";
            this.MetricRadioButton.Size = new System.Drawing.Size(130, 34);
            this.MetricRadioButton.TabIndex = 2;
            this.MetricRadioButton.Text = "Metric";
            this.MetricRadioButton.UseVisualStyleBackColor = true;
            this.MetricRadioButton.CheckedChanged += new System.EventHandler(this.MetricRadioButton_CheckedChanged);
            // 
            // ImperialRadioButton
            // 
            this.ImperialRadioButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ImperialRadioButton.AutoSize = true;
            this.ImperialRadioButton.Location = new System.Drawing.Point(142, 175);
            this.ImperialRadioButton.Name = "ImperialRadioButton";
            this.ImperialRadioButton.Size = new System.Drawing.Size(133, 34);
            this.ImperialRadioButton.TabIndex = 1;
            this.ImperialRadioButton.Text = "Imperial";
            this.ImperialRadioButton.UseVisualStyleBackColor = true;
            this.ImperialRadioButton.CheckedChanged += new System.EventHandler(this.ImperialRadioButton_CheckedChanged);
            // 
            // WeightInput
            // 
            this.WeightInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.WeightInput, 2);
            this.WeightInput.Location = new System.Drawing.Point(59, 125);
            this.WeightInput.Name = "WeightInput";
            this.WeightInput.Size = new System.Drawing.Size(160, 45);
            this.WeightInput.TabIndex = 6;
            this.WeightInput.TextChanged += new System.EventHandler(this.WeightInput_TextChanged);
            // 
            // CalculateBMIButton
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.CalculateBMIButton, 2);
            this.CalculateBMIButton.Location = new System.Drawing.Point(3, 215);
            this.CalculateBMIButton.Name = "CalculateBMIButton";
            this.CalculateBMIButton.Size = new System.Drawing.Size(272, 38);
            this.CalculateBMIButton.TabIndex = 7;
            this.CalculateBMIButton.Text = "Calculate BMI";
            this.CalculateBMIButton.UseVisualStyleBackColor = true;
            this.CalculateBMIButton.Click += new System.EventHandler(this.CalculateBMIButton_Click);
            // 
            // BMIResultsTextBox
            // 
            this.BMIResultsTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BMIResultsTextBox.BackColor = System.Drawing.Color.Snow;
            this.tableLayoutPanel1.SetColumnSpan(this.BMIResultsTextBox, 2);
            this.BMIResultsTextBox.Enabled = false;
            this.BMIResultsTextBox.Location = new System.Drawing.Point(31, 266);
            this.BMIResultsTextBox.Name = "BMIResultsTextBox";
            this.BMIResultsTextBox.Size = new System.Drawing.Size(216, 45);
            this.BMIResultsTextBox.TabIndex = 8;
            // 
            // BMIScaleResults
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.BMIScaleResults, 2);
            this.BMIScaleResults.Enabled = false;
            this.BMIScaleResults.Location = new System.Drawing.Point(3, 321);
            this.BMIScaleResults.Multiline = true;
            this.BMIScaleResults.Name = "BMIScaleResults";
            this.BMIScaleResults.Size = new System.Drawing.Size(272, 85);
            this.BMIScaleResults.TabIndex = 9;
            this.BMIScaleResults.Text = "e.g. Your BMI is 18.9\r\nBMI is Normal";
            this.BMIScaleResults.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BMICalculator
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(302, 433);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.MaximizeBox = false;
            this.Name = "BMICalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton ImperialRadioButton;
        private System.Windows.Forms.RadioButton MetricRadioButton;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.TextBox HeightInput;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.TextBox WeightInput;
        private System.Windows.Forms.Button CalculateBMIButton;
        private System.Windows.Forms.TextBox BMIResultsTextBox;
        private System.Windows.Forms.TextBox BMIScaleResults;
    }
}

