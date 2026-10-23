public delegate void StockPriceChangeHandller(Stock stock, decimal OldPrice);

public class Stock
{
    private string name;
    private decimal price;

    public event StockPriceChangeHandller OnPriceChanged;

    public string Name => this.name;

    public decimal Price{get => this.price ; set => this.price = value;}


#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.


    public Stock(string StockName)
    {
        this.name = StockName;
    }

    public void ChangePriceBy(decimal percent)
    {
        decimal OldPrice = this.price;
        this.price +=Math.Round(this.price*percent, 2);
        if(OnPriceChanged != null)
        {
            OnPriceChanged(this, OldPrice);
        }
    }




}

// var stock = new Stock ("Amazon");

// stock.Price = 100;

// // lambda expression to handle the event when the price changes

// stock.OnPriceChanged += (stock, OldPrice) =>
// {
//     if (OldPrice < stock.Price)
//     {
//         Console.ForegroundColor = ConsoleColor.Green;
//     }
//     else if (OldPrice > stock.Price)
//     {
//         Console.ForegroundColor = ConsoleColor.Red; 
//     }
//     else
//     {
//         Console.ForegroundColor = ConsoleColor.White;
//     }
//     Console.WriteLine($"The price of {stock.Name} has increased from {OldPrice} to {stock.Price}");
// };




// Console.WriteLine($"The price before changing : {stock.Price}");

// stock.ChangePriceBy(0.0m);

// Console.Write($"The price after changing : {stock.Price}");



