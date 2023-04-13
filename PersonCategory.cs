using System;
namespace ExceptionDemo
{
	public class PersonCategory
	{
		public static void FindPersonCategory(int age)
		{
			if(age>0 && age <= 14)
			{
				Console.WriteLine("The Person He/She is Children Cotegory");
			}
			else if(age >= 15 && age <= 24)
			{
                Console.WriteLine("The Person He/She is Youth Cotegory");
            }
            else if (age >= 25 && age <= 64)
            {
                Console.WriteLine("The Person He/She is Adults Cotegory");
            }
			else
			{
                Console.WriteLine("The Person He/She is Seniors Cotegory");
            }
        }
	}
}

