public class Writer : IWriter
{
    void IWriter.Write()
    {

    }
}
public interface IWorker
{
    public void Build();
}
public class Worker : IWorker
{
    public void Build()
    {
        Console.WriteLine("Rtrtc");
    }
}
public interface IWriter
{
    void Write();
}
public interface IReader
{
    void Read();
}
public interface IMailer
{
    void SendEmail();
}
public class FileManader : IMailer, IWriter, IReader
{
    public void Read()
    {
        throw new NotImplementedException();
    }

    public void SendEmail()
    {
        throw new NotImplementedException();
    }
    public void Write()
    {
        throw new NotImplementedException();
    }
}
public interface ICreatable
{
    void Create();
}
public interface IDeletable
{
    void Delete();
}
public interface IUpdatable
{
    void Update();
}
public class Entity : ICreatable,
IDeletable,
IUpdatable
{
    public void Create()
    {
        throw new NotImplementedException();
    }

    public void Delete()
    {
        throw new NotImplementedException();
    }

    public void Update()
    {
        throw new NotImplementedException();
    }
}
public interface IBook
{
    void Read();
}
public interface IDevice
{
    void TurnOn();
    void TurnOff();
}
public class ElectronicBook : IBook, IDevice
{
    void IDevice.TurnOff()
    {
        throw new NotImplementedException();
    }

    void IDevice.TurnOn()
    {
        throw new NotImplementedException();
    }

    void IBook.Read()
    {
        throw new NotImplementedException();
    }
}
class Program
{
    static void Main(string[] args)
    {
        Writer writer = new Writer();
        ((IWriter) writer) .Write();
        Console.WriteLine();

        var worker = new Worker();
        ((IWorker)worker).Build();
        Console.WriteLine();
    }
}