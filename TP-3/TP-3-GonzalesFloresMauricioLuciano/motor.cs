using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum EMotor
    {
        Electrico,
        CicloOtto,
        Diesel

    }
    public class Motor : Parte, IDetalles
    {
        EMotor motorTipo;

        #region Propiedades
        public EMotor MotorTipo
        {
            get { return this.motorTipo; }
        }
        #endregion

        #region Constructores
        public Motor() : base()
        {

        }
        public Motor(string motorTipo) : this()
        {
            base.TiempoDeProceso = this.CalcularTiempo();
            this.motorTipo = SeleccionarMotor(motorTipo);
        }
        #endregion

        #region Metodos
        public override int CalcularTiempo()
        {
            switch (this.motorTipo)
            {
                case EMotor.Electrico:
                    return 3;
                case EMotor.CicloOtto:
                    return 2;
                case EMotor.Diesel:
                    return 1;
            }
            return TiempoDeProceso;
        }
        public EMotor SeleccionarMotor(string tamanio)
        {
            switch (tamanio.Trim())
            {
                case "Electrico":
                    return EMotor.Electrico;
                case "CicloOtto":
                    return EMotor.CicloOtto;
                case "Diesel":
                    return EMotor.Diesel;
                default:
                    throw new Exception("Motor: No se eligio ningun tipo");
            }
        }
        public static object[] AgregarAlCmb()
        {
            Object[] aux = new Object[3];
            aux[0] = EMotor.Electrico;
            aux[1] = EMotor.CicloOtto;
            aux[2] = EMotor.Diesel;

            return aux;
        }
        #endregion

        #region IDetalles
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"-Tipo de motor: {this.motorTipo}");
            return sb.ToString();
        }
        #endregion
    }
}
