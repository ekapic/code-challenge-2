namespace CalculoEstadisticas.Utils
{
    public static class StringExtension
    {
        public static bool IsIntegerAndGreaterThanZero(this string s)
        {
            int output;
            return int.TryParse(s, out output) && output >= 0;
        }
    }
}
