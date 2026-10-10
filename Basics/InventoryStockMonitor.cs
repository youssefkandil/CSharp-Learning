string [] products = new string [] {"Chair", "Office", "Desk", "Pen", "Paper"};

// for (int i = 0; i < products.Length; i++)
// {
//     Console.WriteLine(products[i]);
//     Console.WriteLine();
// }

int [] quantity = new int [] {5, 10, 11, 20, 90};

string[] statuss = new string[products.Length];

for (int item = 0; item < quantity.Length; item++)
{
    if (quantity[item] == 0)
    {
        statuss[item] = "Out of Stock";
    }
    else if (quantity[item] < 10)
    {
        statuss[item] = "Low Stock";
    }
    else
    {
        statuss[item] = "In Stock";
    }
}

for (int i = 0; i < products.Length; i++)
{
    Console.WriteLine(
        $"Product: {products[i]} → Quantity: {quantity[i]} → Status: {statuss[i]}"
    );
}







