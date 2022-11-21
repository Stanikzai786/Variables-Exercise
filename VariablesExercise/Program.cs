namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello, C32!");
            Console.WriteLine("please enter your name:  ");
            string name = Console.ReadLine();
            Console.WriteLine("please enter your cat color:  ");
            string catColor = Console.ReadLine();
            Console.WriteLine("enter your CatAge:  ");
            int age = int.Parse(Console.ReadLine());


            //string interoplation
            Console.WriteLine($"Hello, {name}. Your cats color is, {catColor}.");
            Console.WriteLine($"And Your cat's Age is {age}");
        }
    }
}
