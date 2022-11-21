namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            string myName = "Devin";
            int age = 23;
            char favoriteLetter = 'z';
            bool isZfavoriteNumber = true;
            double number_1 = 4.5687;
            decimal number_2 = 7.84964m;

            Console.WriteLine($"Hi, my name is {myName} and I am {age} years old. People ask me if my favorite letter is {favoriteLetter}, and that would be {isZfavoriteNumber}.");
            Console.WriteLine($"A cool fact about me is that numbers such as {number_1} and {number_2} make me sick to my stomach.");
        }
    }
}
