using System.Collections.Generic;

class TreeChallenges
{
  public static IEnumerable<T> BreadthFirst<T>(BinaryTree<T> tree)
  {
    // Either need to handle null early
    if (tree.Root == null) yield break; // quit early with empty seq

    Queue<Node<T>> q = new Queue<Node<T>>();
    q.Enqueue(tree.Root);

    while (q.Count > 0) {
      Node<T> next = q.Dequeue();

      // Or skip any nulls we see in the queue
      if (next == null) continue;

      yield return next.Value; // OUTPUT <- next.Value

      if (next.Left != null) q.Enqueue(next.Left);
      if (next.Right != null) q.Enqueue(next.Right);
    }
  }
}