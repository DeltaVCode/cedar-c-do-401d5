class Library : ILibrary
{
  // Store my stuff here:
  Dictionary<string, Book> books = new();



  void Return(Book book)
  {
    books.Add(book.Title, book);
  }

  // Other methods/properties
}
