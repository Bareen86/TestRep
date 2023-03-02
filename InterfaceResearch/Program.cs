interface IDataProvider
{
    string GetData();
}

interface IDataProcessor
{
    void ProcessData(IDataProvider dataProvider);
}

class ConsoleDataProcessor : IDataProcessor
{
    public void ProcessData(IDataProvider dataProvider)
    {
        Console.WriteLine(dataProvider.GetData());
    }
}

class DbDataProvider : IDataProvider
{
    public string GetData()
    {
        return "Данные из БД";
    }
}

class FileDataProvider : IDataProvider
{
    public string GetData()
    {
        return "Данные из файла";
    }
}

class APIDataProvider : IDataProvider
{
    public string GetData()
    {
        return "Данны из API";
    }
}

class Program
{
    static void Main(string[] args)
    {
        IDataProcessor dataProcessor = new ConsoleDataProcessor();
        DbDataProvider dbDataProvider = new DbDataProvider();
        dataProcessor.ProcessData(dbDataProvider);
        dataProcessor.ProcessData(new FileDataProvider());
        dataProcessor.ProcessData(new APIDataProvider());
    }
}
