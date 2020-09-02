namespace Lab06Zoo
{
    public class Birds : Animal
    {
        public virtual bool Herons { get; set; }
        
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

     public   class Limpkin : Frugivorous, IOmnivores
        {
            public  override bool Herons => true;

            public bool Frugivores => true;

            public int Strength => 15;

            public int Speed => (int)45m;

            bool IOmnivores.Speed => throw new System.NotImplementedException();
        }
                
                }

}
