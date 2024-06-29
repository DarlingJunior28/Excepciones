using System;

public class InvalidUsernameException : Exception
{
    public InvalidUsernameException(string message) : base(message)
    {
    }
}

public class InvalidPasswordException : Exception
{
    public InvalidPasswordException(string message) : base(message)
    {
    }
}

public class Program
{
    public static void Main()
    {
        try
        {
            Console.Write("Ingrese su nombre de usuario: ");
            string username = Console.ReadLine();
            ValidateUsername(username);

            Console.Write("Ingrese su contraseña (debe tener al menos 8 caracteres): ");
            string password = Console.ReadLine();
            ValidatePassword(password);

            Console.WriteLine("¡Nombre de usuario y contraseña válidos!");
        }
        catch (InvalidUsernameException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        catch (InvalidPasswordException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("Proceso de validación finalizado.");
        }
    }

    public static void ValidateUsername(string username)
    {
        if (string.IsNullOrWhiteSpace(username))
        {
            throw new InvalidUsernameException("El nombre de usuario no puede estar vacío.");
        }
    }

    public static void ValidatePassword(string password)
    {
        if (password.Length < 8)
        {
            throw new InvalidPasswordException("La contraseña debe tener al menos 8 caracteres.");
        }
    }
}
