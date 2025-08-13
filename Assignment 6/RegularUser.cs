namespace Assignment_6
{
    internal class RegularUser : User
    {
        public override Discount GetDiscount()
        {
            return new PercentageDiscount(){
            Name = "5% Regular Discount",
            Percentage = 5
            };
        }
    }
}
