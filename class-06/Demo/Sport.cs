namespace Demo
{
    abstract class Sport : Game // extends Game
    {
        public int TeamCount { get; set; }

        public abstract string[] GetEquipment();
    }
}
