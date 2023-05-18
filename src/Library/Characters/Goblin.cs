using System.Collections.Generic;
namespace RoleplayGame
{
    public class Goblin:Enemy,  ICharacter
    {
        private List<IItem> items = new List<IItem>();

        public Goblin(string name)
        {
            this.Name = name + " el goblin";
            
            this.AddItem(new Club());
        }
    }
}