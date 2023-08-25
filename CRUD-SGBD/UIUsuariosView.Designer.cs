namespace CRUD_SGBD
{
    partial class UIUsuariosView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataUserList = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataUserList)).BeginInit();
            this.SuspendLayout();
            // 
            // dataUserList
            // 
            this.dataUserList.AllowUserToAddRows = false;
            this.dataUserList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataUserList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(12)))), ((int)(((byte)(9)))));
            this.dataUserList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataUserList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataUserList.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataUserList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Oswald", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataUserList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataUserList.ColumnHeadersHeight = 29;
            this.dataUserList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataUserList.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataUserList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(21)))), ((int)(((byte)(18)))));
            this.dataUserList.Location = new System.Drawing.Point(0, 0);
            this.dataUserList.Name = "dataUserList";
            this.dataUserList.RowHeadersWidth = 51;
            this.dataUserList.RowTemplate.Height = 24;
            this.dataUserList.Size = new System.Drawing.Size(679, 232);
            this.dataUserList.TabIndex = 0;
            this.dataUserList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(308, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // UIUsuariosView
            // 
            this.BackgroundImage = global::CRUD_SGBD.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(679, 447);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataUserList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UIUsuariosView";
            this.Load += new System.EventHandler(this.UIUsuariosView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataUserList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataUserList;
        private System.Windows.Forms.Button button1;
    }
}