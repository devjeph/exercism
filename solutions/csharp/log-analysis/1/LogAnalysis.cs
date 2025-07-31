public static class LogAnalysis
{
    
    public static string SubstringAfter(this string message, string delimiter) => message.Split(delimiter)[1];

    public static string SubstringBetween(this string message, string leftChar, string rightChar) => 
        message.Split(leftChar)[1].Split(rightChar)[0];

    public static string Message(this string message) => message.SubstringAfter("]: ");

    public static string LogLevel(this string message) => message.SubstringBetween("[","]");
    
}
