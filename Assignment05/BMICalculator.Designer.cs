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
            this.Imperial = new System.Windows.Forms.RadioButton();
            this.Metric = new System.Windows.Forms.RadioButton();
            this.MyHeight = new System.Windows.Forms.Label();
            this.HeightInput = new System.Windows.Forms.TextBox();
            this.MyWeight = new System.Windows.Forms.Label();
            this.WeightInput = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.Results = new System.Windows.Forms.TextBox();
            this.BMIScaleResults = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.MyWeight, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.MyHeight, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.HeightInput, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Metric, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.Imperial, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.WeightInput, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.CalculateButton, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.Results, 0, 6);
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
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // Imperial
            // 
            this.Imperial.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Imperial.AutoSize = true;
            this.Imperial.Location = new System.Drawing.Point(142, 175);
            this.Imperial.Name = "Imperial";
            this.Imperial.Size = new System.Drawing.Size(133, 34);
            this.Imperial.TabIndex = 1;
            this.Imperial.TabStop = true;
            this.Imperial.Text = "Imperial";
            this.Imperial.UseVisualStyleBackColor = true;
            this.Imperial.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            // 
            // Metric
            // 
            this.Metric.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Metric.AutoSize = true;
            this.Metric.Location = new System.Drawing.Point(4, 175);
            this.Metric.Name = "Metric";
            this.Metric.Size = new System.Drawing.Size(130, 34);
            this.Metric.TabIndex = 2;
            this.Metric.TabStop = true;
            this.Metric.Text = "Metric";
            this.Metric.UseVisualStyleBackColor = true;
            // 
            // MyHeight
            // 
            this.MyHeight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MyHeight.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.MyHeight, 2);
            this.MyHeight.Location = new System.Drawing.Point(49, 0);
            this.MyHeight.Name = "MyHeight";
            this.MyHeight.Size = new System.Drawing.Size(179, 36);
            this.MyHeight.TabIndex = 3;
            this.MyHeight.Text = "My Height:";
            this.MyHeight.Click += new System.EventHandler(this.label1_Click);
            // 
            // HeightInput
            // 
            this.HeightInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.HeightInput, 2);
            this.HeightInput.Location = new System.Drawing.Point(59, 39);
            this.HeightInput.Name = "HeightInput";
            this.HeightInput.Size = new System.Drawing.Size(160, 45);
            this.HeightInput.TabIndex = 4;
            // 
            // MyWeight
            // 
            this.MyWeight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MyWeight.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.MyWeight, 2);
            this.MyWeight.Location = new System.Drawing.Point(46, 86);
            this.MyWeight.Name = "MyWeight";
            this.MyWeight.Size = new System.Drawing.Size(186, 36);
            this.MyWeight.TabIndex = 5;
            this.MyWeight.Text = "My Weight:";
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
            // CalculateButton
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.CalculateButton, 2);
            this.CalculateButton.Location = new System.Drawing.Point(3, 215);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(272, 38);
            this.CalculateButton.TabIndex = 7;
            this.CalculateButton.Text = "Calculate BMI";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Results
            // 
            this.Results.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Results.BackColor = System.Drawing.Color.Snow;
            this.tableLayoutPanel1.SetColumnSpan(this.Results, 2);
            this.Results.Enabled = false;
            this.Results.Location = new System.Drawing.Point(31, 266);
            this.Results.Name = "Results";
            this.Results.Size = new System.Drawing.Size(216, 45);
            this.Results.TabIndex = 8;
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
            this.BMIScaleResults.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
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
        private System.Windows.Forms.RadioButton Imperial;
        private System.Windows.Forms.RadioButton Metric;
        private System.Windows.Forms.Label MyHeight;
        private System.Windows.Forms.TextBox HeightInput;
        private System.Windows.Forms.Label MyWeight;
        private System.Windows.Forms.TextBox WeightInput;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.TextBox Results;
        private System.Windows.Forms.TextBox BMIScaleResults;
    }
}

