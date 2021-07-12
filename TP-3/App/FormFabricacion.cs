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
using System.Threading;
using Formatos;

namespace App
{
    public partial class FrmPrincipar : Form
    {
        Thread hiloFabricar;
        Thread procesoDeFabricacion;
        public FrmPrincipar()
        {
            InitializeComponent();
        }
        #region FormPrincipal
        private void form_principal_Load(object sender, EventArgs e)
        {
            try
            {
                this.cmbRuedasTamanio.Items.AddRange(Rueda.AgregarTamanioAlCmb());
                this.cmbRuedaTipo.Items.AddRange(Rueda.AgregarTipoAlCmb());
                this.cmbMotor.Items.AddRange(Motor.AgregarAlCmb());
                this.cmbCarroceria.Items.AddRange(Carroceria.AgregarAlCmb());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void form_principal_FormClosing(object sender, FormClosingEventArgs e)
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
            else
            {
                if (!object.ReferenceEquals(this.procesoDeFabricacion, null))
                {
                    if (this.procesoDeFabricacion.IsAlive)
                        this.procesoDeFabricacion.Abort();
                }
                if (!object.ReferenceEquals(this.hiloFabricar, null))
                {
                    if (this.hiloFabricar.IsAlive)
                        this.hiloFabricar.Abort();
                }
            }
        }
        #endregion

        #region Botones
        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            this.txtNombre.Text = "";
            this.cmbRuedasTamanio.Text = "";
            this.cmbRuedaTipo.Text = "";
            this.cmbMotor.Text = "";
            this.cmbCarroceria.Text = "";
            this.numUpDownnCantPuertas.Value = 2;
        }
        private void btn_fabricar_Click(object sender, EventArgs e)
        {
            try
            {
                string login = Archivos.LeerArchivoXml<string>();
                Auto nuevoAuto = new Auto(
                    login,
                    this.txtNombre.Text,
                    this.cmbCarroceria.Text,
                    this.numUpDownnCantPuertas.Value.ToString(),
                    this.cmbMotor.Text,
                    this.cmbRuedaTipo.Text,
                    this.cmbRuedasTamanio.Text);
                Taller.AgregarUnVehiculo(nuevoAuto);
                MessageBox.Show(nuevoAuto.FormatoAlert(), "Auto Creado");
                ActualizarLblFabricados();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMostrarAutos_Click(object sender, EventArgs e)
        {
            ActualizarRtbLista();
            ActualizarLblFabricados();
        }

        private void btnFabricar_Click(object sender, EventArgs e)
        {
            try
            {
                this.procesoDeFabricacion = new Thread(this.ActivarFabricacion);
                this.procesoDeFabricacion.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        #endregion

        #region Barra de opciones
        private void traerAutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int cantidad = DBConexion.TraerAutos(Taller.listaDeAutos);
                ActualizarRtbLista();
                MessageBox.Show($"Se trajeron {cantidad} autos de la BD", "Select");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        private void insertarTodosLosAutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int cantidad = DBConexion.InsertarAutos(Taller.listaDeAutos);

                MessageBox.Show($"Se insertaron {cantidad} de autos en la BD", "Insert");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        private void ingresarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            if (frmLogin.ShowDialog() == DialogResult.OK)
            {

            }
        }
        #endregion

        #region Metodos
        private void ActualizarRtbLista()
        {
            this.rtb_lista.Text = "";
            this.rtb_lista.Text = Taller.MostrarLista();
        }
        private void ActualizarLblFabricados()
        {
            this.lblFabricados.Text = $"";
            this.lblFabricados.Text = $"Autos Fabricados: {Taller.listaDeAutos.Count}";
        }
        private void ActivarFabricacion()
        {
            foreach (Auto auxAuto in Taller.listaDeAutos)
            {
                auxAuto.EventoConstruir += FabricarAuto;
                auxAuto.EventoConstruir += Informar;
                auxAuto.EventoConstruir += CrearArchivo;

                this.hiloFabricar = new Thread(new ParameterizedThreadStart(auxAuto.Proceso));
                this.hiloFabricar.Start(auxAuto);
            }
        }
        private void FabricarAuto(object nuevoAuto)
        {
            try
            {
                Auto auxNuevoAuto = (Auto)nuevoAuto;
                Taller.EliminarAuto(auxNuevoAuto);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        private void CrearArchivo(object nuevoAuto)
        {
            Taller.EntregarAuto((Auto)nuevoAuto);
            this.hiloFabricar.Abort();
        }
        private void Informar(object autoFabricado)
        {
            Auto auxAuto = (Auto)autoFabricado;
            if (this.lblFabricados.InvokeRequired)
            {
                Construir d = new Construir(Informar);
                object[] objs = new object[] { auxAuto };
                this.Invoke(d, objs);
            }
            else
            {
                MessageBox.Show($"Auto: {auxAuto.Nombre} fué creado");
                this.ActualizarLblFabricados();
            }
        }
        #endregion
    }
}
