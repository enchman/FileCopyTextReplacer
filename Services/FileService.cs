using FileCopyTextReplacer.Utilities;
using System.IO;

namespace FileCopyTextReplacer.Services
{
    class FileService
    {
        private readonly UserInput input;
        private readonly TextParser parser;

        public FileService(UserInput input, TextParser parser)
        {
            this.input = input;
            this.parser = parser;
        }

        public TextCopy GetCopier()
        {
            var reader = File.OpenText(input.SourcePath);
            var writer = File.CreateText(input.DestinationPath);
            return new TextCopy(reader, writer, parser);
        }
    }
}
