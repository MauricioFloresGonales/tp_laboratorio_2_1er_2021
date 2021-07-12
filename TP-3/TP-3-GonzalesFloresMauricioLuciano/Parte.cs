using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Parte
    {
        int tiempoDeProceso;

        #region Propiedades
        public int TiempoDeProceso
        {
            get { return this.tiempoDeProceso; }
            set 
            {
                if (value > 0)
                {
                    tiempoDeProceso = value;
                }
                else
                {
                    tiempoDeProceso = 1;
                }
            }
        }
        #endregion

        #region Constructores
        public Parte()
        {
            tiempoDeProceso = 0;
        }
        public Parte(int tiempoDeProceso) :this()
        {
            this.tiempoDeProceso = tiempoDeProceso;
        }
        #endregion

        #region Metodos
        public abstract int CalcularTiempo();
        #endregion
    }
}
