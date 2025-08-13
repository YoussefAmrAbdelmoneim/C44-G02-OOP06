namespace Assignment_6
{
    internal class PercentageDiscount : Discount
    {
        public int Percentage { get; set; }
        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            return price * quantity *(Percentage /100);
        }
    }
}
