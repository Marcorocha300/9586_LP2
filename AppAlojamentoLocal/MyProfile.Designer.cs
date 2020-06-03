namespace AppAlojamentoLocal
{
    partial class MyProfile
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.alojamentoDbDataSet = new AppAlojamentoLocal.AlojamentoDbDataSet();
            this.alojamentoDbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passWord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alojamentoDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alojamentoDbDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userName,
            this.passWord,
            this.nome});
            this.dataGridView1.DataSource = this.alojamentoDbDataSetBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(252, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(484, 312);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // alojamentoDbDataSet
            // 
            this.alojamentoDbDataSet.DataSetName = "AlojamentoDbDataSet";
            this.alojamentoDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alojamentoDbDataSetBindingSource
            // 
            this.alojamentoDbDataSetBindingSource.DataSource = this.alojamentoDbDataSet;
            this.alojamentoDbDataSetBindingSource.Position = 0;
            // 
            // userName
            // 
            this.userName.HeaderText = "User Name";
            this.userName.Name = "userName";
            // 
            // passWord
            // 
            this.passWord.HeaderText = "Password";
            this.passWord.Name = "passWord";
            // 
            // nome
            // 
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            // 
            // MyProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MyProfile";
            this.Text = "MyProfile";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alojamentoDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alojamentoDbDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn userName;
        private System.Windows.Forms.DataGridViewTextBoxColumn passWord;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.BindingSource alojamentoDbDataSetBindingSource;
        private AlojamentoDbDataSet alojamentoDbDataSet;
    }
}