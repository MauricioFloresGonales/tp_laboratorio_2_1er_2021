using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Formatos;

namespace Entidades
{
    public static class Taller
    {

        public static List<Auto> listaDeAutos;
        static Taller()
        {
            listaDeAutos = new List<Auto>();
        }
        public static void AgregarUnVehiculo(object auto)
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
        public static void AgregarVehiculos(List<Auto> listaDeAutos)
        {
            try 
            {
                foreach (Auto auxAuto in listaDeAutos)
                {
                    Taller.AgregarUnVehiculo(auxAuto);
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
                Thread.Sleep(auto.TiempoDeProcduccion() * 1000);
                Taller.listaDeAutos -= auto;
            }
            catch (Exception e)
            {
                throw new Exception($"Ocurrio un error:\n{e.Message}");
            }
        }

        public static string MostrarLista()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Auto auto in listaDeAutos)
            {
                sb.Append(Taller.MostrarUnoDeLaLista(auto));
            }
            return sb.ToString();
        }
        public static string MostrarUnoDeLaLista(Auto autoAMostrar)
        {
            StringBuilder sb = new StringBuilder();
            if(autoAMostrar.Id == 0)
            {
                sb.AppendLine($"-------------------Todavia no se le asignó un Id---------------------------------");
            }
            else
            {
                sb.AppendLine($"---------------------------------{autoAMostrar.Id}-------------------------------------------");
            }
            sb.AppendLine($"{autoAMostrar.MostrarDatos()}");

            return sb.ToString();
        }

        public static string IdsEnApp()
        {
            string retorno = "";

            for (int i = 0; i < Taller.listaDeAutos.Count; i++)
            {
                retorno += $"CAST({Taller.listaDeAutos[i].Id.ToString()} AS int)";
                if(i < Taller.listaDeAutos.Count-1)
                {
                    retorno += " , ";
                }
            }
            return retorno;
        }
        public static void EntregarAuto(Auto auto)
        {
            try
            {
                Archivos.CrearArchivoTexto(auto.FormatoArchivos(), auto.CreadoPor, auto.Nombre);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
