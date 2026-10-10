
var product = "Office Chair";
var unitPrice = 6000;
var quantity = 1;

var total = unitPrice * quantity;
var finalTotal = total;

if (total >= 5000)
{
    finalTotal = total - total * 0.1;
}
else if (total >= 2000)
{
    finalTotal = total - total * 0.05;
}

Console.WriteLine($"Product: {product}");
Console.WriteLine($"Quantity: {quantity}");
Console.WriteLine($"Total before discount: {total}");
Console.WriteLine($"Final total: {finalTotal}");
