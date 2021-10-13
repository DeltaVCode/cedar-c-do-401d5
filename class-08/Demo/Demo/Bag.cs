using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class Bag<T> : IEnumerable<T>
    {
        int count = 0;
        T[] stuff = new T[2];

        public int Count => count;

        public void Add(T value)
        {
            if (count >= stuff.Length)
            {
                Array.Resize(ref stuff, stuff.Length * 2);
            }

            stuff[count] = value;
            count++;
        }

        public IEnumerator<T> GetEnumerator()
        {
            // Use iterator to return empty (for now)
            // yield break;

            for (int i = 0; i < count; i++)
            {
                yield return stuff[i];
            }
        }

        // Explicit implementation of the interface member
        IEnumerator IEnumerable.GetEnumerator()
        {
            // Call the real one above
            return GetEnumerator();
        }
    }
}
