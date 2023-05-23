using System.Collections.Generic;
namespace RoleplayGame
{
    public class Pirate:Enemy
    {
        private List<IItem> items = new List<IItem>();

        public Pirate(string name)
        {
            this.Name = name;
            
            this.AddItem(new Hook());
            this.AddItem(new Sword());
        }
    }
}