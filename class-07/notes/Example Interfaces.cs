interface IDancer
{
    void Dance();
}

interface ILaysEggs
{
    void LayEggs();
    int MaxEggsPerBatch { get; }
}


interface IHasCheeseburger
{
    string FavoriteCheeseburger { get; }
}


OutputCheeseburgers(IHasCheeseburger cb)
{
   Console.WriteLine(cb.FavoriteCheeseburger);
}