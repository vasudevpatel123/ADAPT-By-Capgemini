using System;

public class ExceptionHandlingExample1
{
 
    public static void Main(string[] args)
    {

        int a=10;
        int b=0;
        int[] r = new int[5]{1,2,3,4,5};
        try
        {
           //write your code that cause Division by zero exeption
            int c=a/b;
        }
        catch (ArithmeticException e)
        {
            Console.WriteLine("Attempted to divide by zero.");
        }

        try
        {
            //write your code that causes Array Index Out Of RangeException
            Console.WriteLine(r[6]);
        }
        catch (IndexOutOfRangeException e1)
        {
            Console.WriteLine("Your array index range is exceeded than defined");
        }

        finally
        {
          //write your code to print "I am end of all exceptions"
            Console.WriteLine("I am end of all exceptions");
        }
        
        //write your code to print "I am after exception"
        Console.WriteLine("I am after exception");

    }

}
