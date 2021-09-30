namespace FileCopyTextReplacer.Utilities
{
    public class TextParser
    {
        public string Parse(string text, string find, string replace) =>
            text.Replace(find, replace);
    }
}
