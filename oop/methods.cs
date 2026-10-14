public class Info
{
        public void DisplayInfo()
    {
        Console.WriteLine($"First Name: John");
        Console.WriteLine($"Last Name: Doe");
        Console.WriteLine($"Wage: 10");
        Console.WriteLine($"Logged Hours: 10");
    }

    public int CalculateWage(int loggedHours, int wage)
    {
        return loggedHours * wage;
    }

    public void Printnum(double num)
    {
        Console.WriteLine(num);
    }

    public void Printnumwithtax0(double n)
    {
        n = (double) n - (n * 0.03);
        Console.WriteLine(n);
    }

    public void Printnumwithtax(ref double n) // ref keyword is used to pass the argument by reference, allowing the method to modify the original variable's value.
    {
        n = (double) n - (n * 0.03);
        Console.WriteLine(n);
    }

    // Overloading methods is a feature in C# that allows you to define multiple methods with the same name but different parameter lists. This enables you to provide different implementations of a method based on the number or types of parameters passed to it.

    public void promote(double amount)
    {
        Console.WriteLine($"Promoted with amount: {amount}");
    }

    public void promote(double amount,string trip)
    {
        Console.WriteLine($"Promoted with amount: {amount} and trip: {trip}");
    }

    public void promote(double amount, string trip, string hotel)
    {
        Console.WriteLine($"Promoted with amount: {amount}, trip: {trip}, and hotel: {hotel}");
    }

    // Expertion body method 

    // The Old Way
    public bool IsEven(int number)
    {
        return number % 2 == 0;
    }

    public bool IsEven1(int number) => number % 2 == 0;

    

}


// out keyword is used to pass the argument by reference, but it requires that the method assigns a value to the parameter before the method returns. It is typically used when a method needs to return multiple values or when a method needs to indicate success or failure through an output parameter.
// var numstring = "123456";

// int number;
// if (!int.TryParse(numstring, out number))
// {
//     Console.WriteLine("Conversion failed.");
// }
// else
// {
//     Console.WriteLine($"Conversion successful: {number}");
// }
