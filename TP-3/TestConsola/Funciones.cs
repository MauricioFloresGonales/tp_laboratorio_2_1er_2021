using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace TestConsola
{
    public static class Funciones
    {
        public static void Separador()
        {
            Console.WriteLine("------------------------------------------------------");
        }
        public static void Pausa()
        {
            Console.WriteLine("\n(Toque cualquier tecla para continuar)");
            Console.ReadKey();
        }
        public static void TestAgregarUnVehiculo()
        {
            Console.WriteLine("1-Taller.AgregarUnVehiculo");

            int auxCount = Taller.listaDeAutos.Count;
            Auto nuevoAuto = new Auto("test", "test",
                new Carroceria(EEstilo.Clasico.ToString(), 3),
                new Motor(EMotor.CicloOtto.ToString()),
                new Rueda(ETipo.Invierno.ToString(), ETamanio.Mediana.ToString()));
            Taller.AgregarUnVehiculo(nuevoAuto);

            Console.WriteLine($"lista sin agregar nada: {auxCount}");
            Console.WriteLine($"lista agregando un auto nuevo: {Taller.listaDeAutos.Count}");
        }
        public static void TestAgregarVehiculos()
        {
            Console.WriteLine("2-Taller.AgregarVehiculos");

            Auto nuevoAutoUno = new Auto("testUno", "test1",
                new Carroceria(EEstilo.Clasico.ToString(), 3),
                new Motor(EMotor.CicloOtto.ToString()),
                new Rueda(ETipo.Invierno.ToString(), ETamanio.Mediana.ToString()));
            Auto nuevoAutoDos = new Auto("testDos", "test2",
                new Carroceria(EEstilo.TodoTerreno.ToString(), 3),
                new Motor(EMotor.Electrico.ToString()),
                new Rueda(ETipo.Deportivo.ToString(), ETamanio.Grande.ToString()));
            Auto nuevoAutoTres = new Auto("testTres", "test3",
                new Carroceria(EEstilo.Clasico.ToString(), 3),
                new Motor(EMotor.Diesel.ToString()),
                new Rueda(ETipo.Pista.ToString(), ETamanio.Grande.ToString()));

            List<Auto> listaDeAutos = new List<Auto>();
            listaDeAutos.Add(nuevoAutoUno);
            listaDeAutos.Add(nuevoAutoDos);
            listaDeAutos.Add(nuevoAutoTres);

            Taller.AgregarVehiculos(listaDeAutos);

            Console.WriteLine($"Cantidad de autos a crear: {listaDeAutos.Count}");
            Console.WriteLine($"Cantidad de autos agregados: {Taller.listaDeAutos.Count}");
        }
        public static void TestEliminarAuto()
        {
            Console.WriteLine("3-Taller.EliminarAutos");

            Auto nuevoAutoUno = new Auto("nuevoAutoUno", "nuevoAuto1",
                new Carroceria(EEstilo.Clasico.ToString(), 3),
                new Motor(EMotor.CicloOtto.ToString()),
                new Rueda(ETipo.Invierno.ToString(), ETamanio.Mediana.ToString()));
            Taller.AgregarUnVehiculo(nuevoAutoUno);

            int auxCount = Taller.listaDeAutos.Count;

            Console.WriteLine($"El auto se eliminara en: {nuevoAutoUno.TiempoDeProcduccion()}seg");
            Console.WriteLine($"Este tiempo fue usado para la simulacion de construccion del auto");
            Taller.EliminarAuto(nuevoAutoUno);

            Console.WriteLine($"Cantidad de autos a crear: {auxCount}");
            Console.WriteLine($"Cantidad de autos eliminados: 1");
            Console.WriteLine($"Cantidad de autos que quedan en la lista: {Taller.listaDeAutos.Count}");
        }
        public static void TestMostrarLista()
        {
            Console.WriteLine("4-Taller.MostrarLista");
            Console.WriteLine("Muestra en una lista la lista de autos que fueran creado y estan listos para fabricarse");
            
            Console.WriteLine(Taller.MostrarLista());
        }
        

    }
}
