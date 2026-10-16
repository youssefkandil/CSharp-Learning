public class Date
{
    // public Date() // That is the default Constructor that the c# impliment if you don't
    // {
        
    // }


    // public int Day;
    // public int Month;
    // public int Year;


    // Validatian

    private static readonly int[] DaysToMonth365 =
    { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

    private static readonly int[] DaysToMonth366 =
    { 0, 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };


    private readonly int  day = 01;
    private readonly int month = 01;
    private readonly int year= 1900;


    // Constructor

    public Date(int day, int month, int year)
    {
        var IsLeap = year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);

        if (year >= 1900 && year <= 2026 && month >=1 && month <= 12)
        {
            int[] days = IsLeap ? DaysToMonth366 : DaysToMonth365;
            if(day >= 1 && day <= days[month])
            {
                this.day = day;
                this.month = month;
                this.year = year;
            }
        }
    }
    
    // Overloading Constractor


    public Date(int year) : this(01, 01, year){} //  01/01/any year entared
    public Date(int month, int year) : this(01, month, year){} // 01/any month entared/any year entared

    
    public string GetDate()
    {
        return $"{day.ToString().PadLeft(2,'0')}/{month.ToString().PadLeft(2,'0')}/{year.ToString().PadLeft(4,'0')}";
    }
}    

// → How to deal with private constractor

// namespace OOPConstructor
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Employee e1 = Employee.Create(1000, "Issam", "A.");

//             Console.WriteLine(e1.DisplayName());
//             Console.ReadKey();
//         }
//     }

//     public class Employee
//     {
//         private Employee() { }
//         private Employee(int id, string fname, string lname)
//         {
//             this.id = id;
//             this.fName = fname;
//             this.lName = lname;

//         }

//         public static Employee Create(int id, string fname, string lname)
//         {
//             return new Employee(id, fname, lname);
//         }

//         private int id;
//         private string fName;
//         private string lName;

//        public string DisplayName()
//         {
//             return $"Id: {id} Name:{fName} {lName}\n";
//         }
//     }
// }