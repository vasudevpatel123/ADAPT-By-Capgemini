using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


public	class Student
{
//write your code here
    private int rollno;
    private string name;
    private string address;
    private string college;
    
    public Student(){
        rollno=0;
        name=null;
        address=null;
        college=null;
    }
    public Student(int r){
        this.rollno=r;
    }
    public Student(int r,string n){
        this.rollno=r;
        this.name=n;
    }
    public Student(int rollno,string name,string address){
        this.rollno=rollno;
        this.name=name;
        this.address=address;
    }
    public void changeCollege(){
        
    }
    public void input(){
        rollno=Int32.Parse(Console.ReadLine());
        name=Console.ReadLine();
        address=Console.ReadLine();
        college=Console.ReadLine();
    }
    public void input(int r,string n){
        rollno=r;
        name=n;
    }
    public void input(int r,string n,string a){
        rollno=r;
        name=n;
        address=a;
    }
    public void input(int r){
        rollno=r;
    }
    public void output(){
        Console.WriteLine(rollno,name,address,college);
    }
}
