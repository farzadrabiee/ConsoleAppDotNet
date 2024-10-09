namespace ConsoleAppUseClass;

public class Account
{
    public string Name { get; set; }
    
    public void Print()
    {
        Console.WriteLine($"Account Name: {Name}");
    }
}