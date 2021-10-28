BinaryTree<string> FizzBuzz(BinaryTree<int> t)
   => new BinaryTree<string> {
         Root = FizzBuzz(t.Root)
      };


Node<string> FizzBuzz(Node<int> n)
{
    if (n == null) return null;

    Node<string> newNode = new Node<string>();
    newNode.Value = FizzBuzz(n.Value);
    newNode.Left = FizzBuzz(n.Left);
    newNode.Right = FizzBuzz(n.Right);
    return newNode;
}

string FizzBuzz(int n)
{
   // TODO
}