namespace EjemploABM
{
    partial class Index
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
            this.btn_prods = new System.Windows.Forms.Button();
            this.btn_cat = new System.Windows.Forms.Button();
            this.btn_subca = new System.Windows.Forms.Button();
            this.btn_ventas = new System.Windows.Forms.Button();
            this.btn_usr = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btn_prods
            // 
            this.btn_prods.Location = new System.Drawing.Point(12, 36);
            this.btn_prods.Name = "btn_prods";
            this.btn_prods.Size = new System.Drawing.Size(87, 37);
            this.btn_prods.TabIndex = 0;
            this.btn_prods.Text = "Productos";
            this.btn_prods.UseVisualStyleBackColor = true;
            this.btn_prods.Click += new System.EventHandler(this.btn_prods_Click);
            // 
            // btn_cat
            // 
            this.btn_cat.Location = new System.Drawing.Point(12, 103);
            this.btn_cat.Name = "btn_cat";
            this.btn_cat.Size = new System.Drawing.Size(87, 39);
            this.btn_cat.TabIndex = 1;
            this.btn_cat.Text = "Categorias";
            this.btn_cat.UseVisualStyleBackColor = true;
            // 
            // btn_subca
            // 
            this.btn_subca.Location = new System.Drawing.Point(12, 183);
            this.btn_subca.Name = "btn_subca";
            this.btn_subca.Size = new System.Drawing.Size(87, 40);
            this.btn_subca.TabIndex = 2;
            this.btn_subca.Text = "Sub-Categorias";
            this.btn_subca.UseVisualStyleBackColor = true;
            // 
            // btn_ventas
            // 
            this.btn_ventas.Location = new System.Drawing.Point(12, 260);
            this.btn_ventas.Name = "btn_ventas";
            this.btn_ventas.Size = new System.Drawing.Size(87, 42);
            this.btn_ventas.TabIndex = 3;
            this.btn_ventas.Text = "Ventas";
            this.btn_ventas.UseVisualStyleBackColor = true;
            // 
            // btn_usr
            // 
            this.btn_usr.Location = new System.Drawing.Point(12, 340);
            this.btn_usr.Name = "btn_usr";
            this.btn_usr.Size = new System.Drawing.Size(87, 42);
            this.btn_usr.TabIndex = 4;
            this.btn_usr.Text = "Usuarios";
            this.btn_usr.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(597, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Bienvenido:";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(122, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(650, 388);
            this.panel1.TabIndex = 6;
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_usr);
            this.Controls.Add(this.btn_ventas);
            this.Controls.Add(this.btn_subca);
            this.Controls.Add(this.btn_cat);
            this.Controls.Add(this.btn_prods);
            this.Name = "Index";
            this.Text = "Index";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_prods;
        private System.Windows.Forms.Button btn_cat;
        private System.Windows.Forms.Button btn_subca;
        private System.Windows.Forms.Button btn_ventas;
        private System.Windows.Forms.Button btn_usr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}