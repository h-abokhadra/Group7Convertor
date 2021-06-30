namespace Converter
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Convert = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Weight = new System.Windows.Forms.RadioButton();
            this.TimeRB = new System.Windows.Forms.RadioButton();
            this.Temperature = new System.Windows.Forms.RadioButton();
            this.Length = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Unit2 = new System.Windows.Forms.RadioButton();
            this.Unit1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(88, 222);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(267, 222);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 1;
            // 
            // Convert
            // 
            this.Convert.Location = new System.Drawing.Point(176, 278);
            this.Convert.Name = "Convert";
            this.Convert.Size = new System.Drawing.Size(125, 40);
            this.Convert.TabIndex = 2;
            this.Convert.Text = "CONVERT";
            this.Convert.UseVisualStyleBackColor = true;
            this.Convert.Click += new System.EventHandler(this.Convert_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Weight);
            this.groupBox1.Controls.Add(this.TimeRB);
            this.groupBox1.Controls.Add(this.Temperature);
            this.groupBox1.Controls.Add(this.Length);
            this.groupBox1.Location = new System.Drawing.Point(60, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(156, 133);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Measurement Type";
            // 
            // Weight
            // 
            this.Weight.AutoSize = true;
            this.Weight.Location = new System.Drawing.Point(21, 103);
            this.Weight.Name = "Weight";
            this.Weight.Size = new System.Drawing.Size(73, 21);
            this.Weight.TabIndex = 7;
            this.Weight.Text = "Weight";
            this.Weight.UseVisualStyleBackColor = true;
            this.Weight.CheckedChanged += new System.EventHandler(this.ConvertionType_CheckedChanged);
            // 
            // TimeRB
            // 
            this.TimeRB.AutoSize = true;
            this.TimeRB.Location = new System.Drawing.Point(21, 76);
            this.TimeRB.Name = "TimeRB";
            this.TimeRB.Size = new System.Drawing.Size(60, 21);
            this.TimeRB.TabIndex = 6;
            this.TimeRB.Text = "Time";
            this.TimeRB.UseVisualStyleBackColor = true;
            this.TimeRB.CheckedChanged += new System.EventHandler(this.ConvertionType_CheckedChanged);
            // 
            // Temperature
            // 
            this.Temperature.AutoSize = true;
            this.Temperature.Location = new System.Drawing.Point(21, 49);
            this.Temperature.Name = "Temperature";
            this.Temperature.Size = new System.Drawing.Size(111, 21);
            this.Temperature.TabIndex = 5;
            this.Temperature.Text = "Temperature";
            this.Temperature.UseVisualStyleBackColor = true;
            this.Temperature.CheckedChanged += new System.EventHandler(this.ConvertionType_CheckedChanged);
            // 
            // Length
            // 
            this.Length.AutoSize = true;
            this.Length.Location = new System.Drawing.Point(21, 22);
            this.Length.Name = "Length";
            this.Length.Size = new System.Drawing.Size(73, 21);
            this.Length.TabIndex = 0;
            this.Length.Text = "Length";
            this.Length.UseVisualStyleBackColor = true;
            this.Length.CheckedChanged += new System.EventHandler(this.ConvertionType_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Unit2);
            this.groupBox2.Controls.Add(this.Unit1);
            this.groupBox2.Location = new System.Drawing.Point(252, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(210, 82);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Unit Conversion";
            // 
            // Unit2
            // 
            this.Unit2.AutoSize = true;
            this.Unit2.Location = new System.Drawing.Point(23, 49);
            this.Unit2.Name = "Unit2";
            this.Unit2.Size = new System.Drawing.Size(17, 16);
            this.Unit2.TabIndex = 6;
            this.Unit2.TabStop = true;
            this.Unit2.UseVisualStyleBackColor = true;
            this.Unit2.CheckedChanged += new System.EventHandler(this.ConversionUnit_CheckedChanged);
            // 
            // Unit1
            // 
            this.Unit1.AutoSize = true;
            this.Unit1.Location = new System.Drawing.Point(23, 22);
            this.Unit1.Name = "Unit1";
            this.Unit1.Size = new System.Drawing.Size(17, 16);
            this.Unit1.TabIndex = 5;
            this.Unit1.TabStop = true;
            this.Unit1.UseVisualStyleBackColor = true;
            this.Unit1.CheckedChanged += new System.EventHandler(this.ConversionUnit_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 355);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Convert);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Convert;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Weight;
        private System.Windows.Forms.RadioButton TimeRB;
        private System.Windows.Forms.RadioButton Temperature;
        private System.Windows.Forms.RadioButton Length;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton Unit2;
        private System.Windows.Forms.RadioButton Unit1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

