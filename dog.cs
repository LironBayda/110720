using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _080720
{
    class Dog : Animal
    {
        string _favoriteFood;
        public Dog(string name,string favoriteFood) :base(name)
        {
            _favoriteFood = favoriteFood;

        }
        public virtual void Bark()
        {
            Console.WriteLine("Hab, Hab");
        
        }
        public override void MakeSound()
        {
            Bark();
        }

        public override string ToString()
        {
            return base.ToString()+$" favoriteFood: {_favoriteFood}";
        }
    }
}
