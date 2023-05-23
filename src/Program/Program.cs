using System;
using System.Collections.Generic;
using RoleplayGame;

namespace RoleplayGameProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            SpellsBook book = new SpellsBook();
            book.AddSpell(new SpellOne());
            book.AddSpell(new SpellOne());

            Wizard gandalf = new Wizard("Gandalf");
            gandalf.AddItem(book);

            Dwarf gimli = new Dwarf("Gimli");

            Console.WriteLine($"Gimli has ❤️ {gimli.Health}");
            Console.WriteLine($"Gandalf attacks Gimli with ⚔️ {gandalf.AttackValue}");

            gimli.ReceiveAttack(gandalf.AttackValue);

            Console.WriteLine($"Gimli has ❤️ {gimli.Health}");

            gimli.Cure();

            Console.WriteLine($"Someone cured Gimli. Gimli now has ❤️ {gimli.Health}");

            Hero paco = new Knight("Paco");
            Hero pepe = new Archer("Pepe");
            Hero Mario = new Knight("Mario");


            Enemy Bowser = new Goblin("Bowser");
            
            List<Hero> heroes = new List<Hero>();
            heroes.Add(paco);
            heroes.Add(pepe);
            heroes.Add(gimli);
            heroes.Add(Mario);

            new CuevaGoblin(heroes);

            List<ICharacter> ListaEnanos = new List<ICharacter>{gimli};
            
        }
    }
}
