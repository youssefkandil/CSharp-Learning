// int num = 5;
//Console.WriteLine(num);

//_________
// concatenation by using the + operator or $ sign like this $"{}"
// string s1 = "Youssef";
// string s2 = "Kandil";
//Console.WriteLine(s1+ " " + s2);

// string s3 = $"My name is {s1} {s2}";
//Console.WriteLine(s3);
//_________

// Limits of the data types in C#:

/*
Console.WriteLine($"sbyte: [{sbyte.MinValue} → {sbyte.MaxValue}]");  // [-128 → 127]
Console.WriteLine($"byte: [{byte.MinValue} → {byte.MaxValue}]");    // [0 → 255]
Console.WriteLine($"short: [{short.MinValue} → {short.MaxValue}]"); // [-32,768 → 32,767]
Console.WriteLine($"ushort: [{ushort.MinValue} → {ushort.MaxValue}]"); // [0 → 65,535]
Console.WriteLine($"int: [{int.MinValue} → {int.MaxValue}]");      // [-2,147,483,648 → 2,147,483,647]
Console.WriteLine($"uint: [{uint.MinValue} → {uint.MaxValue}]");    // [0 → 4,294,967,295]
Console.WriteLine($"long: [{long.MinValue} → {long.MaxValue}]");    // [-9,223,372,036,854,775,808 → 9,223,372,036,854,775,807]
Console.WriteLine($"ulong: [{ulong.MinValue} → {ulong.MaxValue}]"); // [0 → 18,446,744,073,709,551,615]

Console.WriteLine($"float: [{float.MinValue} → {float.MaxValue}]");    // [±1.5 × 10⁻⁴⁵ → ±3.4 × 10³⁸]
Console.WriteLine($"double: [{double.MinValue} → {double.MaxValue}]"); // [±5.0 × 10⁻³²⁴ → ±1.7 × 10³⁰⁸]
Console.WriteLine($"decimal: [{decimal.MinValue} → {decimal.MaxValue}]"); // [±1.0 × 10⁻²⁸ → ±7.9228 × 10²⁸]*/

// var vs Dynamic in C#:

var x = 10;
dynamic y = 10;

// x = "Hello"; // Compile-time Error

y = "Hello";    // Valid

Console.WriteLine(x + 5); // 15
Console.WriteLine(y + 5); // Hello5var x = 10;


// Exercise
