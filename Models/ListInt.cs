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
    internal class ListInt
    {

        private int[] arr;




        public int this[int index]
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
        public ListInt()
        {
            arr = new int[0];
        }
        public ListInt(int length)
        {
            arr = new int[length];
        }

        public ListInt(params int[] numbers)
        {
            arr = numbers;
        }
        public int Length
        {
            get
            {
                return arr.Length;
            }
        }

        public void Add(int num)
        {
            Array.Resize(ref arr, Length + 1);
            arr[arr.Length - 1] = num;
        }
        public void AddRange(params int[] numbers)
        {
            int[] newArr = new int[numbers.Length + Length];
            for (int i = 0; i < Length; i++)
            {
                newArr[i] = arr[i];
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                newArr[Length + i] = numbers[i];
            }
            arr = newArr;
        }
        public bool Contains(int num)
        {

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == num)
                {
                    return true;
                }
            }
            return false;
        }
        public int Sum()
        {
            int sum = 0;

            for (int i = 0; i < Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
        public void Remove(int num)
        {
            int j = 0;
            int[] newArr = new int[Length - 1];
            for (int i = 0; i < Length; i++)
            {
                if (arr[i] != num)
                    newArr[j++] = arr[i];
            }
            arr = newArr;
        }
        public void RemoveRange(params int[] nums)
        {
            foreach (int num in nums)
            {

                Remove(num);

            }

        }
        public override string ToString()
        {
            return string.Join(",", arr);
        }
    }
}

