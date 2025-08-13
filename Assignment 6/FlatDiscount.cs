namespace Assignment_6
{
    internal class FlatDiscount : Discount
    {
        public decimal FlatAmount { get; set; }
        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            return FlatAmount * Math.Min(quantity,1);
        }
    }
}
