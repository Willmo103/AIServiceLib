using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AIServiceLib.Core;
using AIServiceLib.Core.Interfaces;

namespace AIServiceLib.Tests
{
    internal class MockAiTask : IAITask
    {
        public Task RunAsync()
        {
            return Task.CompletedTask;
        }
    }

    internal class MockPromptProvider : IPromptProvider
    {
        public Task<string> GetPromptAsync(string promptName)
        {
            return Task.FromResult("Mock Prompt");
        }
    }

    public class InterfaceTests
    {
        [Fact]
        public void IAITaskTest()
        {
            MockAiTask task = new();
            Assert.NotNull(task);
        }

        [Fact]
        public void IPromptProviderTest()
        {
            MockPromptProvider provider = new();
            Assert.NotNull(provider);
        }
    }
}
