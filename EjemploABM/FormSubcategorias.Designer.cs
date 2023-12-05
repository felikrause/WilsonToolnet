namespace EjemploABM
{
    partial class FormSubcategorias
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
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ComboBoxCat = new System.Windows.Forms.ComboBox();
            this.btn_crear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Crear SubCategoria";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(198, 148);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(115, 20);
            this.txt_nombre.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Categoria:";
            // 
            // ComboBoxCat
            // 
            this.ComboBoxCat.FormattingEnabled = true;
            this.ComboBoxCat.Location = new System.Drawing.Point(198, 192);
            this.ComboBoxCat.Name = "ComboBoxCat";
            this.ComboBoxCat.Size = new System.Drawing.Size(142, 21);
            this.ComboBoxCat.TabIndex = 4;
            this.ComboBoxCat.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCat_SelectedIndexChanged);
            // 
            // btn_crear
            // 
            this.btn_crear.Location = new System.Drawing.Point(217, 246);
            this.btn_crear.Name = "btn_crear";
            this.btn_crear.Size = new System.Drawing.Size(96, 49);
            this.btn_crear.TabIndex = 5;
            this.btn_crear.Text = "Crear";
            this.btn_crear.UseVisualStyleBackColor = true;
            this.btn_crear.Click += new System.EventHandler(this.btn_crear_Click);
            // 
            // FormSubcategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 426);
            this.Controls.Add(this.btn_crear);
            this.Controls.Add(this.ComboBoxCat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormSubcategorias";
            this.Text = "FormSubcategorias";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ComboBoxCat;
        private System.Windows.Forms.Button btn_crear;
    }
}