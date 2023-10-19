// Pacotes como se fosse importações, C# é dividido nesses pacotes

using System; // Usa um pacote para alterar dados do sistema do usuário
using System.Collections.Generic;
using System.Linq; // Usa um Pacote para mexer com grandes quantidades de elementos
using System.Text; // Usa um pacote para mexer com textos

namespace HelloWorld{

    internal class Program{
    
        static void Main(string[] args){

            // Console.Write Apenas escreve no console sem quebra de linha
            // Console.WriteLine Escreve quebrando a linha sem necessidade de usar \n

            Console.WriteLine("Hello World");
            Console.WriteLine("Meu nome é kauan");

            Console.ReadLine(); // Serve para o usuário digitar algo no console, ele espera até q o usuario digite algo
        
        }
    }
}
