namespace Excursion
{
    partial class Riscoss
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
            this.btnSeleccionarElementos = new System.Windows.Forms.Button();
            this.txtNombreRisco = new System.Windows.Forms.TextBox();
            this.txtCalorias = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.lblRisco = new System.Windows.Forms.Label();
            this.lblCalorias = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvElementosSeleccionados = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvElementosSeleccionados)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSeleccionarElementos
            // 
            this.btnSeleccionarElementos.Location = new System.Drawing.Point(142, 223);
            this.btnSeleccionarElementos.Name = "btnSeleccionarElementos";
            this.btnSeleccionarElementos.Size = new System.Drawing.Size(197, 49);
            this.btnSeleccionarElementos.TabIndex = 0;
            this.btnSeleccionarElementos.Text = "Seleccionar Elementos";
            this.btnSeleccionarElementos.UseVisualStyleBackColor = true;
            this.btnSeleccionarElementos.Click += new System.EventHandler(this.btnSeleccionarElementos_Click);
            // 
            // txtNombreRisco
            // 
            this.txtNombreRisco.Location = new System.Drawing.Point(23, 108);
            this.txtNombreRisco.Name = "txtNombreRisco";
            this.txtNombreRisco.Size = new System.Drawing.Size(166, 22);
            this.txtNombreRisco.TabIndex = 1;
            // 
            // txtCalorias
            // 
            this.txtCalorias.Location = new System.Drawing.Point(20, 54);
            this.txtCalorias.Name = "txtCalorias";
            this.txtCalorias.Size = new System.Drawing.Size(100, 22);
            this.txtCalorias.TabIndex = 2;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(20, 134);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(100, 22);
            this.txtPeso.TabIndex = 3;
            // 
            // lblRisco
            // 
            this.lblRisco.AutoSize = true;
            this.lblRisco.Location = new System.Drawing.Point(20, 73);
            this.lblRisco.Name = "lblRisco";
            this.lblRisco.Size = new System.Drawing.Size(120, 17);
            this.lblRisco.TabIndex = 4;
            this.lblRisco.Text = "Nombre del Risco";
            // 
            // lblCalorias
            // 
            this.lblCalorias.AutoSize = true;
            this.lblCalorias.Location = new System.Drawing.Point(17, 34);
            this.lblCalorias.Name = "lblCalorias";
            this.lblCalorias.Size = new System.Drawing.Size(59, 17);
            this.lblCalorias.TabIndex = 5;
            this.lblCalorias.Text = "Calorias";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(17, 114);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(40, 17);
            this.lblPeso.TabIndex = 6;
            this.lblPeso.Text = "Peso";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.lblRisco);
            this.groupBox1.Controls.Add(this.txtNombreRisco);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(467, 195);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información del Risco";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblPeso);
            this.groupBox2.Controls.Add(this.lblCalorias);
            this.groupBox2.Controls.Add(this.txtPeso);
            this.groupBox2.Controls.Add(this.txtCalorias);
            this.groupBox2.Location = new System.Drawing.Point(235, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(222, 163);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Requerimientos";
            // 
            // dgvElementosSeleccionados
            // 
            this.dgvElementosSeleccionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvElementosSeleccionados.Location = new System.Drawing.Point(13, 294);
            this.dgvElementosSeleccionados.Name = "dgvElementosSeleccionados";
            this.dgvElementosSeleccionados.RowTemplate.Height = 24;
            this.dgvElementosSeleccionados.Size = new System.Drawing.Size(467, 155);
            this.dgvElementosSeleccionados.TabIndex = 8;
            // 
            // Riscoss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 461);
            this.Controls.Add(this.dgvElementosSeleccionados);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSeleccionarElementos);
            this.Name = "Riscoss";
            this.Text = "Riscos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvElementosSeleccionados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSeleccionarElementos;
        private System.Windows.Forms.TextBox txtNombreRisco;
        private System.Windows.Forms.TextBox txtCalorias;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label lblRisco;
        private System.Windows.Forms.Label lblCalorias;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvElementosSeleccionados;
    }
}