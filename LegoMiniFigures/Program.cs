using System;
using LegoMiniFigures.Figures;

namespace LegoMiniFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            Superheroes.Hero hero1 = new Superheroes.Hero("Superman");
            hero1.Jump();
            Superheroes.Hero hero2 = new Superheroes.Hero("Spiderman");
            hero2.Jump();
            hero2.SpecialWeapon ="Web shooter";
            hero2.SpecialAttack();
            hero2.SpecialAttack();
            Superheroes.Villain villain1 = new Superheroes.Villain("Green Goblin", 200);
            villain1.TakeDamage(hero2.AttackDamage);

        }
    }
}
