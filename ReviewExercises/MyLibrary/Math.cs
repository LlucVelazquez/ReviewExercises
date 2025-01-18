namespace MyLibrary
{
    public static class Math
    {
        public static float CalculateDiscount (float preu,  float preuDescompte)
        {
            return (preuDescompte * 100) / preu;
        }
    }
}
