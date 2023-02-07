using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace тортики_2._0
{
    public class Choice
    {
        private string name;
        private int price;

       
        public Choice(string name, int price)
        {
            this.name = name;
            this.price = price;
        }
        public string Name()
        {
            return this.name;
        }
        public int Price()
        {
            return this.price;
        }
    }
}
