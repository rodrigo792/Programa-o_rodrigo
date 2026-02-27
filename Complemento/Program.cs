namespace Complemento
{
    using System;

    class Program
    {
        static void Main()
        {
            int A, B, C;

            Console.WriteLine("Digite o valor de A:");
            A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o valor de B:");
            B = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o valor de C:");
            C = Convert.ToInt32(Console.ReadLine());

            if (A > B && A > C)
            {
                Console.WriteLine("O maior valor é: " + A);
            }
            else if (B > A && B > C)
            {
                Console.WriteLine("O maior valor é: " + B);
            }
            else
            {
                Console.WriteLine("O maior valor é: " + C);
            }

            Console.ReadKey();
        }
    }
}
