Node prev = null;
Node current = Head;

while (current != null)
{
  if (current.Value == valueToFind)
  {
    if (prev == null)
    {
      this.Insert(value); // insert at Head
      break;
    }

    Node newNode = new Node();
    newNode.Value = value;
    newNode.Next = current;

    prev.Next = newNode;
    break;
  }

  prev = current;
  current = current.Next;
}
// break takes us here