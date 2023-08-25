namespace CRUD_SGBD
{
    partial class UINpcView
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
            this.dataNpc = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataNpc)).BeginInit();
            this.SuspendLayout();
            // 
            // dataNpc
            // 
            this.dataNpc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataNpc.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataNpc.Location = new System.Drawing.Point(0, 0);
            this.dataNpc.Name = "dataNpc";
            this.dataNpc.RowHeadersWidth = 51;
            this.dataNpc.RowTemplate.Height = 24;
            this.dataNpc.Size = new System.Drawing.Size(800, 296);
            this.dataNpc.TabIndex = 0;
            this.dataNpc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataNpc_CellContentClick);
            // 
            // UINpcView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CRUD_SGBD.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataNpc);
            this.Name = "UINpcView";
            this.Text = "UINpcView";
            this.Load += new System.EventHandler(this.UINpcView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataNpc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataNpc;
    }
}