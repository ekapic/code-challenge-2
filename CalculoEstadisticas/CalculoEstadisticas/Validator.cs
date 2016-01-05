namespace CalculoEstadisticas
{
    public class Validator
    {
        public bool IsValidNumber(string value, out int output)
        {
            return int.TryParse(value, out output);
        }
    }
}