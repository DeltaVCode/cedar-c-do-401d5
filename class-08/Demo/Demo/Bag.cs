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
        public void Add(T v)
        {
        }

        public IEnumerator<T> GetEnumerator()
        {
            // Use iterator to return empty (for now)
            yield break;
        }

        // Explicit implementation of the interface member
        IEnumerator IEnumerable.GetEnumerator()
        {
            // Call the real one above
            return GetEnumerator();
        }
    }
}
