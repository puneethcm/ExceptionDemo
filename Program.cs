using ExceptionDemo;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Exception Demo");
        Console.WriteLine("Enter person Age");
        int age = Convert.ToInt32(Console.ReadLine());

        PersonCategory.FindPersonCategory(age);
        Console.ReadLine();
    }
}