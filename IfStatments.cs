var score = 70;

// Basic if statement
if (score >= 90)
    Console.WriteLine("Excellent!");



// Basic if-else statement
if (score >= 90)
{
    Console.WriteLine("Excellent!");
}
else
{
    Console.WriteLine("Good job!");
}


// Basic if-else if-else statement
if (score >= 90)
{
    Console.WriteLine("Excellent!");
}
else if (score >= 80)
{
    Console.WriteLine("Great job!");
}
else if (score >= 70)
{
    Console.WriteLine("Good job!");
}
else
{
    Console.WriteLine("Keep trying!");
}


// Nested if statements
if (score >= 70)
{
    if (score >= 90)
    {
        Console.WriteLine("Excellent!");
    }
    else if (score >= 80)
    {
        Console.WriteLine("Great job!");
    }
    else
    {
        Console.WriteLine("Good job!");
    }
}
else
{
    Console.WriteLine("Keep trying!");
}


// Switch statement

switch (score)
{
    case int n when (n >= 90):
        Console.WriteLine("Excellent!");
        break;
    case int n when (n >= 80):
        Console.WriteLine("Great job!");
        break;
    case int n when (n >= 70):
        Console.WriteLine("Good job!");
        break;
    default:
        Console.WriteLine("Keep trying!");
        break;
}

// one value execute the same statement
var num = 3;
switch (num)
{
    case 1:
    case 3:
    case 5:
    case 7:
        Console.WriteLine("odd");
        break;
    case 2:
    case 4:
    case 6:
    case 8:
        Console.WriteLine("even");
        break;
}




object o1 = 3;
switch (o1)
{
    case int i:
        Console.WriteLine($"It's int,  sqr of{i}={i * i}");
        break;
    case string i:
        Console.WriteLine($"It's string ,capitalization of {i} = {i.ToUpper()}");
        break;
}



bool isVip = true;
switch (isVip)
{
    case bool s when s == true:
        Console.WriteLine("yes");
        break;
    case bool s:
        Console.WriteLine("no");
        break;
}



// Switch Expression
var cardNo = 13;
string cardName = cardNo switch
{
    1 => "ACE",
    13 => "KING",
    12 => "QUEEN",
    10 => "JACK",
    _ => cardNo.ToString()
};
Console.WriteLine(cardName);
