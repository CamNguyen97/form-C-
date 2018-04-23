namespace Cinemaroom.Design
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.header = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.slideMenu = new System.Windows.Forms.Panel();
            this.btnMenu = new System.Windows.Forms.Button();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.Content = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMini = new Bunifu.Framework.UI.BunifuImageButton();
            this.header.SuspendLayout();
            this.panel1.SuspendLayout();
            this.slideMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMini)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(77)))), ((int)(((byte)(92)))));
            this.header.Controls.Add(this.btnMini);
            this.header.Controls.Add(this.bunifuImageButton1);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1279, 44);
            this.header.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Content);
            this.panel1.Controls.Add(this.slideMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1279, 604);
            this.panel1.TabIndex = 2;
            // 
            // slideMenu
            // 
            this.slideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(47)))), ((int)(((byte)(64)))));
            this.slideMenu.Controls.Add(this.btnMenu);
            this.slideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.slideMenu.Location = new System.Drawing.Point(0, 0);
            this.slideMenu.Name = "slideMenu";
            this.slideMenu.Size = new System.Drawing.Size(215, 604);
            this.slideMenu.TabIndex = 0;
            // 
            // btnMenu
            // 
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.Location = new System.Drawing.Point(163, 22);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(33, 30);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.header;
            this.bunifuDragControl1.Vertical = true;
            // 
            // Content
            // 
            this.Content.BackColor = System.Drawing.Color.White;
            this.Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Content.Location = new System.Drawing.Point(215, 0);
            this.Content.Name = "Content";
            this.Content.Size = new System.Drawing.Size(1064, 604);
            this.Content.TabIndex = 1;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(77)))), ((int)(((byte)(92)))));
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(1242, 9);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(25, 25);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 0;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // btnMini
            // 
            this.btnMini.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(77)))), ((int)(((byte)(92)))));
            this.btnMini.Image = ((System.Drawing.Image)(resources.GetObject("btnMini.Image")));
            this.btnMini.ImageActive = null;
            this.btnMini.Location = new System.Drawing.Point(1208, 9);
            this.btnMini.Name = "btnMini";
            this.btnMini.Size = new System.Drawing.Size(25, 25);
            this.btnMini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMini.TabIndex = 1;
            this.btnMini.TabStop = false;
            this.btnMini.Zoom = 10;
            this.btnMini.Click += new System.EventHandler(this.btnMini_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 648);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.header.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.slideMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMini)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel slideMenu;
        private System.Windows.Forms.Button btnMenu;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel Content;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuImageButton btnMini;
    }
}