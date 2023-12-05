namespace EjemploABM
{
    partial class FormCategorias
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
            this.btn_crear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Crear Categoria";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // lb_nombre
            // 
            this.lb_nombre.AutoSize = true;
            this.lb_nombre.Location = new System.Drawing.Point(172, 147);
            this.lb_nombre.Name = "lb_nombre";
            this.lb_nombre.Size = new System.Drawing.Size(47, 13);
            this.lb_nombre.TabIndex = 1;
            this.lb_nombre.Text = "Nombre:";
            this.lb_nombre.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(229, 144);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(125, 20);
            this.txt_nombre.TabIndex = 2;
            this.txt_nombre.TextChanged += new System.EventHandler(this.txt_nombre_TextChanged);
            // 
            // btn_crear
            // 
            this.btn_crear.Location = new System.Drawing.Point(241, 209);
            this.btn_crear.Name = "btn_crear";
            this.btn_crear.Size = new System.Drawing.Size(77, 45);
            this.btn_crear.TabIndex = 3;
            this.btn_crear.Text = "Crear";
            this.btn_crear.UseVisualStyleBackColor = true;
            this.btn_crear.Click += new System.EventHandler(this.btn_crear_Click);
            // 
            // FormCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 337);
            this.Controls.Add(this.btn_crear);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.lb_nombre);
            this.Controls.Add(this.label2);
            this.Name = "FormCategorias";
            this.Text = "FromCategorias";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_nombre;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Button btn_crear;
    }
}