using System;

namespace AppAlojamentoLocal
{
    partial class MinhasReservas
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
            this.Alojamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateCheckIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateCheckOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alojamentoDbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alojamentoDbDataSet = new AppAlojamentoLocal.AlojamentoDbDataSet();
            this.buttonActualizarRes = new System.Windows.Forms.Button();
            this.button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alojamentoDbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alojamentoDbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Alojamento,
            this.dateCheckIn,
            this.dateCheckOut,
            this.custo});
            this.dataGridView1.DataSource = this.alojamentoDbDataSetBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(218, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(442, 314);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Alojamento
            // 
            this.Alojamento.HeaderText = "Alojamento";
            this.Alojamento.Name = "Alojamento";
            // 
            // dateCheckIn
            // 
            this.dateCheckIn.HeaderText = "Check In";
            this.dateCheckIn.Name = "dateCheckIn";
            // 
            // dateCheckOut
            // 
            this.dateCheckOut.HeaderText = "Check Out";
            this.dateCheckOut.Name = "dateCheckOut";
            // 
            // custo
            // 
            this.custo.HeaderText = "Custo";
            this.custo.Name = "custo";
            // 
            // alojamentoDbDataSetBindingSource
            // 
            this.alojamentoDbDataSetBindingSource.DataSource = this.alojamentoDbDataSet;
            this.alojamentoDbDataSetBindingSource.Position = 0;
            // 
            // alojamentoDbDataSet
            // 
            this.alojamentoDbDataSet.DataSetName = "AlojamentoDbDataSet";
            this.alojamentoDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonActualizarRes
            // 
            this.buttonActualizarRes.Location = new System.Drawing.Point(44, 50);
            this.buttonActualizarRes.Name = "buttonActualizarRes";
            this.buttonActualizarRes.Size = new System.Drawing.Size(75, 23);
            this.buttonActualizarRes.TabIndex = 1;
            this.buttonActualizarRes.Text = "Actualizar";
            this.buttonActualizarRes.UseVisualStyleBackColor = true;
            this.buttonActualizarRes.UseWaitCursor = true;
            this.buttonActualizarRes.Click += new System.EventHandler(this.buttonActualizarRes_Click);
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(44, 184);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(75, 23);
            this.button.TabIndex = 1;
            this.button.Text = "Actualizar";
            this.button.UseVisualStyleBackColor = true;
            this.button.UseWaitCursor = true;
            // 
            // MinhasReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 350);
            this.Controls.Add(this.button);
            this.Controls.Add(this.buttonActualizarRes);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MinhasReservas";
            this.Text = "MinhasReservas";
            this.Load += new System.EventHandler(this.MinhasReservas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alojamentoDbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alojamentoDbDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alojamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateCheckIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateCheckOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn custo;
        private System.Windows.Forms.BindingSource alojamentoDbDataSetBindingSource;
        private AlojamentoDbDataSet alojamentoDbDataSet;
        private System.Windows.Forms.Button buttonActualizarRes;
        private System.Windows.Forms.Button button;
    }
}