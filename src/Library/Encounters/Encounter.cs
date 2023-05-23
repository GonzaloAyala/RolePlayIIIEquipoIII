using System;
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
            while (!AllDead(Heroes) && !AllDead(Enemies))
            {
                Round();
            }
            if (AllDead(Heroes))
            {
                Console.WriteLine($"Nuestros heroes fueron vencidos, una sombra se cierne sobre la Tierra Media, o algo asi.");
            }
            else if (AllDead(Enemies))
            {
                Console.WriteLine($"Nuestros heroes triunfaron en esta batalla, pero la aventura aun no termina.");
                this.Heroes.ForEach(heroe =>
                {
                    Console.WriteLine($"{heroe.Name} termino esta batalla con {heroe.PV} puntos de victoria.");
                });
            }
        }

        private bool AllDead<T>(List<T> grupo) where T : ICharacter
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
            int heroeObjetivo = 0;
            this.Enemies.ForEach(enemigo =>
            {
                if (enemigo.Health == 0)
                {
                    return;
                }
                heroeObjetivo = heroeObjetivo == numeroHeroes? 0 : heroeObjetivo;
                bool successfulAttack = false;
                while (!successfulAttack)
                {
                    if (this.Heroes[heroeObjetivo].Health == 0)
                    {
                        heroeObjetivo++;
                        heroeObjetivo = heroeObjetivo == numeroHeroes? 0 : heroeObjetivo;
                        if (this.AllDead(this.Heroes))
                        {
                            break;
                        }
                    } else {
                        this.Heroes[heroeObjetivo].ReceiveAttack(enemigo.AttackValue);
                        if (Heroes[heroeObjetivo].DefenseValue >= enemigo.AttackValue)
                        {
                            Console.WriteLine($"{enemigo.Name} no pudo penetrar las defensas de {this.Heroes[heroeObjetivo].Name}.");
                        } else {
                            Console.WriteLine($"{enemigo.Name} ataco a {this.Heroes[heroeObjetivo].Name} disminuyendo su salud a {this.Heroes[heroeObjetivo].Health}.");
                        }
                        if (this.Heroes[heroeObjetivo].Health == 0)
                            {
                                Console.WriteLine($"{this.Heroes[heroeObjetivo].Name} ha caido a manos de {enemigo.Name}!");
                            }
                        successfulAttack = true;
                        heroeObjetivo++;
                    }
                }
            });
            this.Heroes.ForEach(heroe => 
            {
                if (heroe.Health == 0)
                {
                    return;
                }
                this.Enemies.ForEach(enemigo =>
                {
                    if (enemigo.Health != 0)
                    {
                        enemigo.ReceiveAttack(heroe.AttackValue);
                    if (enemigo.DefenseValue >= heroe.AttackValue)
                    {
                        Console.WriteLine($"{heroe.Name} no pudo penetrar las defensas de {enemigo.Name}.");
                    } else 
                    {
                        Console.WriteLine($"{heroe.Name} ataco a {enemigo.Name} disminuyendo su salud a {enemigo.Health}.");
                    }
                    if (enemigo.Health == 0)
                        {
                            heroe.WinPV(enemigo.Dead());
                            Console.WriteLine($"{heroe.Name} derroto a {enemigo.Name}.");
                        }
                    }
                });
            });
        }
    }
}