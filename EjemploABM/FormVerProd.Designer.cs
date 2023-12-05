using System;

namespace EjemploABM
{
    partial class FormVerProd
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
            this.txt_id = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.Label();
            this.lb_descripcion = new System.Windows.Forms.Label();
            this.txt_descripcion = new System.Windows.Forms.Label();
            this.lb_precio = new System.Windows.Forms.Label();
            this.txt_precio = new System.Windows.Forms.Label();
            this.lb_stock = new System.Windows.Forms.Label();
            this.txt_stock = new System.Windows.Forms.Label();
            this.lb_subca = new System.Windows.Forms.Label();
            this.txt_subcategoria = new System.Windows.Forms.Label();
            this.lb_cat = new System.Windows.Forms.Label();
            this.txt_categoria = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(309, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ver Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID:";
            // 
            // txt_id
            // 
            this.txt_id.AutoSize = true;
            this.txt_id.Location = new System.Drawing.Point(101, 77);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(18, 13);
            this.txt_id.TabIndex = 2;
            this.txt_id.Text = "ID";
            this.txt_id.Click += new System.EventHandler(this.txt_id_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(524, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre:";
            // 
            // txt_nombre
            // 
            this.txt_nombre.AutoSize = true;
            this.txt_nombre.Location = new System.Drawing.Point(597, 105);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(54, 13);
            this.txt_nombre.TabIndex = 4;
            this.txt_nombre.Text = "NOMBRE";
            // 
            // lb_descripcion
            // 
            this.lb_descripcion.AutoSize = true;
            this.lb_descripcion.Location = new System.Drawing.Point(514, 147);
            this.lb_descripcion.Name = "lb_descripcion";
            this.lb_descripcion.Size = new System.Drawing.Size(66, 13);
            this.lb_descripcion.TabIndex = 5;
            this.lb_descripcion.Text = "Descripcion:";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.AutoSize = true;
            this.txt_descripcion.Location = new System.Drawing.Point(597, 147);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(80, 13);
            this.txt_descripcion.TabIndex = 6;
            this.txt_descripcion.Text = "DESCRIPCION";
            // 
            // lb_precio
            // 
            this.lb_precio.AutoSize = true;
            this.lb_precio.Location = new System.Drawing.Point(524, 186);
            this.lb_precio.Name = "lb_precio";
            this.lb_precio.Size = new System.Drawing.Size(40, 13);
            this.lb_precio.TabIndex = 7;
            this.lb_precio.Text = "Precio:";
            // 
            // txt_precio
            // 
            this.txt_precio.AutoSize = true;
            this.txt_precio.Location = new System.Drawing.Point(597, 186);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(47, 13);
            this.txt_precio.TabIndex = 8;
            this.txt_precio.Text = "PRECIO";
            // 
            // lb_stock
            // 
            this.lb_stock.AutoSize = true;
            this.lb_stock.Location = new System.Drawing.Point(514, 234);
            this.lb_stock.Name = "lb_stock";
            this.lb_stock.Size = new System.Drawing.Size(38, 13);
            this.lb_stock.TabIndex = 9;
            this.lb_stock.Text = "Stock:";
            // 
            // txt_stock
            // 
            this.txt_stock.AutoSize = true;
            this.txt_stock.Location = new System.Drawing.Point(597, 234);
            this.txt_stock.Name = "txt_stock";
            this.txt_stock.Size = new System.Drawing.Size(43, 13);
            this.txt_stock.TabIndex = 10;
            this.txt_stock.Text = "STOCK";
            // 
            // lb_subca
            // 
            this.lb_subca.AutoSize = true;
            this.lb_subca.Location = new System.Drawing.Point(487, 280);
            this.lb_subca.Name = "lb_subca";
            this.lb_subca.Size = new System.Drawing.Size(77, 13);
            this.lb_subca.TabIndex = 11;
            this.lb_subca.Text = "Sub-Categoria:";
            this.lb_subca.Click += new System.EventHandler(this.label10_Click);
            // 
            // txt_subcategoria
            // 
            this.txt_subcategoria.AutoSize = true;
            this.txt_subcategoria.Location = new System.Drawing.Point(597, 280);
            this.txt_subcategoria.Name = "txt_subcategoria";
            this.txt_subcategoria.Size = new System.Drawing.Size(91, 13);
            this.txt_subcategoria.TabIndex = 12;
            this.txt_subcategoria.Text = "SUBCATEGORIA";
            // 
            // lb_cat
            // 
            this.lb_cat.AutoSize = true;
            this.lb_cat.Location = new System.Drawing.Point(497, 329);
            this.lb_cat.Name = "lb_cat";
            this.lb_cat.Size = new System.Drawing.Size(55, 13);
            this.lb_cat.TabIndex = 13;
            this.lb_cat.Text = "Categoria:";
            this.lb_cat.Click += new System.EventHandler(this.lb_cat_Click);
            // 
            // txt_categoria
            // 
            this.txt_categoria.AutoSize = true;
            this.txt_categoria.Location = new System.Drawing.Point(582, 329);
            this.txt_categoria.Name = "txt_categoria";
            this.txt_categoria.Size = new System.Drawing.Size(69, 13);
            this.txt_categoria.TabIndex = 14;
            this.txt_categoria.Text = "CATEGORIA";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(77, 105);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(273, 285);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FormVerProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_categoria);
            this.Controls.Add(this.lb_cat);
            this.Controls.Add(this.txt_subcategoria);
            this.Controls.Add(this.lb_subca);
            this.Controls.Add(this.txt_stock);
            this.Controls.Add(this.lb_stock);
            this.Controls.Add(this.txt_precio);
            this.Controls.Add(this.lb_precio);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.lb_descripcion);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormVerProd";
            this.Text = "FormVerProd_";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label10_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void txt_id_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txt_id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txt_nombre;
        private System.Windows.Forms.Label lb_descripcion;
        private System.Windows.Forms.Label txt_descripcion;
        private System.Windows.Forms.Label lb_precio;
        private System.Windows.Forms.Label txt_precio;
        private System.Windows.Forms.Label lb_stock;
        private System.Windows.Forms.Label txt_stock;
        private System.Windows.Forms.Label lb_subca;
        private System.Windows.Forms.Label txt_subcategoria;
        private System.Windows.Forms.Label lb_cat;
        private System.Windows.Forms.Label txt_categoria;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}