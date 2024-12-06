using Less_5_pr2;

namespace Less_5_pr2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 2, 8, 3, 7, 1 };
            Array array = new Array(numbers);

            array.Show();
            array.Show("Array elements:");

            Console.WriteLine("Max: " + array.Max());
            Console.WriteLine("Min: " + array.Min());
            Console.WriteLine("Avg: " + array.Avg());
            Console.WriteLine("Search 3: " + array.Search(3));
            Console.WriteLine("Search 55: " + array.Search(55));

            array.SortAsc();
            array.Show("Sorted Ascending");

            array.SortDesc();
            array.Show("Sorted Descending");

            array.SortByParam(true);
            array.Show("Sorted, param - asc)");

            array.SortByParam(false);
            array.Show("Sorted, param - desc");
        }
    }
}
