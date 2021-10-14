Node c1 = l1.Head;
Node c2 = l2.Head;

if (c1 == null)
    return l2;

Node n1 = null;
Node n2 = null;

while (c1 != null && c2 != null)
{
    n1 = c1.Next; // don't lose (C)
    c1.Next = c2; // point at (B)
    c1 = n1;      // Move c1 to (C)

    n2 = c2.Next; // don't lose (D)

    // Don't lose the rest of l2 if c1 is gone
    if (c1 != null)
    {
        c2.Next = c1; // point at (C)
    }
    c2 = n2;      // Move c2 to (D)
}

// We think we're done!
return l1;
