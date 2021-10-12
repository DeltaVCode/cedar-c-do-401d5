public class Mammal
{
    public Mammal()
    {
       this.NumberOfLegs = 4;
    }

    public int NumberOfLegs { get; set; }

    public string Run() { return $"I have {NumOfLegs} legs  running"; }
}