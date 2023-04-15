using ExceptionDemo;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Exception Demo");
        try
        {
            Console.WriteLine("Enter person Age");

            int age = Convert.ToInt32(Console.ReadLine());
            PersonCategory.FindPersonCategory(age);
        }
        catch (Exception ex)
        {
            Console.WriteLine("The Entered input is empty please enter any value");
            //throw new CustomException("The Entered age is Empty", CustomException.ExceptionTypes.EUMPTY);
        }
        Console.ReadLine();
    }
}