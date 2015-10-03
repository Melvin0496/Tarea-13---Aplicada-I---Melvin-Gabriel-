namespace EjerciciosCapitulo9Y10
{
    partial class EnumNeumaticos
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
            this.TipocomboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NeumaticosrichTextBox = new System.Windows.Forms.RichTextBox();
            this.Verbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TipocomboBox
            // 
            this.TipocomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipocomboBox.FormattingEnabled = true;
            this.TipocomboBox.Items.AddRange(new object[] {
            "Diagonal",
            "Verano",
            "Invierno",
            "All Season",
            "Asimetricos",
            "Tubuless",
            "Perfil bajo",
            "Verdes",
            "Run Flat"});
            this.TipocomboBox.Location = new System.Drawing.Point(103, 59);
            this.TipocomboBox.Name = "TipocomboBox";
            this.TipocomboBox.Size = new System.Drawing.Size(121, 21);
            this.TipocomboBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipo Neumatico:";
            // 
            // NeumaticosrichTextBox
            // 
            this.NeumaticosrichTextBox.Location = new System.Drawing.Point(12, 111);
            this.NeumaticosrichTextBox.Name = "NeumaticosrichTextBox";
            this.NeumaticosrichTextBox.Size = new System.Drawing.Size(390, 124);
            this.NeumaticosrichTextBox.TabIndex = 2;
            this.NeumaticosrichTextBox.Text = "";
            // 
            // Verbutton
            // 
            this.Verbutton.Location = new System.Drawing.Point(240, 59);
            this.Verbutton.Name = "Verbutton";
            this.Verbutton.Size = new System.Drawing.Size(75, 21);
            this.Verbutton.TabIndex = 3;
            this.Verbutton.Text = "Ver";
            this.Verbutton.UseVisualStyleBackColor = true;
            this.Verbutton.Click += new System.EventHandler(this.Verbutton_Click);
            // 
            // EnumNeumaticos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 284);
            this.Controls.Add(this.Verbutton);
            this.Controls.Add(this.NeumaticosrichTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TipocomboBox);
            this.Name = "EnumNeumaticos";
            this.Text = "Enum neumaticos";
            this.Load += new System.EventHandler(this.EnumNeumaticos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox TipocomboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox NeumaticosrichTextBox;
        private System.Windows.Forms.Button Verbutton;
    }
}