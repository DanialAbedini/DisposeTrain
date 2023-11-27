using System;
using System.IO;



public class FileReader : IDisposable
{
    private StreamReader reader;

    public FileReader(string filePath)
    {
        reader = new StreamReader(filePath);
    }


    public string ReadFileContent()
    {
        return reader.ReadToEnd();
    }
    public void Dispose()
    {
        if (reader != null)
        {
            reader.Dispose();
            reader = null;
        }
    }
}

public class ByUsing
{
    public void ReadAndPrintFileContent(string filePath)
    {
        using (FileReader fileReader = new FileReader(filePath))
        {
            string content = fileReader.ReadFileContent();
            Console.WriteLine("File content: " + content);
        }
    }

}

class Program
{
    static void Main()
    {
        ByUsing byusing = new ByUsing();
        byusing.ReadAndPrintFileContent("C:\\Users\\Lucifer\\Desktop\\exa.txt");
    }
}
