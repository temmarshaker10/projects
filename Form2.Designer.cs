namespace PROJECT
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
            panel1 = new Panel();
            btnHelp = new Button();
            btnSettings = new Button();
            btnTrash = new Button();
            btnFavorites = new Button();
            btnHome = new Button();
            panel2 = new Panel();
            pnlNav = new Panel();
            label2 = new Label();
            label1 = new Label();
            lblTitle = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            pnlFormLoader = new Panel();
            label4 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            pnlFormLoader.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(24, 30, 54);
            panel1.Controls.Add(btnHelp);
            panel1.Controls.Add(btnSettings);
            panel1.Controls.Add(btnTrash);
            panel1.Controls.Add(btnFavorites);
            panel1.Controls.Add(btnHome);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(216, 581);
            panel1.TabIndex = 0;
            // 
            // btnHelp
            // 
            btnHelp.FlatAppearance.BorderSize = 0;
            btnHelp.FlatStyle = FlatStyle.Flat;
            btnHelp.Font = new Font("Nirmala UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHelp.ForeColor = Color.FromArgb(0, 126, 249);
            btnHelp.Image = Properties.Resources.info;
            btnHelp.Location = new Point(12, 514);
            btnHelp.Name = "btnHelp";
            btnHelp.Size = new Size(186, 42);
            btnHelp.TabIndex = 5;
            btnHelp.Text = "Help";
            btnHelp.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnHelp.UseVisualStyleBackColor = true;
            btnHelp.Click += btnHelp_Click;
            btnHelp.Leave += btnHelp_Leave;
            // 
            // btnSettings
            // 
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Nirmala UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSettings.ForeColor = Color.FromArgb(0, 126, 249);
            btnSettings.Image = Properties.Resources.settings;
            btnSettings.Location = new Point(3, 466);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(186, 42);
            btnSettings.TabIndex = 4;
            btnSettings.Text = "Settings";
            btnSettings.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnSettings.UseVisualStyleBackColor = true;
            btnSettings.Click += btnSettings_Click;
            btnSettings.Leave += btnSettings_Leave;
            // 
            // btnTrash
            // 
            btnTrash.Dock = DockStyle.Top;
            btnTrash.FlatAppearance.BorderSize = 0;
            btnTrash.FlatStyle = FlatStyle.Flat;
            btnTrash.Font = new Font("Nirmala UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTrash.ForeColor = Color.FromArgb(0, 126, 249);
            btnTrash.Image = Properties.Resources.trash;
            btnTrash.Location = new Point(0, 252);
            btnTrash.Name = "btnTrash";
            btnTrash.Size = new Size(216, 42);
            btnTrash.TabIndex = 3;
            btnTrash.Text = "Trash";
            btnTrash.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnTrash.UseVisualStyleBackColor = true;
            btnTrash.Click += btnTrash_Click;
            btnTrash.Leave += btnTrash_Leave;
            // 
            // btnFavorites
            // 
            btnFavorites.Dock = DockStyle.Top;
            btnFavorites.FlatAppearance.BorderSize = 0;
            btnFavorites.FlatStyle = FlatStyle.Flat;
            btnFavorites.Font = new Font("Nirmala UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFavorites.ForeColor = Color.FromArgb(0, 126, 249);
            btnFavorites.Image = Properties.Resources.star1;
            btnFavorites.Location = new Point(0, 210);
            btnFavorites.Name = "btnFavorites";
            btnFavorites.Size = new Size(216, 42);
            btnFavorites.TabIndex = 2;
            btnFavorites.Text = "Favorites";
            btnFavorites.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnFavorites.UseVisualStyleBackColor = true;
            btnFavorites.Click += btnFavorites_Click;
            btnFavorites.Leave += btnFavorites_Leave;
            // 
            // btnHome
            // 
            btnHome.Dock = DockStyle.Top;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Nirmala UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHome.ForeColor = Color.FromArgb(0, 126, 249);
            btnHome.Image = Properties.Resources.house_chimney;
            btnHome.Location = new Point(0, 168);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(216, 42);
            btnHome.TabIndex = 1;
            btnHome.Text = "Home";
            btnHome.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            btnHome.Leave += btnHome_Leave;
            // 
            // panel2
            // 
            panel2.Controls.Add(pnlNav);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(216, 168);
            panel2.TabIndex = 0;
            // 
            // pnlNav
            // 
            pnlNav.BackColor = Color.FromArgb(0, 126, 249);
            pnlNav.Location = new Point(0, 193);
            pnlNav.Name = "pnlNav";
            pnlNav.Size = new Size(3, 100);
            pnlNav.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(158, 161, 178);
            label2.Location = new Point(24, 102);
            label2.Name = "label2";
            label2.Size = new Size(161, 17);
            label2.TabIndex = 1;
            label2.Text = "Some User Text here";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 126, 249);
            label1.Location = new Point(35, 77);
            label1.Name = "label1";
            label1.Size = new Size(119, 25);
            label1.TabIndex = 0;
            label1.Text = "User Name";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 21F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(158, 161, 176);
            lblTitle.Location = new Point(231, 24);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(232, 48);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Dashboard";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(74, 79, 99);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Myanmar Text", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = SystemColors.ScrollBar;
            textBox1.Location = new Point(650, 24);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(348, 32);
            textBox1.TabIndex = 2;
            textBox1.Text = "Search For Something...";
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(1015, 12);
            button1.Name = "button1";
            button1.Size = new Size(30, 41);
            button1.TabIndex = 3;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pnlFormLoader
            // 
            pnlFormLoader.BackColor = Color.FromArgb(37, 42, 64);
            pnlFormLoader.Controls.Add(label4);
            pnlFormLoader.Dock = DockStyle.Bottom;
            pnlFormLoader.Location = new Point(216, 104);
            pnlFormLoader.Name = "pnlFormLoader";
            pnlFormLoader.Size = new Size(841, 477);
            pnlFormLoader.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Nirmala UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(54, 48);
            label4.Name = "label4";
            label4.Size = new Size(96, 38);
            label4.TabIndex = 0;
            label4.Text = "label4";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1057, 581);
            Controls.Add(pnlFormLoader);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(lblTitle);
            Controls.Add(panel1);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            pnlFormLoader.ResumeLayout(false);
            pnlFormLoader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private Label label1;
        private Button btnHome;
        private Button btnHelp;
        private Button btnSettings;
        private Button btnTrash;
        private Button btnFavorites;
        private Panel pnlNav;
        private Label lblTitle;
        private TextBox textBox1;
        private Button button1;
        private Panel pnlFormLoader;
        private Label label4;
    }
}