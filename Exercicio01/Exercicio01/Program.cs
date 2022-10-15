using System;
internal class Program 
{
    private static void Main(string[] args)
    {
        double X, soma = 0, maior = -99999, menor = 1000000000000;
        int i = 0;
        Console.WriteLine("Digite: ");
        X = Convert.ToDouble(Console.ReadLine());
        while(X != 0)
        {
            i++;
            soma += X;
            if(X > maior)
            {
                maior = X;
            }
            if(X < menor)
            {
                menor = X;
            }
            Console.WriteLine("Digite: ");
            X = Convert.ToDouble(Console.ReadLine());
        }
        Console.WriteLine("A soma de todos os valores é: {0:0.00}", soma);
        soma = (double)soma / i;
        Console.WriteLine("A média é: {0}", soma);
        Console.WriteLine("O maior valor é {0}", maior);
        Console.WriteLine("O menor valor é {0}", menor);
        Console.ReadKey();
    }
}