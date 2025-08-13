namespace Assignment_6
{
    internal abstract class Discount
    {
        public abstract decimal CalculateDiscount(decimal price, int quantity);
        public string? Name { get; set; }
    }
}
