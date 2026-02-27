namespace p2
{
    using System;

    class Program
    {
        static void Main()
        {
            
            int A, B, C;
            double R, S, D;

            
            Console.WriteLine("Digite o valor de A:");
            A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o valor de B:");
            B = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o valor de C:");
            C = Convert.ToInt32(Console.ReadLine());

            
            R = Math.Pow(A + B, 2);
            S = Math.Pow(B + C, 2);
            D = R + (S / 2.0);

            
            Console.WriteLine("O valor de D é: " + D);

            Console.ReadKey();
        }
    }
}
