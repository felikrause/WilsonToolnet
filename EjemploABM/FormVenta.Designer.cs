namespace EjemploABM
{
    partial class FormVenta
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.btn_registrar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_siguiente = new System.Windows.Forms.Button();
            this.lblPaginaActual = new System.Windows.Forms.Label();
            this.btn_anterior = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(324, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Control de registro de ventas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(700, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha Actual:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha.Location = new System.Drawing.Point(803, 35);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(63, 18);
            this.lbl_fecha.TabIndex = 2;
            this.lbl_fecha.Text = "lblFecha";
            // 
            // btn_registrar
            // 
            this.btn_registrar.Location = new System.Drawing.Point(739, 487);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(75, 23);
            this.btn_registrar.TabIndex = 6;
            this.btn_registrar.Text = "Comprar";
            this.btn_registrar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 222);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(516, 277);
            this.dataGridView1.TabIndex = 7;
            // 
            // btn_siguiente
            // 
            this.btn_siguiente.Location = new System.Drawing.Point(316, 186);
            this.btn_siguiente.Name = "btn_siguiente";
            this.btn_siguiente.Size = new System.Drawing.Size(103, 30);
            this.btn_siguiente.TabIndex = 10;
            this.btn_siguiente.Text = "Siguiente";
            this.btn_siguiente.UseVisualStyleBackColor = true;
            // 
            // lblPaginaActual
            // 
            this.lblPaginaActual.AutoSize = true;
            this.lblPaginaActual.Location = new System.Drawing.Point(217, 198);
            this.lblPaginaActual.Name = "lblPaginaActual";
            this.lblPaginaActual.Size = new System.Drawing.Size(73, 13);
            this.lblPaginaActual.TabIndex = 9;
            this.lblPaginaActual.Text = "Pagina 0 de 0";
            // 
            // btn_anterior
            // 
            this.btn_anterior.Location = new System.Drawing.Point(87, 186);
            this.btn_anterior.Name = "btn_anterior";
            this.btn_anterior.Size = new System.Drawing.Size(101, 30);
            this.btn_anterior.TabIndex = 8;
            this.btn_anterior.Text = "Anterior";
            this.btn_anterior.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(132, 95);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(299, 21);
            this.comboBox1.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Productos disponibles:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(444, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Agregar ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(230, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Carrito:";
            // 
            // FormVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 536);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_siguiente);
            this.Controls.Add(this.lblPaginaActual);
            this.Controls.Add(this.btn_anterior);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_registrar);
            this.Controls.Add(this.lbl_fecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormVenta";
            this.Text = "FormVenta";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.Button btn_registrar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_siguiente;
        private System.Windows.Forms.Label lblPaginaActual;
        private System.Windows.Forms.Button btn_anterior;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
    }
}