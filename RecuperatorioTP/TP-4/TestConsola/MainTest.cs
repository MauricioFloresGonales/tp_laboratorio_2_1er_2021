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

            Funciones.Preparacion();
            Funciones.Pausa();

            Funciones.Separador();

            Funciones.Fabricacion();
            Funciones.Pausa();

            Funciones.Separador();

            Funciones.Mostrar();
            Funciones.Pausa();

            Funciones.Separador();
            
            Funciones.CrearArchivos();
            Funciones.Pausa();
            
        }
    }
}
