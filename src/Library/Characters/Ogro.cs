using System.Collections.Generic;
namespace RoleplayGame
{
    public class Ogro:Enemy,  ICharacter
    {
        private List<IItem> items = new List<IItem>();

        public Ogro(string name)
        {
            this.Name = name + " el ogro";
            
            this.AddItem(new BigClub());
            this.AddItem(new LayeredSkin());
        }
    }
}