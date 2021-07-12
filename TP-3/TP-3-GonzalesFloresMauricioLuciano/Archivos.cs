using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    public static class Archivos
    {
        #region Texto
        public static void CrearArchivoTexto(string formato, string usuario, string nombreDelObjeto)
        {
            try
            {
                //Ruta = App\bin\Debug
                string ruta = string.Concat(Environment.CurrentDirectory, $"\\Auto.{usuario}.{nombreDelObjeto}.txt");

                using (StreamWriter escritor = new StreamWriter(ruta, true))
                {
                    escritor.WriteLine(formato);
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }
        #endregion

        #region XML
        public static void CrearArchivoXml<T>(T formato)
        {
            try
            {
                string path = string.Concat(Environment.CurrentDirectory, "\\Usuario");
                XmlTextWriter escribir = new XmlTextWriter(path, Encoding.UTF8);

                if (!object.ReferenceEquals(escribir, null))
                {
                    XmlSerializer serializador = new XmlSerializer(typeof(T));

                    serializador.Serialize(escribir, formato);

                    escribir.Close();
                }
                else
                {
                    throw new Exception("El archivo no se pudo abrir");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }
        public static T LeerArchivoXml<T>()
        {
            try
            {
                XmlTextReader leer = new XmlTextReader(string.Concat(Environment.CurrentDirectory, "\\Usuario"));

                object retorno;

                if (!object.ReferenceEquals(leer, null))
                {
                    XmlSerializer lector = new XmlSerializer(typeof(T));

                    retorno = lector.Deserialize(leer);

                    leer.Close();

                    return (T)retorno;
                }
                else
                {
                    throw new Exception("El archivo no se pudo abrir");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        #endregion
    }
}
