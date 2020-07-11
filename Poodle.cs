using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace _080720
{
    class Poodle: Dog
    {
        string _numberOfPonyTails;

        public Poodle(string name,string numberOfPonyTails,string favoriteFood) :base(name,favoriteFood)
        {
            _numberOfPonyTails = numberOfPonyTails;
        }

        public override void Bark()
        {
            Console.WriteLine("hav!,hav!");
        }

        public override string ToString()
        {
            return base.ToString()+ $" _numberOfPonyTails: {_numberOfPonyTails}" ;
        }
    }
}
