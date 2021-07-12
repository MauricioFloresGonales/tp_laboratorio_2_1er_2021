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
    }
}
