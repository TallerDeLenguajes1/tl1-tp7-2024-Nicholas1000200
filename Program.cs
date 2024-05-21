using System;
using EspacioCalculadora;

int opcion;
double num1;
do
{
Console.WriteLine("Ingrese el primer numero a operar: ");
Console.WriteLine("Ingrese el segundo numero a operar: ");
double.TryParse(Console.ReadLine(), out num1);
Console.WriteLine("1-Suma: ");
Console.WriteLine("2-Resta: ");
Console.WriteLine("3-Multiplicacion: ");
Console.WriteLine("4-Division: ");
Console.WriteLine("5-Salir: ");
int.TryParse(Console.ReadLine(), out opcion);
Calculadora calc = new Calculadora();
switch (opcion)
{
    case 1:
        calc.Sumar(num1);
        Console.WriteLine({$calc.Resultado});    
    break;
    case 2:
        calc.Restar(num1);
        Console.WriteLine({$calc.Resultado});  
    break;
    case 3:
        calc.Multiplicar(num1);
        Console.WriteLine({$calc.Resultado});  
    break;
    case 4:
        calc.Dividir(num1);
        Console.WriteLine({$calc.Resultado});  
    break;
    default:
    break;
}
} while (opcion != 5);
