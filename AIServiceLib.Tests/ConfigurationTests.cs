using AIServiceLib.Core;
using Xunit;


namespace AiServiceLib.Tests
{
    public class ConfigurationTests
    {
        [Fact]
        public void Test1()
        {
            var settings = new AIServiceSettings();
            Assert.Equal("llama3.1", settings.DefaultModel);
            Assert.Equal("http://localhost:11434/", settings.Endpoint);
            Assert.Equal("Prompts/", settings.PromptFilesPath);
        }
    }
}
