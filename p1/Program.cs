namespace p1
{
    using System;

    class Program
    {
        static void Main()
        {
           
            double x1, y1, x2, y2, distancia;

           
            Console.WriteLine("Digite o valor de x1:");
            x1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o valor de y1:");
            y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o valor de x2:");
            x2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o valor de y2:");
            y2 = Convert.ToDouble(Console.ReadLine());

            distancia = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

          
            Console.WriteLine("A distância entre os pontos é: " + distancia);

            Console.ReadKey();
        }
    }
}
