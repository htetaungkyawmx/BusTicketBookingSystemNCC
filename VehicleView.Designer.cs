namespace BusTicketBookingSystem
{
    partial class VehicleView
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
            this.vehiclegrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclegrid)).BeginInit();
            this.SuspendLayout();
            // 
            // vehiclegrid
            // 
            this.vehiclegrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vehiclegrid.Location = new System.Drawing.Point(0, 0);
            this.vehiclegrid.Name = "vehiclegrid";
            this.vehiclegrid.RowHeadersWidth = 62;
            this.vehiclegrid.RowTemplate.Height = 28;
            this.vehiclegrid.Size = new System.Drawing.Size(796, 456);
            this.vehiclegrid.TabIndex = 0;
            // 
            // VehicleView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.vehiclegrid);
            this.Name = "VehicleView";
            this.Text = "VehicleView";
            this.Load += new System.EventHandler(this.VehicleView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vehiclegrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView vehiclegrid;
    }
}