namespace Domino_Challenge.Core.Helpers;

/// <summary>
/// Provides helper methods for console operations.
/// </summary>
public static class ConsoleHelper
{
    /// <summary>
    /// Clears the console screen if input and output are not redirected.
    /// This method ensures that the console is cleared only when it is not being redirected, 
    /// preventing exceptions that can occur when redirecting the console input/output streams.
    /// </summary>
    public static void ClearConsole()
    {
        // Check if the console input and output are not redirected (e.g., in a test environment or when piping input/output)
        if (!Console.IsInputRedirected && !Console.IsOutputRedirected)
        {
            // Clear the console screen if the condition is met
            Console.Clear();
        }
    }
}