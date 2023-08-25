namespace CRUD_SGBD
{
    partial class UICreatureMisionesView
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
            this.dataCreaturesMisiones = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataCreaturesMisiones)).BeginInit();
            this.SuspendLayout();
            // 
            // dataCreaturesMisiones
            // 
            this.dataCreaturesMisiones.AllowDrop = true;
            this.dataCreaturesMisiones.AllowUserToAddRows = false;
            this.dataCreaturesMisiones.AllowUserToResizeColumns = false;
            this.dataCreaturesMisiones.AllowUserToResizeRows = false;
            this.dataCreaturesMisiones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataCreaturesMisiones.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(21)))), ((int)(((byte)(18)))));
            this.dataCreaturesMisiones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataCreaturesMisiones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataCreaturesMisiones.ColumnHeadersHeight = 29;
            this.dataCreaturesMisiones.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataCreaturesMisiones.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataCreaturesMisiones.Location = new System.Drawing.Point(0, 0);
            this.dataCreaturesMisiones.Name = "dataCreaturesMisiones";
            this.dataCreaturesMisiones.RowHeadersWidth = 51;
            this.dataCreaturesMisiones.RowTemplate.Height = 24;
            this.dataCreaturesMisiones.Size = new System.Drawing.Size(844, 373);
            this.dataCreaturesMisiones.TabIndex = 0;
            // 
            // UICreatureMisionesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 478);
            this.Controls.Add(this.dataCreaturesMisiones);
            this.Name = "UICreatureMisionesView";
            this.Text = "UICreatureMisionesView";
            this.Load += new System.EventHandler(this.UICreatureMisionesView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataCreaturesMisiones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataCreaturesMisiones;
    }
}