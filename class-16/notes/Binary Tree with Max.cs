// Option 1: Challenge

class TreeChallenges {
  public int FindMax(BinaryTree<int> tree)
  {
    // TODO
  }
}

// Option 2: Fancy Challenge

class TreeChallenges {
  public T FindMax<T>(BinaryTree<T> tree)
    where T : IComparable<T>
  {
    // TODO
  }
}

// Option 3: Class NumberBinaryTree

class NumberBinaryTree : BinaryTree<int>
{
  public virtual int FindMax() { ... }
}

class BinarySearchTree : NumberBinaryTree
{
  // Can be more efficient for BST!
  public override int FindMax() { ... }
}

// Option 4: Class ComparableBinaryTree

class ComparableBinaryTree<T> : BinaryTree<T>
  where T : IComparable<T>
{
  public virtual T FindMax() { ... }
}

class BinarySearchTree<T> : ComparableBinaryTree<T>
{
  // Can be more efficient for BST!
  public override T FindMax() { ... }
}

