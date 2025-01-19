namespace MyLibrary
{
    public class Math
    {
        public static float DiscountPercentage(float initialPrice, float discountPrice)
        {
            return (discountPrice / initialPrice) * 100;
        }
    }
}
