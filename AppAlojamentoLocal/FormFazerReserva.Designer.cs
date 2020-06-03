namespace AppAlojamentoLocal
{
    partial class FormFazerReserva
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
            this.labelNumBungalow = new System.Windows.Forms.Label();
            this.labelCheckOut = new System.Windows.Forms.Label();
            this.labelcheckIn = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.MenuRegisto = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.butonConfirmarReserva = new System.Windows.Forms.Button();
            this.textBoxNumBungalow = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelNumBungalow
            // 
            this.labelNumBungalow.AutoSize = true;
            this.labelNumBungalow.Location = new System.Drawing.Point(22, 81);
            this.labelNumBungalow.Name = "labelNumBungalow";
            this.labelNumBungalow.Size = new System.Drawing.Size(69, 13);
            this.labelNumBungalow.TabIndex = 0;
            this.labelNumBungalow.Text = "Bungalow Nº";
            // 
            // labelCheckOut
            // 
            this.labelCheckOut.AutoSize = true;
            this.labelCheckOut.Location = new System.Drawing.Point(33, 172);
            this.labelCheckOut.Name = "labelCheckOut";
            this.labelCheckOut.Size = new System.Drawing.Size(58, 13);
            this.labelCheckOut.TabIndex = 15;
            this.labelCheckOut.Text = "Check Out";
            // 
            // labelcheckIn
            // 
            this.labelcheckIn.AutoSize = true;
            this.labelcheckIn.Location = new System.Drawing.Point(33, 128);
            this.labelcheckIn.Name = "labelcheckIn";
            this.labelcheckIn.Size = new System.Drawing.Size(50, 13);
            this.labelcheckIn.TabIndex = 14;
            this.labelcheckIn.Text = "Check In";
            this.labelcheckIn.Click += new System.EventHandler(this.labelcheckIn_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(108, 166);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(236, 20);
            this.dateTimePicker2.TabIndex = 13;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(108, 128);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(236, 20);
            this.dateTimePicker1.TabIndex = 12;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // MenuRegisto
            // 
            this.MenuRegisto.AutoSize = true;
            this.MenuRegisto.BackColor = System.Drawing.SystemColors.HotTrack;
            this.MenuRegisto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuRegisto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.MenuRegisto.Location = new System.Drawing.Point(125, 9);
            this.MenuRegisto.Name = "MenuRegisto";
            this.MenuRegisto.Size = new System.Drawing.Size(90, 25);
            this.MenuRegisto.TabIndex = 11;
            this.MenuRegisto.Text = "Reservar";
            this.MenuRegisto.UseMnemonic = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(64, 219);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 10;
            this.button4.Text = "Exit";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // butonConfirmarReserva
            // 
            this.butonConfirmarReserva.Location = new System.Drawing.Point(190, 219);
            this.butonConfirmarReserva.Name = "butonConfirmarReserva";
            this.butonConfirmarReserva.Size = new System.Drawing.Size(75, 23);
            this.butonConfirmarReserva.TabIndex = 9;
            this.butonConfirmarReserva.Text = "Confirmar";
            this.butonConfirmarReserva.UseVisualStyleBackColor = true;
            this.butonConfirmarReserva.Click += new System.EventHandler(this.butonConfirmarReserva_Click);
            // 
            // textBoxNumBungalow
            // 
            this.textBoxNumBungalow.Location = new System.Drawing.Point(108, 78);
            this.textBoxNumBungalow.Name = "textBoxNumBungalow";
            this.textBoxNumBungalow.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumBungalow.TabIndex = 16;
            this.textBoxNumBungalow.TextChanged += new System.EventHandler(this.textBoxNumBungalow_TextChanged);
            // 
            // FormFazerReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 257);
            this.Controls.Add(this.textBoxNumBungalow);
            this.Controls.Add(this.labelCheckOut);
            this.Controls.Add(this.labelcheckIn);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.MenuRegisto);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.butonConfirmarReserva);
            this.Controls.Add(this.labelNumBungalow);
            this.Name = "FormFazerReserva";
            this.Text = "FormFazerReserva";
            this.Load += new System.EventHandler(this.FormFazerReserva_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNumBungalow;
        private System.Windows.Forms.Label labelCheckOut;
        private System.Windows.Forms.Label labelcheckIn;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label MenuRegisto;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button butonConfirmarReserva;
        private System.Windows.Forms.TextBox textBoxNumBungalow;
    }
}