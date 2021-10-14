class Backpack<T> : IBag<T>
{
  List<T> items = new List<T>();

  void Pack(T item) {
    items.Add(item);
  }

  // TODO: Unpack()
}

