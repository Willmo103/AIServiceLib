using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIServiceLib.Core.Interfaces
{
    public interface IPromptProvider
    {
        Task<string> GetPromptAsync(string promptName);
    }
}
