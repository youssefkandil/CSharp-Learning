// primary expressions is a term used in the C# language specification to refer to the most basic expressions that can be used in the language. These include literals, identifiers, and member access expressions. Primary expressions are the building blocks for more complex expressions and statements in C#.
// like math expressions, primary expressions can be combined and manipulated to create more complex expressions that perform calculations or operations on data. For example, a primary expression can be used to access a property of an object, which can then be used in a mathematical expression to calculate a value.
// the left hand side of the expression is called member lookup, and the right hand side is called member access. Member lookup is used to find the member of an object that is being accessed, while member access is used to retrieve the value of that member. In C#, member access can be performed using the dot operator (.) or the null-conditional operator (?.) for safe access to members of potentially null objects.

// var amount = Math.Sin(60); // This is a primary expression that calls the Sin method from the Math class to calculate the sine of 60 degrees. The result of this expression will be stored in the variable 'amount'.
// Console.WriteLine(amount); 

// void expression is a type of expression in C# that does not return a value. It is typically used to perform an action or side effect, such as printing to the console or modifying a variable. Void expressions are often used in methods that do not need to return a value, such as event handlers or utility functions.

// void SayHello()
// {
//     Console.WriteLine("Hello");
// }

// In this example, the SayHello method is a void expression that prints "Hello" to the console. It does not return any value, but it performs an action when called, if i try to call the method like this: var result = SayHello(); it will give an error because the method does not return any value. Instead, you can simply call the method without assigning it to a variable, like this: SayHello(); which will execute the method and print "Hello" to the console.


// Binary Operators
// var x = 2;
// var y = 5;
// Console.WriteLine($"x = {x}, y = {y}");
// Console.WriteLine($"x + y = {x + y}"); // Addition
// Console.WriteLine($"x - y = {x - y}"); // Subtraction
// Console.WriteLine($"x * y = {x * y}"); // Multiplication
// Console.WriteLine($"x / y = {x / y}"); // Division
// Console.WriteLine($"x % y = {x % y}"); // Modulus

// Null coalescing operator (??) is a binary operator in C# that returns the value of its left-hand operand if it is not null; otherwise, it returns the value of its right-hand operand. This operator is useful for providing default values for nullable types or reference types that may be null.

// string name = null;
// name = name ?? "Guest";
// Console.WriteLine(name);

// Null conditional operator (?.) is a binary operator in C# that allows you to safely access members of an object that may be null. It returns null if the left-hand operand is null, instead of throwing a NullReferenceException. This operator is useful for avoiding null reference errors when working with objects that may not be initialized.

// -- string s1 = null; not equal to s2 = ""; because s1 is null, and s2 is a string with a value of an empty string. The null conditional operator (?.) is used to safely access the ToUpper() method of the string object, which will return null if s1 is null. Therefore, s2 will be assigned a value of null, and the output of Console.WriteLine(s2) will be (null).

// string s1 = null;
// string s2 = s1?.ToUpper(); // s2 will be null because s1 is null
// Console.WriteLine(s2); // Output: (null)

 // Statement vs Statement blocks


Console.WriteLine("hi");    // Statement
{                            // Statement block
    Console.WriteLine("hi");
    Console.WriteLine("hi");
}

// Declaration Statement 
int a;

//--- Expression Statement
var name = "Issam";

//1. change state
name = name + "A";

//2. call something that change the state
name = name.ToUpper();

//3. Assignment
name = name + "A";

//4. Increment / decrement
var totalFriends = 150;
++totalFriends;   // 151
--totalFriends;   // 150
var x1 = 2;
Console.WriteLine(x1++);  // 2;
Console.WriteLine(x1);  // 3;

// 5. Object instansiation
object o = new object();








