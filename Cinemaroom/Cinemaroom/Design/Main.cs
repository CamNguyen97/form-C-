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
        public Main()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Main_Load(object sender, EventArgs e)
        {
           
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (slideMenu.Width == 50)
            {
                slideMenu.Visible = false;
                btnMenu.Visible = false;
                slideMenu.Width = 215;
                btnMenu.Location = new Point(163, 25);
                slideMenu.Visible = true;
                btnMenu.Visible = true;
            }
            else
            {
                slideMenu.Visible = false;
                btnMenu.Visible = false;
                slideMenu.Width = 50;
                btnMenu.Location = new Point(9, 25);
                slideMenu.Visible = true;
                btnMenu.Visible = true;
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
    }
}
