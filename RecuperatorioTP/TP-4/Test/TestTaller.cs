using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Entidades;

namespace Test
{
    [TestClass]
    public class TestTaller
    {
        [TestMethod]
        public void TestAgregarUnVehiculo()
        {
            int auxCount = Taller.listaDeAutos.Count;
            Auto nuevoAuto = new Auto("test", "test",
                new Carroceria(EEstilo.Clasico.ToString(), 3),
                new Motor(EMotor.CicloOtto.ToString()),
                new Rueda(ETipo.Invierno.ToString(), ETamanio.Mediana.ToString()));

            Taller.AgregarUnAuto(nuevoAuto);

            Assert.IsTrue(auxCount != Taller.listaDeAutos.Count);
        }

        [TestMethod]
        public void TestAgregarVehiculos()
        {
            Taller.listaDeAutos.Clear();

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

            Taller.AgregarAutos(listaDeAutos);

            Assert.IsTrue(3 == Taller.listaDeAutos.Count);
        }

        [TestMethod]
        public void TestEliminarVehiculos()
        {
            Taller.listaDeAutos.Clear();

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
            Motocicleta nuevoMoto = new Motocicleta("testMoto", "test2",
                new Chasis(EChasis.Scooter.ToString()),
                new Motor(EMotor.CicloOtto.ToString()),
                new Rueda(ETipo.Invierno.ToString(), ETamanio.Mediana.ToString()));

            List<Auto> listaDeAutos = new List<Auto>();
            listaDeAutos.Add(nuevoAutoUno);
            listaDeAutos.Add(nuevoAutoDos);
            listaDeAutos.Add(nuevoAutoTres);
            List<Motocicleta> listaDeMotos = new List<Motocicleta>();
            listaDeMotos.Add(nuevoMoto);

            Taller.AgregarAutos(listaDeAutos);
            Taller.AgregarMotos(listaDeMotos);

            Taller.EliminarAuto(nuevoAutoUno);
            Taller.EliminarMoto(nuevoMoto);

            Assert.IsTrue(2 == Taller.listaDeAutos.Count && Taller.listaDeMotos.Count == 0);
        }

        [TestMethod]
        public void TestMostrarLista()
        {
            Taller.listaDeAutos.Clear();

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
            Motocicleta nuevoMoto = new Motocicleta("testMoto", "test2",
                new Chasis(EChasis.Scooter.ToString()),
                new Motor(EMotor.CicloOtto.ToString()),
                new Rueda(ETipo.Invierno.ToString(), ETamanio.Mediana.ToString()));

            List<Auto> listaDeAutos = new List<Auto>();
            listaDeAutos.Add(nuevoAutoUno);
            listaDeAutos.Add(nuevoAutoDos);
            listaDeAutos.Add(nuevoAutoTres);
            List<Motocicleta> listaDeMotos = new List<Motocicleta>();
            listaDeMotos.Add(nuevoMoto);

            Taller.AgregarAutos(listaDeAutos);
            Taller.AgregarMotos(listaDeMotos);

            string texto = Taller.MostrarLista();

            Assert.IsTrue(texto.Length>0);
        }

        [TestMethod]
        public void TestMostrarUnoDeLaLista()
        {
            Taller.listaDeAutos.Clear();

            Auto nuevoAuto = new Auto("testAuto", "test1",
                new Carroceria(EEstilo.Clasico.ToString(), 3),
                new Motor(EMotor.CicloOtto.ToString()),
                new Rueda(ETipo.Invierno.ToString(), ETamanio.Mediana.ToString()));

            string texto = Taller.MostrarUnoDeLaLista(nuevoAuto);

            Assert.IsTrue(texto.Length > 0);
        }
    }
}
