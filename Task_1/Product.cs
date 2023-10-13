namespace Task_1
{
    class Product 
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public int Rating { get; set; }

        public Product(string name, double price, string description, string category, int rating)
        {
            Name = name;
            Price = price;
            Description = description;
            Category = category;
            Rating = rating;
        }

        
        public static Product Pistol => new Product("Pistol", 499.99, "Compact 9mm pistol", "Firearms", 4);
        public static Product Shotgun => new Product("Shotgun", 799.99, "12-gauge shotgun", "Firearms", 5);
        public static Product Rifle => new Product("Rifle", 1499.99, "5.56mm rifle", "Firearms", 4);
        public static Product Milk => new Product("Milk", 2.99, "Pasteurized milk", "Groceries", 4);
        public static Product CannedFood => new Product("Canned Food", 1.99, "Canned vegetables", "Groceries", 3);
        public static Product Water => new Product("Water", 0.99, "Bottled drinking water", "Groceries", 4);
    
    }
}