﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatsInTheBoxComposite
{
    //Add and remove methods. Not in the abstract
    //class because Leaf class will not be using them
    //Only composite class will use these methods
    public interface IComponent
    {
        //void DisplayPrice();     
        int CalculateTotalPrice();
    }
}
