public void SQueue_starts_empty()
{
   var q = new SQueue();
   Assert.True(q.IsEmpty();
}

public void SQueue_can_Enqueue_once()
{
   // Arrange
   var q = new SQueue();

   // Act
   q.Enqueue(1);

   // Assert
   Assert.Equal(1, q.Peek());
   Assert.False(q.IsEmpty);
}

public void SQueue_can_Dequeue_once()
{
   var q = new SQueue();
   q.Enqueue(1);

   Assert.Equal(1, q.Peek());
   Assert.False(q.IsEmpty);
}

public void SQueue_stress_test()
{

// Arrange
SQueue q = new SQueue();

// Act / Assert
q.Enqueue(1);
Assert.Equal(1, q.Peek());
Assert.False(q.IsEmpty);

q.Enqueue(2);
Assert.Equal(1, q.Peek());
Assert.False(q.IsEmpty);

q.Enqueue(3);
Assert.Equal(1, q.Peek());
Assert.False(q.IsEmpty);

Assert.Equal(1, q.Dequeue());

Assert.Equal(2, q.Peek());
Assert.False(q.IsEmpty);

Assert.Equal(2, q.Dequeue());

Assert.Equal(3, q.Peek());
Assert.False(q.IsEmpty);

q.Enqueue(4);

Assert.Equal(3, q.Peek());
Assert.False(q.IsEmpty);

Assert.Equal(3, q.Dequeue());

Assert.Equal(4, q.Peek());
Assert.False(q.IsEmpty);

Assert.Equal(4, q.Dequeue());

Assert.True(q.IsEmpty);
Assert.Throws(() => q.Peek());

q.Enqueue(5);
q.Enqueue(6);

Assert.Equals(5, q.Dequeue());
Assert.Equals(6, q.Dequeue());
Assert.True(q.IsEmpty);

// Empty again
q.Enqueue(7);
Assert.Equals(7, q.Dequeue());
Assert.True(q.IsEmpty);
Assert.Equal(true, q.IsEmpty); // warning
}