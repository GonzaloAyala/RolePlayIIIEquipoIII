using System.Collections.Generic;
namespace RoleplayGame
{
    public class CuevaGoblin : Encounter
    {
        public CuevaGoblin(List<Hero> heroes)
        {
            List<Enemy> enemigos = new List<Enemy>();
            enemigos.Add(new Goblin("Marcelo"));
            enemigos.Add(new Goblin("Valentin"));
            enemigos.Add(new Goblin("Roberto"));
            enemigos.Add(new Goblin("Pedro"));
            enemigos.Add(new Goblin("Sauron"));
            enemigos.Add(new Ogro("Shrek"));

            Heroes = heroes;
            Enemies = enemigos;

            DoEncounter();
        }
    }
}