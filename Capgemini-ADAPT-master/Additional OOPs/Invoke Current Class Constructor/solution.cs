using System;
public class Test
{
 
    public int x;
    public Test()
    {
//write your code to print a message I am the default constructor
//on the console window
        Console.WriteLine("I am the default constructor");
    }
   public Test(int x) : this() 
    {
       // write your code to invoke default constructor
       
        this.x = x;

    }
}



public class Program
{

    public static void Main(string[] args)
    {
      

//Write your code that create object of Test class and 
//initializes the value of x to 100
        
        Test t2 = new Test(100);
        
//write your code to print meassge '  X value is 100  on the console 
        Console.WriteLine("X value is "+t2.x);
    }

}
