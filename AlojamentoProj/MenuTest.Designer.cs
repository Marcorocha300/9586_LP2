namespace AlojamentoProj
{
    partial class MenuTest
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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.MenuRegisto = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.checkIn = new System.Windows.Forms.Label();
            this.checkOut = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(185, 112);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(185, 153);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(185, 195);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Exit";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // MenuRegisto
            // 
            this.MenuRegisto.AutoSize = true;
            this.MenuRegisto.BackColor = System.Drawing.SystemColors.HotTrack;
            this.MenuRegisto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuRegisto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.MenuRegisto.Location = new System.Drawing.Point(190, 12);
            this.MenuRegisto.Name = "MenuRegisto";
            this.MenuRegisto.Size = new System.Drawing.Size(90, 25);
            this.MenuRegisto.TabIndex = 4;
            this.MenuRegisto.Text = "Reservar";
            this.MenuRegisto.UseMnemonic = false;
            this.MenuRegisto.Click += new System.EventHandler(this.MenuRegisto_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(370, 128);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(236, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(370, 166);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(236, 20);
            this.dateTimePicker2.TabIndex = 6;
            // 
            // checkIn
            // 
            this.checkIn.AutoSize = true;
            this.checkIn.Location = new System.Drawing.Point(295, 128);
            this.checkIn.Name = "checkIn";
            this.checkIn.Size = new System.Drawing.Size(50, 13);
            this.checkIn.TabIndex = 7;
            this.checkIn.Text = "Check In";
            this.checkIn.Click += new System.EventHandler(this.CheckIn_Click);
            // 
            // checkOut
            // 
            this.checkOut.AutoSize = true;
            this.checkOut.Location = new System.Drawing.Point(295, 172);
            this.checkOut.Name = "checkOut";
            this.checkOut.Size = new System.Drawing.Size(58, 13);
            this.checkOut.TabIndex = 8;
            this.checkOut.Text = "Check Out";
            this.checkOut.Click += new System.EventHandler(this.CheckOut_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(695, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 341);
            this.Controls.Add(this.checkOut);
            this.Controls.Add(this.checkIn);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.MenuRegisto);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuTest";
            this.Text = "MenuTest";
            this.Load += new System.EventHandler(this.MenuTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label MenuRegisto;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label checkIn;
        private System.Windows.Forms.Label checkOut;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}