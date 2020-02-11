using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class DynamicArray<T>: IEnumerable<T>
    {
        private T[] values;
        public int Lenght { get; private set; }
        public int Capacity
        {
            get
            {
                return values.Length;
            }
            set
            {
                if (value < Lenght)
                {
                    throw new ArgumentException("New capacity value cannot be less then current lenght value");
                }
                var newArr = new T[value];
                for(int i = 0; i < Lenght; i++)
                {
                    newArr[i] = values[i];
                }
                values = newArr;
            }
        }

        public void Add(T value)
        {
            Lenght++;
            Capacity++;
            values[Lenght - 1] = value;
        }

        public T Max()
        {
            return this.Max();
        }

        public T Min()
        {
            return this.Min();
        }

        public T Sum()
        {
            return this.Sum();
        }

        public T Average()
        {
            return this.Average();
        }

        public IEnumerable ZeroFilter()
        {
            return this.Where(x => x.Equals(default(T))); 
        } 

        public T Multyply()
        {
            var type = typeof(T);
            var multyplyMethod = type.GetMethods().Where(x => x.IsStatic && x.Name == "*").FirstOrDefault();
            if (multyplyMethod == null) throw new InvalidOperationException("Type cannot be multyplied");
            var result = values[0];
            for(int i = 1; i < Lenght; i++)
            {
                result = (T)multyplyMethod.Invoke(null, new object[] { result, values[i] });
            }
            return result;
        }

        public T this [int index]
        {
            get
            {
                return values[index];
            }
            set
            {
                if (index < 0) throw new ArgumentException("Index cannot be less then 0");
                if (index < Capacity)
                {
                    values[index] = value;
                }
                else
                {
                    Capacity = index + 1;
                    Lenght = index + 1;
                    values[index] = value;
                }
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("[");
            sb.Append($"{values[0]}");
            for(int i = 1; i<Lenght; i++)
            {
                sb.Append($",{values[i]}");
            }
            sb.Append("]");
            return sb.ToString();
        }

        public IEnumerator<T> GetEnumerator()
        {
            for(int i = 0; i < Lenght; i++)
            {
                yield return values[i];
            }
            yield break;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            for (int i = 0; i < Lenght; i++)
            {
                yield return values[i];
            }
            yield break;
        }
    }
}
