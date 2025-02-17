using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoptAFish
{
    public class Store
    {
        public double fishfood = 0;

        public string FishFood()
        {
            string output = "";
            output += $"There is {fishfood} fish food in the store";

            return output;
        }

        public double storecurrency = 0.00;

        public string StoreCurrency()
        {
            string output = "";
            output += $"There is {StoreCurrency} dollars in the register";

            return output;
        }


        public List<Fish> Inventory = new List<Fish>()
        {
            new Fish()
            {
                FishName = "Reggie",
                Description = "Blue and purple koi fish",
                Price = 250.00

            },
            new Fish
            {
               FishName = "Omar",
               Description = "Big orange gold fish",
               Price = 50.00
            },
            new Fish
            {
                FishName = "Harold",
                Description = "Green sun fish",
                Price = 100.00
            }
        };


        public void StoreMenu()
        {
            Console.WriteLine("Buy Fish Food");
        }

    }
}
