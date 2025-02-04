namespace CPPPPAdvancedProgramming6;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            var key = Console.ReadKey();
            if (key.Key == ConsoleKey.R) 
            {
                throw new CustomException("Bu cındır R tuşuna bastı!");
            }
        }
        catch (CustomException Exp) 
        {
            Console.WriteLine(Exp);
            Console.WriteLine(Exp.Message);
        }
    }
}

class CustomException : Exception 
{
    public CustomException(string msg) : base(msg) 
    {

    }
}