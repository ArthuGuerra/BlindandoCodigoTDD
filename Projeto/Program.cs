using Projeto.Models;
using System.Collections.Generic;
using System.Globalization;

int n = 0;
Calculadora c1 = new Calculadora();

while( n != 6 )
{
Console.WriteLine("Calculadora ON");
Console.WriteLine("");
Console.WriteLine("Escolha uma opção");
Console.WriteLine("1 - Somar");
Console.WriteLine("2 - Subtrair");
Console.WriteLine("3 - Multiplicar");
Console.WriteLine("4 - Dividir");
Console.WriteLine("5 - Mostrar Histórico");
Console.WriteLine("6 - Sair");


n = int.Parse(Console.ReadLine());

switch(n)
{
    case 1:
    Console.WriteLine("Digite quantos numeros que deseja somar");
    int m = int.Parse(Console.ReadLine());
    double[] numeros = new double[m]; 
    
    for(int i = 0; i < m; i++)
    {
        Console.WriteLine($"Digite o numero { i + 1}: ");
        numeros[i] = double.Parse(Console.ReadLine());
    }

    double result = c1.Somar(numeros);
    Console.WriteLine("resultado: " + result);
    Console.WriteLine("aperte qualquer botão");
    Console.ReadLine();
    Console.Clear();
    break;

    case 2:

    Console.WriteLine("Digite quantos numeros que deseja subtrair");
    int a = int.Parse(Console.ReadLine());
    double[] num = new double[a]; 
    
    for(int i = 0; i < a; i++)
    {
        Console.WriteLine($"Digite o numero { i + 1}: ");
        num[i] = double.Parse(Console.ReadLine());
    }

    double resultado = c1.Sub(num);
    Console.WriteLine("resultado: " + resultado);
    Console.WriteLine("aperte qualquer botão");
    Console.ReadLine();
    Console.Clear();

    break;

    case 3:

    Console.WriteLine("Digite quantos numeros que deseja multiplicar");
    int b = int.Parse(Console.ReadLine());
    double[] numero = new double[b]; 
    
    for(int i = 0; i < b; i++)
    {
        Console.WriteLine($"Digite o numero { i + 1}: ");
        numero[i] = double.Parse(Console.ReadLine());
    }

    double resultados = c1.Mult(numero);
    Console.WriteLine("resultado: " + resultados);
    Console.WriteLine("aperte qualquer botão");
    Console.ReadLine();
    Console.Clear();

    break;

    case 4:

    Console.WriteLine("Digite quantos numeros que deseja dividir");
    int c = int.Parse(Console.ReadLine());
    double[] lista = new double[c]; 
    
    for(int i = 0; i < c; i++)
    {
        Console.WriteLine($"Digite o numero { i + 1}: ");
        lista[i] = double.Parse(Console.ReadLine());
    }

    double resultados1 = c1.Dividir(lista);
    Console.WriteLine("resultado: " + resultados1);
    Console.WriteLine("aperte qualquer botão");
    Console.ReadLine();
    Console.Clear();

    break;

    case 5:

    List<string> lista3;

    lista3 = c1.Historico();

    foreach (string s in lista3)
    {
         Console.WriteLine(s);
    }
    Console.WriteLine("aperte qualquer botão");
    Console.ReadLine();
    Console.Clear();

    break;
}
}




