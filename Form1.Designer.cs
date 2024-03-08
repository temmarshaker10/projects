namespace PROJECT
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnUserName = new TextBox();
            btnPassword = new TextBox();
            checkBox1 = new CheckBox();
            linkLabel1 = new LinkLabel();
            button1 = new Button();
            label6 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 52);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 0;
            label1.Text = "DocHub";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 156);
            label2.Name = "label2";
            label2.Size = new Size(104, 25);
            label2.TabIndex = 1;
            label2.Text = "welcome to";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(55, 181);
            label3.Name = "label3";
            label3.Size = new Size(173, 48);
            label3.TabIndex = 2;
            label3.Text = "DOCHUB";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.DarkGray;
            label4.Location = new Point(94, 288);
            label4.Name = "label4";
            label4.Size = new Size(89, 25);
            label4.TabIndex = 3;
            label4.Text = "username";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.DarkGray;
            label5.Location = new Point(94, 396);
            label5.Name = "label5";
            label5.Size = new Size(89, 25);
            label5.TabIndex = 4;
            label5.Text = "password";
            // 
            // btnUserName
            // 
            btnUserName.ForeColor = Color.FromArgb(0, 117, 214);
            btnUserName.Location = new Point(94, 316);
            btnUserName.Name = "btnUserName";
            btnUserName.Size = new Size(345, 31);
            btnUserName.TabIndex = 5;
            // 
            // btnPassword
            // 
            btnPassword.ForeColor = Color.FromArgb(0, 117, 214);
            btnPassword.Location = new Point(94, 424);
            btnPassword.Name = "btnPassword";
            btnPassword.Size = new Size(345, 31);
            btnPassword.TabIndex = 6;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.ForeColor = Color.DarkGray;
            checkBox1.Location = new Point(94, 479);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(154, 29);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Remember me";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(359, 479);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(159, 25);
            linkLabel1.TabIndex = 8;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Forget password ?";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 117, 214);
            button1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(94, 536);
            button1.Name = "button1";
            button1.Size = new Size(345, 55);
            button1.TabIndex = 9;
            button1.Text = "LOG IN";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(124, 640);
            label6.Name = "label6";
            label6.Size = new Size(203, 25);
            label6.TabIndex = 10;
            label6.Text = "Don`t have an account ?";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 117, 214);
            button2.ForeColor = Color.White;
            button2.Location = new Point(327, 640);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 11;
            button2.Text = "Sign up";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(999, 705);
            Controls.Add(button2);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(linkLabel1);
            Controls.Add(checkBox1);
            Controls.Add(btnPassword);
            Controls.Add(btnUserName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox btnUserName;
        private TextBox btnPassword;
        private CheckBox checkBox1;
        private LinkLabel linkLabel1;
        private Button button1;
        private Label label6;
        private Button button2;
    }
}
