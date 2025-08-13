namespace Assignment_6
{
    internal class PremiumUser : User
    {
        public override Discount GetDiscount()
        {
        return new FlatDiscount()
        {
            Name="$100 Premium Discount",
            FlatAmount =100
        };
        }
    }
}
