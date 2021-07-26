using System.Text;
using Entidades;

namespace Formatos
{
    public static class ExtencionDeFormato
    {
        #region Auto
        public static string FormatoArchivos(this Auto objeto)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("|---------------------------------------|");
            sb.AppendLine($"| Creado por:{objeto.CreadoPor}   Nombre:{objeto.Nombre}	|");
            sb.AppendLine($"|\t\t\t\t\t|");
            sb.AppendLine("|-------------=Carroceria=--------------|");
            sb.AppendLine($"|         {objeto.Carroceria.MostrarDatos()}			|");
            sb.AppendLine("|\t\t\t\t\t|");
            sb.AppendLine($"|         {objeto.Motor.MostrarDatos()}                  |");
            sb.AppendLine("|\t\t\t\t\t|");
            sb.AppendLine($"|         {objeto.Ruedas.MostrarDatos()}                  |");
            sb.AppendLine("|\t\t\t\t\t|");
            sb.AppendLine($"|       TIEMPO DE FABRICACIÓN: {objeto.TiempoDeProcduccion()}       |");
            sb.AppendLine("|\t\t\t\t\t|");
            return sb.ToString();
        }
        public static string FormatoAlert(this Auto objeto)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"\tNUEVO AUTO");
            sb.AppendLine($"*Creado por: {objeto.CreadoPor}");
            sb.AppendLine($"*Nombre: {objeto.Nombre}");
            sb.AppendLine($"------------=Carroceria=------------\n{objeto.Carroceria.MostrarDatos()}");
            sb.AppendLine($"--------------=Motor=---------------\n{objeto.Motor.MostrarDatos()}");
            sb.AppendLine($"--------------=Ruedas=--------------\n{objeto.Ruedas.MostrarDatos()}");
            sb.AppendLine($"     TIEMPO EN FABRICAR: {objeto.TiempoDeProcduccion()} seg");
            return sb.ToString();
        }
        #endregion

        #region Motocicleta
        public static string FormatoArchivos(this Motocicleta objeto)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("|---------------------------------------|");
            sb.AppendLine($"| Creado por:{objeto.CreadoPor}   Nombre:{objeto.Nombre}	|");
            sb.AppendLine($"|\t\t\t\t\t|");
            sb.AppendLine("|-------------=Chasis=--------------|");
            sb.AppendLine($"|         {objeto.ChasisTipo.MostrarDatos()}			|");
            sb.AppendLine("|\t\t\t\t\t|");
            sb.AppendLine($"|         {objeto.Motor.MostrarDatos()}                  |");
            sb.AppendLine("|\t\t\t\t\t|");
            sb.AppendLine($"|         {objeto.Ruedas.MostrarDatos()}                  |");
            sb.AppendLine("|\t\t\t\t\t|");
            sb.AppendLine($"|       TIEMPO DE FABRICACIÓN: {objeto.TiempoDeProcduccion()}       |");
            sb.AppendLine("|\t\t\t\t\t|");
            return sb.ToString();
        }
        public static string FormatoAlert(this Motocicleta objeto)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"\tNUEVA MOTOCICLETA");
            sb.AppendLine($"*Creado por: {objeto.CreadoPor}");
            sb.AppendLine($"*Nombre: {objeto.Nombre}");
            sb.AppendLine($"------------=Chasis=------------\n{objeto.ChasisTipo.MostrarDatos()}");
            sb.AppendLine($"--------------=Motor=---------------\n{objeto.Motor.MostrarDatos()}");
            sb.AppendLine($"--------------=Ruedas=--------------\n{objeto.Ruedas.MostrarDatos()}");
            sb.AppendLine($"     TIEMPO EN FABRICAR: {objeto.TiempoDeProcduccion()} seg");
            return sb.ToString();
        }
        #endregion
    }
}
