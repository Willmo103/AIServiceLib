namespace AIServiceLib.Core
{
    public class AIServiceSettings
    {
        public string DefaultModel { get; set; } = "llama3.1";
        public string Endpoint { get; set; } = "http://localhost:11434/";
        public string PromptFilesPath { get; set; } = "Prompts/";
    }

}
