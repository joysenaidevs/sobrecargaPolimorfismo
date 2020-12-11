using System;
using Polimorfismo__sobrecarga.classe;

namespace Polimorfismo__sobrecarga
{
    class Program
    {
        static void Main(string[] args)
        {
            //instanciar funcionario

            Funcionario funcionario = new Funcionario();
            funcionario.Mostrar();
            funcionario.Mostrar("Tsukamoto");
            funcionario.Mostrar("1");

            Console.Beep();
        }
    }
}
