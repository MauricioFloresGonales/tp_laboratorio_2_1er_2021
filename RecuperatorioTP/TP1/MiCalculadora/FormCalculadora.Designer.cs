namespace MiCalculadora
{
    partial class FormCalculadora
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOperar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnBinario = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.txtOperadorUno = new System.Windows.Forms.TextBox();
            this.txtOperadorDos = new System.Windows.Forms.TextBox();
            this.cmbOperador = new System.Windows.Forms.ComboBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOperar
            // 
            this.btnOperar.Location = new System.Drawing.Point(12, 92);
            this.btnOperar.Name = "btnOperar";
            this.btnOperar.Size = new System.Drawing.Size(211, 66);
            this.btnOperar.TabIndex = 3;
            this.btnOperar.Text = "Operar";
            this.btnOperar.UseVisualStyleBackColor = true;
            this.btnOperar.Click += new System.EventHandler(this.btnOperar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(229, 92);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(211, 66);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(446, 92);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(211, 66);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnBinario
            // 
            this.btnBinario.Location = new System.Drawing.Point(13, 164);
            this.btnBinario.Name = "btnBinario";
            this.btnBinario.Size = new System.Drawing.Size(324, 59);
            this.btnBinario.TabIndex = 6;
            this.btnBinario.Text = "Convertir a Binario";
            this.btnBinario.UseVisualStyleBackColor = true;
            this.btnBinario.Click += new System.EventHandler(this.btnBinario_Click);
            // 
            // btnDecimal
            // 
            this.btnDecimal.Location = new System.Drawing.Point(343, 164);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(315, 59);
            this.btnDecimal.TabIndex = 7;
            this.btnDecimal.Text = "Converti a Decimmal";
            this.btnDecimal.UseVisualStyleBackColor = true;
            this.btnDecimal.Click += new System.EventHandler(this.btnDecimal_Click);
            // 
            // txtOperadorUno
            // 
            this.txtOperadorUno.Location = new System.Drawing.Point(13, 49);
            this.txtOperadorUno.Name = "txtOperadorUno";
            this.txtOperadorUno.Size = new System.Drawing.Size(268, 22);
            this.txtOperadorUno.TabIndex = 0;
            // 
            // txtOperadorDos
            // 
            this.txtOperadorDos.Location = new System.Drawing.Point(383, 49);
            this.txtOperadorDos.Name = "txtOperadorDos";
            this.txtOperadorDos.Size = new System.Drawing.Size(275, 22);
            this.txtOperadorDos.TabIndex = 2;
            // 
            // cmbOperador
            // 
            this.cmbOperador.FormattingEnabled = true;
            this.cmbOperador.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.cmbOperador.Location = new System.Drawing.Point(305, 49);
            this.cmbOperador.Name = "cmbOperador";
            this.cmbOperador.Size = new System.Drawing.Size(60, 24);
            this.cmbOperador.TabIndex = 1;
            // 
            // lblResultado
            // 
            this.lblResultado.AllowDrop = true;
            this.lblResultado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultado.Location = new System.Drawing.Point(13, 9);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(645, 25);
            this.lblResultado.TabIndex = 8;
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // FormCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 241);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.cmbOperador);
            this.Controls.Add(this.txtOperadorDos);
            this.Controls.Add(this.txtOperadorUno);
            this.Controls.Add(this.btnDecimal);
            this.Controls.Add(this.btnBinario);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnOperar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora Mauricio Luciano Gonzales Flores 2-C";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCalculadora_FormClosing);
            this.Load += new System.EventHandler(this.FormCalculadora_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOperar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnBinario;
        private System.Windows.Forms.Button btnDecimal;
        private System.Windows.Forms.TextBox txtOperadorUno;
        private System.Windows.Forms.TextBox txtOperadorDos;
        private System.Windows.Forms.ComboBox cmbOperador;
        private System.Windows.Forms.Label lblResultado;
    }
}

