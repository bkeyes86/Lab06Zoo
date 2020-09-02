namespace Lab06Zoo
{
    public interface IOmnivores
    {
        public abstract bool Frugivores { get; }
        public abstract int Strength { get; }

        public abstract bool Speed { get; }
    }
}