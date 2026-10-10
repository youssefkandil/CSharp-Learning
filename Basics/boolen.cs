var x= 10;
var y= 20;
// Console.WriteLine(x==y);

// var result1 = !(x == y); 
// var result2 = (x > y); 
// var result3 = (x < y); 
// Console.WriteLine(result1);
// Console.WriteLine($"{result1} {result2} {result3}"); // false false true

// condition ? valueIfTrue : valueIfFalse;


Console.Write("Enter your age: ");
int age = int.Parse(Console.ReadLine());

string result = age >= 18 ? "Adult" : "Not Adult";

Console.WriteLine(result);