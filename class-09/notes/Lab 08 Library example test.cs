// Arrange
Library libary = new Library();

library.Add("C# in Depth");

// Assert
bool found = false;
foreach(Book book in library)
{
  if (book.Title == "C# in Depth")
  {
    found = true;
    break;
  }
}

Assert.True(found);

// Act
Book csid = library.Borrow("C# in Depth");

// Assert
Assert.NotContains(csid, library);

// Act
library.Return(csid);

// Assert
Assert.Contains(csid, library);
