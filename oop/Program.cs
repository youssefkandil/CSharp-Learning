var stock = new Stock ("Amazon");

stock.Price = 100;

// lambda expression to handle the event when the price changes

stock.OnPriceChanged += (stock, OldPrice) =>
{
    if (OldPrice < stock.Price)
    {
        Console.ForegroundColor = ConsoleColor.Green;
    }
    else if (OldPrice > stock.Price)
    {
        Console.ForegroundColor = ConsoleColor.Red; 
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.White;
    }
    Console.WriteLine($"The price of {stock.Name} has increased from {OldPrice} to {stock.Price}");
};




Console.WriteLine($"The price before changing : {stock.Price}");

stock.ChangePriceBy(0.0m);

Console.Write($"The price after changing : {stock.Price}");



