using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Generics;
using System.Runtime.InteropServices;

namespace XUnitTestProject.Generics
{
    public class GenericsTest
    {
        [Fact]
        public void Calcular_valor_unitario_dev() {

            //arrange
            DesenvolvimentoDeSoftware dev = new DesenvolvimentoDeSoftware();
            CalculoGenerico<DesenvolvimentoDeSoftware> calcDev = new CalculoGenerico<DesenvolvimentoDeSoftware>();

            //act
            calcDev.CalcularValorUnitario(dev);

            //assert
            Assert.Equal(57.50M, dev.ValorFinal);
        }

        [Fact]
        public void Calcular_valor_unitario_carro()
        {
            //arrange
            CarroUsado carro = new CarroUsado();
            CalculoGenerico<CarroUsado> calcCarro = new CalculoGenerico<CarroUsado>();

            //act
            calcCarro.CalcularValorUnitario(carro);

            //assert
            Assert.Equal(34500, carro.ValorFinal);
        }

        [Fact]
        public void Calcular_valor_unitario_comida()
        {
            //arrange
            KiloBuffet comida = new KiloBuffet();
            CalculoGenerico<KiloBuffet> calcBuffet = new CalculoGenerico<KiloBuffet>();

            //act
            calcBuffet.CalcularValorUnitario(comida);

            //assert
            Assert.Equal(48.30M, comida.ValorFinal);

        }

        //Teste com mais de um parametro de uma vez usar Theory, senão usar Fact
        [Theory]
        [InlineData("Sizenando", 3)]
        [InlineData("Jose Klecio",2)]
        public void Verificar_quantidade_de_palavras(string texto, int valorEsperado)
        {
            int qtd = texto.ContadorDePalavras();
            Assert.Equal(valorEsperado, qtd);
        }
    }
}
