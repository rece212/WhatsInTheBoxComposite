using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatsInTheBoxComposite
{
    //inherits from Items to be able to use properties
    //overrides the inherited calculate method
    public class Leaf :Items,IComponent
    {
        public Leaf(String name, int price, int qua)
            : base(name, price, qua) { }

        public int CalculateTotalPrice()
        {
            Console.WriteLine(name +"with the price "+(price*quantity));
            return (price*quantity);
        }

    }
}
