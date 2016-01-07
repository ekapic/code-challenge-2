namespace CalculoEstadisticas.Utils
{
    public class Constants
    {
        public static class SelectFileOrConsole
        {
            public const string SelectFileOrConsoleText = "Introduzca el número 1 si desea meter los datos por consola, \n2 si desea leerlos por fichero";
            public const string Console = "1";
            public const string File = "2";
        }

        public static class ConsoleText
        {
            public const string StartProgram = "Por favor, introduzca los tiempos de respuesta del sitio web milisegundos.";
            public const string FinalizeProgram = "Para finalizar, introduzca la palabra 'done'.";
            public const string Separator = "************************************************************************";
            public const string IntroduceData = "Introduzca un número:";
            public const string PrintNumers = "Números: ";
        }

        public static class FileText
        {
            public const string PathFileText = "Leyendo archivo...";
            public const string PathFile = @"FileNumers.txt";
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
            public const string ErrorFileData = "no es válido, escriba un número valido.";
            public const string ErrorIntroduceData = "Número no válido, introdúzcalo de nuevo.";
            public const string FileNotFound = "Error al cargar el archivo.";
        }

        public const string Done = "DONE";
    }
}
