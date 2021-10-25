1. New folder called Trees in DataStructures project

2. New class in `Trees/Node.cs`

   class Node<T> {
       // Optional: constructor with (T value)
       public T Value { get; set; }
       public Node<T> Left {get;set;}
       public Node<T> Right {get;set;}
   }

3. New class in `Trees/BinaryTree.cs` 

   class BinaryTree<T> {
       public Node<T> Root {get;set;}

     // Option 1
       public IEnumerable<T> PreOrder() {
           return PreOrder(Root);
       }

       private IEnumerable<T> PreOrder(Node<T> root) {
           // Add this node's value to the output sequence
           yield return root.Value; // T

           // Traverse Left, then Right
       }

     // Option 2
       public IEnumerable<T> PostOrder() {
           List<T> results = new List<T>();
           PostOrder(Root, results);
           return results;
       }

       private IEnumerable<T> PostOrder(Node<T> root, List<T> results) {
           // Add this node's value to the output sequence
           results.Add(root.Value);

           // Traverse Left, then Right
           if (root.Left != null) {
               PostOrder(root.Left, results);
           }
       }

       // InOrder()
   }

4. New class in `Trees/BinarySearchTree.cs`

   class BinarySearchTree : BinaryTree<int>
   {
       void Add(int value) { ... }
       bool Contains(int value) { ... }
   }

   // Stretch goal
   class BinarySearchTree<T> : BinaryTree<T>
       where T : IComparable<T>
   {
       void Add(T value) { ... }
       bool Contains(T value) { ... }
   }
