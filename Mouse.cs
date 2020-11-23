using System;
using System.Collections.Generic;
using System.Text;

namespace FarmOOP
{
    class Mouse : Animal
    {
        public Mouse()
        {
            
        }
        public static string Catch()
        {
            return "Catch some prey. \n";
        }
        public static string Rat()
        {
            return "Mouse RatRat. \n";
        }
        public override string Go()
        {
            this.Location += 23;
            return "Mouse is moving >>>\n" + "Location of mouse is " + this.Location;
        }
        public override string Run()
        {
            this.Location += 12;
            return  "Mouse is running >>>\n" + "Location of mouse is " + this.Location;
        }
        public override string Eat()
        {
            this.Food = "Rice";
            return "Mouse is eatting " + this.Food;
        }
        public override string Drink()
        {
            return "Mouse is drinking sting ";
        }
        public override string Action()
        {
            return  "Mouse is playing with Cat ^^";
        }
    }
}
