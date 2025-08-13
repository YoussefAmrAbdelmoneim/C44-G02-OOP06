namespace Assignment_6
{
    internal class BuyOneGetOneDiscount : Discount
    {
        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            if (quantity >1)
            {
                return (price / 2) * (quantity / 2);
            }
            else
            {
                return 0;
            }
        }
    }
}
