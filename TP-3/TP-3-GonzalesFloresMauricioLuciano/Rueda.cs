using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum ETipo
    {
        Normales,
        Invierno,
        Deportivo,
        Pista

    }
    public enum ETamanio
    {
        Pequenia,
        Mediana,
        Grande
    }
    public class Rueda:Parte,IDetalles
    {
        ETamanio tamanio;
        ETipo tipo;

        #region Propiedades
        public ETamanio Tamanio
        {
            get { return this.tamanio; }
        }
        public ETipo Tipo
        {
            get { return this.tipo; }
        }
        #endregion

        #region Constructores
        public Rueda():base()
        {

        }
        public Rueda(string tipo, string tamanio) : this()
        {
            base.TiempoDeProceso = this.CalcularTiempo();
            this.tamanio = this.SeleccionarTamanio(tamanio);
            this.tipo = this.SeleccionarTipo(tipo);
        }
        #endregion

        #region Metodos
        public override int CalcularTiempo()
        {
            return this.CalcularTiempoTamanio() + this.CalcularTiempoTipo();
        }
        public int CalcularTiempoTamanio()
        {
            switch (this.tamanio)
            {
                case ETamanio.Pequenia:
                    return 1;
                case ETamanio.Mediana:
                    return 2;
                case ETamanio.Grande:
                    return 3;
            }
            return TiempoDeProceso;
        }
        public  int CalcularTiempoTipo()
        {
            switch (this.tipo)
            {
                case ETipo.Normales:
                    return 1;
                case ETipo.Invierno:
                    return 2;
                case ETipo.Deportivo:
                    return 4;
                case ETipo.Pista:
                    return 3;
            }
            return TiempoDeProceso;
        }
        public ETamanio SeleccionarTamanio(string tamanio)
        {
            switch (tamanio.Trim())
            {
                case "Pequenia":
                    return ETamanio.Pequenia;
                case "Mediana":
                    return ETamanio.Mediana;
                case "Grande":
                    return ETamanio.Grande;
                default:
                    throw new Exception("Ruedas: No se eligio ningun tamaño");
            }
        }
        public ETipo SeleccionarTipo(string tamanio)
        {
            switch (tamanio.Trim())
            {
                case "Normales":
                    return ETipo.Normales;
                case "Invierno":
                    return ETipo.Invierno;
                case "Deportivo":
                    return ETipo.Deportivo;
                case "Pista":
                    return ETipo.Pista;
                default:
                    throw new Exception("Ruedas: No se eligio ningun tipo de rueda");
            }
        }
        public static object[] AgregarTipoAlCmb()
        {
            Object[] aux = new Object[4];
            aux[0] = ETipo.Normales;
            aux[1] = ETipo.Invierno;
            aux[2] = ETipo.Deportivo;
            aux[3] = ETipo.Pista;

            return aux;
        }
        public static object[] AgregarTamanioAlCmb()
        {
            Object[] aux = new Object[3];
            aux[0] = ETamanio.Pequenia;
            aux[1] = ETamanio.Mediana;
            aux[2] = ETamanio.Grande;

            return aux;
        }
        #endregion

        #region IDetalles
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"-Tipo de ruedas: {this.tipo}");
            sb.AppendLine($"-Tamanio: {this.tamanio}");
            return sb.ToString();
        }
        #endregion
    }
}
