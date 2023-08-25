namespace CRUD_SGBD
{
    partial class UIMisionesTomadasView
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
            this.dataMisionesTomadas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataMisionesTomadas)).BeginInit();
            this.SuspendLayout();
            // 
            // dataMisionesTomadas
            // 
            this.dataMisionesTomadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMisionesTomadas.Location = new System.Drawing.Point(22, 83);
            this.dataMisionesTomadas.Name = "dataMisionesTomadas";
            this.dataMisionesTomadas.RowHeadersWidth = 51;
            this.dataMisionesTomadas.RowTemplate.Height = 24;
            this.dataMisionesTomadas.Size = new System.Drawing.Size(687, 310);
            this.dataMisionesTomadas.TabIndex = 0;
            // 
            // UIMisionesTomadasView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataMisionesTomadas);
            this.Name = "UIMisionesTomadasView";
            this.Text = "UIMisionesTomadasView";
            this.Load += new System.EventHandler(this.UIMisionesTomadasView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataMisionesTomadas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataMisionesTomadas;
    }
}