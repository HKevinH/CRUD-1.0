namespace CRUD_SGBD
{
    partial class UIMisionesView
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
            this.dataMisiones = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataMisiones)).BeginInit();
            this.SuspendLayout();
            // 
            // dataMisiones
            // 
            this.dataMisiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMisiones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataMisiones.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataMisiones.Location = new System.Drawing.Point(0, 0);
            this.dataMisiones.Name = "dataMisiones";
            this.dataMisiones.RowHeadersWidth = 51;
            this.dataMisiones.RowTemplate.Height = 24;
            this.dataMisiones.Size = new System.Drawing.Size(800, 450);
            this.dataMisiones.TabIndex = 0;
            this.dataMisiones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataMisiones_CellContentClick);
            // 
            // UIMisionesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataMisiones);
            this.Name = "UIMisionesView";
            this.Text = "UIMisionesView";
            this.Load += new System.EventHandler(this.UIMisionesView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataMisiones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataMisiones;
    }
}