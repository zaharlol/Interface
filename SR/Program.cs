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
    static void Main(string[] args)
    {
        IPlus plus = new Plus();
        try
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int result = plus.Plus1(a, b);
            Console.WriteLine(result);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}