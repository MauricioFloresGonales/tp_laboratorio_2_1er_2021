namespace App
{
    partial class FrmPrincipar
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
            this.rtb_lista = new System.Windows.Forms.RichTextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.lbl_ruedas = new System.Windows.Forms.Label();
            this.lblMotor = new System.Windows.Forms.Label();
            this.lblCarroceria = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cmbRuedasTamanio = new System.Windows.Forms.ComboBox();
            this.cmbMotor = new System.Windows.Forms.ComboBox();
            this.cmbCarroceria = new System.Windows.Forms.ComboBox();
            this.lblCantPuertas = new System.Windows.Forms.Label();
            this.numUpDownnCantPuertas = new System.Windows.Forms.NumericUpDown();
            this.lblTipoRueda = new System.Windows.Forms.Label();
            this.cmbRuedaTipo = new System.Windows.Forms.ComboBox();
            this.lblRuedasTamanio = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcinesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baseDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traerAutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertarTodosLosAutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFabricar = new System.Windows.Forms.Button();
            this.lblFabricados = new System.Windows.Forms.Label();
            this.btnActualizarLista = new System.Windows.Forms.Button();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownnCantPuertas)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtb_lista
            // 
            this.rtb_lista.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_lista.Location = new System.Drawing.Point(12, 47);
            this.rtb_lista.Name = "rtb_lista";
            this.rtb_lista.Size = new System.Drawing.Size(859, 571);
            this.rtb_lista.TabIndex = 0;
            this.rtb_lista.Text = "";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(889, 382);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(118, 53);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btn_fabricar_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(1013, 382);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(117, 53);
            this.btn_limpiar.TabIndex = 3;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Location = new System.Drawing.Point(894, 624);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(237, 41);
            this.btn_cerrar.TabIndex = 4;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Location = new System.Drawing.Point(891, 61);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(68, 17);
            this.lbl_Nombre.TabIndex = 5;
            this.lbl_Nombre.Text = "NOMBRE";
            // 
            // lbl_ruedas
            // 
            this.lbl_ruedas.AutoSize = true;
            this.lbl_ruedas.Location = new System.Drawing.Point(967, 242);
            this.lbl_ruedas.Name = "lbl_ruedas";
            this.lbl_ruedas.Size = new System.Drawing.Size(65, 17);
            this.lbl_ruedas.TabIndex = 6;
            this.lbl_ruedas.Text = "RUEDAS";
            // 
            // lblMotor
            // 
            this.lblMotor.AutoSize = true;
            this.lblMotor.Location = new System.Drawing.Point(967, 184);
            this.lblMotor.Name = "lblMotor";
            this.lblMotor.Size = new System.Drawing.Size(60, 17);
            this.lblMotor.TabIndex = 7;
            this.lblMotor.Text = "MOTOR";
            // 
            // lblCarroceria
            // 
            this.lblCarroceria.AutoSize = true;
            this.lblCarroceria.Location = new System.Drawing.Point(967, 96);
            this.lblCarroceria.Name = "lblCarroceria";
            this.lblCarroceria.Size = new System.Drawing.Size(97, 17);
            this.lblCarroceria.TabIndex = 8;
            this.lblCarroceria.Text = "CARROCERIA";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(980, 58);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(150, 22);
            this.txtNombre.TabIndex = 9;
            // 
            // cmbRuedasTamanio
            // 
            this.cmbRuedasTamanio.FormattingEnabled = true;
            this.cmbRuedasTamanio.Location = new System.Drawing.Point(981, 266);
            this.cmbRuedasTamanio.Name = "cmbRuedasTamanio";
            this.cmbRuedasTamanio.Size = new System.Drawing.Size(150, 24);
            this.cmbRuedasTamanio.TabIndex = 10;
            // 
            // cmbMotor
            // 
            this.cmbMotor.FormattingEnabled = true;
            this.cmbMotor.Location = new System.Drawing.Point(980, 204);
            this.cmbMotor.Name = "cmbMotor";
            this.cmbMotor.Size = new System.Drawing.Size(150, 24);
            this.cmbMotor.TabIndex = 11;
            // 
            // cmbCarroceria
            // 
            this.cmbCarroceria.FormattingEnabled = true;
            this.cmbCarroceria.Location = new System.Drawing.Point(980, 116);
            this.cmbCarroceria.Name = "cmbCarroceria";
            this.cmbCarroceria.Size = new System.Drawing.Size(150, 24);
            this.cmbCarroceria.TabIndex = 12;
            // 
            // lblCantPuertas
            // 
            this.lblCantPuertas.AutoSize = true;
            this.lblCantPuertas.Location = new System.Drawing.Point(902, 148);
            this.lblCantPuertas.Name = "lblCantPuertas";
            this.lblCantPuertas.Size = new System.Drawing.Size(57, 17);
            this.lblCantPuertas.TabIndex = 14;
            this.lblCantPuertas.Text = "Puertas";
            // 
            // numUpDownnCantPuertas
            // 
            this.numUpDownnCantPuertas.Location = new System.Drawing.Point(980, 146);
            this.numUpDownnCantPuertas.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numUpDownnCantPuertas.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numUpDownnCantPuertas.Name = "numUpDownnCantPuertas";
            this.numUpDownnCantPuertas.ReadOnly = true;
            this.numUpDownnCantPuertas.Size = new System.Drawing.Size(150, 22);
            this.numUpDownnCantPuertas.TabIndex = 16;
            this.numUpDownnCantPuertas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numUpDownnCantPuertas.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // lblTipoRueda
            // 
            this.lblTipoRueda.AutoSize = true;
            this.lblTipoRueda.Location = new System.Drawing.Point(928, 299);
            this.lblTipoRueda.Name = "lblTipoRueda";
            this.lblTipoRueda.Size = new System.Drawing.Size(36, 17);
            this.lblTipoRueda.TabIndex = 17;
            this.lblTipoRueda.Text = "Tipo";
            // 
            // cmbRuedaTipo
            // 
            this.cmbRuedaTipo.FormattingEnabled = true;
            this.cmbRuedaTipo.Location = new System.Drawing.Point(981, 296);
            this.cmbRuedaTipo.Name = "cmbRuedaTipo";
            this.cmbRuedaTipo.Size = new System.Drawing.Size(150, 24);
            this.cmbRuedaTipo.TabIndex = 18;
            // 
            // lblRuedasTamanio
            // 
            this.lblRuedasTamanio.AutoSize = true;
            this.lblRuedasTamanio.Location = new System.Drawing.Point(904, 269);
            this.lblRuedasTamanio.Name = "lblRuedasTamanio";
            this.lblRuedasTamanio.Size = new System.Drawing.Size(60, 17);
            this.lblRuedasTamanio.TabIndex = 19;
            this.lblRuedasTamanio.Text = "Tamaño";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(917, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Estilo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(913, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Tipo";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcinesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1142, 30);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcinesToolStripMenuItem
            // 
            this.opcinesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.baseDeDatosToolStripMenuItem});
            this.opcinesToolStripMenuItem.Name = "opcinesToolStripMenuItem";
            this.opcinesToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.opcinesToolStripMenuItem.Text = "Opcines";
            // 
            // baseDeDatosToolStripMenuItem
            // 
            this.baseDeDatosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.traerAutosToolStripMenuItem,
            this.insertarTodosLosAutosToolStripMenuItem});
            this.baseDeDatosToolStripMenuItem.Name = "baseDeDatosToolStripMenuItem";
            this.baseDeDatosToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.baseDeDatosToolStripMenuItem.Text = "Base de Datos";
            // 
            // traerAutosToolStripMenuItem
            // 
            this.traerAutosToolStripMenuItem.Name = "traerAutosToolStripMenuItem";
            this.traerAutosToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.traerAutosToolStripMenuItem.Text = "Traer autos";
            this.traerAutosToolStripMenuItem.Click += new System.EventHandler(this.traerAutosToolStripMenuItem_Click);
            // 
            // insertarTodosLosAutosToolStripMenuItem
            // 
            this.insertarTodosLosAutosToolStripMenuItem.Name = "insertarTodosLosAutosToolStripMenuItem";
            this.insertarTodosLosAutosToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.insertarTodosLosAutosToolStripMenuItem.Text = "Insertar todos los autos";
            this.insertarTodosLosAutosToolStripMenuItem.Click += new System.EventHandler(this.insertarTodosLosAutosToolStripMenuItem_Click);
            // 
            // btnFabricar
            // 
            this.btnFabricar.Location = new System.Drawing.Point(260, 624);
            this.btnFabricar.Name = "btnFabricar";
            this.btnFabricar.Size = new System.Drawing.Size(119, 45);
            this.btnFabricar.TabIndex = 23;
            this.btnFabricar.Text = "Fabricar Autos";
            this.btnFabricar.UseVisualStyleBackColor = true;
            this.btnFabricar.Click += new System.EventHandler(this.btnFabricar_Click);
            // 
            // lblFabricados
            // 
            this.lblFabricados.AutoSize = true;
            this.lblFabricados.Location = new System.Drawing.Point(385, 638);
            this.lblFabricados.Name = "lblFabricados";
            this.lblFabricados.Size = new System.Drawing.Size(146, 17);
            this.lblFabricados.TabIndex = 24;
            this.lblFabricados.Text = "Autos a Fabricados: 0\r\n";
            // 
            // btnActualizarLista
            // 
            this.btnActualizarLista.Location = new System.Drawing.Point(889, 448);
            this.btnActualizarLista.Name = "btnActualizarLista";
            this.btnActualizarLista.Size = new System.Drawing.Size(240, 47);
            this.btnActualizarLista.TabIndex = 25;
            this.btnActualizarLista.Text = "Actualizar lista de autos";
            this.btnActualizarLista.UseVisualStyleBackColor = true;
            this.btnActualizarLista.Click += new System.EventHandler(this.btnMostrarAutos_Click);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarUsuarioToolStripMenuItem});
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.loginToolStripMenuItem.Text = "Login";
            // 
            // ingresarUsuarioToolStripMenuItem
            // 
            this.ingresarUsuarioToolStripMenuItem.Name = "ingresarUsuarioToolStripMenuItem";
            this.ingresarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ingresarUsuarioToolStripMenuItem.Text = "Ingresar Usuario";
            this.ingresarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.ingresarUsuarioToolStripMenuItem_Click);
            // 
            // FrmPrincipar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1142, 676);
            this.Controls.Add(this.btnActualizarLista);
            this.Controls.Add(this.lblFabricados);
            this.Controls.Add(this.btnFabricar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRuedasTamanio);
            this.Controls.Add(this.cmbRuedaTipo);
            this.Controls.Add(this.lblTipoRueda);
            this.Controls.Add(this.numUpDownnCantPuertas);
            this.Controls.Add(this.lblCantPuertas);
            this.Controls.Add(this.cmbCarroceria);
            this.Controls.Add(this.cmbMotor);
            this.Controls.Add(this.cmbRuedasTamanio);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblCarroceria);
            this.Controls.Add(this.lblMotor);
            this.Controls.Add(this.lbl_ruedas);
            this.Controls.Add(this.lbl_Nombre);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.rtb_lista);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipar";
            this.Text = "Fabrica De Autos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.form_principal_FormClosing);
            this.Load += new System.EventHandler(this.form_principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownnCantPuertas)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_lista;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.Label lbl_ruedas;
        private System.Windows.Forms.Label lblMotor;
        private System.Windows.Forms.Label lblCarroceria;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cmbRuedasTamanio;
        private System.Windows.Forms.ComboBox cmbMotor;
        private System.Windows.Forms.ComboBox cmbCarroceria;
        private System.Windows.Forms.Label lblCantPuertas;
        private System.Windows.Forms.NumericUpDown numUpDownnCantPuertas;
        private System.Windows.Forms.Label lblTipoRueda;
        private System.Windows.Forms.ComboBox cmbRuedaTipo;
        private System.Windows.Forms.Label lblRuedasTamanio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcinesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baseDeDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem traerAutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertarTodosLosAutosToolStripMenuItem;
        private System.Windows.Forms.Button btnFabricar;
        private System.Windows.Forms.Label lblFabricados;
        private System.Windows.Forms.Button btnActualizarLista;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarUsuarioToolStripMenuItem;
    }
}

