namespace CalculoEstadisticas.Utils
{
    public class Constants
    {
        public static class ConsoleText
        {
            public const string StartProgram = "Por favor, introduzca los tiempos de respuesta del sitio web milisegundos";
            public const string FinalizeProgram = "Para finalizar, introduzca la palabra 'done'";
            public const string Separator = "************************************************************************";
            public const string IntroduceData = "Introduzca un número:";
            public const string PrintNumers = "Números: ";
        }

        public static class StatisticsText
        {
            public const string Separator = "*******************************Statistics*******************************";
            public const string NotValuesInArray = "No hay elementos introducidos, no se puede calcular las estadísticas.";
            public const string Average = "El promedio es";
            public const string Min = "El mínimo es";
            public const string Max = "El máximo es";
            public const string StandardDeviation = "La desviación estándar es";
        }

        public static class Errors
        {
            public const string ErrorIntroduceData = "Número no válido, introdúzcalo de nuevo";
        }

        public const string Done = "DONE";
    }
}
