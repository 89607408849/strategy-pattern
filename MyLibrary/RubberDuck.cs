using System;
using System.Collections.Generic;
using System.Text;

namespace MyLibrary
{
    public class RubberDuck : Duck, IQuackable
    {
        public override string Display()
        {
            return "Display" + this.GetType();
        }
        public string quack()
        {
            return "Quack" + this.GetType();
        }
    }
}
