using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public delegate void ConstruirAuto(object nuevoAuto);
    public class Auto : Vehiculo, IDetalles
    {
        public event ConstruirAuto EventoConstruirAuto;

        Carroceria carroceria;
        Rueda ruedas;
        Motor motor;

        #region Propiedades
        public Carroceria Carroceria
        {
            get { return this.carroceria; }
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
        public Auto():base()
        {
        }
        public Auto(string creadoPor, string nombre, Carroceria carroceria, Motor motor, Rueda ruedas) : base(creadoPor, nombre)
        {
            this.carroceria = carroceria;
            this.motor = motor;
            this.ruedas = ruedas;
        }
        public Auto(string nombre, string creadoPor, string carroceriaEstilo, string carroceriaCantPuertas, string motorTipo, string ruedaTipo, string ruedaTamanio) : base(nombre, creadoPor)
        {
            this.carroceria = new Carroceria(carroceriaEstilo, int.Parse(carroceriaCantPuertas));
            this.motor = new Motor(motorTipo);
            this.ruedas = new Rueda(ruedaTipo,ruedaTamanio);
        }
        public Auto(int id, string creadoPor, string nombre) : base(id, creadoPor, nombre)
        {
        }
        public Auto(int id, string nombre, string creadoPor, string carroceriaEstilo, string carroceriaCantPuertas, string motorTipo, string ruedaTipo, string ruedaTamanio) : this(id, nombre, creadoPor)
        {
            this.carroceria = new Carroceria(carroceriaEstilo, int.Parse(carroceriaCantPuertas));
            this.motor = new Motor(motorTipo);
            this.ruedas = new Rueda(ruedaTipo, ruedaTamanio);
        }
        #endregion

        #region Metodos

        public override int TiempoDeProcduccion()
        {
            return carroceria.CalcularTiempo() + ruedas.CalcularTiempo() + motor.CalcularTiempo();
        }
        public override bool Existe<Auto>(List<Auto> listaDeAutos)
        {
            if(listaDeAutos.Count != 0)
            {
                foreach (Auto item in listaDeAutos)
                {
                    if (item == this)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public void Proceso(object nuevoAuto)
        {
            if (!object.ReferenceEquals(this.EventoConstruirAuto, null))
                this.EventoConstruirAuto.Invoke(nuevoAuto);
        }
        #endregion

        #region Sobrecargas
        public static List<Auto> operator +(List<Auto> listaDeAutos, Auto auto)
        {
            if (listaDeAutos != null)
            {
                listaDeAutos.Add(auto);
                return listaDeAutos;
            }
            return listaDeAutos;
        }
        public static List<Auto> operator -(List<Auto> listaDeAutos, Auto auto)
        {
            if (listaDeAutos != null)
            {
                listaDeAutos.Remove(auto);
                return listaDeAutos;
            }
            return listaDeAutos;
        }
        public static bool operator ==(object autoUno, Auto autoDos)
        {
            Auto auxAuto = (Auto)autoUno;
            if (auxAuto.CreadoPor == autoDos.CreadoPor && auxAuto.Nombre == autoDos.Nombre)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(object autoUno, Auto autoDos)
        {
            return !(autoUno == autoDos);
        }
        #endregion

        #region IDetalles
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre:{base.Nombre}");
            sb.AppendLine($"Creado por:{base.CreadoPor}");
            sb.AppendLine($"\t-=Carroceria=-\n{this.carroceria.MostrarDatos()}");
            sb.AppendLine($"\t-=Motor=-\n{this.motor.MostrarDatos()}");
            sb.AppendLine($"\t-=Ruedas=-\n{this.ruedas.MostrarDatos()}");
            sb.AppendLine($"\tTIEMPO EN FABRICAR:{this.TiempoDeProcduccion()}");
            return sb.ToString();
        }
        #endregion
    }
}
