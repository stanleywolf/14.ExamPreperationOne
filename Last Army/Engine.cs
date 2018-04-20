using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Engine
{
    private const string input_terminated_string = "Enough! Pull back!";

    private IReader reader;
    private IWriter writer;
    private GameController gameController;

    public Engine(IReader reader, IWriter writer)
    {
        this.reader = reader;
        this.writer = writer;
    }

    public void Run()
    {
        var input = reader.ReadLine();
        var gameComtroller = new GameController(writer);
        

        while (!input.Equals(input_terminated_string))
        {
            try
            {
                gameComtroller.GiveInputToGameController(input);
            }
            catch (ArgumentException arg)
            {
                writer.AppendLine(arg.Message);
            }
            input = reader.ReadLine();
        }

        gameComtroller.RequestResult();
        writer.WriteLineAll();
    }
}