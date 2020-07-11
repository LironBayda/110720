using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _080720
{
     abstract class Animal
    {
        string _name;

        public Animal(string name)
        {
            _name = name;
        }

       public abstract void MakeSound();
        public override string ToString()
        {
            return base.ToString()+$" name: {_name}";
        }

    }
}
