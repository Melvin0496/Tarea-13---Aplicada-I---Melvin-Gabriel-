namespace EjerciciosCapitulo9Y10
{
    partial class EstructuraCuenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EstructuraCuenta));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AhorroradioButton = new System.Windows.Forms.RadioButton();
            this.CorrienteradioButton = new System.Windows.Forms.RadioButton();
            this.NombreEntidadFinacieratextBox = new System.Windows.Forms.TextBox();
            this.NumeroCuentatextBox = new System.Windows.Forms.TextBox();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.DatosrichTextBox = new System.Windows.Forms.RichTextBox();
            this.Cuentabutton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de la entidad finaciera:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero de Cuenta:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CorrienteradioButton);
            this.groupBox1.Controls.Add(this.AhorroradioButton);
            this.groupBox1.Location = new System.Drawing.Point(15, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(151, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo decuenta bancaria:";
            // 
            // AhorroradioButton
            // 
            this.AhorroradioButton.AutoSize = true;
            this.AhorroradioButton.Location = new System.Drawing.Point(11, 29);
            this.AhorroradioButton.Name = "AhorroradioButton";
            this.AhorroradioButton.Size = new System.Drawing.Size(56, 17);
            this.AhorroradioButton.TabIndex = 0;
            this.AhorroradioButton.TabStop = true;
            this.AhorroradioButton.Text = "Ahorro";
            this.AhorroradioButton.UseVisualStyleBackColor = true;
            // 
            // CorrienteradioButton
            // 
            this.CorrienteradioButton.AutoSize = true;
            this.CorrienteradioButton.Location = new System.Drawing.Point(11, 64);
            this.CorrienteradioButton.Name = "CorrienteradioButton";
            this.CorrienteradioButton.Size = new System.Drawing.Size(67, 17);
            this.CorrienteradioButton.TabIndex = 1;
            this.CorrienteradioButton.TabStop = true;
            this.CorrienteradioButton.Text = "Corriente";
            this.CorrienteradioButton.UseVisualStyleBackColor = true;
            // 
            // NombreEntidadFinacieratextBox
            // 
            this.NombreEntidadFinacieratextBox.Location = new System.Drawing.Point(172, 58);
            this.NombreEntidadFinacieratextBox.Name = "NombreEntidadFinacieratextBox";
            this.NombreEntidadFinacieratextBox.Size = new System.Drawing.Size(184, 20);
            this.NombreEntidadFinacieratextBox.TabIndex = 3;
            // 
            // NumeroCuentatextBox
            // 
            this.NumeroCuentatextBox.Location = new System.Drawing.Point(172, 87);
            this.NumeroCuentatextBox.Name = "NumeroCuentatextBox";
            this.NumeroCuentatextBox.Size = new System.Drawing.Size(184, 20);
            this.NumeroCuentatextBox.TabIndex = 4;
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Guardarbutton.Image")));
            this.Guardarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Guardarbutton.Location = new System.Drawing.Point(43, 249);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(85, 41);
            this.Guardarbutton.TabIndex = 2;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // DatosrichTextBox
            // 
            this.DatosrichTextBox.Location = new System.Drawing.Point(172, 129);
            this.DatosrichTextBox.Name = "DatosrichTextBox";
            this.DatosrichTextBox.ReadOnly = true;
            this.DatosrichTextBox.Size = new System.Drawing.Size(184, 96);
            this.DatosrichTextBox.TabIndex = 5;
            this.DatosrichTextBox.Text = "";
            // 
            // Cuentabutton
            // 
            this.Cuentabutton.Image = ((System.Drawing.Image)(resources.GetObject("Cuentabutton.Image")));
            this.Cuentabutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cuentabutton.Location = new System.Drawing.Point(218, 249);
            this.Cuentabutton.Name = "Cuentabutton";
            this.Cuentabutton.Size = new System.Drawing.Size(85, 41);
            this.Cuentabutton.TabIndex = 6;
            this.Cuentabutton.Text = "Cuenta";
            this.Cuentabutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Cuentabutton.UseVisualStyleBackColor = true;
            this.Cuentabutton.Click += new System.EventHandler(this.Cuentabutton_Click);
            // 
            // EstructuraCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 311);
            this.Controls.Add(this.Cuentabutton);
            this.Controls.Add(this.DatosrichTextBox);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.NumeroCuentatextBox);
            this.Controls.Add(this.NombreEntidadFinacieratextBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EstructuraCuenta";
            this.Text = "Estructura cuenta";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton CorrienteradioButton;
        private System.Windows.Forms.RadioButton AhorroradioButton;
        private System.Windows.Forms.TextBox NombreEntidadFinacieratextBox;
        private System.Windows.Forms.TextBox NumeroCuentatextBox;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.RichTextBox DatosrichTextBox;
        private System.Windows.Forms.Button Cuentabutton;
    }
}