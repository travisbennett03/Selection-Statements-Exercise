namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {

            var r = new Random();
            var favNumber = r.Next(1, 10);

            Console.WriteLine("Try to guess my favorite number");

            var userInput = int.Parse(Console.ReadLine());

            if (userInput < favNumber)
            {
                Console.WriteLine("Too Low");
            }
            else if (userInput > favNumber)
            {
                Console.WriteLine("Too High");
            }
            else
            {
                Console.WriteLine("Nevermind");
            }
            Console.WriteLine($"This is what the number was {favNumber}");
        }
    }
}
