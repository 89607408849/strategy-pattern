using System;
using System.Collections.Generic;
using System.Text;

namespace MyLibrary
{
    public class DecoyDuck : Duck
    {
        public override string Display()
        {
            return "Display" + this.GetType();
        }
    }
}
