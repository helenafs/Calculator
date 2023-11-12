using System;

namespace Calculator{

    class Program{
        static void Soma(){
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());
            Console.WriteLine(" "); 
            float soma = valor1+valor2; 
            Console.WriteLine($"O resultado da soma é {soma}");
            Console.ReadKey(); 
            Menu(); 
        }

        static void Subtrair(){
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());
            Console.WriteLine(" "); 
            float subtrair = valor1-valor2; 
            Console.WriteLine($"O resultado da subtração é {subtrair}");
            Console.ReadKey(); 
            Menu(); 
        }

        static void Dividir(){
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());
            Console.WriteLine(" "); 
            float dividir = valor1/valor2; 
            Console.WriteLine($"O resultado da divisão é {dividir}"); 
            Console.ReadKey(); 
            Menu(); 
        }

        static void Multiplicar(){
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());
            Console.WriteLine(" "); 
            float multiplicar = valor1/valor2; 
            Console.WriteLine($"O resultado da multiplicação é {multiplicar}");
            Console.ReadKey(); 
            Menu(); 
        }

        static void Menu(){
            Console.Clear();
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1 - soma");
            Console.WriteLine("2 - subtração");
            Console.WriteLine("3 - divisão");
            Console.WriteLine("4 - multiplicação");
            Console.WriteLine("5 - sair");
            Console.WriteLine("-----------------");
            Console.WriteLine("Selecione uma opção:");
            short opcao = short.Parse(Console.ReadLine()); 

            switch(opcao){
                case 1: Soma(); break;
                case 2: Subtrair(); break;
                case 3: Dividir(); break;
                case 4: Multiplicar(); break; 
                case 5: System.Environment.Exit(0); break;  
                default: Menu(); break; 
            }
        }
        static void Main (string[] args){
            
           Menu(); 
           

        }

    }


}
