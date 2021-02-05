using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;
using Matematica;

namespace SpecFlowTest.Features
{
    [Binding]
    public class ConversionSteps
    {
        Implementacion implementacion = new Implementacion();
        private double expectedResultado = 50;

        public object Resultado { get; private set; }

        [Given(@"que ingreso el valor en grados centigrados (.*)")]
        public void DadoQueIngresoElValorEnGradosCentigrados(double NumeroCentogrado)
        {
            implementacion.numeroCentigrado = NumeroCentogrado;
        }

        [When(@"hago clic en el boton convertir")]
        public void CuandoHagoClicEnElBotonConvertir()
        {
            Resultado = implementacion.convert();
        }

        [Then(@"el resultado debe  ser (.*)")]
        public void EntoncesElResultadoDebeSer(double Resultado)
        {
            Assert.AreEqual(Resultado, expectedResultado);
        }
    }
}
