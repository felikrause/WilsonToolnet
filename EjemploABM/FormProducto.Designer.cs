namespace EjemploABM
{
    partial class FormProducto
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
            this.label2 = new System.Windows.Forms.Label();
            this.lb_nombre = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_cantidad = new System.Windows.Forms.NumericUpDown();
            this.btn_cargar_img = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxCat = new System.Windows.Forms.ComboBox();
            this.comboBoxSub = new System.Windows.Forms.ComboBox();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(340, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Crear Producto";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // lb_nombre
            // 
            this.lb_nombre.AutoSize = true;
            this.lb_nombre.Location = new System.Drawing.Point(54, 88);
            this.lb_nombre.Name = "lb_nombre";
            this.lb_nombre.Size = new System.Drawing.Size(47, 13);
            this.lb_nombre.TabIndex = 1;
            this.lb_nombre.Text = "Nombre:";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(107, 85);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(134, 20);
            this.txt_nombre.TabIndex = 2;
            this.txt_nombre.TextChanged += new System.EventHandler(this.txt_nombre_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Descripcion:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(107, 147);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(167, 20);
            this.txt_descripcion.TabIndex = 4;
            this.txt_descripcion.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Precio:";
            // 
            // txt_precio
            // 
            this.txt_precio.Location = new System.Drawing.Point(100, 202);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(100, 20);
            this.txt_precio.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Stock:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Location = new System.Drawing.Point(98, 263);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(120, 20);
            this.txt_cantidad.TabIndex = 8;
            // 
            // btn_cargar_img
            // 
            this.btn_cargar_img.Location = new System.Drawing.Point(377, 88);
            this.btn_cargar_img.Name = "btn_cargar_img";
            this.btn_cargar_img.Size = new System.Drawing.Size(153, 23);
            this.btn_cargar_img.TabIndex = 9;
            this.btn_cargar_img.Text = "Cargar Imagen";
            this.btn_cargar_img.UseVisualStyleBackColor = true;
            this.btn_cargar_img.Click += new System.EventHandler(this.btn_cargar_img_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(313, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Categoria:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(291, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Sub-Categoria:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // comboBoxCat
            // 
            this.comboBoxCat.FormattingEnabled = true;
            this.comboBoxCat.Location = new System.Drawing.Point(377, 177);
            this.comboBoxCat.Name = "comboBoxCat";
            this.comboBoxCat.Size = new System.Drawing.Size(137, 21);
            this.comboBoxCat.TabIndex = 12;
            // 
            // comboBoxSub
            // 
            this.comboBoxSub.FormattingEnabled = true;
            this.comboBoxSub.Location = new System.Drawing.Point(374, 252);
            this.comboBoxSub.Name = "comboBoxSub";
            this.comboBoxSub.Size = new System.Drawing.Size(137, 21);
            this.comboBoxSub.TabIndex = 13;
            this.comboBoxSub.SelectedIndexChanged += new System.EventHandler(this.comboBoxSub_SelectedIndexChanged);
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.Location = new System.Drawing.Point(249, 343);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(169, 49);
            this.btn_confirmar.TabIndex = 14;
            this.btn_confirmar.Text = "Confirmar";
            this.btn_confirmar.UseVisualStyleBackColor = true;
            this.btn_confirmar.Click += new System.EventHandler(this.btn_confirmar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(567, 88);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(261, 287);
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // FormProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 483);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btn_confirmar);
            this.Controls.Add(this.comboBoxSub);
            this.Controls.Add(this.comboBoxCat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_cargar_img);
            this.Controls.Add(this.txt_cantidad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_precio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.lb_nombre);
            this.Controls.Add(this.label2);
            this.Name = "FormProducto";
            this.Text = "FormProducto";
            ((System.ComponentModel.ISupportInitialize)(this.txt_cantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_nombre;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown txt_cantidad;
        private System.Windows.Forms.Button btn_cargar_img;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxCat;
        private System.Windows.Forms.ComboBox comboBoxSub;
        private System.Windows.Forms.Button btn_confirmar;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}