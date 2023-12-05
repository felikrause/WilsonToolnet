namespace EjemploABM.ControlesDeUsuario
{
    partial class Venta_UC
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
            this.lb_ventas = new System.Windows.Forms.Label();
            this.btn_add_venta = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_ventas
            // 
            this.lb_ventas.AutoSize = true;
            this.lb_ventas.Location = new System.Drawing.Point(44, 49);
            this.lb_ventas.Name = "lb_ventas";
            this.lb_ventas.Size = new System.Drawing.Size(43, 13);
            this.lb_ventas.TabIndex = 0;
            this.lb_ventas.Text = "Ventas:";
            // 
            // btn_add_venta
            // 
            this.btn_add_venta.Location = new System.Drawing.Point(732, 33);
            this.btn_add_venta.Name = "btn_add_venta";
            this.btn_add_venta.Size = new System.Drawing.Size(118, 45);
            this.btn_add_venta.TabIndex = 1;
            this.btn_add_venta.Text = "Agregar";
            this.btn_add_venta.UseVisualStyleBackColor = true;
            this.btn_add_venta.Click += new System.EventHandler(this.btn_add_venta_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(96, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(632, 329);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Venta_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_add_venta);
            this.Controls.Add(this.lb_ventas);
            this.Name = "Venta_UC";
            this.Size = new System.Drawing.Size(910, 501);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_ventas;
        private System.Windows.Forms.Button btn_add_venta;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
