namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            int favNumber = r.Next(1,4);


            Console.WriteLine("Can you read minds? Guess what my favorite number is?");
            int userInput = int.Parse(Console.ReadLine());

            if (userInput < favNumber)

            {
                Console.WriteLine("Your answer is too low, keep guessing!");

            }
            else if (userInput > favNumber)
            {
                Console.WriteLine("Your answer is too high, keep guessing!");
            }
            else 
            {
                Console.WriteLine("You guessed it! Maybe you can read minds!");
            }
        }

    }
}
