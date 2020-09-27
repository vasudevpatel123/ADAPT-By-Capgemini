using System;

public class InvalidAgeException : Exception
{
    public InvalidAgeException(string s):base(s)
    {
        
    }
}

public class UserDefinedException
{

    static void ageCheck(int age)
        {
        //Write your code to check the user age
            if(age<=18){
                throw new InvalidAgeException("Not eligible to vote");
            }else{
                Console.WriteLine("Welcome to vote");
            }
        }

    public static void Main(String[] args)
    {
        int age;
        
        try
        {
            //write your code read users age and validatte age by invoking ageCheck()
            age=Int32.Parse(Console.ReadLine());
            ageCheck(age);
            
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        
    }

}
