using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace BoxOfT
{
    public class Box<T>
    { 
        private List<T> data;

        public int Count
        {
            get
            {
                return data.Count;
            }
        }

        public Box()
        {
            data = new List<T>();
            
        }

        public void Add(T element)
        {
            data.Add(element);
           
        }

        public T Remove()
        {
            if (data.Count == 0)
            {
                throw new InvalidOperationException("Can not remove from empty collection!");
            }

            T result = data.Last();
            data.Remove(result);

            return result;
        }
    }
}
