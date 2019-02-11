using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = new ArrayList<String>();
            for (int i = 0; i < 12; i++)
            {
                t.Adicionar("" + i);
            }
            Console.WriteLine("tamanho: " + t.Tamanho());

            Console.WriteLine("--------------------");
            t.Adicionar(5, "Agora vai!");
            t.Remover(2);
            for (int i = 0; i < t.Tamanho(); i++)
            {
                Console.WriteLine(">> " + t.Obter(i));
            }
            
            Console.WriteLine(" ------ >> " );
            Console.Read();
        }
    }
}
