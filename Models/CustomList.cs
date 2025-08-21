using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace IndexerTask.Models
{
    internal class CustomList<T>

    {

        private T[] arr;

        public int Capacity;
        public int Count;


        public T this[int index]
        {
            get
            {

                return arr[index];

            }
            set
            {
                arr[index] = value;
            }

        }
        public CustomList()
        {
            arr = new T[0];
            Count = 0;
        }
        public CustomList(int length)
        {
            arr = new T[length];
            Count = 0;
        }

        public CustomList(params T[] numbers)
        {
            arr = new T[numbers.Length];
            Array.Copy(numbers, arr, numbers.Length);
            Count = numbers.Length;
        }
        public int Length
        {
            get
            {
                return arr.Length;
            }
        }

        public void Add(T num)
        {
            if (Capacity == 0)
            {
                Capacity = 4;
                Array.Resize(ref arr, Capacity);
            }
            if (Capacity == Count)
            {
                Capacity *= 2;
                Array.Resize(ref arr, Capacity + Length);

            }
            arr[Count] = num;
            Count++;
        }
        public void AddRange(params T[] numbers)
        {
            foreach (T num in numbers)
            {
                Add(num);
            }
        }
        public bool Contains(T num)
        {

            foreach (T item in arr)
            {
                if (item.Equals(num)) return true;
            }
            return false;
        }

        public void Remove(T num)
        {

            for (int i = 0; i < Count; i++)
            {
                if (arr[i].Equals(num))
                    for (int j = 0; j < Count - 1; j++)
                    {
                        arr[j] = arr[j + 1];
                    }
                Count--;
                return;
            }

        }
        public void RemoveRange(params T[] nums)
        {
            foreach (T num in nums)
            {

                Remove(num);

            }

        }
        public override string ToString()
        {
            return string.Join(", ", arr.Take(Count));
        }
    }
}

