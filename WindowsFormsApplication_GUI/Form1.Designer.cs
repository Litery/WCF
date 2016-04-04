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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.serviceComboBox = new System.Windows.Forms.ComboBox();
            this.ParamTextBox1 = new System.Windows.Forms.TextBox();
            this.ParamTextBox2 = new System.Windows.Forms.TextBox();
            this.ExecuteButton = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MethodComboBox
            // 
            this.MethodComboBox.FormattingEnabled = true;
            this.MethodComboBox.Location = new System.Drawing.Point(137, 46);
            this.MethodComboBox.Name = "MethodComboBox";
            this.MethodComboBox.Size = new System.Drawing.Size(121, 21);
            this.MethodComboBox.TabIndex = 0;
            this.MethodComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Metoda\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Usluga";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // serviceComboBox
            // 
            this.serviceComboBox.FormattingEnabled = true;
            this.serviceComboBox.Items.AddRange(new object[] {
            "Usluga 1",
            "Usluga 2"});
            this.serviceComboBox.Location = new System.Drawing.Point(137, 6);
            this.serviceComboBox.Name = "serviceComboBox";
            this.serviceComboBox.Size = new System.Drawing.Size(121, 21);
            this.serviceComboBox.TabIndex = 3;
            this.serviceComboBox.SelectedIndexChanged += new System.EventHandler(this.serviceComboBox_SelectedIndexChanged);
            // 
            // ParamTextBox1
            // 
            this.ParamTextBox1.Location = new System.Drawing.Point(28, 107);
            this.ParamTextBox1.Name = "ParamTextBox1";
            this.ParamTextBox1.Size = new System.Drawing.Size(230, 20);
            this.ParamTextBox1.TabIndex = 4;
            // 
            // ParamTextBox2
            // 
            this.ParamTextBox2.Location = new System.Drawing.Point(28, 160);
            this.ParamTextBox2.Name = "ParamTextBox2";
            this.ParamTextBox2.Size = new System.Drawing.Size(230, 20);
            this.ParamTextBox2.TabIndex = 5;
            // 
            // ExecuteButton
            // 
            this.ExecuteButton.Location = new System.Drawing.Point(104, 226);
            this.ExecuteButton.Name = "ExecuteButton";
            this.ExecuteButton.Size = new System.Drawing.Size(75, 23);
            this.ExecuteButton.TabIndex = 6;
            this.ExecuteButton.Text = "Wykonaj";
            this.ExecuteButton.UseVisualStyleBackColor = true;
            this.ExecuteButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(158, 200);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(100, 20);
            this.Result.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "parametr 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "parametr 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "wynik";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.ExecuteButton);
            this.Controls.Add(this.ParamTextBox2);
            this.Controls.Add(this.ParamTextBox1);
            this.Controls.Add(this.serviceComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MethodComboBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox MethodComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox serviceComboBox;
        private System.Windows.Forms.TextBox ParamTextBox1;
        private System.Windows.Forms.TextBox ParamTextBox2;
        private System.Windows.Forms.Button ExecuteButton;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

