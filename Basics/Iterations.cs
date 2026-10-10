//1. while
var counter = 0;
while (counter < 10)
{
    Console.Write(counter + " ");
    ++counter;
}
counter = 0;
Console.WriteLine();

//2. do-while

do
{
    Console.Write(counter + " ");
    ++counter;
} 
while (counter < 10);
Console.WriteLine();

//3. for

for (var count = 0; count < 10; count++)
{
    Console.Write(count + " ");
}

Console.WriteLine();


//Fibonacci [0,1,1,2,3,5,8,13,21,34]

for (int count = 0, prev = 0, current = 1; count < 10; ++count)
{
    Console.Write(prev + " ");
    int newFib = prev + current;
    prev = current;
    current = newFib;
}

Console.WriteLine();

//4. foreach

foreach (char c in "Full stack Devoloper course")
{
    Console.Write(c + " ");
}

Console.WriteLine();

var arr = new int[] { 1, 2, 3 };
foreach (int i in arr)
{
    Console.Write(i + " ");
}

Console.WriteLine();

for (int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i] + " ");
}
Console.WriteLine();

//1. break

var j = 0;
while (j < 10)
{
    if (j > 5)
        break;
    Console.Write(j + " ");
    ++j;
}
Console.WriteLine();

//2. continue
for (int i = 0; i < 10; ++i)
{
    if (i % 2 == 0)
        continue;
    Console.Write(i + " ");
}
Console.WriteLine();

//3. goto
var u = 0;
start:
if (u < 5)
{
    Console.Write(u + " ");
    ++u;
    goto start;
}
Console.WriteLine();
