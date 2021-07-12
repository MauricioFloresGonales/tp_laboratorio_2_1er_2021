using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
    public delegate void Construir(object nuevoAuto);
    public sealed class Auto : IDetalles
    {
        public event Construir EventoConstruir;

        int id;
        string nombre;
        string creadoPor;
        Carroceria carroceria;
        Rueda ruedas;
        Motor motor;

        #region Propiedades
        public int Id
        {
            get { return this.id; }
        }
        public string Nombre
        {
            get { return this.nombre; }
        }
        public string CreadoPor
        {
            get { return this.creadoPor; }
        }
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
        public Auto()
        {
            this.creadoPor = "Desconocido";
        }
        public Auto(string creadoPor, string nombre, Carroceria carroceria, Motor motor, Rueda ruedas)
        {
            this.nombre = nombre;
            this.creadoPor = creadoPor;
            this.carroceria = carroceria;
            this.motor = motor;
            this.ruedas = ruedas;
        }
        public Auto(string creadoPor, string nombre, string carroceriaEstilo, string carroceriaCantPuertas, string motorTipo, string ruedaTipo, string ruedaTamanio)
        {
            this.nombre = nombre;
            this.creadoPor = creadoPor;
            this.carroceria = new Carroceria(carroceriaEstilo, int.Parse(carroceriaCantPuertas));
            this.motor = new Motor(motorTipo);
            this.ruedas = new Rueda(ruedaTipo,ruedaTamanio);
        }
        public Auto(int id, string creadoPor, string nombre, string carroceriaEstilo, string carroceriaCantPuertas, string motorTipo, string ruedaTipo, string ruedaTamanio):this(creadoPor,nombre,carroceriaEstilo,carroceriaCantPuertas,motorTipo,ruedaTipo,ruedaTamanio)
        {
            this.id = id;
        }
        #endregion

        #region Metodos

        public int TiempoDeProcduccion()
        {
            return carroceria.CalcularTiempo() + ruedas.CalcularTiempo() + motor.CalcularTiempo();
        }
        public bool AutoExiste(List<Auto> listaDeAutos)
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
            if (!object.ReferenceEquals(this.EventoConstruir, null))
                this.EventoConstruir.Invoke(nuevoAuto);
        }
        public void Fabricacion()
        {
            Thread.Sleep(this.TiempoDeProcduccion()*1000);
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
        public static bool operator ==(Auto autoUno, Auto autoDos)
        {
            if (autoUno.CreadoPor == autoDos.CreadoPor && autoUno.Nombre == autoDos.Nombre)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Auto autoUno, Auto autoDos)
        {
            return !(autoUno == autoDos);
        }
        #endregion

        #region IDetalles
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre:{this.nombre}");
            sb.AppendLine($"Creado por:{this.creadoPor}");
            sb.AppendLine($"\t-=Carroceria=-\n{this.carroceria.MostrarDatos()}");
            sb.AppendLine($"\t-=Motor=-\n{this.motor.MostrarDatos()}");
            sb.AppendLine($"\t-=Ruedas=-\n{this.ruedas.MostrarDatos()}");
            sb.AppendLine($"\tTIEMPO EN FABRICAR:{this.TiempoDeProcduccion()}");
            return sb.ToString();
        }
        #endregion
    }
}
