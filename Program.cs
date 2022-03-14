using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppG02
{
    class Program
    {
        static void Main(string[] args)
        {
            int saldo_inicial=100000;
            int opcion;
            float ingreso, saldoActual, retiro;

            Console.WriteLine("Bienvenido a su cajero automatico\n"
                + "1. ingresar dinero a la cuenta\n"
                + "2. retirar dinero de la cuenta\n"
                + "3. salir.");
            opcion =int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1: Console.WriteLine("Digite la cantidad que desea ingresar en la cuenta: ");
                    ingreso = int.Parse(Console.ReadLine());
                    saldoActual = saldo_inicial + ingreso;
                    Console.WriteLine("dinero en cuenta " + saldoActual);
                    break;
                case 2: Console.WriteLine("Digite la cantidad que desea retirar: ");
                    retiro = int.Parse(Console.ReadLine());
                    if (retiro > saldo_inicial)
                    {
                        Console.WriteLine("No cuenta con el saldo sufiente");
                    }
                    else
                    {
                        saldoActual = saldo_inicial - retiro;
                        Console.WriteLine("Dinero en cuenta " + saldoActual);
                    }
                    break;
                case 3: 
                    break; 
                default: Console.WriteLine("Se equivo de opcion del menu");
                    break;
            }

        }
    }
}