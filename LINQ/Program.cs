namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            var names = new string[] { "Rangers", "Astros", "Angels", "Mariners" };

            var orderNames = names.OrderBy(name => name.Length);

            foreach (var name in orderNames) 
            {
                Console.WriteLine(name);
            }
        }
    }
}
