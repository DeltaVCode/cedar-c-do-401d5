class Stack<T>
{
  // encapsulation: can't fiddle with top directly
  private Node<T> top;

  void Push(T value) { ... }

  T Pop() { ... }

  T Peek() { ... }

  bool IsEmpty => top == null;
}

class Node<T>
{
    T Value { get; set; }
    Node<T> Next { get; set; }
}