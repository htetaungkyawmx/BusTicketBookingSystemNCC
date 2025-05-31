namespace BusTicketBookingSystem
{
    partial class Kyaw
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
            this.userNameVariable = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userNameVariable
            // 
            this.userNameVariable.AutoSize = true;
            this.userNameVariable.Location = new System.Drawing.Point(44, 32);
            this.userNameVariable.Name = "userNameVariable";
            this.userNameVariable.Size = new System.Drawing.Size(89, 20);
            this.userNameVariable.TabIndex = 0;
            this.userNameVariable.Text = "User Name";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(356, 215);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(117, 30);
            this.password.TabIndex = 1;
            this.password.Text = "Password";
            this.password.Click += new System.EventHandler(this.label1_Click);
            // 
            // Kyaw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 628);
            this.Controls.Add(this.password);
            this.Controls.Add(this.userNameVariable);
            this.Name = "Kyaw";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userNameVariable;
        private System.Windows.Forms.Label password;
    }
}