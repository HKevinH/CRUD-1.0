namespace CRUD_SGBD
{
    partial class Conex
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
            System.Windows.Forms.Button btnConectar;
            this.textUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textPass = new System.Windows.Forms.TextBox();
            this.textPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textServer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textDatabase = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panelCont = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            btnConectar = new System.Windows.Forms.Button();
            this.panelCont.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConectar
            // 
            btnConectar.BackColor = System.Drawing.Color.Transparent;
            btnConectar.BackgroundImage = global::CRUD_SGBD.Properties.Resources.gb_button_default;
            btnConectar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnConectar.FlatAppearance.BorderSize = 0;
            btnConectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnConectar.Font = new System.Drawing.Font("Oswald", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnConectar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            btnConectar.Location = new System.Drawing.Point(73, 340);
            btnConectar.Name = "btnConectar";
            btnConectar.Size = new System.Drawing.Size(255, 72);
            btnConectar.TabIndex = 8;
            btnConectar.Text = "Conectar";
            btnConectar.UseVisualStyleBackColor = false;
            btnConectar.Click += new System.EventHandler(this.button1_Click);
            // 
            // textUser
            // 
            this.textUser.Location = new System.Drawing.Point(272, 85);
            this.textUser.Name = "textUser";
            this.textUser.Size = new System.Drawing.Size(100, 22);
            this.textUser.TabIndex = 0;
            this.textUser.TextChanged += new System.EventHandler(this.textUser_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Oswald", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.label1.Location = new System.Drawing.Point(266, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Oswald", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.label2.Location = new System.Drawing.Point(266, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contraseña";
            // 
            // textPass
            // 
            this.textPass.Location = new System.Drawing.Point(272, 152);
            this.textPass.Name = "textPass";
            this.textPass.Size = new System.Drawing.Size(100, 22);
            this.textPass.TabIndex = 3;
            // 
            // textPort
            // 
            this.textPort.Location = new System.Drawing.Point(272, 233);
            this.textPort.Name = "textPort";
            this.textPort.Size = new System.Drawing.Size(100, 22);
            this.textPort.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Oswald", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.label3.Location = new System.Drawing.Point(266, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "Puerto";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textServer
            // 
            this.textServer.Location = new System.Drawing.Point(272, 308);
            this.textServer.Name = "textServer";
            this.textServer.Size = new System.Drawing.Size(100, 22);
            this.textServer.TabIndex = 7;
            this.textServer.TextChanged += new System.EventHandler(this.textServer_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Oswald", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.label4.Location = new System.Drawing.Point(266, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 31);
            this.label4.TabIndex = 6;
            this.label4.Text = "Servidor";
            // 
            // textDatabase
            // 
            this.textDatabase.Location = new System.Drawing.Point(427, 85);
            this.textDatabase.Name = "textDatabase";
            this.textDatabase.Size = new System.Drawing.Size(100, 22);
            this.textDatabase.TabIndex = 10;
            this.textDatabase.TextChanged += new System.EventHandler(this.textDatabase_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Oswald", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.label5.Location = new System.Drawing.Point(421, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 31);
            this.label5.TabIndex = 9;
            this.label5.Text = "Database";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelCont
            // 
            this.panelCont.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCont.BackColor = System.Drawing.Color.Transparent;
            this.panelCont.BackgroundImage = global::CRUD_SGBD.Properties.Resources.divider_2;
            this.panelCont.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelCont.Controls.Add(btnConectar);
            this.panelCont.Location = new System.Drawing.Point(199, 12);
            this.panelCont.Name = "panelCont";
            this.panelCont.Size = new System.Drawing.Size(495, 435);
            this.panelCont.TabIndex = 11;
            this.panelCont.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::CRUD_SGBD.Properties.Resources.divider_2;
            this.panel1.Location = new System.Drawing.Point(199, 430);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(495, 50);
            this.panel1.TabIndex = 12;
            // 
            // Conex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::CRUD_SGBD.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(726, 568);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textDatabase);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textServer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textPort);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textUser);
            this.Controls.Add(this.panelCont);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(68)))), ((int)(((byte)(2)))));
            this.Name = "Conex";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelCont.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textPass;
        private System.Windows.Forms.TextBox textPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textServer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textDatabase;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelCont;
        private System.Windows.Forms.Panel panel1;
    }
}