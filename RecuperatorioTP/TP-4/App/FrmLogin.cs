using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace App
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.txtNombre.Text = "";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Archivos.CrearArchivoXml<string>(this.txtNombre.Text);
            this.DialogResult = DialogResult.OK;
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
