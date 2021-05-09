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

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();       
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
           this.lblResultado.Text = FormCalculadora.Operar(this.txtOperadorUno.Text, this.txtOperadorDos.Text, this.cmbOperador.Text).ToString();
        }

        private void btnBinario_Click(object sender, EventArgs e)
        {
            this.lblResultado.Text = Numero.DecimalBinario(this.lblResultado.Text);
        }
        private void btnDecimal_Click(object sender, EventArgs e)
        {
            this.lblResultado.Text = Numero.BinarioDecimal(this.lblResultado.Text);
        }
        private void Limpiar()
        {
            this.txtOperadorUno.Text = "";
            this.txtOperadorDos.Text = "";
            this.cmbOperador.Text = "";
            this.lblResultado.Text = "0";
        }
        private static double Operar(string numero1, string numero2, string operador)
        {
            Numero n1 = new Numero(numero1);
            Numero n2 = new Numero(numero2);

            return Caluladora.Operar(n1, n2, operador);
        }

        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (
                MessageBox.Show(
                "Estas seguro que quiere salir?",
                "SALIR",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button2) == DialogResult.No
               )
            {
                e.Cancel = true;
            }
        }
    }
}
