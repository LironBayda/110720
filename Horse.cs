using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _080720
{
    class Horse:Animal
    {
        bool _racingHorse;

        public Horse(string name, bool racingHorse):base(name)
        {
            _racingHorse = racingHorse;
        }

        public override void MakeSound()
        {
            Neigh();
        }

        virtual public void Neigh()
        {
            Console.WriteLine("hooo");
        }

        public override string ToString()
        {
            return base.ToString() + $" racingHorse: {_racingHorse}";
        }
    }
}
