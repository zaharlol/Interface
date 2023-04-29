public interface IPlus
{
    int Plus1(int a, int b);
}

public class Plus : IPlus
{
    public int Plus1(int a, int b)
    {
        int c = 0;
        try
        {
            c = a + b;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        return c;
    }
}
class Program
{
    static ILogger Logger { get; set; }
    static void Main(string[] args)
    {
        Logger = new Logger();
        var worker = new Worker1(Logger);
        IPlus plus = new Plus();
        try
        {
            Console.WriteLine("Введите первое число");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int b = Convert.ToInt32(Console.ReadLine());
            int result = plus.Plus1(a, b);
            worker.Work();
            Console.WriteLine("Результат {0}", result);
        }
        catch (Exception e)
        {
            Logger.Error(e.Message);

        }
        Console.ReadKey();
    }
}
public interface ILogger
{
    void Error(string messege);
    void Event(string messege);
}

public class Logger : ILogger
{
    public void Error(string messege)
    {
        Console.BackgroundColor = ConsoleColor.Red;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine(messege);
    }

    public void Event(string messege)
    {
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine(messege);
    }
}
public interface IWorker
{
    void Work();
}
public class Worker1 : IWorker
{
    ILogger Logger { get; }
    public Worker1(ILogger logger)
    {
        Logger = logger;
    }
    public void Work()
    {
        Logger.Event("");
    }
}