using System;

class Program
{
    static void Main()
    {
        try
        {
            
            PerformOperation();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Caught exception: {ex.Message}");

           
            RethrowException(ex);
        }
    }

    static void PerformOperation()
    {
        try
        {
            
            throw new InvalidOperationException("Something went wrong in PerformOperation");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Caught exception in PerformOperation: {ex.Message}");

            
            throw;
        }
    }

    static void RethrowException(Exception ex)
    {
        try
        {
            
            Console.WriteLine($"Handling rethrown exception: {ex.Message}");
        }
        catch (Exception)
        {
            
            Console.WriteLine("Exception handling code here");
        }
    }
}
