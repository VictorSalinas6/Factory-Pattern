namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            string answer = "";
            do
            {
                Console.WriteLine("What fruit would you like? (Apple, Banana or Orange");
                answer = Console.ReadLine();
            } while ((answer.ToLower() != "apple") && (answer.ToLower() != "banana") && (answer.ToLower() != "orange"));

            Console.WriteLine();
            IFruit fruit = FruitFactory.PickingFruit(answer);
        }
    }
}
