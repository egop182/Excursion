namespace Excursion
{
    partial class Elementoss
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnIngresar = new System.Windows.Forms.Button();
            this.lblElemento = new System.Windows.Forms.Label();
            this.lblCalorias = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.txtElemento = new System.Windows.Forms.TextBox();
            this.txtCalorias = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.riscosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIngresar
            // 
            this.btnIngresar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnIngresar.Location = new System.Drawing.Point(117, 251);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(153, 33);
            this.btnIngresar.TabIndex = 0;
            this.btnIngresar.Text = "Guardar Elemento";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // lblElemento
            // 
            this.lblElemento.AutoSize = true;
            this.lblElemento.Location = new System.Drawing.Point(167, 46);
            this.lblElemento.Name = "lblElemento";
            this.lblElemento.Size = new System.Drawing.Size(67, 17);
            this.lblElemento.TabIndex = 1;
            this.lblElemento.Text = "Elemento";
            // 
            // lblCalorias
            // 
            this.lblCalorias.AutoSize = true;
            this.lblCalorias.Location = new System.Drawing.Point(43, 137);
            this.lblCalorias.Name = "lblCalorias";
            this.lblCalorias.Size = new System.Drawing.Size(59, 17);
            this.lblCalorias.TabIndex = 2;
            this.lblCalorias.Text = "Calorias";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(242, 137);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(40, 17);
            this.lblPeso.TabIndex = 3;
            this.lblPeso.Text = "Peso";
            // 
            // txtElemento
            // 
            this.txtElemento.Location = new System.Drawing.Point(106, 91);
            this.txtElemento.Name = "txtElemento";
            this.txtElemento.Size = new System.Drawing.Size(173, 22);
            this.txtElemento.TabIndex = 4;
            // 
            // txtCalorias
            // 
            this.txtCalorias.Location = new System.Drawing.Point(46, 174);
            this.txtCalorias.Name = "txtCalorias";
            this.txtCalorias.Size = new System.Drawing.Size(87, 22);
            this.txtCalorias.TabIndex = 5;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(245, 174);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(89, 22);
            this.txtPeso.TabIndex = 6;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.riscosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(372, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // riscosToolStripMenuItem
            // 
            this.riscosToolStripMenuItem.Name = "riscosToolStripMenuItem";
            this.riscosToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.riscosToolStripMenuItem.Text = "Riscos";
            this.riscosToolStripMenuItem.Click += new System.EventHandler(this.riscosToolStripMenuItem_Click);
            // 
            // Elementoss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 340);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.txtCalorias);
            this.Controls.Add(this.txtElemento);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.lblCalorias);
            this.Controls.Add(this.lblElemento);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Elementoss";
            this.Text = "Elementos";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label lblElemento;
        private System.Windows.Forms.Label lblCalorias;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.TextBox txtElemento;
        private System.Windows.Forms.TextBox txtCalorias;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem riscosToolStripMenuItem;
    }
}

