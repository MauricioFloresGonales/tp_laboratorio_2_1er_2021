using System;
using System.Collections.Generic;
using System.Linq;
using Entidades;
using Formatos;

namespace TestConsola
{
    public static class Funciones
    {
        public static void Separador()
        {
            Console.WriteLine("------------------------------------------------------");
            Console.Clear();
        }
        public static void SeparadorCorto()
        {
            Console.WriteLine("\t------------------");
        }
        public static void Pausa()
        {
            Console.WriteLine("\n(Toque cualquier tecla para continuar)");
            Console.ReadKey();
        }

        public static void Preparacion()
        {
            Console.WriteLine("1- Cargando listas con autos y motocicletas");

            Auto nuevoAutoUno = new Auto("testAutoUno", "test1",
                new Carroceria(EEstilo.Clasico.ToString(), 3),
                new Motor(EMotor.CicloOtto.ToString()),
                new Rueda(ETipo.Invierno.ToString(), ETamanio.Mediana.ToString()));
            Auto nuevoAutoDos = new Auto("testAutoDos", "test2",
                new Carroceria(EEstilo.TodoTerreno.ToString(), 3),
                new Motor(EMotor.Electrico.ToString()),
                new Rueda(ETipo.Deportivo.ToString(), ETamanio.Pequenia.ToString()));
            Auto nuevoAutoTres = new Auto("testAutoTres", "test3",
                new Carroceria(EEstilo.Clasico.ToString(), 3),
                new Motor(EMotor.Diesel.ToString()),
                new Rueda(ETipo.Pista.ToString(), ETamanio.Grande.ToString()));
            Motocicleta nuevoMotoUno = new Motocicleta("testMotoUno", "test1",
                new Chasis(EChasis.Scooter.ToString()),
                new Motor(EMotor.CicloOtto.ToString()),
                new Rueda(ETipo.Invierno.ToString(), ETamanio.Mediana.ToString()));
            Motocicleta nuevoMotoDos = new Motocicleta("testMotoDos", "test2",
                new Chasis(EChasis.Retro.ToString()),
                new Motor(EMotor.Diesel.ToString()),
                new Rueda(ETipo.Deportivo.ToString(), ETamanio.Grande.ToString()));

            List<Auto> listaDeAutos = new List<Auto>();
            listaDeAutos.Add(nuevoAutoUno);
            listaDeAutos.Add(nuevoAutoDos);
            listaDeAutos.Add(nuevoAutoTres);

            List<Motocicleta> listaDeMotos = new List<Motocicleta>();
            listaDeMotos.Add(nuevoMotoUno);
            listaDeMotos.Add(nuevoMotoDos);

            Taller.AgregarAutos(listaDeAutos);
            Taller.AgregarMotos(listaDeMotos);

            Console.WriteLine($"Se QUIZO ingresar {listaDeAutos.Count} autos y {listaDeMotos.Count} motocicletas");

            Console.WriteLine($"Se PUDO ingresar {Taller.listaDeAutos.Count} autos y {Taller.listaDeMotos.Count} motocicletas");
        }
        public static void Fabricacion()
        {
            Console.WriteLine("2 Ahora vamos comenzar con el proceso de fabricacion\n");

            int antesAuto = Taller.listaDeAutos.Count;
            int antesMoto = Taller.listaDeMotos.Count;

            Console.WriteLine("2-1 Fabricar un Auto");
            Auto auxAuto = Taller.listaDeAutos.ElementAt(1);
            Console.WriteLine($"Tiempo de fabricacion es de {auxAuto.TiempoDeProcduccion()}seg");
            Taller.EliminarAuto(auxAuto);

            Console.WriteLine($"Se fabricó una Auto");
            Console.WriteLine($"Habian {antesAuto} autos y Ahora quedan {Taller.listaDeMotos.Count} autos en el taller");

            Funciones.SeparadorCorto();
            Console.WriteLine("2-2 Fabricar un Motocicleta");
            Motocicleta auxMoto = Taller.listaDeMotos.ElementAt(1);
            Console.WriteLine($"Tiempo de fabricacion es de {auxMoto.TiempoDeProcduccion()}seg");
            Taller.EliminarMoto(auxMoto);

            Console.WriteLine($"Se fabricó una moto");
            Console.WriteLine($"Habian {antesMoto} motocicletas y Ahora queda {Taller.listaDeMotos.Count} motocicletas en el taller");
        }

        public static void Mostrar()
        {
            Console.WriteLine($"3- Mostrar Lista");
            Console.WriteLine(Taller.MostrarLista());
        }
        public static void CrearArchivos()
        {
            Console.WriteLine($"4- Crear Archivos");
            Console.WriteLine($"Se entrega un .txt con las caracteristicas del vehiculo");

            Auto auxAuto = Taller.listaDeAutos.ElementAt(0);
            Motocicleta auxMoto = Taller.listaDeMotos.ElementAt(0);

            Archivos.CrearArchivoTexto("Auto", auxAuto.FormatoArchivos(), "CONSOLA", auxAuto.Nombre);
            Archivos.CrearArchivoTexto("Motocicleta", auxMoto.FormatoArchivos(), "CONSOLA", auxMoto.Nombre);

            Console.WriteLine("Se crearon estos dos archivos de estos vehiculos en TestConsola/App/bin/Debug");

            Console.WriteLine(Taller.MostrarUnoDeLaLista(auxAuto));
            Console.WriteLine(Taller.MostrarUnoDeLaLista(auxMoto));
        }
    }
}
