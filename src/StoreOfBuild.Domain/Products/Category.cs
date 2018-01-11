namespace StoreOfBuild.Domain.Products
{
    public class Category : Entity
    {
        public string Name { get; private set; }
        protected Category(){}
        public Category(string name)
        {
            ValidateAndSetName(name);
        }

        public void Update(string name)
        {
            ValidateAndSetName(name);
        }

        private void ValidateAndSetName(string name)
        {
            DomainException.When(string.IsNullOrEmpty(name), "Name is required");
            DomainException.When(name.Length < 3, "Name invalid");

            Name = name;
        }


    }
}