namespace Lab06Zoo
{
    interface ICarnivore
    {
       public abstract int Speed { get; }
        public abstract int Strength { get; }

        public abstract bool Claws { get; }
    }
}