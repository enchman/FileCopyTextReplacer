using System;

namespace FileCopyTextReplacer.Utilities
{
    public class UserInput
    {
        public string SourcePath { get; private set; }

        public string DestinationPath { get; private set; }

        public string FindText { get; private set; }

        public string ReplaceText { get; private set; }

        public void Input()
        {
            InputSourcePath();
            InputDestinationPath();
            InputFindText();
            InputReplaceText();
        }

        private void InputSourcePath()
        {
            SourcePath = GetInput("Source file: ");
        }

        private void InputDestinationPath()
        {
            DestinationPath = GetInput("Destination file: ");
        }

        private void InputFindText()
        {
            FindText = GetInput("Find: ");
        }

        private void InputReplaceText()
        {
            ReplaceText = GetInput("Replace: ");
        }

        private string GetInput(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }
    }
}
