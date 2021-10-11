namespace Demo
{
    abstract class Sport : Game // extends Game
    {
        public Sport(string name)
        {
            Name = name;
        }

        public int TeamCount { get; set; }

        public abstract string[] GetEquipment();
    }
}
