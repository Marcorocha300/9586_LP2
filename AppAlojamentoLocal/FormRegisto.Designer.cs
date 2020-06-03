namespace AppAlojamentoLocal
{
    partial class FormRegisto
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
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.textBoxSobrenome = new System.Windows.Forms.TextBox();
            this.labelRegisto = new System.Windows.Forms.Label();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.textPhone = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textUserName = new System.Windows.Forms.TextBox();
            this.labelSobrenome = new System.Windows.Forms.Label();
            this.textNome = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.buttonCancelReg = new System.Windows.Forms.Button();
            this.buttonAddReg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(74, 220);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(32, 13);
            this.labelEmail.TabIndex = 22;
            this.labelEmail.Text = "Email";
            this.labelEmail.Click += new System.EventHandler(this.labelEmail_Click);
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(71, 181);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(38, 13);
            this.labelPhone.TabIndex = 21;
            this.labelPhone.Text = "Phone";
            this.labelPhone.Click += new System.EventHandler(this.labelPhone_Click);
            // 
            // textBoxSobrenome
            // 
            this.textBoxSobrenome.Location = new System.Drawing.Point(377, 84);
            this.textBoxSobrenome.Name = "textBoxSobrenome";
            this.textBoxSobrenome.Size = new System.Drawing.Size(100, 20);
            this.textBoxSobrenome.TabIndex = 20;
            this.textBoxSobrenome.TextChanged += new System.EventHandler(this.textBoxSobrenome_TextChanged);
            // 
            // labelRegisto
            // 
            this.labelRegisto.AutoSize = true;
            this.labelRegisto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegisto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelRegisto.Location = new System.Drawing.Point(261, 21);
            this.labelRegisto.Name = "labelRegisto";
            this.labelRegisto.Size = new System.Drawing.Size(64, 20);
            this.labelRegisto.TabIndex = 12;
            this.labelRegisto.Text = "Registo";
            this.labelRegisto.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(148, 214);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(100, 20);
            this.textEmail.TabIndex = 18;
            this.textEmail.TextChanged += new System.EventHandler(this.textEmail_TextChanged);
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(377, 46);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(100, 20);
            this.textPassword.TabIndex = 17;
            this.textPassword.TextChanged += new System.EventHandler(this.textPassword_TextChanged);
            // 
            // textPhone
            // 
            this.textPhone.Location = new System.Drawing.Point(148, 174);
            this.textPhone.Name = "textPhone";
            this.textPhone.Size = new System.Drawing.Size(100, 20);
            this.textPhone.TabIndex = 16;
            this.textPhone.TextChanged += new System.EventHandler(this.textPhone_TextChanged);
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(148, 128);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(100, 20);
            this.textBoxAddress.TabIndex = 15;
            this.textBoxAddress.TextChanged += new System.EventHandler(this.textBoxAddress_TextChanged);
            // 
            // textUserName
            // 
            this.textUserName.Location = new System.Drawing.Point(148, 46);
            this.textUserName.Name = "textUserName";
            this.textUserName.Size = new System.Drawing.Size(100, 20);
            this.textUserName.TabIndex = 19;
            this.textUserName.TextChanged += new System.EventHandler(this.textUserName_TextChanged);
            // 
            // labelSobrenome
            // 
            this.labelSobrenome.AutoSize = true;
            this.labelSobrenome.Location = new System.Drawing.Point(302, 84);
            this.labelSobrenome.Name = "labelSobrenome";
            this.labelSobrenome.Size = new System.Drawing.Size(61, 13);
            this.labelSobrenome.TabIndex = 11;
            this.labelSobrenome.Text = "Sobrenome";
            this.labelSobrenome.Click += new System.EventHandler(this.labelSobrenome_Click);
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(148, 87);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(100, 20);
            this.textNome.TabIndex = 13;
            this.textNome.TextChanged += new System.EventHandler(this.textNome_TextChanged);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(318, 49);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(53, 13);
            this.labelPassword.TabIndex = 12;
            this.labelPassword.Text = "Password";
            this.labelPassword.Click += new System.EventHandler(this.labelPassword_Click);
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(67, 131);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(45, 13);
            this.labelAddress.TabIndex = 9;
            this.labelAddress.Text = "Address";
            this.labelAddress.Click += new System.EventHandler(this.labelAddress_Click);
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(46, 49);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(60, 13);
            this.labelUserName.TabIndex = 7;
            this.labelUserName.Text = "User Name";
            this.labelUserName.Click += new System.EventHandler(this.labelUserName_Click);
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(71, 87);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(35, 13);
            this.labelNome.TabIndex = 5;
            this.labelNome.Text = "Nome";
            this.labelNome.Click += new System.EventHandler(this.labelNome_Click);
            // 
            // buttonCancelReg
            // 
            this.buttonCancelReg.Location = new System.Drawing.Point(391, 181);
            this.buttonCancelReg.Name = "buttonCancelReg";
            this.buttonCancelReg.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelReg.TabIndex = 4;
            this.buttonCancelReg.Text = "Cancel";
            this.buttonCancelReg.UseVisualStyleBackColor = true;
            this.buttonCancelReg.Click += new System.EventHandler(this.buttonCancelReg_Click);
            // 
            // buttonAddReg
            // 
            this.buttonAddReg.Location = new System.Drawing.Point(391, 143);
            this.buttonAddReg.Name = "buttonAddReg";
            this.buttonAddReg.Size = new System.Drawing.Size(75, 23);
            this.buttonAddReg.TabIndex = 3;
            this.buttonAddReg.Text = "Adicionar";
            this.buttonAddReg.UseVisualStyleBackColor = true;
            this.buttonAddReg.Click += new System.EventHandler(this.buttonAddReg_Click);
            // 
            // FormRegisto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 257);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelRegisto);
            this.Controls.Add(this.textBoxSobrenome);
            this.Controls.Add(this.buttonAddReg);
            this.Controls.Add(this.buttonCancelReg);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.textPhone);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textUserName);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.labelSobrenome);
            this.Name = "FormRegisto";
            this.Text = "FormRegisto";
            this.Load += new System.EventHandler(this.FormRegisto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.TextBox textBoxSobrenome;
        private System.Windows.Forms.Label labelRegisto;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.TextBox textPhone;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textUserName;
        private System.Windows.Forms.Label labelSobrenome;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Button buttonCancelReg;
        private System.Windows.Forms.Button buttonAddReg;
    }
}