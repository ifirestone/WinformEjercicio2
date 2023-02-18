namespace WinFormsEjercicio2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_convertir = new System.Windows.Forms.Button();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.tb_texto = new System.Windows.Forms.TextBox();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.rb_mayusuclas = new System.Windows.Forms.RadioButton();
            this.rb_minuculas = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btn_convertir
            // 
            this.btn_convertir.Location = new System.Drawing.Point(639, 12);
            this.btn_convertir.Name = "btn_convertir";
            this.btn_convertir.Size = new System.Drawing.Size(102, 48);
            this.btn_convertir.TabIndex = 0;
            this.btn_convertir.Text = "Convertir";
            this.btn_convertir.UseVisualStyleBackColor = true;
            this.btn_convertir.Click += new System.EventHandler(this.btn_convertir_Click);
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.Location = new System.Drawing.Point(24, 78);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(59, 15);
            this.lbl_resultado.TabIndex = 1;
            this.lbl_resultado.Text = "Resultado";
            // 
            // tb_texto
            // 
            this.tb_texto.Location = new System.Drawing.Point(24, 26);
            this.tb_texto.Name = "tb_texto";
            this.tb_texto.Size = new System.Drawing.Size(471, 23);
            this.tb_texto.TabIndex = 2;
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(747, 12);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(95, 48);
            this.btn_limpiar.TabIndex = 3;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // rb_mayusuclas
            // 
            this.rb_mayusuclas.AutoSize = true;
            this.rb_mayusuclas.Location = new System.Drawing.Point(519, 12);
            this.rb_mayusuclas.Name = "rb_mayusuclas";
            this.rb_mayusuclas.Size = new System.Drawing.Size(87, 19);
            this.rb_mayusuclas.TabIndex = 4;
            this.rb_mayusuclas.TabStop = true;
            this.rb_mayusuclas.Text = "Mayusculas";
            this.rb_mayusuclas.UseVisualStyleBackColor = true;
            // 
            // rb_minuculas
            // 
            this.rb_minuculas.AutoSize = true;
            this.rb_minuculas.Location = new System.Drawing.Point(519, 37);
            this.rb_minuculas.Name = "rb_minuculas";
            this.rb_minuculas.Size = new System.Drawing.Size(81, 19);
            this.rb_minuculas.TabIndex = 5;
            this.rb_minuculas.TabStop = true;
            this.rb_minuculas.Text = "Minisculas";
            this.rb_minuculas.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 126);
            this.Controls.Add(this.rb_minuculas);
            this.Controls.Add(this.rb_mayusuclas);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.tb_texto);
            this.Controls.Add(this.lbl_resultado);
            this.Controls.Add(this.btn_convertir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_convertir;
        private Label lbl_resultado;
        private TextBox tb_texto;
        private Button btn_limpiar;
        private RadioButton rb_mayusuclas;
        private RadioButton rb_minuculas;
    }
}