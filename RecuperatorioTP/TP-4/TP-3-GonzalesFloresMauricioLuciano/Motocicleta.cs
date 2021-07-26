using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public delegate void ConstruirMoto(object nuevoMoto);
    public class Motocicleta : Vehiculo, IDetalles
    {
        public event ConstruirMoto EventoConstruirMoto;

        Chasis chasisTipo;
        Rueda ruedas;
        Motor motor;

        #region Propiedades
        public Chasis ChasisTipo
        {
            get { return this.chasisTipo; }
        }
        public Rueda Ruedas
        {
            get { return this.ruedas; }
        }
        public Motor Motor
        {
            get { return this.motor; }
        }
        #endregion

        #region Constructores
        public Motocicleta():base()
        {
        }
        public Motocicleta(string nombre, string creadoPor, Chasis chasisTipo, Motor motor, Rueda ruedas) : base(nombre, creadoPor)
        {
            this.chasisTipo = chasisTipo;
            this.motor = motor;
            this.ruedas = ruedas;
        }
        public Motocicleta(string creadoPor, string nombre, string chasisTipo, string motorTipo, string ruedaTipo, string ruedaTamanio) : base(nombre, creadoPor)
        {
            this.chasisTipo = new Chasis(chasisTipo);
            this.motor = new Motor(motorTipo);
            this.ruedas = new Rueda(ruedaTipo, ruedaTamanio);
        }
        public Motocicleta(int id, string creadoPor, string nombre) : base(id,creadoPor, nombre)
        {
        }
        public Motocicleta(int id, string nombre, string creadoPor, string chasisTipo, string motorTipo, string ruedaTipo, string ruedaTamanio) : this(id, nombre, creadoPor)
        {
            this.chasisTipo = new Chasis(chasisTipo);
            this.motor = new Motor(motorTipo);
            this.ruedas = new Rueda(ruedaTipo, ruedaTamanio);
        }
        #endregion

        #region Metodos

        public override int TiempoDeProcduccion()
        {
            return chasisTipo.CalcularTiempo() + ruedas.CalcularTiempo() + motor.CalcularTiempo();
        }
        public override bool Existe<Motocicleta>(List<Motocicleta> listaDeAutos)
        {
            if(listaDeAutos.Count != 0)
            {
                foreach (Motocicleta item in listaDeAutos)
                {
                    if (item == this)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public void Proceso(object nuevaMoto)
        {
            if (!object.ReferenceEquals(this.EventoConstruirMoto, null))
                this.EventoConstruirMoto.Invoke(nuevaMoto);
        }

        #endregion

        #region Sobrecargas
        public static List<Motocicleta> operator +(List<Motocicleta> listaDeMotos, Motocicleta moto)
        {
            if (listaDeMotos != null)
            {
                listaDeMotos.Add(moto);
                return listaDeMotos;
            }
            return listaDeMotos;
        }
        public static List<Motocicleta> operator -(List<Motocicleta> listaDeMotos, Motocicleta moto)
        {
            if (listaDeMotos != null)
            {
                listaDeMotos.Remove(moto);
                return listaDeMotos;
            }
            return listaDeMotos;
        }
        public static bool operator ==(object motoUno, Motocicleta motoDos)
        {
            Motocicleta auxMotocicleta = (Motocicleta)motoUno;
            if (auxMotocicleta.CreadoPor == motoDos.CreadoPor && auxMotocicleta.Nombre == motoDos.Nombre)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(object motoUno, Motocicleta motoDos)
        {
            return !(motoUno == motoDos);
        }
        #endregion

        #region IDetalles
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre:{base.Nombre}");
            sb.AppendLine($"Creado por:{base.CreadoPor}");
            sb.AppendLine($"\t-=Chasis=-\n{this.chasisTipo.MostrarDatos()}");
            sb.AppendLine($"\t-=Motor=-\n{this.motor.MostrarDatos()}");
            sb.AppendLine($"\t-=Ruedas=-\n{this.ruedas.MostrarDatos()}");
            sb.AppendLine($"\tTIEMPO EN FABRICAR:{this.TiempoDeProcduccion()}");
            return sb.ToString();
        }
        #endregion
    }
}
