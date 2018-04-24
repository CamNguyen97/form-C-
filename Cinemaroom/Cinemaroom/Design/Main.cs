using Cinemaroom.Design.Partial;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinemaroom.Design
{
    public partial class Main : Form
    {
        private Home frm_home = new Home();
        public Main()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            
            Content.Controls.Add(frm_home);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (slideMenu.Width == 65)
            {
                slideMenu.Visible = false;
                btnMenu.Visible = false;
                btnAcount.Visible = false;
                slideMenu.Width = 215;
                btnMenu.Location = new Point(163, 25);
                btnAcount.Location = new Point(17, 528);
                btnAcount.Width = 160;
                btnAcount.Height = 35;
                btnAcount.Text = "MY ACCOUNT";
                btnAcount.FlatAppearance.BorderSize = 1;
                btnAcount.Image = null;
                slideMenu.Visible = true;
                btnMenu.Visible = true;
                btnAcount.Visible = true;
            }
            else
            {
                slideMenu.Visible = false;
                btnMenu.Visible = false;
                btnAcount.Visible = false;
                slideMenu.Width = 65;
                btnMenu.Location = new Point(12, 25);
                btnAcount.Location = new Point(15, 528);
                Content.AutoSize = true;
                frm_home.AutoSize = true;
                btnAcount.Width = 35;
                btnAcount.Height = 35;
                btnAcount.Text = "";
                btnAcount.FlatAppearance.BorderSize = 0;
                btnAcount.Image = Properties.Resources.User_gray;
                slideMenu.Visible = true;
                btnMenu.Visible = true;
                btnAcount.Visible = true;
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton9_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton10_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {

        }
    }
}
