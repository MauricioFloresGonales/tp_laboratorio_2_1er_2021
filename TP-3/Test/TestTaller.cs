using System;
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

            Taller.AgregarUnVehiculo(nuevoAuto);

            Assert.IsTrue(auxCount != Taller.listaDeAutos.Count);
        }
        [TestMethod]
        public void TestAgregarVehiculos()
        {
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

            Assert.IsTrue(3 == Taller.listaDeAutos.Count);
        }
    }
}
