using System.Collections.Generic;

namespace RoleplayGame
{
    public abstract class Encounter
    {
        public string Name;
        public List<Hero> Heroes;
        public List<Enemy> Enemies;

        public Encounter()
        {
            
        }
        public void DoEncounter()
        {
            
        }

        private bool AllDead(List<ICharacter> grupo)
        {
            bool allDead = true;
            grupo.ForEach(member => {
                if (member.Health > 0)
                {
                    allDead = false;
                }
            });
            return  allDead;
        }
        private void Round()
        {
            int numeroHeroes = this.Heroes.Count;
            this.Enemies.ForEach(enemigo =>
            {
                for (int indiceHero = 0; indiceHero < this.Enemies.Count;)
                {
                    
                }
            });
            this.Heroes.ForEach(heroe => 
            {

            });

            for (int indiceEnemy = 0; indiceEnemy < this.Enemies.Count; indiceEnemy++)
            {
                
            }


            
            //winPV
        }
    }
}