namespace WindowsFormsApplication_GUI
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
            this.MethodComboBox = new System.Windows.Forms.ComboBox();
            this.FunctionLabel = new System.Windows.Forms.Label();
            this.ServiceLabel = new System.Windows.Forms.Label();
            this.ServiceComboBox = new System.Windows.Forms.ComboBox();
            this.FirstArgumentTextBox = new System.Windows.Forms.TextBox();
            this.SecondArgumentTextBox = new System.Windows.Forms.TextBox();
            this.RunButton = new System.Windows.Forms.Button();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.FirstArgumentLabel = new System.Windows.Forms.Label();
            this.SecondArgumentLabel = new System.Windows.Forms.Label();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MethodComboBox
            // 
            this.MethodComboBox.FormattingEnabled = true;
            this.MethodComboBox.Location = new System.Drawing.Point(218, 25);
            this.MethodComboBox.Name = "MethodComboBox";
            this.MethodComboBox.Size = new System.Drawing.Size(168, 21);
            this.MethodComboBox.TabIndex = 0;
            this.MethodComboBox.SelectedIndexChanged += new System.EventHandler(this.FunctionComboBox_SelectedIndexChanged);
            // 
            // FunctionLabel
            // 
            this.FunctionLabel.AutoSize = true;
            this.FunctionLabel.Location = new System.Drawing.Point(215, 9);
            this.FunctionLabel.Name = "FunctionLabel";
            this.FunctionLabel.Size = new System.Drawing.Size(48, 13);
            this.FunctionLabel.TabIndex = 1;
            this.FunctionLabel.Text = "Function";
            // 
            // ServiceLabel
            // 
            this.ServiceLabel.AutoSize = true;
            this.ServiceLabel.Location = new System.Drawing.Point(25, 9);
            this.ServiceLabel.Name = "ServiceLabel";
            this.ServiceLabel.Size = new System.Drawing.Size(43, 13);
            this.ServiceLabel.TabIndex = 2;
            this.ServiceLabel.Text = "Service";
            // 
            // ServiceComboBox
            // 
            this.ServiceComboBox.FormattingEnabled = true;
            this.ServiceComboBox.Items.AddRange(new object[] {
            "Primary",
            "Secondary"});
            this.ServiceComboBox.Location = new System.Drawing.Point(28, 25);
            this.ServiceComboBox.Name = "ServiceComboBox";
            this.ServiceComboBox.Size = new System.Drawing.Size(168, 21);
            this.ServiceComboBox.TabIndex = 3;
            this.ServiceComboBox.SelectedIndexChanged += new System.EventHandler(this.ServiceComboBox_SelectedIndexChanged);
            // 
            // FirstArgumentTextBox
            // 
            this.FirstArgumentTextBox.Location = new System.Drawing.Point(28, 107);
            this.FirstArgumentTextBox.Name = "FirstArgumentTextBox";
            this.FirstArgumentTextBox.Size = new System.Drawing.Size(358, 20);
            this.FirstArgumentTextBox.TabIndex = 4;
            // 
            // SecondArgumentTextBox
            // 
            this.SecondArgumentTextBox.Location = new System.Drawing.Point(28, 160);
            this.SecondArgumentTextBox.Name = "SecondArgumentTextBox";
            this.SecondArgumentTextBox.Size = new System.Drawing.Size(358, 20);
            this.SecondArgumentTextBox.TabIndex = 5;
            // 
            // RunButton
            // 
            this.RunButton.Location = new System.Drawing.Point(28, 272);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(358, 50);
            this.RunButton.TabIndex = 6;
            this.RunButton.Text = "Run";
            this.RunButton.UseVisualStyleBackColor = true;
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Location = new System.Drawing.Point(28, 223);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.ReadOnly = true;
            this.ResultTextBox.Size = new System.Drawing.Size(358, 20);
            this.ResultTextBox.TabIndex = 7;
            // 
            // FirstArgumentLabel
            // 
            this.FirstArgumentLabel.AutoSize = true;
            this.FirstArgumentLabel.Location = new System.Drawing.Point(25, 91);
            this.FirstArgumentLabel.Name = "FirstArgumentLabel";
            this.FirstArgumentLabel.Size = new System.Drawing.Size(104, 13);
            this.FirstArgumentLabel.TabIndex = 8;
            this.FirstArgumentLabel.Text = "Function argument 1";
            // 
            // SecondArgumentLabel
            // 
            this.SecondArgumentLabel.AutoSize = true;
            this.SecondArgumentLabel.Location = new System.Drawing.Point(25, 144);
            this.SecondArgumentLabel.Name = "SecondArgumentLabel";
            this.SecondArgumentLabel.Size = new System.Drawing.Size(104, 13);
            this.SecondArgumentLabel.TabIndex = 9;
            this.SecondArgumentLabel.Text = "Function argument 2";
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(25, 207);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(37, 13);
            this.ResultLabel.TabIndex = 10;
            this.ResultLabel.Text = "Result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(417, 340);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.SecondArgumentLabel);
            this.Controls.Add(this.FirstArgumentLabel);
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.RunButton);
            this.Controls.Add(this.SecondArgumentTextBox);
            this.Controls.Add(this.FirstArgumentTextBox);
            this.Controls.Add(this.ServiceComboBox);
            this.Controls.Add(this.ServiceLabel);
            this.Controls.Add(this.FunctionLabel);
            this.Controls.Add(this.MethodComboBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox MethodComboBox;
        private System.Windows.Forms.Label FunctionLabel;
        private System.Windows.Forms.Label ServiceLabel;
        private System.Windows.Forms.ComboBox ServiceComboBox;
        private System.Windows.Forms.TextBox FirstArgumentTextBox;
        private System.Windows.Forms.TextBox SecondArgumentTextBox;
        private System.Windows.Forms.Button RunButton;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.Label FirstArgumentLabel;
        private System.Windows.Forms.Label SecondArgumentLabel;
        private System.Windows.Forms.Label ResultLabel;
    }
}

