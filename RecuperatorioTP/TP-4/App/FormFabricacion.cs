using System;
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
                this.rbtAuto.Checked = true;
                this.btnFabricar.Enabled = false;
                this.lblFabricados.Text = $"Vehiculos a Fabricar: {Taller.listaDeAutos.Count + Taller.listaDeMotos.Count}";
                this.cmbRuedasTamanio.Items.AddRange(Rueda.AgregarTamanioAlCmb());
                this.cmbRuedaTipo.Items.AddRange(Rueda.AgregarTipoAlCmb());
                this.cmbMotor.Items.AddRange(Motor.AgregarAlCmb());
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
            this.rbtAuto.Checked = false;
            this.rbtMotocicleta.Checked = false;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Agregar();
                this.ActualizarLblFabricados();
                this.ActualizarRtbLista();

                this.ActivarBtnFabricacion();
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
            this.ActualizarRtbLista();
            this.ActualizarLblFabricados();
        }

        private void btnFabricar_Click(object sender, EventArgs e)
        {
            try
            {
                this.procesoDeFabricacion = new Thread(this.ActivarFabricacion);
                this.procesoDeFabricacion.Start();
                if (Taller.listaDeAutos.Count > 0 || Taller.listaDeMotos.Count > 0)
                    this.lblProceso.Text = "Proceso: Trabajando";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        private void rbtAuto_CheckedChanged(object sender, EventArgs e)
        {
            this.lblCarroceria.Text = "CARROCERIA";
            this.lblCantPuertas.Text = "Puertas";
            this.numUpDownnCantPuertas.Enabled = true;
            this.cmbCarroceria.Items.Clear();
            this.cmbCarroceria.Items.AddRange(Carroceria.AgregarAlCmb());
        }

        private void rbtMotocicleta_CheckedChanged(object sender, EventArgs e)
        {
            this.lblCarroceria.Text = "CHASIS";
            this.lblCantPuertas.Text = "";
            this.numUpDownnCantPuertas.Enabled = false;
            this.cmbCarroceria.Items.Clear();
            this.cmbCarroceria.Items.AddRange(Chasis.AgregarAlCmb());
        }
        #endregion

        #region Barra de opciones
        private void ingresarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            if (frmLogin.ShowDialog() == DialogResult.OK)
            {

            }
        }
        private void traerAutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int cantidad = DBConexion.TraerAutos();
                this.ActualizarRtbLista();
                MessageBox.Show($"Se trajeron {cantidad} autos de la BD", "Select");

                this.ActivarBtnFabricacion();
                this.ActualizarLblFabricados();
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
                if (cantidad == Taller.listaDeAutos.Count)
                {
                    Taller.listaDeAutos.Clear();
                }
                this.ActualizarRtbLista();

                this.ActivarBtnFabricacion();
                this.ActualizarLblFabricados();

                MessageBox.Show($"Se insertaron {cantidad} de autos en la BD", "Insert");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        private void traerMotocicletasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int cantidad = DBConexion.TraerMotos();
                this.ActualizarRtbLista();
                MessageBox.Show($"Se trajeron {cantidad} motocicletas de la BD", "Select");

                this.ActivarBtnFabricacion();
                this.ActualizarLblFabricados();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void insertarTodosLasMotocicletasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int cantidad = DBConexion.InsertarMotos(Taller.listaDeMotos);
                if (cantidad == Taller.listaDeMotos.Count)
                {
                    Taller.listaDeMotos.Clear();
                }
                this.ActualizarRtbLista();

                this.ActivarBtnFabricacion();
                this.ActualizarLblFabricados();

                MessageBox.Show($"Se insertaron {cantidad} de autos en la BD", "Insert");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
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
            this.lblFabricados.Text = $"Vehiculos a Fabricar: {Taller.listaDeAutos.Count + Taller.listaDeMotos.Count}";
        }

        private void ActivarBtnFabricacion()
        {
            if(Taller.listaDeAutos.Count > 0 || Taller.listaDeMotos.Count > 0)
            {
                this.btnFabricar.Enabled = true;
            }
        }
        private void Agregar()
        {
            try
            {
                string login = Archivos.LeerArchivoXml<string>();
                if (login.Trim().Length > 0)
                {
                    if (this.rbtAuto.Checked == true)
                    {
                        Auto nuevoAuto = new Auto(
                            this.txtNombre.Text,
                            login,
                            this.cmbCarroceria.Text,
                            this.numUpDownnCantPuertas.Value.ToString(),
                            this.cmbMotor.Text,
                            this.cmbRuedaTipo.Text,
                            this.cmbRuedasTamanio.Text);
                        Taller.AgregarUnAuto(nuevoAuto);
                        MessageBox.Show(nuevoAuto.FormatoAlert(), "Auto Creado");
                    }
                    if (this.rbtMotocicleta.Checked == true)
                    {
                        Motocicleta nuevaMoto = new Motocicleta(
                            login,
                            this.txtNombre.Text,
                            this.cmbCarroceria.Text,
                            this.cmbMotor.Text,
                            this.cmbRuedaTipo.Text,
                            this.cmbRuedasTamanio.Text);
                        Taller.AgregarUnaMoto(nuevaMoto);
                        MessageBox.Show(nuevaMoto.FormatoAlert(), "Auto Creado");
                    }
                    if (this.rbtAuto.Checked == false && this.rbtMotocicleta.Checked == false)
                    {
                        throw new Exception($"Seleccione si quiere agregar un Auto o una Motocicleta");
                    }
                }
                else
                {
                    throw new Exception($"Es necesario loguearse. (Mirar la opciones)");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"ups, {ex.Message}");
            }
        }
        private void ActivarFabricacion()
        {
            foreach (Auto auxAuto in Taller.listaDeAutos)
            {
                auxAuto.EventoConstruirAuto += FabricarVehiculo;
                auxAuto.EventoConstruirAuto += Informar;
                auxAuto.EventoConstruirAuto += CrearArchivo;

                this.hiloFabricar = new Thread(new ParameterizedThreadStart(auxAuto.Proceso));
                this.hiloFabricar.Start(auxAuto);
            }
            foreach (Motocicleta auxMoto in Taller.listaDeMotos)
            {
                auxMoto.EventoConstruirMoto += FabricarVehiculo;
                auxMoto.EventoConstruirMoto += Informar;
                auxMoto.EventoConstruirMoto += CrearArchivo;

                this.hiloFabricar = new Thread(new ParameterizedThreadStart(auxMoto.Proceso));
                this.hiloFabricar.Start(auxMoto);
            }
        }
        private void FabricarVehiculo(object nuevoVehiculo)
        {
            try
            {
                if (nuevoVehiculo.GetType() == typeof(Auto))
                {
                    Auto auxNuevoAuto = (Auto)nuevoVehiculo;
                    Thread.Sleep(auxNuevoAuto.TiempoDeProcduccion() * 1000);
                    Taller.EliminarAuto(auxNuevoAuto);
                }
                if (nuevoVehiculo.GetType() == typeof(Motocicleta))
                {
                    Motocicleta auxNuevaMoto = (Motocicleta)nuevoVehiculo;
                    Thread.Sleep(auxNuevaMoto.TiempoDeProcduccion() * 1000);
                    Taller.EliminarMoto(auxNuevaMoto);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        private void CrearArchivo(object nuevoVehiculo)
        {
            if (nuevoVehiculo.GetType() == typeof(Auto))
                Taller.Entregar((Auto)nuevoVehiculo);
            if (nuevoVehiculo.GetType() == typeof(Motocicleta))
                Taller.Entregar((Motocicleta)nuevoVehiculo);
            
            this.hiloFabricar.Abort();
        }
        private void Informar(object vehiculoFabricado)
        {
            if (vehiculoFabricado.GetType() == typeof(Auto))
            {
                Auto auxAuto = (Auto)vehiculoFabricado;
                if (this.lblFabricados.InvokeRequired)
                {
                    ConstruirAuto d = new ConstruirAuto(Informar);
                    object[] objs = new object[] { auxAuto };
                    this.Invoke(d, objs);
                }
                else
                {
                    MessageBox.Show($"Auto: {auxAuto.Nombre} fué creado");
                    this.ActualizarLblFabricados();
                }
            }
            if (vehiculoFabricado.GetType() == typeof(Motocicleta))
            {
                Motocicleta auxNuevaMoto = (Motocicleta)vehiculoFabricado;
                if (this.lblFabricados.InvokeRequired)
                {
                    ConstruirMoto d = new ConstruirMoto(Informar);
                    object[] objs = new object[] { auxNuevaMoto };
                    this.Invoke(d, objs);
                }
                else
                {
                    MessageBox.Show($"Motocicleta: {auxNuevaMoto.Nombre} fué creado");
                    this.ActualizarLblFabricados();
                }
            }

            if(Taller.listaDeAutos.Count == 0 && Taller.listaDeMotos.Count == 0)
                this.lblProceso.Text = "Proceso: sin trabajo";

        }
        #endregion
    }
}
