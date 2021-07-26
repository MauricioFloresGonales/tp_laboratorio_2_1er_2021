using System.Collections.Generic;
using System.Threading;

namespace Entidades
{
    public abstract class Vehiculo
    {
        int id;
        string nombre;
        string creadoPor;

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
        #endregion

        #region Constructores
        public Vehiculo()
        {
            this.creadoPor = "Desconocido";
            this.nombre = "Desconocido";
            this.creadoPor = "Desconocido";
        }
        public Vehiculo(string nombre, string creadoPor):this()
        {
            this.nombre = nombre;
            this.creadoPor = creadoPor;
        }
        public Vehiculo(int id, string nombre, string creadoPor) : this(nombre,creadoPor)
        {
            this.id = id;
        }
        #endregion

        public abstract int TiempoDeProcduccion();

        public abstract bool Existe<T>(List<T> listaDeAutos);

        public void Fabricacion()
        {
            Thread.Sleep(this.TiempoDeProcduccion() * 1000);
        }

    }
}
