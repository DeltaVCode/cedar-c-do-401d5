void Append_works()
{
  // Arrange
  LinkedList list = new LinkedList();
  list.Insert(2);
  list.Insert(1);

  // Act
  list.Append(3);

  // Assert
  Assert.Equal(
    "1 -> 2 -> 3 -> NULL",
    list.ToString());

  Assert.NotNull(list.Head);
  Assert.NotNull(list.Head.Next);
  Assert.NotNull(list.Head.Next.Next);
  Assert.Equal(3, list.Head.Next.Next.Value);
}