using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace FarmOOP
{
    public abstract class Animal
    {
        //Khai bao Level cua cac con vat , gan gia tri vao de khi cong hai con vat vao thi no se tang len 1 level))
        public enum LevelAnimal
        {
            Min = 1,
            Basic = 2,
            Silver = 3,
            Gold = 4,
            Platinum = 5,
            Max = 6
        };

        private int age;
        private string food;
        private string color;
        private float hight;
        private float length;
        private int location;
        LevelAnimal level;

        public Animal(int age, string food, string color, float hight, float length, int location, LevelAnimal level)
        {
            this.age = age;
            this.food = food;
            this.color = color;
            this.hight = hight;
            this.length = length;
            this.location = location;
            this.Level = level;
        }
        public static int count;
        static Animal()
        {
            count = 0;
        }

        public Animal()
        {
            count += 1;
            location = 0;//Animal luon duoc khoi tao voi vi tri bang 0
        }

        public int Age { get => age; set => age = value; }
        public string Food { get => food; set => food = value; }
        public string Color { get => color; set => color = value; }
        public float Hight { get => hight; set => hight = value; }
        public int Location { get => location; set => location = value; }
        public LevelAnimal Level { get => level; set => level = value; }

        public abstract string Go();
        public abstract string Run();
        public abstract string Eat();
        public abstract string Drink();
        public virtual string Action()
        {
            return "Action of animal >>>";
        }

        public Animal(Animal a)
        {

        }
        //nap chong toan tu (+) 
        public static Animal operator +(Animal a, Animal b)
        {
            Animal dog = new Dog();
            Animal cat = new Cat();
            Animal mouse = new Mouse();
            Animal snake = new Snake();
            Animal kq = new VirtualAnimal();
            // dog + dog  = cat, Level = level cua dog + 1
            if (a.GetType() == dog.GetType() && b.GetType() == dog.GetType())
            {
                kq = new Cat();
                kq.Level = a.Level + 1;
            }
            // cat + cat = dog, Level + 1
            else if (a.GetType() == cat.GetType() && b.GetType() == cat.GetType())
            {
                kq = new Dog();
                kq.Level = a.Level + 1;

            }
            //mouse + mouse = snake, Level = level cua mouse + 1
            else if (a.GetType() == mouse.GetType() && b.GetType() == mouse.GetType())
            {
                kq = new Snake();
                kq.Level = a.Level + 1;
            }
            //snake + snake = mouse , Level + 1
            else if (a.GetType() == snake.GetType() && b.GetType() == snake.GetType())
            {
                kq = new Mouse();
                kq.Level = a.Level + 1;
            }
            return kq;
        }
        //Nap chong toan tu (-)
        public static Animal operator -(Animal a, Animal b)
        {
            Animal dog = new Dog();
            Animal cat = new Cat();
            Animal mouse = new Mouse();
            Animal snake = new Snake();
            Animal kq = new VirtualAnimal();
            // dog - dog  = Mouse, Level = level cua dog - 1
            if (a.GetType() == dog.GetType() && b.GetType() == dog.GetType())
            {
                kq = new Mouse();
                kq.Level = a.Level - 1;
            }
            // cat - cat = Snake, Level - 1
            else if (a.GetType() == cat.GetType() && b.GetType() == cat.GetType())
            {
                kq = new Snake();
                kq.Level = a.Level - 1;

            }
            //mouse - mouse = cat, Level = level cua mouse - 1
            else if (a.GetType() == mouse.GetType() && b.GetType() == mouse.GetType())
            {
                kq = new Cat();
                kq.Level = a.Level - 1;
            }
            //snake - snake = dog , Level - 1
            else if (a.GetType() == snake.GetType() && b.GetType() == snake.GetType())
            {
                kq = new Dog();
                kq.Level = a.Level - 1;
            }
            return kq;
        }

        public string Step1()
        {
            return "Step1: Prepare.\n";
        }
        public string Step2()
        {
            return "Step2: Warm - up.\n";
        }
        public string Step3()
        {
            return "Step3: In position.\n";
        }
        public virtual string Step4(DelegateSkill skill, params object[] thamso)
        {
            return "Step4: " + skill(thamso);
        }
        public string Step5()
        {
            return "Step5: End of performance.\n";

        }
        public string Step6()
        {
            return "Step6: Back to the position.\n";
        }
        public string Step7()
        {
            return "Step7: Come back home.\n";
        }
        public delegate string DelegateSkill(params object[] thamso);

        public string Performance(DelegateSkill skill, params object[] thamso)
        {
            return Step1() + Step2() + Step3() + Step4(skill, thamso) + Step5() + Step6() + Step7();
        }

    }
}
