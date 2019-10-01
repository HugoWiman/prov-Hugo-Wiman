using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prov_Hugo_Wiman_TE17B
{
    class böcker
    {
        //detta är en generator som är private vilket gör att den bara går att användas i classen böcker
        private Random generator = new Random();
        public int price = 0;
        //den här skappar en public strings och ints som går att använda både i program.cs och i böcker.cs.
        public string sort;
        //den här metoden tar och använder random gen för att ta fram vad för rarity det är på boken.
        // Den här klassen randomaisar mellan de olika raritysen och när man kallar på den ger den dig en av de 4 olika raritysen.
        public void rarity()
        
        {
              int val = generator.Next(1, 4);
            if (val == 1 )
            {
                sort = "Common";
                
            }
            if (val == 2 )
            {
                sort = " Rare";
                
            }
            if (val == 3)
            {
                sort = "Epic";
                
            }
            if (val == 4)
            {
                sort = "legendary";
               
            }
            Console.WriteLine(sort);
        }

       
    }
}
