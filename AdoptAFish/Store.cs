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

        private void Store()
        { 
        
        
        
        }
    }
}
