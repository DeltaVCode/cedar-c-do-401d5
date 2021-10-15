class Stack
{
  // encapsulation: can't fiddle with top directly
  private Node top;

  void Push(int value) { ... }

  int Pop() { ... }

  int Peek() { ... }

  bool IsEmpty => top == null;
}

class Node
{
    int Value { get; set; }
    Node Next { get; set; }
}