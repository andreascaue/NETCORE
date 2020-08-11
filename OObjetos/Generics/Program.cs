using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                DesenvolvimentoDeSoftware dev = new DesenvolvimentoDeSoftware();
                //Generics definindo a tipagem no momento da instância da classe
                CalculoGenerico<DesenvolvimentoDeSoftware> calDev = new CalculoGenerico<DesenvolvimentoDeSoftware>();
                calDev.CalcularValorUnitario(dev);

                Console.WriteLine($"O valor final do desenvolvimento é {dev.ValorFinal}");

                CarroUsado carro = new CarroUsado();
                CalculoGenerico<CarroUsado> calcCarro = new CalculoGenerico<CarroUsado>();
                calcCarro.CalcularValorUnitario(carro);

                Console.WriteLine($"O valor final do Carro é {carro.ValorFinal}");

                KiloBuffet kbuffet = new KiloBuffet();
                CalculoGenerico<KiloBuffet> calKilo = new CalculoGenerico<KiloBuffet>();
                calKilo.CalcularValorUnitario(kbuffet);

                Console.WriteLine($"O valor final do kilo é {kbuffet.ValorFinal}");

                //Usando o Extension
                var texto = "Olá meu nome é Sizenando??? Sim... E seu sobrenome é Anannias.";
                //O método pode ser utilizado para qualquer string nesse contexto.
                Console.WriteLine($"A frase possui {texto.ContadorDePalavras()} palavras.");


                //Erro forçado
                string erro = null;
                erro.ContadorDePalavras();

            }
            catch (Exception ex)
            {

                throw new Exception($"Ihh deu ruim => {ex.Message}");
            }         

        }
    }
}
