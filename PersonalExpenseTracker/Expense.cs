using System;
namespace PersonalExpenseTracker;

public class Expense
{
    const decimal budget = 10000m;

    public string Description { get; set; }
    public decimal Amount { get; set; }
    public string Category { get; set; }

    public static List<Expense> expenses = new();


    public Expense(string describtion, decimal amount, string category)
    {
        Description = describtion;
        Amount = amount;
        Category = category;
    }

    public static bool AddExpense(Expense Ex)
    {
        if (Ex.Amount <= 0)
        {
            Console.WriteLine("The Amount Must Be Positive");
            return false;
        }

        expenses.Add(Ex);
        Console.WriteLine("Expense added successfully.\n");
        return true;
    }

    public static void DisplayExpenses()
    {
        if (expenses.Count == 0)
        {
            Console.WriteLine("No expenses recorded.\n");
            return;
        }

        foreach (Expense expense in expenses)
        {
            Console.WriteLine($"Description: {expense.Description}, Amount: {expense.Amount:C}, Category: {expense.Category}");
        }
    }
    
    static decimal totalExpenses = 0;

    public static void TotalExpenses()
    {
        foreach (Expense expense in expenses)
        {
            totalExpenses += expense.Amount;
        }
        decimal remainingBudget = budget - totalExpenses;
        Console.WriteLine($"Total Expenses is {totalExpenses}, The remaining is {remainingBudget}");
    }

    public static void GetExpensesByCategory(string category)
{
    switch (category.ToLower())
    {
        case "food":
            category = "Food";
            break;

        case "transport":
            category = "Transport";
            break;

        case "education":
            category = "Education";
            break;

        case "entertainment":
            category = "Entertainment";
            break;

        default:
            Console.WriteLine("Invalid category.");
            return;
    }

    decimal total = 0;
    bool found = false;

    foreach (Expense Ex in expenses)
    {
        if (Ex.Category.Equals(category, StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine($"{Ex.Description} - {Ex.Amount}");
            total += Ex.Amount;
            found = true;
        }
    }

    if (found)
    {
        Console.WriteLine($"Total {category} expenses: {total}");
    }
    else
    {
        Console.WriteLine($"No expenses found for {category}.");
    }
}


}
