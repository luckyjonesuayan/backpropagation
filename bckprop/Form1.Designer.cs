namespace bckprop
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
            this.tb1 = new System.Windows.Forms.TextBox();
            this.tbO = new System.Windows.Forms.TextBox();
            this.tb3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.tb4 = new System.Windows.Forms.TextBox();
            this.tbHN = new System.Windows.Forms.TextBox();
            this.tbE = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Output = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelEpoch = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(55, 206);
            this.tb1.Margin = new System.Windows.Forms.Padding(2);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(143, 20);
            this.tb1.TabIndex = 0;
            // 
            // tbO
            // 
            this.tbO.Enabled = false;
            this.tbO.Location = new System.Drawing.Point(349, 153);
            this.tbO.Margin = new System.Windows.Forms.Padding(2);
            this.tbO.Name = "tbO";
            this.tbO.Size = new System.Drawing.Size(290, 20);
            this.tbO.TabIndex = 1;
            this.tbO.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tb3
            // 
            this.tb3.Location = new System.Drawing.Point(349, 206);
            this.tb3.Margin = new System.Windows.Forms.Padding(2);
            this.tb3.Name = "tb3";
            this.tb3.Size = new System.Drawing.Size(143, 20);
            this.tb3.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(55, 242);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 37);
            this.button1.TabIndex = 3;
            this.button1.Text = "create BPNN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(254, 242);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(189, 37);
            this.button2.TabIndex = 4;
            this.button2.Text = "train NN";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(465, 242);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(174, 37);
            this.button3.TabIndex = 5;
            this.button3.Text = "Test";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(202, 206);
            this.tb2.Margin = new System.Windows.Forms.Padding(2);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(143, 20);
            this.tb2.TabIndex = 6;
            // 
            // tb4
            // 
            this.tb4.Location = new System.Drawing.Point(496, 206);
            this.tb4.Margin = new System.Windows.Forms.Padding(2);
            this.tb4.Name = "tb4";
            this.tb4.Size = new System.Drawing.Size(143, 20);
            this.tb4.TabIndex = 7;
            // 
            // tbHN
            // 
            this.tbHN.Location = new System.Drawing.Point(55, 153);
            this.tbHN.Margin = new System.Windows.Forms.Padding(2);
            this.tbHN.Name = "tbHN";
            this.tbHN.Size = new System.Drawing.Size(134, 20);
            this.tbHN.TabIndex = 8;
            // 
            // tbE
            // 
            this.tbE.Location = new System.Drawing.Point(202, 152);
            this.tbE.Margin = new System.Windows.Forms.Padding(2);
            this.tbE.Name = "tbE";
            this.tbE.Size = new System.Drawing.Size(134, 20);
            this.tbE.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Epoch";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "No. of Hidden Neurons";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Output
            // 
            this.Output.AutoSize = true;
            this.Output.Location = new System.Drawing.Point(346, 134);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(39, 13);
            this.Output.TabIndex = 12;
            this.Output.Text = "Output";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Inputs";
            // 
            // labelEpoch
            // 
            this.labelEpoch.AutoSize = true;
            this.labelEpoch.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEpoch.Location = new System.Drawing.Point(48, 58);
            this.labelEpoch.Name = "labelEpoch";
            this.labelEpoch.Size = new System.Drawing.Size(321, 37);
            this.labelEpoch.TabIndex = 14;
            this.labelEpoch.Text = "Total Num of Epoch: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 333);
            this.Controls.Add(this.labelEpoch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbE);
            this.Controls.Add(this.tbHN);
            this.Controls.Add(this.tb4);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb3);
            this.Controls.Add(this.tbO);
            this.Controls.Add(this.tb1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.TextBox tbO;
        private System.Windows.Forms.TextBox tb3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.TextBox tb4;
        private System.Windows.Forms.TextBox tbHN;
        private System.Windows.Forms.TextBox tbE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Output;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelEpoch;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

