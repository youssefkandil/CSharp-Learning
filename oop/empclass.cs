public class Employee
{
    // <Access Modifier> -> public, private, protected
    // Constant  --> <Access Modifier> <DataType> <ConstantName> = <Value>
    public const double TAX = 0.03;
    // <Access Modifier> -> public, private, protected
    // Fields  --> <Access Modifier> <DataType> <FieldName> = <IntialValue>
    public string FName;
    public string LName;
    public double Wage;
    public double LoggedHours;

    public void DisplayInfo()
    {
        Console.WriteLine($"First Name: {FName}");
        Console.WriteLine($"Last Name: {LName}");
        Console.WriteLine($"Wage: {Wage}");
        Console.WriteLine($"Logged Hours: {LoggedHours}");
    }
}