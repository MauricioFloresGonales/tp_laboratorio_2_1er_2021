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
        static Numero NumeroUno;
        static Numero NumeroDos;
        string operador = "+";
        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            NumeroUno = new Numero();
            NumeroDos = new Numero();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            NumeroUno.SetNumero = "0";
            NumeroDos.SetNumero = "0";
            this.txtOperadorUno.Text = "0";
            this.txtOperadorDos.Text = "0";
            this.lblResultado.Text = "0";
        }

        private void txtOperadorUno_TextChanged(object sender, EventArgs e)
        {
            NumeroUno.SetNumero = this.txtOperadorUno.Text;
        }

        private void txtOperadorDos_TextChanged(object sender, EventArgs e)
        {
            NumeroDos.SetNumero = this.txtOperadorDos.Text;
        }

        private void cmbOperador_SelectedIndexChanged(object sender, EventArgs e)
        {
            operador = this.cmbOperador.Text;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
           this.lblResultado.Text = Caluladora.Operar(NumeroUno, NumeroDos, operador).ToString();
        }

        private void btnBinario_Click(object sender, EventArgs e)
        {
            this.lblResultado.Text = Numero.DecimalBinario(this.lblResultado.Text);
        }
        private void btnDecimal_Click(object sender, EventArgs e)
        {
            this.lblResultado.Text = Numero.BinarioDecimal(this.lblResultado.Text);
        }
    }
}
