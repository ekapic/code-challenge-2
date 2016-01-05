using System.Collections.Generic;
using System.Globalization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculoEstadisticas;

namespace CalculoEstadisticasTests
{
    [TestClass]
    public class CalculadoraEstadisticasServiceTests
    {
        [TestMethod]
        public void PromedioTest()
        {
            var calculadoraEstadisticasService = new CalculadoraEstadisticasService();
            var result = calculadoraEstadisticasService.Promedio(new List<int>() {100, 200, 300, 1000});
            Assert.AreEqual("400.00", result.ToString("0.00",CultureInfo.InvariantCulture));
        }

        [TestMethod()]
        public void DesviacionTest()
        {
            var calculadoraEstadisticasService = new CalculadoraEstadisticasService();
            var result = calculadoraEstadisticasService.Desviacion(new List<int>() { 100, 200, 300, 1000 });
            Assert.AreEqual("353.55", result.ToString("0.00",CultureInfo.InvariantCulture));
        }
    }
}