using System;
using System.Text;

public class Writer:IWriter
{
    public StringBuilder stringBuilder;

    public Writer()
    {
        stringBuilder = new StringBuilder();
    }

    public void AppendLine(string line)
    {
        stringBuilder.AppendLine(line);
    }
    public void WriteLineAll()
    {
        Console.WriteLine(stringBuilder.ToString().Trim());
    }
}