
using System;
using System.Collections.Generic;

namespace InventoryManagementSystem;

class Product
{
    public static List<Product> Products = new();

    public int ID { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
    public int Min_Inventory_Level { get; set; }

    public Product(int id, string name, decimal price, int quantity, int minimumInventoryLevel)
    {
        ID = id;
        Name = name;
        Price = price;
        Quantity = quantity;
        Min_Inventory_Level = minimumInventoryLevel;
    }

    public static bool AddProduct(Product product)
    {
        if (Products.Exists(p => p.ID == product.ID))
        {
            Console.WriteLine("A product with this ID already exists.\n");
            return false;
        }

        if (product.Price < 0 || product.Quantity < 0 || product.Min_Inventory_Level < 0)
        {
            Console.WriteLine("Price, quantity, and minimum inventory level cannot be negative.\n");
            return false;
        }

        Products.Add(product);
        Console.WriteLine("Product added successfully.\n");
        return true;
    }

    public static void Display()
    {
        if (Products.Count == 0)
        {
            Console.WriteLine("No products available.\n");
            return;
        }

        foreach (Product product in Products)
        {
            string status;

            if (product.Quantity == 0)
            {
                status = "Out of Stock";
            }
            else if (product.Quantity <= product.Min_Inventory_Level)
            {
                status = "Low Stock";
            }
            else
            {
                status = "In Stock";
            }

            Console.WriteLine(
                $"ID: {product.ID} | Name: {product.Name} | Price: {product.Price:F2} | Quantity: {product.Quantity} | Status: {status}"
            );
        }

        Console.WriteLine();
    }

    public static void TotalValue()
    {
        decimal total = 0;

        foreach (Product product in Products)
        {
            total += product.Price * product.Quantity;
        }

        Console.WriteLine($"Total inventory value: {total:F2}\n");
    }

    public static bool Sell(int productId, int quantityToSell)
    {
        if (quantityToSell <= 0)
        {
            Console.WriteLine("Quantity to sell must be greater than zero.\n");
            return false;
        }

        Product? product = Products.Find(p => p.ID == productId);

        if (product == null)
        {
            Console.WriteLine("Product ID not found.\n");
            return false;
        }

        if (quantityToSell > product.Quantity)
        {
            Console.WriteLine("Not enough stock available.\n");
            return false;
        }

        product.Quantity -= quantityToSell;

        Console.WriteLine("Sale completed successfully.\n");
        return true;
    }
}
