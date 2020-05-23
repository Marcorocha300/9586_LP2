namespace AlojamentoProj
{
    partial class Menu1
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
            this.btnGoToLogin = new System.Windows.Forms.Button();
            this.btnGoToRegist = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTitulo1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGoToLogin
            // 
            this.btnGoToLogin.Location = new System.Drawing.Point(55, 74);
            this.btnGoToLogin.Name = "btnGoToLogin";
            this.btnGoToLogin.Size = new System.Drawing.Size(125, 23);
            this.btnGoToLogin.TabIndex = 0;
            this.btnGoToLogin.Text = "LOGIN";
            this.btnGoToLogin.UseVisualStyleBackColor = true;
            this.btnGoToLogin.UseWaitCursor = true;
            this.btnGoToLogin.Click += new System.EventHandler(this.btnGoToLogin_Click);
            // 
            // btnGoToRegist
            // 
            this.btnGoToRegist.Location = new System.Drawing.Point(55, 135);
            this.btnGoToRegist.Name = "btnGoToRegist";
            this.btnGoToRegist.Size = new System.Drawing.Size(125, 23);
            this.btnGoToRegist.TabIndex = 1;
            this.btnGoToRegist.Text = "REGISTRATION";
            this.btnGoToRegist.UseVisualStyleBackColor = true;
            this.btnGoToRegist.Click += new System.EventHandler(this.btnGoToRegist_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(55, 189);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(125, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelTitulo1);
            this.panel1.Controls.Add(this.btnGoToLogin);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnGoToRegist);
            this.panel1.Location = new System.Drawing.Point(324, 104);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 238);
            this.panel1.TabIndex = 3;
            // 
            // labelTitulo1
            // 
            this.labelTitulo1.AutoSize = true;
            this.labelTitulo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo1.Location = new System.Drawing.Point(23, 24);
            this.labelTitulo1.Name = "labelTitulo1";
            this.labelTitulo1.Size = new System.Drawing.Size(177, 25);
            this.labelTitulo1.TabIndex = 4;
            this.labelTitulo1.Text = "Alojamento Local";
            // 
            // Menu1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 454);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Name = "Menu1";
            this.Text = "Nenu1";
            this.Load += new System.EventHandler(this.Menu1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGoToLogin;
        private System.Windows.Forms.Button btnGoToRegist;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTitulo1;
    }
}