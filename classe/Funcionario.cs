using System;

namespace Polimorfismo__sobrecarga.classe
{
    public class Funcionario
    {
      public string[] lista = {"Paulo",  "Tsukamoto", "Joyce", "Laiane"};

        public void Mostar(){
          //imprimimos todos os dados no array
          foreach (var item in lista)
          {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(item);
            Console.ResetColor();
          }
      }
        public void Mostar(int indice){
        //mostrando apenas o dado que esta no indice de array
        Console.ForegroundColor = ConsoleColor.Blue;
        if (indice < lista.Length){

            Console.WriteLine(lista[indice]);

        }
        Console.ResetColor();
      }

        public void Mostrar(string busca){
        foreach (var item in lista)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            if (item == busca ){

                Console.WriteLine("Resultado da busca : "+ item);

            }
            Console.ResetColor();
            
        }

    
    }

    
    }
}