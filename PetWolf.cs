using System;

namespace _080720
{
    internal class PetWolf:Wolf
    {
        public PetWolf(string name,string nameOfPack, string favoriteFood) :base(name,nameOfPack,favoriteFood)
        {
        }

        public override void Bark()
        {
            Console.WriteLine(" ");
        }
    }
}