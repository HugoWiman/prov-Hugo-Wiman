using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prov_Hugo_Wiman_TE17B
{
    class Program
    {
        static void Main(string[] args)
        {
            //den här metoden gör att när du skriver bok skappas en klass bok som då kan vara unik från sina andra.
            böcker bok = new böcker();
            bok.rarity();
            // här skappas en ny klass med en ny rarity.
            Console.ReadKey();
          
        }
        
    }
}
