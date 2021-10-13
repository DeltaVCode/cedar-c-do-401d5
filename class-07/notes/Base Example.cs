class Animal
{
  override ToString() = "I am an Animal";

  virtual void Dance()
  {
    Console.WriteLine("Dance Party!");
  }
}

class Mammal : Animal
{
  override ToString()
  {
    string valueFromBase = base.ToString();

     return $"Parent said {valueFromBase}. I am a Mammal.";
  }
}


class Cow
{
   override string Speak() => "Moo";

   override void Dance()
   {
      base.Dance(); // Do whatever Mammal says
      Console.WriteLine("Swing those udders");
   }
}



Cow cow = new Cow();

string moo = cow.Speak();
Console.WriteLine(moo);

Console.WriteLine(cow.Speak());
