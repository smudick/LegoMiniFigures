using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMiniFigures.Figures
{
    class Superheroes
    {
        public class Hero
        {
            public string Name { get; set; }
            public string Head { get; set; }
            public string Torso { get; set; }
            public string Legs { get; set; }
            public string SpecialWeapon { get; set; }
            public bool HasCape { get; set; }
            public int AttackDamage { get; set; }

            public Hero(string name)
            {
                Name = name;
                if (name == "Superman" || name == "Batman")
                {
                    HasCape = true;
                }
                else
                {
                    HasCape = false;
                }
                AttackDamage = 0;
            }

            public void Jump()
            {
                if (Legs != null)
                {
                    if (HasCape)
                    {
                        Console.WriteLine($"{Name} jumps very high!");
                    }
                    else
                    {
                        Console.WriteLine($"{Name} has kind of a weak jump, maybe a cape would have helped.");
                    }
                }
                else
                {
                    Console.WriteLine("Your figure has no legs! You need to give them legs before they can jump!");
                }

            }
            public void SpecialAttack()
            {
                if (SpecialWeapon != null)
                {
                    Console.WriteLine($"{Name} does a sweet attack with their {SpecialWeapon}");
                    AttackDamage += 100;
                }
                else
                {
                    Console.WriteLine($"{Name} does not have a special weapon. They attack with a punch but are sad about it.");
                    AttackDamage += 50;
                }
            }
        }
        public class Villain
        {
            public string Name { get; set; }
            public int Healthbar { get; set; }
            public Villain(string name, int healthbar)
            {
                Name = name;
                Healthbar = healthbar;
            }
            public void TakeDamage(int damage)
            {
                if (damage > 0)
                {
                    Healthbar = Healthbar - damage;
                    if (Healthbar <= 0)
                    {
                        Console.WriteLine($"{Name} has been defeated!");
                    }
                    else
                    {
                        Console.WriteLine($"{Name} has taken damage but still has {Healthbar} health points left.");
                    }
                }
                else
                {
                    Console.WriteLine($"The attack missed!");
                }
            }
        }
    }
}
