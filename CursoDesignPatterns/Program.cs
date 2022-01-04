using System;

namespace CursoDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //IImposto iccc = new ICCC();

            
            CalculadorDeDescontos calculador = new CalculadorDeDescontos();

            Orcamento orcamento = new Orcamento(500.0);
            orcamento.AdicionaItem(new Item("Caneta", 650));
            

            double desconto = calculador.Calcula(orcamento);
            Console.WriteLine(desconto);

            Console.ReadKey();
        }
    }
}
