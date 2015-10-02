namespace EjerciciosCapitulo9Y10
{
    partial class EstructuraProductosTienda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EstructuraProductosTienda));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NombreProductotextBox = new System.Windows.Forms.TextBox();
            this.TipotextBox = new System.Windows.Forms.TextBox();
            this.PreciotextBox = new System.Windows.Forms.TextBox();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Listarbutton = new System.Windows.Forms.Button();
            this.ProductosrichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Pruducto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Precio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo de producto:";
            // 
            // NombreProductotextBox
            // 
            this.NombreProductotextBox.Location = new System.Drawing.Point(111, 33);
            this.NombreProductotextBox.Name = "NombreProductotextBox";
            this.NombreProductotextBox.Size = new System.Drawing.Size(100, 20);
            this.NombreProductotextBox.TabIndex = 3;
            // 
            // TipotextBox
            // 
            this.TipotextBox.Location = new System.Drawing.Point(111, 69);
            this.TipotextBox.Name = "TipotextBox";
            this.TipotextBox.Size = new System.Drawing.Size(100, 20);
            this.TipotextBox.TabIndex = 4;
            // 
            // PreciotextBox
            // 
            this.PreciotextBox.Location = new System.Drawing.Point(111, 105);
            this.PreciotextBox.Name = "PreciotextBox";
            this.PreciotextBox.Size = new System.Drawing.Size(100, 20);
            this.PreciotextBox.TabIndex = 5;
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Guardarbutton.Image")));
            this.Guardarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Guardarbutton.Location = new System.Drawing.Point(80, 168);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(91, 39);
            this.Guardarbutton.TabIndex = 6;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Listarbutton
            // 
            this.Listarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Listarbutton.Image")));
            this.Listarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Listarbutton.Location = new System.Drawing.Point(269, 168);
            this.Listarbutton.Name = "Listarbutton";
            this.Listarbutton.Size = new System.Drawing.Size(91, 39);
            this.Listarbutton.TabIndex = 8;
            this.Listarbutton.Text = "Producto";
            this.Listarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Listarbutton.UseVisualStyleBackColor = true;
            this.Listarbutton.Click += new System.EventHandler(this.Listarbutton_Click);
            // 
            // ProductosrichTextBox
            // 
            this.ProductosrichTextBox.Location = new System.Drawing.Point(241, 33);
            this.ProductosrichTextBox.Name = "ProductosrichTextBox";
            this.ProductosrichTextBox.ReadOnly = true;
            this.ProductosrichTextBox.Size = new System.Drawing.Size(187, 92);
            this.ProductosrichTextBox.TabIndex = 9;
            this.ProductosrichTextBox.Text = "";
            // 
            // EstructuraProductosTienda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 261);
            this.Controls.Add(this.ProductosrichTextBox);
            this.Controls.Add(this.Listarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.PreciotextBox);
            this.Controls.Add(this.TipotextBox);
            this.Controls.Add(this.NombreProductotextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EstructuraProductosTienda";
            this.Text = "Estructura productos tienda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NombreProductotextBox;
        private System.Windows.Forms.TextBox TipotextBox;
        private System.Windows.Forms.TextBox PreciotextBox;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Listarbutton;
        private System.Windows.Forms.RichTextBox ProductosrichTextBox;
    }
}