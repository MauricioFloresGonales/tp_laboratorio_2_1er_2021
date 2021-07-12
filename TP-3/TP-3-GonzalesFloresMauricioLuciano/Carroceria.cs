using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum EEstilo
    {
        Clasico,
        Discreto,
        Deportivo,
        TodoTerreno
    }
    public class Carroceria:Parte,IDetalles
    {
        EEstilo estilo;
        int cantPuertas;

        #region Propiedades
        public EEstilo Estilo
        {
            get { return this.estilo; }
        }
        public int CantPuertas
        {
            get { return this.cantPuertas; }
        }
        #endregion

        #region Constructores
        public Carroceria() : base()
        {
            this.cantPuertas = 2;
        }
        public Carroceria(int cantPuertas) : this()
        {
            base.TiempoDeProceso = this.CalcularTiempo();
            this.cantPuertas = cantPuertas;
        }
        public Carroceria(string estilo, int cantPuertas) : this(cantPuertas)
        {
            this.estilo = SeleccionarEstilo(estilo);
        }
        #endregion

        #region Metodos
        public override int CalcularTiempo()
        {
            switch (this.estilo)
            {
                case EEstilo.Clasico:
                    return 1;
                case EEstilo.Discreto:
                    return 2;
                case EEstilo.Deportivo:
                    return 3;
                case EEstilo.TodoTerreno:
                    return 4;
            }
            return TiempoDeProceso;
        }
        public EEstilo SeleccionarEstilo(string estilo)
        {
            switch (estilo.Trim())
            {
                case "Clasico":
                    return EEstilo.Clasico;
                case "Discreto":
                    return EEstilo.Discreto;
                case "Deportivo":
                    return EEstilo.Deportivo;
                case "TodoTerreno":
                    return EEstilo.TodoTerreno;
                default:
                    throw new Exception("Carroceria: No se eligio ningun tipo de estilo");
            }
        }
        public static object[] AgregarAlCmb()
        {
            Object[] aux = new Object[4];
            aux[0] = EEstilo.Clasico;
            aux[1] = EEstilo.Discreto;
            aux[2] = EEstilo.Deportivo;
            aux[3] = EEstilo.TodoTerreno;
            return aux;
        }
        #endregion

        #region IDetalles
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"-Estilo: {this.estilo}");
            sb.AppendLine($"-Cantidad de Puertas: {this.cantPuertas}");
            return sb.ToString();
        }
        #endregion
    }
}
