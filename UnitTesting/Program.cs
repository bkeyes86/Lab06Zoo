using System;

namespace Lab06Zoo
{
    public class Animals
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

    }

    public abstract class Animal
    {
        public virtual string FoodType { get; set; }
        public virtual string SleepType { get; set; }
        public virtual string SkinType { get; set; }

        private string theEats;

        public abstract string TheEats();
        
        

        public virtual void SetTheEats(string value)
        {
            theEats = value;
        }
        //public virtual string Sleep();

        //public virtual string Sounds();

    }

}
   


    



