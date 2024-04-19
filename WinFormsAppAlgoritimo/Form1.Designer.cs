namespace WinFormsAppAlgoritimo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Comic Sans MS", 11F);
            groupBox1.Location = new Point(12, 33);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(553, 405);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "banana";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 46);
            label1.Name = "label1";
            label1.Size = new Size(83, 30);
            label1.TabIndex = 0;
            label1.Text = "banana";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ActiveCaption;
            textBox1.Location = new Point(9, 74);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(247, 38);
            textBox1.TabIndex = 1;
            textBox1.Text = "banana";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Red;
            textBox2.Location = new Point(264, 74);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(283, 38);
            textBox2.TabIndex = 3;
            textBox2.Text = "banana";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(264, 46);
            label2.Name = "label2";
            label2.Size = new Size(83, 30);
            label2.TabIndex = 2;
            label2.Text = "banana";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(9, 167);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 38);
            textBox3.TabIndex = 5;
            textBox3.Text = "banana";
            textBox3.TextAlign = HorizontalAlignment.Right;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 139);
            label3.Name = "label3";
            label3.Size = new Size(83, 30);
            label3.TabIndex = 4;
            label3.Text = "banana";
            label3.Click += label3_Click;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Comic Sans MS", 11F, FontStyle.Bold);
            textBox4.Location = new Point(171, 167);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(376, 38);
            textBox4.TabIndex = 7;
            textBox4.Text = "banana";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(171, 139);
            label4.Name = "label4";
            label4.Size = new Size(83, 30);
            label4.TabIndex = 6;
            label4.Text = "banana";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(577, 450);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
    }
}
