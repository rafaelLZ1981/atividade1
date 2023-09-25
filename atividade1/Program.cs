
Decimal numero1, numero2, numero3, valor = 0, menorValor = 0, maiorvalor;

Console.WriteLine("Digite um numero");
numero1 = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite um numero");
numero2 = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite um numero");
numero3 = Convert.ToDecimal(Console.ReadLine());

if (numero1 > numero2 && numero1 > numero3)
{
    maiorvalor = numero1;
    Console.WriteLine("O Maior valor é " + maiorvalor);

}
else
{
    if (numero2 > numero1 && numero2 > numero3)
    {
        maiorvalor = numero2;
        Console.WriteLine("O Maior valor é " + maiorvalor);
    }
    if (numero3 > numero1 && numero3 > numero2)

    {
        maiorvalor = numero3;
        Console.WriteLine("O Maior valor é  " + maiorvalor);
    }
    if (numero1 < numero2 && numero1 < numero3)
    {
        menorValor = numero1;
        Console.WriteLine("O Menor valor é " + menorValor);

    }
    if (numero2 < numero1 && numero2 < numero3)
    {
        menorValor = numero2;
        Console.WriteLine("O Menor valor é " + menorValor);
    }
    if (numero3 < numero1 && numero3 < numero2)

    {
        menorValor = numero3;
        Console.WriteLine("O Menor valor é  " + menorValor);
    }

}

