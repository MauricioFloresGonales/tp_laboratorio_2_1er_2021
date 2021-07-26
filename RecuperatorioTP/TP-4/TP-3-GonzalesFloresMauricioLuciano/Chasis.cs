using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum EChasis
    {
        Deportivo,
        Scooter,
        Retro
    }
    public class Chasis : Parte, IDetalles
    {
        EChasis chasisTipo;

        #region Propiedades
        public EChasis ChasisTipo
        {
            get { return this.chasisTipo; }
        }
        #endregion

        #region Constructores
        public Chasis() : base()
        {

        }
        public Chasis(string chasisTipo) : this()
        {
            base.TiempoDeProceso = this.CalcularTiempo();
            this.chasisTipo = SeleccionarChasis(chasisTipo);
        }
        #endregion

        #region Metodos
        public override int CalcularTiempo()
        {
            switch (this.chasisTipo)
            {
                case EChasis.Deportivo:
                    return 3;
                case EChasis.Scooter:
                    return 2;
                case EChasis.Retro:
                    return 1;
            }
            return TiempoDeProceso;
        }
        public EChasis SeleccionarChasis(string tipo)
        {
            switch (tipo.Trim())
            {
                case "Deportivo":
                    return EChasis.Deportivo;
                case "Scooter":
                    return EChasis.Scooter;
                case "Retro":
                    return EChasis.Retro;
                default:
                    throw new Exception("Chasis: No se eligio ningun estilo");
            }
        }
        public static object[] AgregarAlCmb()
        {
            Object[] aux = new Object[3];
            aux[0] = EChasis.Deportivo;
            aux[1] = EChasis.Scooter;
            aux[2] = EChasis.Retro;

            return aux;
        }
        #endregion

        #region IDetalles
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"-Tipo de chasis: {this.ChasisTipo}");
            return sb.ToString();
        }
        #endregion
    }
}
