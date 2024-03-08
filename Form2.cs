using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace PROJECT
{
    public partial class Form2 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse);


        public Form2()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = btnHome.Height;
            pnlNav.Top = btnHome.Top;
            pnlNav.Left = btnHome.Left;
            btnHome.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Dashboard";
            this.pnlFormLoader.Controls.Clear();
            frmDashboard FrmDashboard_Vrb = new frmDashboard()
            { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnHome.Height;
            pnlNav.Top = btnHome.Top;
            pnlNav.Left = btnHome.Left;
            btnHome.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Dashboard";
            this.pnlFormLoader.Controls.Clear();
            frmDashboard FrmDashboard_Vrb = new frmDashboard()
            { Dock=DockStyle.Fill, TopLevel=false, TopMost=true };
            FrmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();
        }

        private void btnFavorites_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnFavorites.Height;
            pnlNav.Top = btnFavorites.Top;
            btnFavorites.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Favorites";
            this.pnlFormLoader.Controls.Clear();
            frmFavorites FrmDashboard_Vrb = new frmFavorites()
            { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();
        }

        private void btnTrash_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnTrash.Height;
            pnlNav.Top = btnTrash.Top;
            btnTrash.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Trash";
            this.pnlFormLoader.Controls.Clear();
            frmTrash FrmDashboard_Vrb = new frmTrash()
            { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnSettings.Height;
            pnlNav.Top = btnSettings.Top;
            btnSettings.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Settings";
            this.pnlFormLoader.Controls.Clear();
            frmSettings FrmDashboard_Vrb = new frmSettings()
            { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnHelp.Height;
            pnlNav.Top = btnHelp.Top;
            btnHelp.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Help";
            this.pnlFormLoader.Controls.Clear();
            frmHelp FrmDashboard_Vrb = new frmHelp()
            { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();
        }

        private void btnHome_Leave(object sender, EventArgs e)
        {
            btnHome.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnFavorites_Leave(object sender, EventArgs e)
        {
            btnFavorites.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnTrash_Leave(object sender, EventArgs e)
        {
            btnTrash.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnSettings_Leave(object sender, EventArgs e)
        {
            btnSettings.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnHelp_Leave(object sender, EventArgs e)
        {
            btnHelp.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
