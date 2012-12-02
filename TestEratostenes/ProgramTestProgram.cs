using Eratostenes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace TestEratostenes
{
    
    
    /// <summary>
    ///Se trata de una clase de prueba para ProgramTestProgram y se pretende que
    ///contenga todas las pruebas unitarias ProgramTestProgram.
    ///</summary>
    [TestClass()]
    public class ProgramTestProgram
    {


        private TestContext testContextInstance;
        
        /// <summary>
        ///Obtiene o establece el contexto de la prueba que proporciona
        ///la información y funcionalidad para la ejecución de pruebas actual.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Atributos de prueba adicionales
        // 
        //Puede utilizar los siguientes atributos adicionales mientras escribe sus pruebas:
        
        //Use ClassInitialize para ejecutar código antes de ejecutar la primera prueba en la clase 
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //    for (int i = 2; i < PARAMETRO; i++)
        //    {
        //        lista[i] = new Eratostenes.Numeros();
        //        lista[i].Numero = i;
        //        lista[i].Primo = true;
        //    }
        //}
        //
        //Use ClassCleanup para ejecutar código después de haber ejecutado todas las pruebas en una clase
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize para ejecutar código antes de ejecutar cada prueba
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup para ejecutar código después de que se hayan ejecutado todas las pruebas
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///Comprobar que se recibe un numero mayor que 2
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Eratostenes.exe")]
        public void MainTestProgram()
        {
            string[] args = new string[1];
            args[0] = "1";

            Program_Accessor.Main(args);

            Assert.AreEqual(args.Length, 1);
        }


        /// <summary>
        ///Crea una lista con los valores de los numeros desde el 2 hasta el pasado por parametro
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Eratostenes.exe")]
        public void CrearLista()
        {
            //Asignat
            int valor1 = 2;
            int valor2 = 13;

            //Actuar
            List<Eratostenes.Numeros> result1 = Eratostenes.Primos.CrearLista(valor1);
            List<Eratostenes.Numeros> result2 = Eratostenes.Primos.CrearLista(valor2);

            //ASsert
            Assert.AreEqual(valor1 - 1, result1.Count);
            Assert.AreEqual(valor2 - 1, result2.Count);

        }

        /// <summary>
        /// Es multiplo de un primo un numero
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Eratostenes.exe")]
        public void EsMultiplo()
        {
            //Asignat
            int primo = 2;
            Numeros num = new Numeros(4, true);

            //Actuar
            num.EsMultiplo(primo);
            
            //ASsert
            Assert.AreEqual(false, num.EsPrimo);
        }


        /// <summary>
        /// Multiplos de un numero
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Eratostenes.exe")]
        public void MarcarMultiplosDeLaLista()
        {
            //Asignat
            List<Eratostenes.Numeros> result1 = Primos.CrearLista(4);

            //Actuar
            List<Eratostenes.Numeros> result = Primos.MarcarMultiplos(result1);

            //ASsert
            Assert.AreEqual(false, result[2].EsPrimo);
        }

        /// <summary>
        /// Eliminar multiplos de la lista
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Eratostenes.exe")]
        public void EliminarMultiplos()
        {
            //Asignat
            List<Eratostenes.Numeros> result1 = Primos.CrearLista(4);
            result1[2].EsPrimo = false;

            //Actuar
            List<Numeros> result = Primos.EliminarMultiplos(result1);

            //ASsert
            Assert.AreEqual(2, result.Count);
        }


      
    }
}
