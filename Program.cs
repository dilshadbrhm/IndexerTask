using IndexerTask.Models;

namespace IndexerTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> numbers = new CustomList<int>();
            numbers.Add(1);
            numbers.AddRange(2, 3, 4);
            Console.WriteLine(numbers); 
            Console.WriteLine(numbers.Contains(2)); 
            Console.WriteLine(numbers.Contains(5));

            numbers.Remove(4);
            Console.WriteLine(numbers); 
        }
    }
}
