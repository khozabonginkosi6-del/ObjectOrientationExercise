using System;
using System.Collections.Generic;
using System.Text;
using ObjectOrientationClassExercise.Inheritance;   

namespace ObjectOrientationExercises.Interfaces
{
    internal class InterfacesSample
    {
       
        private List<GameCharacter> dungeon;
        public InterfacesSample()
        {
            dungeon = new List<GameCharacter>();
        }

        public void battle()
        {
            foreach(IDamagable damagable in dungeon)
            {
               
                {
                    damagable.Attack();
                }
            }
        }
        public  void Run()
        { 
        List <GameCharacter> dungeons = new List <GameCharacter>();
            GameCharacter character = new Wizard(100, 50, "Wizard", "Oz", Gender.NotSpecified,150,Race.White, true);

            dungeons.Add(character);

            character = new Goblin(10, 1000, "Tommy", "Gobby", Gender.NotSpecified,150,Race.Indian, true);

            dungeons.Add(character);

            character = new Dragon(200, 5000, "Daemon", "Bob", Gender.male,1252,Race.African,true);

        }
           
    }
}
