using System;
using System.Collections.Generic;
using System.Text;
using Formatos;

namespace Entidades
{
    public static class Taller
    {

        public static List<Auto> listaDeAutos;
        public static List<Motocicleta> listaDeMotos;
        static Taller()
        {
            listaDeAutos = new List<Auto>();
            listaDeMotos = new List<Motocicleta>();
        }

        #region Autos
        public static void AgregarUnAuto(object auto)
        {
            try
            {
                Auto auxAuto = (Auto)auto;
                if(listaDeAutos.Count > 0)
                {
                    foreach (Auto v in listaDeAutos)
                    {
                        if (v == auxAuto)
                        {
                            throw new Exception("El auto que desea fabricar ya existe");
                        }
                    }
                    listaDeAutos += auxAuto;
                }
                else
                {
                    listaDeAutos += auxAuto;
                }
            }
            catch (Exception e)
            {
                throw new Exception($"Ocurrio un error:\n{e.Message}");
            }
        }
        public static void AgregarAutos(List<Auto> listaDeAutos)
        {
            try 
            {
                foreach (Auto auxAuto in listaDeAutos)
                {
                    Taller.AgregarUnAuto(auxAuto);
                }
            }
            catch (Exception e)
            {
                throw new Exception($"Ocurrio un error:\n{e.Message}");
            }
        }
        public static void EliminarAuto(Auto auto)
        {
            try
            {
                Taller.listaDeAutos -= auto;
            }
            catch (Exception e)
            {
                throw new Exception($"Ocurrio un error:\n{e.Message}");
            }
        }
        public static void Entregar(Auto auto)
        {
            try
            {
                Archivos.CrearArchivoTexto("Auto", auto.FormatoArchivos(), auto.CreadoPor, auto.Nombre);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        #endregion

        #region Motocicletas

        public static void AgregarUnaMoto(object moto)
        {
            try
            {
                Motocicleta auxMoto = (Motocicleta)moto;
                if (listaDeMotos.Count > 0)
                {
                    foreach (Motocicleta v in listaDeMotos)
                    {
                        if (v == auxMoto)
                        {
                            throw new Exception("La motocicleta que desea fabricar ya existe");
                        }
                    }
                    listaDeMotos += auxMoto;
                }
                else
                {
                    listaDeMotos += auxMoto;
                }
            }
            catch (Exception e)
            {
                throw new Exception($"Ocurrio un error:\n{e.Message}");
            }
        }

        public static void AgregarMotos(List<Motocicleta> listaDeMotos)
        {
            try
            {
                foreach (Motocicleta auxMoto in listaDeMotos)
                {
                    Taller.AgregarUnaMoto(auxMoto);
                }
            }
            catch (Exception e)
            {
                throw new Exception($"Ocurrio un error:\n{e.Message}");
            }
        }

        public static void EliminarMoto(Motocicleta moto)
        {
            try
            {
                Taller.listaDeMotos -= moto;
            }
            catch (Exception e)
            {
                throw new Exception($"Ocurrio un error:\n{e.Message}");
            }
        }

        public static void Entregar(Motocicleta moto)
        {
            try
            {
                Archivos.CrearArchivoTexto("Motocicleta", moto.FormatoArchivos(), moto.CreadoPor, moto.Nombre);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        #endregion

        public static string MostrarLista()
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                foreach (Auto auto in listaDeAutos)
                {
                    sb.Append(Taller.MostrarUnoDeLaLista(auto));
                }
                foreach (Motocicleta moto in listaDeMotos)
                {
                    sb.Append(Taller.MostrarUnoDeLaLista(moto));
                }
                return sb.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }
        public static string MostrarUnoDeLaLista<T>(T vehiculo)where T:Vehiculo,IDetalles
        {
            try
            {
                StringBuilder sb = new StringBuilder();

                if (vehiculo.GetType() == typeof(Auto))
                {
                    if (vehiculo.Id == 0)
                    {
                        sb.AppendLine($"-------------------Auto---------------------------------");
                    }
                    else
                    {
                        sb.AppendLine($"---------------------------------Auto {vehiculo.Id}-------------------------------------------");
                    }
                    sb.AppendLine($"{vehiculo.MostrarDatos()}");
                }
                if (vehiculo.GetType() == typeof(Motocicleta))
                {

                    if (vehiculo.Id == 0)
                    {
                        sb.AppendLine($"-------------------Motocicleta---------------------------------");
                    }
                    else
                    {
                        sb.AppendLine($"-----------------------------Motocicleta {vehiculo.Id}-----------------------------------------");
                    }
                    sb.AppendLine($"{vehiculo.MostrarDatos()}");
                }
                return sb.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }
    }
}
