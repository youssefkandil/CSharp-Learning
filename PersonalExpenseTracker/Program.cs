using PersonalExpenseTracker;

// Expense.AddExpense(new Expense("Lunch", 150, "Food"));
// Expense.AddExpense(new Expense("Dinner", 200, "Food"));
// Expense.AddExpense(new Expense("Bus", 30, "Transport"));
// Expense.AddExpense(new Expense("Course", 500, "Education"));
// Expense.AddExpense(new Expense("Cinema", 120, "Entertainment"));


// Expense.AddExpense(new Expense("Coffee", 50, "Food"));
// Expense.AddExpense(new Expense("Invalid", 0, "Food"));
// Expense.AddExpense(new Expense("Invalid", -100, "Food"));

Expense.DisplayExpenses();
Console.WriteLine("\n\n");
Expense.GetExpensesByCategory("food");
Console.WriteLine("\n\n");
Expense.TotalExpenses();