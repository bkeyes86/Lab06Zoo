namespace Lab06Zoo
{
    public class Birds : Animal
    {
        
        public bool feathers => true;



        public override string TheEats()
        {
            return "I eat lot's of things ";
        }
    }

    public class Avivorous : Birds
    {
        public override string TheEats()
        {
            base.TheEats();
            return "I am a bird eater";

        }

    }

    public class Frugivorous : Birds
    {

        public override string TheEats()
        {
            base.TheEats();
            return "I love fruit and berries";
        }

    }

}
