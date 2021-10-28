BinaryTree<TResult> MapTree<TSource, TResult>(
	BinaryTree<TSource> t,
	Func<TSource, TResult> mapper)

   => new BinaryTree<TResult> {
         Root = MapTree(t.Root, mapper)
      };


Node<TResult> MapTree(Node<TSource> n, Func<TSource, TResult> mapper)
{
    if (n == null) return null;

    Node<TResult> newNode = new Node<TResult>();
    newNode.Value = mapper(n.Value); // Convert (map) from TSource to TResult
    newNode.Left = MapTree(n.Left);
    newNode.Right = MapTree(n.Right);
    return newNode;
}

BinaryTree<string> FizzBuzz(BinaryTree<int> tree) => MapTree(tree, n => FizzBuzz(n));
