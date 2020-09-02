namespace Lab06Zoo
{
    public class Mammals : Animal
    {
        public virtual bool Cat { get;  }
        public bool Swimmer => false;
        public bool fur => true;



        public override string TheEats()
        {
            return "I eat lot's of things ";
        }
    }

    public class Omnivores : Mammals, IOmnivores
    {
        public bool Frugivores => throw new System.NotImplementedException();

        public int Strength => throw new System.NotImplementedException();

        public bool Speed => throw new System.NotImplementedException();

        public override string TheEats()
        {
            base.TheEats();
            return "I eat food of plant and animal origin";

        }

    }

   public class Lion : Carnivore, ICarnivore
    {
        public  bool Cat => true;

        public int Speed => (int)95m;

        public int Strength => 100;

        public bool Claws => true;
    }
}





