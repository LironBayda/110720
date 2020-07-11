using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _080720
{
    class Program
       
    {
        static Animal[] GetRacingHorses(Horse[] horses)
        {
            Horse[] temp =new Horse[horses.Length];
            int count = 0;
            // get rice horses
            foreach (Horse horse in horses)
            {
                if (horse._racingHorse)
                {
                    temp[count] = horse;
                    count++;
                }


            }
            // create array in the size of horses.
            Horse[] rice_horses = new Horse[count];
            foreach (Horse horse in temp)
            {
                if (horse._racingHorse)

                    rice_horses[count] = horse;
            }

            return rice_horses;
        }
        static void AnimalSing(Animal[] animals)
        {
            foreach (Animal animal in animals)
            {
                animal.MakeSound();
            }
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            Dog dog = new Dog("pola", "dog food");
            Horse horse = new Horse("donny", true);
            Wolf wolf = new Wolf("wolf", "the white", "meat");
            Poodle poodle = new Poodle("dodo", "one", "dog food");
            PetWolf petWolf = new PetWolf("pet", "the white", "meat");

            Animal[] animals = new Animal[5] { dog, horse, wolf, poodle, petWolf };
            AnimalSing(animals);

            
        }
    }
}
