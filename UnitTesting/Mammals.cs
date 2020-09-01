namespace Lab06Zoo
{
    public class Mammals : Animal
    {
        public bool Swimmer => true;
        public bool fur => true;



        public override string TheEats()
        {
            return "I eat lot's of things ";
        }
    }

    public class Omnivores : Dinosaur
    {
        public override string TheEats()
        {
            base.TheEats();
            return "I eat food of plant and animal origin";

        }

    }

}



