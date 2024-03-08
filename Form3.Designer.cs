namespace PROJECT
{
    partial class Form3
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
            panel1 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            button1 = new Button();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 707);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(button1);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(300, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(668, 707);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(48, 22);
            label1.Name = "label1";
            label1.Size = new Size(152, 48);
            label1.TabIndex = 0;
            label1.Text = "Sign Up";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.DarkGray;
            label2.Location = new Point(77, 126);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 1;
            label2.Text = "Full Name";
            // 
            // textBox1
            // 
            textBox1.ForeColor = Color.FromArgb(0, 117, 214);
            textBox1.Location = new Point(77, 154);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(361, 31);
            textBox1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.DarkGray;
            label3.Location = new Point(83, 239);
            label3.Name = "label3";
            label3.Size = new Size(85, 25);
            label3.TabIndex = 3;
            label3.Text = "EMAIL ID";
            // 
            // textBox2
            // 
            textBox2.ForeColor = Color.FromArgb(0, 117, 214);
            textBox2.Location = new Point(77, 267);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(361, 31);
            textBox2.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.DarkGray;
            label4.Location = new Point(83, 352);
            label4.Name = "label4";
            label4.Size = new Size(62, 25);
            label4.TabIndex = 5;
            label4.Text = "Phone";
            // 
            // textBox3
            // 
            textBox3.ForeColor = Color.FromArgb(0, 117, 214);
            textBox3.Location = new Point(77, 380);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(361, 31);
            textBox3.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.DarkGray;
            label5.Location = new Point(83, 468);
            label5.Name = "label5";
            label5.Size = new Size(89, 25);
            label5.TabIndex = 7;
            label5.Text = "password";
            // 
            // textBox4
            // 
            textBox4.ForeColor = Color.FromArgb(0, 117, 214);
            textBox4.Location = new Point(77, 496);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(361, 31);
            textBox4.TabIndex = 8;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 117, 214);
            button1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(77, 587);
            button1.Name = "button1";
            button1.Size = new Size(355, 50);
            button1.TabIndex = 9;
            button1.Text = "SIGN UP";
            button1.UseVisualStyleBackColor = false;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(968, 707);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button button1;
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
    }
}