using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace TestConsola
{
    class MainTest
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test Rapido de Taller");

            Funciones.Separador();

            Funciones.TestAgregarUnVehiculo();

            Funciones.Pausa();
            Funciones.Separador();

            Funciones.TestAgregarVehiculos();

            Funciones.Pausa();
            Funciones.Separador();

            Funciones.TestEliminarAuto();

            Funciones.Pausa();
            Funciones.Separador();

            Funciones.TestMostrarLista();

            Funciones.Pausa();
            Funciones.Separador();
        }
    }
}
