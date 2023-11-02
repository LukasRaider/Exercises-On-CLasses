using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee;

class Employee {
    private int id;
    private string firstName;
    private string lastName;
    private int salary;

    public Employee(int id, String firstName, String lastName, int salary) 
    { 
        this.id = id;
        this.firstName = firstName;
        this.lastName = lastName;
        this.salary = salary;
    }
    public int getId()
    {
        return id;
    }
    public string getFirstName()
    {
        return firstName;
    }
    public string getLastName()
    {
        return lastName;
    }
    public string getName()
    { 
        return firstName + " " + lastName;  
    }
    public int getSalary()
    {
        return salary;
    }
    public void setSalary(int salary) 
    {
        
    }
    public int getAnnualSalary()
    {
        return  salary * 12;
    }
    public int raiseSalary(int percent)
    {
        int newSalary;
        newSalary = salary * (percent / 100);
        salary += newSalary;
        return salary;
    }
    public String toString()
    {
        return($"Zamestanec[id = {id}, jmeno = {firstName} {lastName}, vyplata= {salary}]");
    }
}
class TestEmployee { 
    public static void Mainx()
    {
        Employee e1 = new Employee(1,"Mark","Buffalo",35000);
        Console.WriteLine(e1.toString());
        Console.WriteLine($"Vyplata procenta {e1.raiseSalary(15)}");
        Console.WriteLine($"Rocni mzda je {e1.getAnnualSalary()}");
    }

}
