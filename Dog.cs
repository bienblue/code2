using System;
using System.Collections.Generic;
using System.Text;

namespace FarmOOP
{
    class Dog : Animal
    {

        public Dog()
        {
            

        }
        public Dog(int age, string food)
        {
            this.Age = age;
            this.Food = food;
        }
        public static string NhayCao(params object[] thamso)
        {
            int location = (int)thamso[0];

            return "GoGo Jump . " + " location: "+location + "\n";
        }
        public static string NemDia(params object[] thamso)
        {
            int dia = (int)thamso[0];
            return "GoGo Nem ." + " dia : " + dia +"\n";
        }

        public override string Go()
        {
            this.Location += 4;
            return  "Dog is moving >>>\n"+ "Location of dog is " + this.Location;
        }
        public override string Run()
        {
            this.Location += 12;
            return  "Dog is running>>>\n" + "Location of dog is " + this.Location;
        }
        public override string Eat()
        {
            this.Food ="meat";
            return  "Dog is eatting>>>\n"+ "Dog ate :" + this.Food;
        }
        public override string Drink()
        {
            return "Dog drink bear **";
        }
        public override string Action()
        {
            return "Dog is swimming ";
        }
    }
}
