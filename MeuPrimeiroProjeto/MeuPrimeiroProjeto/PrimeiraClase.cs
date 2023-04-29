using System;
using System.CodeDom;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuPrimeiroProjeto
{
    public class PrimeiraClase
    {
        public void HeloWorld()
        {
            System.Console.WriteLine("Digite seu nome:");
            string nome = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("**********************************************");
            Console.WriteLine("Helo " + nome);
            Console.WriteLine("Pressione qualquer tecla para continuar.");
            Console.ReadKey();
        }
    }
}
