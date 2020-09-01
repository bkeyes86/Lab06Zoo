namespace Lab06Zoo
{
    public class Dinosaur : Animal
    {
        public bool Land => false;
        public bool Teeth => true;



        public override string TheEats()
        {
            return "I eat lot's of things ";
        }
    }

    public class Carnivore : Dinosaur
    {
        public override string TheEats()
        {
            base.TheEats();
            return "I heard you have the meats";

        }

    }

    public class Herbivore : Dinosaur
    {

        public override string TheEats()
        {
            base.TheEats();
            return "I love salad and greens";
        }

    }

}


    





    
