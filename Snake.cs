using System;
using System.Collections.Generic;
using System.Text;

namespace FarmOOP
{
    class Snake : Animal
    {
        public Snake() : base()
        {
           

        }
        public static string Jump()
        {
            return "Snake Jumping. \n";
        }
        public static string Gao()
        {
            return "Snake GaoGao .\n";
        }
        public override string Go()
        {
            this.Location += 12;
            return "Snake is moving >>>\n" + "Location of snake is " + this.Location;

        }
        public override string Run()
        {
            this.Location += 23;
            return "Snake is running >>>\n" + "Location of Snake is " + this.Location;
        }
        public override string Eat()
        {
            this.Food = "mouse";
            return  "Snake is eatting  " + this.Food;
        }
        public override string Drink()
        {
            return  "Snake is drinking seven up";
        }
        public override string Action()
        {

            return  "Snake is catching someone --";

        }
    }
}
