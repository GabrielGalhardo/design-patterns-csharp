using System;

namespace CursoDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {

            //IImposto iccc = new ICCC();


            Imposto iss = new ISS(new ICMS());

            Orcamento orcamento = new Orcamento(500.0);            

            double valor = iss.Calcula(orcamento);
            Console.WriteLine(valor);

            Console.ReadKey();
        }
    }
}
