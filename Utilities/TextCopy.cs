using System;
using System.IO;
using System.Threading.Tasks;

namespace FileCopyTextReplacer.Utilities
{
    public class TextCopy : IDisposable
    {
        private readonly TextReader reader;
        private readonly TextWriter writer;
        private readonly TextParser parser;

        public TextCopy(TextReader reader, TextWriter writer, TextParser parser)
        {
            this.reader = reader;
            this.writer = writer;
            this.parser = parser;
        }

        public void Dispose()
        {
            reader.Dispose();
            writer.Dispose();
        }

        public async Task ParseAsync(string oldText, string newText)
        {
            while (reader.Peek() > -1)
            {
                var newContent = parser.Parse(
                    await reader.ReadLineAsync(),
                    oldText,
                    newText
                );
                await writer.WriteLineAsync(newContent);
            }
        }
    }
}
