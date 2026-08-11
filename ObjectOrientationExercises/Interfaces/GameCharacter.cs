using ObjectOrientationClassExercise.Inheritance;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientationExercises.Interfaces
{
    internal class GameCharacter : Person,IDamagable, ILootable
    {
        public int Health { get; set;  }
        public int Gold { get; set;  }
        public GameCharacter( int health, int gold, string firstName, string surname, Gender gender, int age, Race race, bool alive)
            : base(firstName, surname, gender, age, race, alive)
        {
            Health = health;
            Gold = gold;
        }

        public void Attack()
        {
            var random = new Random();
            int healthToDecrease = random.Next(50);
            if (Health >= healthToDecrease )
            {
                Health -= healthToDecrease; 
            }
            else
            {
                Health = 0;
                Alive = true;
            }
        }

        
        public void Steal()
        {
            var random = new Random();
            int goldToSteal = random.Next(10);
            if (Gold >= goldToSteal)
            {
                Gold -= goldToSteal;
            }
            else
            {
                Gold = 0;
            }
        }

        public void Defender()
        {
            var random = new Random();
            int healthToIncrease = random.Next(50);
            Health += healthToIncrease;
        }
    }

}
