namespace Assignment_6
{
    internal class GuestUser : User
    {
        public override Discount GetDiscount()
        {
            return null;
        }
    }
}
