var sales= new int [7] {2975, 9781, 4673, 6489, 8056, 1368, 5094};

var total_sales = sales.Sum();
var avg_sales = sales.Average();
var min_sale= sales.Min();
var max_sale= sales.Max();
int counter = 0;
Console.WriteLine("Week Report");
Console.WriteLine($"Total Sales {total_sales}");
Console.WriteLine($"AVG Sales: {avg_sales:N2}");
Console.WriteLine($"Max Sales {max_sale}");
Console.WriteLine($"Min Sales {min_sale}");

foreach (var num in sales)
{
    if (num> avg_sales)
    {
        // Console.WriteLine(num);
        counter++;
    }
}
Console.WriteLine($"Days Above Average: {counter}");
if (total_sales >= 50000)
{
    Console.WriteLine("Target Achieved");
}
else
{
    Console.WriteLine("Target Not Achieved");
}
