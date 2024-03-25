﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatsInTheBoxComposite
{
    internal class Composite :Items , IComponent
    {
        private List<Items> component;

        public Composite(String name, int price, int qua)
            : base(name, price, qua)
        {
            component = new List<Items>();
        }
        public void AddItem(Items item)
        {
            component.Add(item);    
        }
        public void RemoveItem(Items item)
        {
            component.Remove(item);
        }
        public int CalculateTotalPrice()
        {
            int miniTotal = (price * quantity);
            int total = 0;
            Console.WriteLine(name +
                "contains the following with prices: "+miniTotal);
            foreach(IComponent item in component)
            {
                total += item.CalculateTotalPrice();
            }
            return total + miniTotal;
        }
    }
    
}
