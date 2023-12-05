
using System;

namespace EjemploABM.ControlesDeUsuario
{
    partial class Productos_UC
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.btn_anterior = new System.Windows.Forms.Button();
            this.lblPaginaActual = new System.Windows.Forms.Label();
            this.btn_siguiente = new System.Windows.Forms.Button();
            this.btn_add_cat = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Productos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Buscar:";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(62, 72);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(143, 20);
            this.txtBusqueda.TabIndex = 2;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // btn_anterior
            // 
            this.btn_anterior.Location = new System.Drawing.Point(299, 62);
            this.btn_anterior.Name = "btn_anterior";
            this.btn_anterior.Size = new System.Drawing.Size(101, 23);
            this.btn_anterior.TabIndex = 3;
            this.btn_anterior.Text = "Anterior";
            this.btn_anterior.UseVisualStyleBackColor = true;
            // 
            // lblPaginaActual
            // 
            this.lblPaginaActual.AutoSize = true;
            this.lblPaginaActual.Location = new System.Drawing.Point(429, 67);
            this.lblPaginaActual.Name = "lblPaginaActual";
            this.lblPaginaActual.Size = new System.Drawing.Size(73, 13);
            this.lblPaginaActual.TabIndex = 4;
            this.lblPaginaActual.Text = "Pagina 0 de 0";
            this.lblPaginaActual.Click += new System.EventHandler(this.label3_Click);
            // 
            // btn_siguiente
            // 
            this.btn_siguiente.Location = new System.Drawing.Point(528, 62);
            this.btn_siguiente.Name = "btn_siguiente";
            this.btn_siguiente.Size = new System.Drawing.Size(103, 23);
            this.btn_siguiente.TabIndex = 5;
            this.btn_siguiente.Text = "Siguiente";
            this.btn_siguiente.UseVisualStyleBackColor = true;
            this.btn_siguiente.Click += new System.EventHandler(this.btn_siguiente_Click);
            // 
            // btn_add_cat
            // 
            this.btn_add_cat.Location = new System.Drawing.Point(782, 56);
            this.btn_add_cat.Name = "btn_add_cat";
            this.btn_add_cat.Size = new System.Drawing.Size(128, 29);
            this.btn_add_cat.TabIndex = 6;
            this.btn_add_cat.Text = "Agregar";
            this.btn_add_cat.UseVisualStyleBackColor = true;
            this.btn_add_cat.Click += new System.EventHandler(this.btn_add_cat_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(884, 381);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Productos_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_add_cat);
            this.Controls.Add(this.btn_siguiente);
            this.Controls.Add(this.lblPaginaActual);
            this.Controls.Add(this.btn_anterior);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Productos_UC";
            this.Size = new System.Drawing.Size(938, 510);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label3_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Button btn_anterior;
        private System.Windows.Forms.Label lblPaginaActual;
        private System.Windows.Forms.Button btn_siguiente;
        private System.Windows.Forms.Button btn_add_cat;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
