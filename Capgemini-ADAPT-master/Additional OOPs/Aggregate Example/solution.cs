using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabExersice
{
    class Program
    {

        static void Main(string[] args)
        {
            //Write yoyr code here 
            SalesManagement sm1 = new SalesManagement();
            sm1.setEmpId(100);
            sm1.setName("AAA");
            sm1.setSalary(12345);
            sm1.setBonus(3000);
            
            Console.WriteLine("Employee Details are");
            Console.WriteLine("EmpId is = "+sm1.getEmpId());
            Console.WriteLine("Emp Name is = "+sm1.getName());
            Console.WriteLine("Emp Salary is = "+sm1.getSalary());
            Console.WriteLine("Emp Bonus is = "+sm1.getBonus());
            
            Address adr = new Address();
            adr.setStreetName("xxx");
            adr.setCityName("Bangalore");
            
            Console.WriteLine("Emp streetName is = "+adr.getStreetName());
            Console.WriteLine("Emp cityName is = "+adr.getCityName());
        }
    }

    public class Employee
    {
        public int empId;
        public String name;
        public float salary;
        public Address a;

        public int getEmpId()
        {
            return empId;
        }
        public void setEmpId(int empId)
        {
            this.empId = empId;
        }
        public String getName()
        {
            return name;
        }
        public void setName(String name)
        {
            this.name = name;
        }
        public float getSalary()
        {
            return salary;
        }
        public void setSalary(float salary)
        {
            this.salary = salary;
        }
        public Address getA()
        {
            return a;
        }
        public void setA(Address a)
        {
            this.a = a;
        }




    }

    class Sales : Employee
    {
	
float bonus;

public float getBonus()
    {
        return bonus;
    }

    public void setBonus(float bonus)
    {
        this.bonus = bonus;
    }

}

class SalesManagement : Sales
{
    String role;

public String getRole()
{
    return role;
}

public void setRole(String role)
{
    this.role = role;
}	

}

class Engineering : Employee
{
    String designation;

public String getDesignation()
{
    return designation;
}

public void setDesignation(String designation)
{
    this.designation = designation;
}

}

public class Address
{
    protected String streetName = "xxx";
    protected String cityName = "Bangalore";
    public String getStreetName()
    {
        return streetName;
    }
    public void setStreetName(String streetName)
    {
        this.streetName = streetName;
    }
    public String getCityName()
    {
        return cityName;
    }
    public void setCityName(String cityName)
    {
        this.cityName = cityName;
    }

}

   

}

