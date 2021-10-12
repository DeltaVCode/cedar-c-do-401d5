public void Cat_does_Cat_things()
{
  Cat cat = new Cat("Fluffy");

  Assert.Equal(9, cat.Lives);  
}

public void Cat_does_IAmFluffy_things()
{

}

public void Cat_does_Animal_things()
{
  Animal animal = new Cat("Fluffy");

  // Animal.Speak()
  Assert.Equal("meow", animal.Speak());
  // Animal.LegCount
  Assert.Equal(4, animal.LegCount);
}

public void Cat_does_Object_things()
{
  Object cat = new Cat("Fluffy");

  Assert.Equal("Cat (Name = Fluffy)", cat.ToString());
}
