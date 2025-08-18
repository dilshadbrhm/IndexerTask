using IndexerTask.Models;

namespace IndexerTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListInt list = new ListInt(1, 2, 3, 4, 5);
            Console.WriteLine(list);

            list.Add(6);
            Console.WriteLine(list);

            list.AddRange(7, 8, 9);
            Console.WriteLine(list);

            //Console.WriteLine(list.Contains(5));
            //Console.WriteLine(list.Sum());

            //list.Remove(3);
            //Console.WriteLine(list); 

            list.RemoveRange(1, 9, 7);
            Console.WriteLine(list);

        }
    }
}
