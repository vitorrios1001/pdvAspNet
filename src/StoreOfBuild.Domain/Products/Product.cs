namespace StoreOfBuild.Domain.Products
{
    public class Product
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public Category Category { get; private set; }
        public decimal Price { get; private set; }
        public int StockQuantity { get; private set; }

        public Product(string name, Category category, decimal price, int stockquatity)
        {
            ValidateValues(name, category, price, stockquatity);
            SetProperties(name, category, price, stockquatity);
        }

        public void Update(string name, Category category, decimal price, int stockquatity)
        {
            ValidateValues(name, category, price, stockquatity);
            SetProperties(name, category, price, stockquatity);
        }

        private void SetProperties(string name, Category category, decimal price, int stockquatity)
        {
            Name = name;
            Category = category;
            Price = price;
            StockQuantity = stockquatity;
        }

        private static void ValidateValues(string name, Category category, decimal price, int stockquatity)
        {
            DomainException.When(string.IsNullOrEmpty(name), "Name is required");
            DomainException.When(category == null, "Category is required");
            DomainException.When(price < 0, "Prece is required");
            DomainException.When(stockquatity < 0, "Stock quatity is required ");
        }
    }
}