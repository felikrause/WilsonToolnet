using System;
using System.Windows.Forms;

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
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.btn_siguiente = new System.Windows.Forms.Button();
            this.lblPaginaActual = new System.Windows.Forms.Label();
            this.btn_anterior = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ver = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Agregar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewButtonColumn2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewDisponibles = new System.Windows.Forms.DataGridView();
            this.Idd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombree = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precioo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Verr = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Agregarr = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewCarrito = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumnI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_subtotal = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.btn_noeliminar = new System.Windows.Forms.Button();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.txt_mail = new System.Windows.Forms.TextBox();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.txt_descuento = new System.Windows.Forms.TextBox();
            this.guna2Button8 = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisponibles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCarrito)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar:";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(81, 31);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(176, 20);
            this.txtBusqueda.TabIndex = 1;
            // 
            // btn_siguiente
            // 
            this.btn_siguiente.Location = new System.Drawing.Point(272, 80);
            this.btn_siguiente.Name = "btn_siguiente";
            this.btn_siguiente.Size = new System.Drawing.Size(103, 23);
            this.btn_siguiente.TabIndex = 8;
            this.btn_siguiente.Text = "Siguiente";
            this.btn_siguiente.UseVisualStyleBackColor = true;
            // 
            // lblPaginaActual
            // 
            this.lblPaginaActual.AutoSize = true;
            this.lblPaginaActual.Location = new System.Drawing.Point(173, 85);
            this.lblPaginaActual.Name = "lblPaginaActual";
            this.lblPaginaActual.Size = new System.Drawing.Size(73, 13);
            this.lblPaginaActual.TabIndex = 7;
            this.lblPaginaActual.Text = "Pagina 0 de 0";
            // 
            // btn_anterior
            // 
            this.btn_anterior.Location = new System.Drawing.Point(43, 80);
            this.btn_anterior.Name = "btn_anterior";
            this.btn_anterior.Size = new System.Drawing.Size(101, 23);
            this.btn_anterior.TabIndex = 6;
            this.btn_anterior.Text = "Anterior";
            this.btn_anterior.UseVisualStyleBackColor = true;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 8;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 8;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 8;
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Ver
            // 
            this.Ver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ver.HeaderText = "Ver";
            this.Ver.MinimumWidth = 6;
            this.Ver.Name = "Ver";
            this.Ver.ReadOnly = true;
            // 
            // Agregar
            // 
            this.Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Agregar.HeaderText = "Agregar";
            this.Agregar.MinimumWidth = 8;
            this.Agregar.Name = "Agregar";
            this.Agregar.ReadOnly = true;
            this.Agregar.Text = "";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataGridViewButtonColumn1.HeaderText = "Ver";
            this.dataGridViewButtonColumn1.MinimumWidth = 6;
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.ReadOnly = true;
            // 
            // dataGridViewButtonColumn2
            // 
            this.dataGridViewButtonColumn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataGridViewButtonColumn2.HeaderText = "Agregar";
            this.dataGridViewButtonColumn2.MinimumWidth = 8;
            this.dataGridViewButtonColumn2.Name = "dataGridViewButtonColumn2";
            this.dataGridViewButtonColumn2.ReadOnly = true;
            this.dataGridViewButtonColumn2.Text = "";
            // 
            // dataGridViewDisponibles
            // 
            this.dataGridViewDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDisponibles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Idd,
            this.Nombree,
            this.Precioo,
            this.Verr,
            this.Agregarr});
            this.dataGridViewDisponibles.Location = new System.Drawing.Point(13, 119);
            this.dataGridViewDisponibles.Name = "dataGridViewDisponibles";
            this.dataGridViewDisponibles.Size = new System.Drawing.Size(546, 196);
            this.dataGridViewDisponibles.TabIndex = 9;
            this.dataGridViewDisponibles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDisponibles_CellContentClick);
            // 
            // Idd
            // 
            this.Idd.HeaderText = "ID";
            this.Idd.Name = "Idd";
            // 
            // Nombree
            // 
            this.Nombree.HeaderText = "Nombre";
            this.Nombree.Name = "Nombree";
            // 
            // Precioo
            // 
            this.Precioo.HeaderText = "Precio";
            this.Precioo.Name = "Precioo";
            // 
            // Verr
            // 
            this.Verr.HeaderText = "Ver";
            this.Verr.Name = "Verr";
            // 
            // Agregarr
            // 
            this.Agregarr.HeaderText = "Agregar";
            this.Agregarr.Name = "Agregarr";
            // 
            // dataGridViewCarrito
            // 
            this.dataGridViewCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCarrito.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumnI,
            this.dataGridViewTextBoxColumnP,
            this.dataGridViewTextBoxColumnC,
            this.dataGridViewTextBoxColumnN});
            this.dataGridViewCarrito.Location = new System.Drawing.Point(13, 347);
            this.dataGridViewCarrito.Name = "dataGridViewCarrito";
            this.dataGridViewCarrito.Size = new System.Drawing.Size(546, 211);
            this.dataGridViewCarrito.TabIndex = 10;
            this.dataGridViewCarrito.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCarrito_CellContentClick);
            // 
            // dataGridViewTextBoxColumnI
            // 
            this.dataGridViewTextBoxColumnI.HeaderText = "ID";
            this.dataGridViewTextBoxColumnI.Name = "dataGridViewTextBoxColumnI";
            // 
            // dataGridViewTextBoxColumnP
            // 
            this.dataGridViewTextBoxColumnP.HeaderText = "Precio";
            this.dataGridViewTextBoxColumnP.Name = "dataGridViewTextBoxColumnP";
            // 
            // dataGridViewTextBoxColumnC
            // 
            this.dataGridViewTextBoxColumnC.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumnC.Name = "dataGridViewTextBoxColumnC";
            // 
            // dataGridViewTextBoxColumnN
            // 
            this.dataGridViewTextBoxColumnN.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumnN.Name = "dataGridViewTextBoxColumnN";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(718, 390);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 16);
            this.label11.TabIndex = 86;
            this.label11.Text = "Descuento:";
            // 
            // txt_subtotal
            // 
            this.txt_subtotal.AutoSize = true;
            this.txt_subtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt_subtotal.Location = new System.Drawing.Point(816, 357);
            this.txt_subtotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txt_subtotal.Name = "txt_subtotal";
            this.txt_subtotal.Size = new System.Drawing.Size(31, 16);
            this.txt_subtotal.TabIndex = 85;
            this.txt_subtotal.Text = "$$$";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(724, 357);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 16);
            this.label9.TabIndex = 84;
            this.label9.Text = "Subtotal:";
            // 
            // txt_total
            // 
            this.txt_total.AutoSize = true;
            this.txt_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt_total.Location = new System.Drawing.Point(816, 425);
            this.txt_total.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(31, 16);
            this.txt_total.TabIndex = 83;
            this.txt_total.Text = "$$$";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(714, 425);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 16);
            this.label6.TabIndex = 82;
            this.label6.Text = "Precio total:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(572, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 17);
            this.label2.TabIndex = 81;
            this.label2.Text = "Buscar Cliente por Dni:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(726, 305);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 16);
            this.label7.TabIndex = 80;
            this.label7.Text = "Dirección:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(726, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 79;
            this.label5.Text = "Telefono:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(737, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 78;
            this.label4.Text = "Mail:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(726, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 77;
            this.label3.Text = "Apellido:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(726, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 16);
            this.label8.TabIndex = 76;
            this.label8.Text = "Nombre:";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(754, 77);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(169, 20);
            this.txtDni.TabIndex = 87;
            // 
            // btn_noeliminar
            // 
            this.btn_noeliminar.Location = new System.Drawing.Point(929, 75);
            this.btn_noeliminar.Name = "btn_noeliminar";
            this.btn_noeliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_noeliminar.TabIndex = 88;
            this.btn_noeliminar.Text = "Buscar";
            this.btn_noeliminar.UseVisualStyleBackColor = true;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(798, 135);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(124, 20);
            this.txt_nombre.TabIndex = 89;
            this.txt_nombre.TextChanged += new System.EventHandler(this.txt_nombre_TextChanged);
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(798, 176);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(124, 20);
            this.txt_apellido.TabIndex = 90;
            // 
            // txt_mail
            // 
            this.txt_mail.Location = new System.Drawing.Point(783, 221);
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(124, 20);
            this.txt_mail.TabIndex = 91;
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(799, 261);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(124, 20);
            this.txt_telefono.TabIndex = 92;
            // 
            // txt_direccion
            // 
            this.txt_direccion.Location = new System.Drawing.Point(808, 304);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(124, 20);
            this.txt_direccion.TabIndex = 93;
            // 
            // txt_descuento
            // 
            this.txt_descuento.Location = new System.Drawing.Point(808, 389);
            this.txt_descuento.Name = "txt_descuento";
            this.txt_descuento.Size = new System.Drawing.Size(124, 20);
            this.txt_descuento.TabIndex = 94;
            // 
            // guna2Button8
            // 
            this.guna2Button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.guna2Button8.Location = new System.Drawing.Point(772, 470);
            this.guna2Button8.Name = "guna2Button8";
            this.guna2Button8.Size = new System.Drawing.Size(135, 47);
            this.guna2Button8.TabIndex = 95;
            this.guna2Button8.Text = "Nueva Venta";
            this.guna2Button8.UseVisualStyleBackColor = true;
            this.guna2Button8.Click += new System.EventHandler(this.guna2Button8_Click_1);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(565, 200);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(111, 20);
            this.txtCantidad.TabIndex = 96;
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(565, 183);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 13);
            this.label10.TabIndex = 97;
            this.label10.Text = "Cantidad de Productos:";
            // 
            // FormVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 573);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.guna2Button8);
            this.Controls.Add(this.txt_descuento);
            this.Controls.Add(this.txt_direccion);
            this.Controls.Add(this.txt_telefono);
            this.Controls.Add(this.txt_mail);
            this.Controls.Add(this.txt_apellido);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.btn_noeliminar);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_subtotal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridViewCarrito);
            this.Controls.Add(this.dataGridViewDisponibles);
            this.Controls.Add(this.btn_siguiente);
            this.Controls.Add(this.lblPaginaActual);
            this.Controls.Add(this.btn_anterior);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.label1);
            this.Name = "FormVenta";
            this.Text = "FormVenta";
            this.Load += new System.EventHandler(this.FormVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisponibles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCarrito)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Button btn_siguiente;
        private System.Windows.Forms.Label lblPaginaActual;
        private System.Windows.Forms.Button btn_anterior;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewButtonColumn Ver;
        private System.Windows.Forms.DataGridViewButtonColumn Agregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn2;
        private System.Windows.Forms.DataGridView dataGridViewDisponibles;
        private System.Windows.Forms.DataGridView dataGridViewCarrito;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label txt_subtotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label txt_total;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Button btn_noeliminar;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.TextBox txt_mail;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.TextBox txt_descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Idd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombree;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precioo;
        private System.Windows.Forms.DataGridViewButtonColumn Verr;
        private System.Windows.Forms.DataGridViewButtonColumn Agregarr;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnI;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnP;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnC;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnN;
        private System.Windows.Forms.Button guna2Button8;
        private TextBox txtCantidad;
        private Label label10;
    }
}