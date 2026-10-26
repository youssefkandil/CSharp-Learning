using InventoryManagementSystem;

Product.AddProduct(new Product(1, "Chair", 6000m, 12, 3));
Product.AddProduct(new Product(2, "Desk", 9000m, 12, 3));
Product.AddProduct(new Product(3, "Pen", 20m, 0, 3));

Product.Display();

Product.TotalValue();

Product.Sell(1, 4);

Product.Display();

Product.TotalValue();









