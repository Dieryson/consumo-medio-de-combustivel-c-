// See https://aka.ms/new-console-template for more information

namespace ConsumoMedioDeCombustivel
{
    class Program
    {

        static void Main(string[] args)
        {

            int distancia;
            double combustivelGasto, consumoMedio;

            Console.WriteLine("Informe a distancia percorrida");

            distancia = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe quantos litros de combustivel gastou nesta viagem ");
            combustivelGasto = Convert.ToDouble(Console.ReadLine());

            consumoMedio = distancia / combustivelGasto; //atribua a formula para que o codigo funcione corretamente

            Console.WriteLine("Distancia media para cada litro de combustivel gasto foi de  {0:0.000} km/l", consumoMedio);

        }
    }
}


