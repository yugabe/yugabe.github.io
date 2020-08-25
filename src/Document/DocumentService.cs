using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace YuGabe.GitHub.io.Document
{
    public class DocumentService
    {
        public DocumentService(JSFunctions jsFunctions) => JSFunctions = jsFunctions;

        private JSFunctions JSFunctions { get; }

        public async Task<bool> ScrollToElementIdAsync(string elementId) => await JSFunctions.ScrollToElementIdAsync(elementId);
    }
}
