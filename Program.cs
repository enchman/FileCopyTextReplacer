using FileCopyTextReplacer.Services;
using FileCopyTextReplacer.Utilities;
using System;
using System.Threading.Tasks;

namespace FileCopyTextReplacer
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var input = new UserInput();
            input.Input();

            var parser = new TextParser();
            var service = new FileService(input, parser);

            using (var copy = service.GetCopier())
            {
                await copy.ParseAsync(input.FindText, input.ReplaceText);
            }

            Console.WriteLine("Done");
        }
    }
}
