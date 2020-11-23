using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Threading;

namespace FarmOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal dog1 = new Dog();
            Animal cat1 = new Cat();
            Console.WriteLine("About Dog: ");
            int vitri = 5;
            int dia = 6;
            string house = "chay tron trong bep!!!";
            int thoigian = 9;
            float gio = 7;
            Animal.DelegateSkill skill1 = new Animal.DelegateSkill(Dog.NhayCao);
            Animal.DelegateSkill skill2 = new Animal.DelegateSkill(Dog.NemDia);
            Animal.DelegateSkill skill4 = new Animal.DelegateSkill(Cat.ChayTron);
            Animal.DelegateSkill skill5 = new Animal.DelegateSkill(Cat.BayXa);
            Console.WriteLine(dog1.Performance(skill1,vitri));
            Console.WriteLine(dog1.Performance(skill2, dia));
            Console.WriteLine(cat1.Performance(skill4, house, thoigian));
            Console.WriteLine(cat1.Performance(skill5, gio));
            
           

        }
    }
}
