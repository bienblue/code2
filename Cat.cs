using System;
using System.Collections.Generic;
using System.Text;

namespace FarmOOP
{

    class Cat : Animal
    {
        public Cat()
        {
            

        }
        public static string BayXa(params object[] thamso)
        {
            float gio = (float)thamso[0];
            return "MeoMeo Bay. " + " gio: " + gio + "\n" ;
        }
        public static string ChayTron(params object[] thamso)
        {
            string house = (string)thamso[0];
            int thoigian = (int)thamso[1];
            return "MeoMeo Chay. " + " house: " + house + " thoi gian: " + thoigian + "\n";
        }
        public override string Go()
        {
            this.Location += 2;
            return "Cat is moving >>>\n" + " Location of cat is " + this.Location;
            
        }
        public override string Run()
        {
            this.Location += 10;
            return "Cat is running >>>\n" + "Location of cat is " + this.Location;
        }
        public override string Eat()
        {
            this.Food = "Hotdog";
            return  "Cat is eating>>>\n" + "Cat just eat " + this.Food;
        }
        public override string Drink()
        {
            return "Cat is finding something to drink\n" + "Cat drinking pepsi";
        }
        public override string Action()
        {
            return "Cat is kicking ball\n" + "Cat is sleeping";
        }
    }
}
