using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestProjectImperiales.ServicioImperialTest;

namespace UnitTestProjectImperiales
{
    [TestClass]
    public class UnitTest1
    {
        readonly WebServiceImperialSoapClient _prueba = new WebServiceImperialSoapClient();

        [TestMethod]
        public void TestMethodAdjuntarIdentificacion()
        {
            var varios = new List<string> { "Luke", "Tatooine"}.ToList();
            ArrayOfString array = new ArrayOfString();
            array.AddRange(varios);
            Assert.IsTrue(_prueba.AdjuntarIdentificacion(array));
        }

        [TestMethod]
        public void TestMethodAdjuntarRebelde()
        {
            Assert.IsTrue(_prueba.AdjuntarRebelde("Luke"));
        }

        [TestMethod]
        public void TestMethodAdjuntarRebeldeVacio()
        {
            Assert.IsFalse(_prueba.AdjuntarRebelde(""));
        }

        [TestMethod]
        public void TestMethodAdjuntarPlaneta()
        {
            Assert.IsTrue(_prueba.AdjuntarPlaneta("Tatooine"));
        }

        [TestMethod]
        public void TestMethodAdjuntarPlanetaVacio()
        {
            Assert.IsFalse(_prueba.AdjuntarPlaneta(""));
        }

        [TestMethod]
        public void TestMethodCrearTxt()
        {
            bool prueba =  false;
            string path = Directory.GetCurrentDirectory() + @"\InfoAvistamientoRebelde.txt";
            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Hello");
                    sw.WriteLine("And");
                    sw.WriteLine("Welcome");
                }
            }

            if (File.Exists(path))
            {
                prueba = true;
            }
            Assert.IsTrue(prueba);
        }

        [TestMethod]
        public void TestMethodCrearEscribirTxt()
        {
            bool prueba = false;
            string path = Directory.GetCurrentDirectory() + @"\InfoAvistamientoRebelde.txt";
            var varios = new List<string> { "Luke", "Tatooine" }.ToList();
            ArrayOfString array = new ArrayOfString();

            array.AddRange(varios);

            if (!File.Exists(path))
            {
                // Write each directory name to a file.
                using (StreamWriter sw = File.CreateText(path))
                {
                    foreach (var item in array)
                    {
                        sw.WriteLine("rebeld " + item[1] + "on " + item[2]);
                        prueba = true;
                    }
                }
            }
            else
            {
                using (StreamWriter sw = new StreamWriter(path))
                {
                    foreach (var item in array)
                    {
                        sw.WriteLine("rebeld " + item[1] + "on " + item[2]);
                        prueba = true;
                    }
                }
            }

            Assert.IsTrue(prueba);
        }

        [TestMethod]
        public void TestMethodNulo()
        {
            bool prueba = false;
            string nombre = "";

            if(String.IsNullOrWhiteSpace(nombre))
            {
                prueba = true;
            }
            Assert.IsTrue(prueba);
        }

        [TestMethod]
        public void TestMethodEspacios()
        {
            bool prueba = false;
            string nombre = "a";
            string nombre2 = "b";

            if (!String.IsNullOrWhiteSpace(nombre) && !String.IsNullOrWhiteSpace(nombre2))
            {
                prueba = true;
            }
            Assert.IsTrue(prueba);
        }
    }
}
