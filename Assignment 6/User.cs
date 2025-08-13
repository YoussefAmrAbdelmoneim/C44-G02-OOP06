namespace Assignment_6
{
    internal abstract class User
    {
        public string? Name { get; set; }
        public abstract Discount GetDiscount();
    }
}
