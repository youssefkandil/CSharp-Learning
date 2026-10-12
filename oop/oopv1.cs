// // First Way <Not Practical>

// // const double TAX = 0.03;

// using System.Xml.Serialization;

// Console.WriteLine("First Employee");
// Console.Write("First Name ");
// var FName = Console.ReadLine();
// Console.Write("Last Name ");
// var LName = Console.ReadLine();
// Console.Write("Wage ");
// var Wage = Convert.ToDouble(Console.ReadLine()); // The Convert Because the <Console.ReadLine()> Return String
// Console.Write("Logged Hours ");
// var LoggedHours = Convert.ToDouble(Console.ReadLine());

// var netSalary = Wage*LoggedHours - (Wage*LoggedHours*TAX);

// Console.WriteLine($"First Name :{FName}");
// Console.WriteLine($"Last Name :{LName}");
// Console.WriteLine($"Wage :{Wage}");
// Console.WriteLine($"Logged Hours :{LoggedHours}");
// Console.WriteLine($"Net Salary :{netSalary}");


// Console.WriteLine("Second Employee");
// Console.Write("First Name ");
// var FName1 = Console.ReadLine();
// Console.Write("Last Name ");
// var LName1 = Console.ReadLine();
// Console.Write("Wage ");
// var Wage1 = Convert.ToDouble(Console.ReadLine()); // The Convert Because the <Console.ReadLine()> Return String
// Console.Write("Logged Hours ");
// var LoggedHours1 = Convert.ToDouble(Console.ReadLine());

// var netSalary1 = Wage1*LoggedHours1 - (Wage1*LoggedHours1*TAX);

// Console.WriteLine($"First Name :{FName1}");
// Console.WriteLine($"Last Name :{LName1}");
// Console.WriteLine($"Wage :{Wage1}");
// Console.WriteLine($"Logged Hours :{LoggedHours1}");
// Console.WriteLine($"Net Salary :{netSalary1}");

// Third empolyee + Foruth empolyee + .... and so on
// it's not a practical way

// So we Using OOP

public class OOPV1
{
    public static void Run()
    {
        Employee e1 = new Employee();

        e1.FName = "John";
        e1.LName = "Doe";
        e1.Wage = 20.5;
        e1.LoggedHours = 40;

        e1.DisplayInfo();
    }
}