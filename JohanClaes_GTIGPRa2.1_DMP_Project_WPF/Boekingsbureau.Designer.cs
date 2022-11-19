
namespace JohanClaes_GTIGPRa2._1_DMP_Project_WPF
{
    partial class Boekingsbureau
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
            this.txtBureauName = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBureauName
            // 
            this.txtBureauName.Location = new System.Drawing.Point(125, 65);
            this.txtBureauName.Name = "txtBureauName";
            this.txtBureauName.Size = new System.Drawing.Size(150, 22);
            this.txtBureauName.TabIndex = 0;
            this.txtBureauName.Text = "dollepret";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(125, 140);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(150, 23);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Login bureau";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Boekingsbureau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtBureauName);
            this.Name = "Boekingsbureau";
            this.Text = "Boekingsbureau";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBureauName;
        private System.Windows.Forms.Button btnLogin;
    }
}