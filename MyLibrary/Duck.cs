using System;

namespace MyLibrary
{
    public abstract class Duck
    {
        public string Swim()
        {
            return "swim" + " " + GetType();
        }

        public abstract string Display();

    }
}
