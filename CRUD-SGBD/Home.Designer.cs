using System.Drawing;

namespace CRUD_SGBD
{
    partial class Home
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button btnDelete;
            this.panelSlider = new System.Windows.Forms.Panel();
            this.time = new System.Windows.Forms.Label();
            this.btnFilter = new System.Windows.Forms.Button();
            this.panelSubmenu = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.userList = new System.Windows.Forms.Button();
            this.btnPrimary = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelChild = new System.Windows.Forms.Panel();
            this.panelContenedorT = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            this.panelSlider.SuspendLayout();
            this.panelSubmenu.SuspendLayout();
            this.panelContenedorT.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            btnDelete.BackColor = System.Drawing.Color.Transparent;
            btnDelete.BackgroundImage = global::CRUD_SGBD.Properties.Resources.gb_button_default;
            btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDelete.Font = new System.Drawing.Font("Oswald", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnDelete.ForeColor = System.Drawing.Color.Transparent;
            btnDelete.Location = new System.Drawing.Point(375, 630);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(170, 59);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Borrar";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += new System.EventHandler(this.button6_Click);
            // 
            // panelSlider
            // 
            this.panelSlider.AutoScroll = true;
            this.panelSlider.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelSlider.BackColor = System.Drawing.SystemColors.InfoText;
            this.panelSlider.Controls.Add(this.time);
            this.panelSlider.Controls.Add(this.btnFilter);
            this.panelSlider.Controls.Add(this.panelSubmenu);
            this.panelSlider.Controls.Add(this.btnPrimary);
            this.panelSlider.Controls.Add(this.logo);
            this.panelSlider.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSlider.Location = new System.Drawing.Point(0, 0);
            this.panelSlider.Name = "panelSlider";
            this.panelSlider.Size = new System.Drawing.Size(250, 699);
            this.panelSlider.TabIndex = 0;
            this.panelSlider.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.time.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.time.Font = new System.Drawing.Font("Oswald", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.time.Location = new System.Drawing.Point(3, 628);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(83, 53);
            this.time.TabIndex = 1;
            this.time.Text = "Hora:";
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFilter.FlatAppearance.BorderSize = 0;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Font = new System.Drawing.Font("Oswald", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnFilter.Location = new System.Drawing.Point(0, 410);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(0);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnFilter.Size = new System.Drawing.Size(250, 52);
            this.btnFilter.TabIndex = 4;
            this.btnFilter.Text = "Filter";
            this.btnFilter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // panelSubmenu
            // 
            this.panelSubmenu.AutoScroll = true;
            this.panelSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelSubmenu.Controls.Add(this.button5);
            this.panelSubmenu.Controls.Add(this.button1);
            this.panelSubmenu.Controls.Add(this.button4);
            this.panelSubmenu.Controls.Add(this.button3);
            this.panelSubmenu.Controls.Add(this.button2);
            this.panelSubmenu.Controls.Add(this.userList);
            this.panelSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubmenu.Location = new System.Drawing.Point(0, 145);
            this.panelSubmenu.Name = "panelSubmenu";
            this.panelSubmenu.Size = new System.Drawing.Size(250, 265);
            this.panelSubmenu.TabIndex = 3;
            this.panelSubmenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Oswald", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button5.Location = new System.Drawing.Point(0, 200);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(250, 40);
            this.button5.TabIndex = 4;
            this.button5.Text = "Creature Misiones";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Oswald", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.Location = new System.Drawing.Point(0, 160);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(250, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "Misiones Tomadas";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Oswald", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button4.Location = new System.Drawing.Point(0, 120);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(250, 40);
            this.button4.TabIndex = 2;
            this.button4.Text = "Misiones";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Oswald", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button3.Location = new System.Drawing.Point(0, 80);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(250, 40);
            this.button3.TabIndex = 1;
            this.button3.Text = "Creaturas (NPC)";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Oswald", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button2.Location = new System.Drawing.Point(0, 40);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(250, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "Personajes";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // userList
            // 
            this.userList.Dock = System.Windows.Forms.DockStyle.Top;
            this.userList.FlatAppearance.BorderSize = 0;
            this.userList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.userList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userList.Font = new System.Drawing.Font("Oswald", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userList.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.userList.Location = new System.Drawing.Point(0, 0);
            this.userList.Name = "userList";
            this.userList.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.userList.Size = new System.Drawing.Size(250, 40);
            this.userList.TabIndex = 0;
            this.userList.Text = "Usuarios";
            this.userList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.userList.UseVisualStyleBackColor = true;
            this.userList.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPrimary
            // 
            this.btnPrimary.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPrimary.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPrimary.FlatAppearance.BorderSize = 0;
            this.btnPrimary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrimary.Font = new System.Drawing.Font("Oswald", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimary.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnPrimary.Location = new System.Drawing.Point(0, 100);
            this.btnPrimary.Margin = new System.Windows.Forms.Padding(0);
            this.btnPrimary.Name = "btnPrimary";
            this.btnPrimary.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnPrimary.Size = new System.Drawing.Size(250, 45);
            this.btnPrimary.TabIndex = 2;
            this.btnPrimary.Text = "Database";
            this.btnPrimary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrimary.UseVisualStyleBackColor = true;
            this.btnPrimary.Click += new System.EventHandler(this.Media_Click);
            // 
            // logo
            // 
            this.logo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.logo.Location = new System.Drawing.Point(0, 0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(250, 100);
            this.logo.TabIndex = 1;
            this.logo.Paint += new System.Windows.Forms.PaintEventHandler(this.logo_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Location = new System.Drawing.Point(250, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(980, 74);
            this.panel1.TabIndex = 3;
            // 
            // panelChild
            // 
            this.panelChild.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelChild.AutoScroll = true;
            this.panelChild.AutoSize = true;
            this.panelChild.BackColor = System.Drawing.Color.Transparent;
            this.panelChild.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelChild.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panelChild.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.panelChild.Location = new System.Drawing.Point(125, 111);
            this.panelChild.Name = "panelChild";
            this.panelChild.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panelChild.Size = new System.Drawing.Size(755, 351);
            this.panelChild.TabIndex = 2;
            this.panelChild.Paint += new System.Windows.Forms.PaintEventHandler(this.panelChild_Paint);
            // 
            // panelContenedorT
            // 
            this.panelContenedorT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContenedorT.BackColor = System.Drawing.Color.Transparent;
            this.panelContenedorT.BackgroundImage = global::CRUD_SGBD.Properties.Resources.marco_11;
            this.panelContenedorT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelContenedorT.Controls.Add(this.panelChild);
            this.panelContenedorT.Location = new System.Drawing.Point(250, 71);
            this.panelContenedorT.Name = "panelContenedorT";
            this.panelContenedorT.Size = new System.Drawing.Size(980, 560);
            this.panelContenedorT.TabIndex = 4;
            this.panelContenedorT.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenedorT_Paint);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BackgroundImage = global::CRUD_SGBD.Properties.Resources.gb_button_default;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Oswald", 10.2F);
            this.btnSearch.ForeColor = System.Drawing.Color.Transparent;
            this.btnSearch.Location = new System.Drawing.Point(631, 628);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(241, 59);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Visible = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.BackgroundImage = global::CRUD_SGBD.Properties.Resources.gb_button_default;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Oswald", 10.2F);
            this.button6.ForeColor = System.Drawing.Color.Transparent;
            this.button6.Location = new System.Drawing.Point(960, 628);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(170, 59);
            this.button6.TabIndex = 7;
            this.button6.Text = "Texto";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CRUD_SGBD.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(1230, 699);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(btnDelete);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelSlider);
            this.Controls.Add(this.panelContenedorT);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Name = "Home";
            this.Text = "CRUD - BASES DE DATOS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelSlider.ResumeLayout(false);
            this.panelSlider.PerformLayout();
            this.panelSubmenu.ResumeLayout(false);
            this.panelContenedorT.ResumeLayout(false);
            this.panelContenedorT.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSlider;
        private System.Windows.Forms.Button btnPrimary;
        private System.Windows.Forms.Panel panelSubmenu;
        private System.Windows.Forms.Button userList;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel logo;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelChild;
        private System.Windows.Forms.Panel panelContenedorT;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button button6;
    }
}

