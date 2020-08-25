using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YuGabe.GitHub.io.Document
{
    public class JSFunctions
    {
        public JSFunctions(IJSRuntime jSRuntime) => JSRuntime = jSRuntime;

        private IJSRuntime JSRuntime { get; }

        public async Task<bool> ScrollToElementIdAsync(string elementId, string color = "#88000e", int timeout = 3000)
            => await JSRuntime.InvokeAsync<bool>("scrollToElementId", elementId, color, timeout);
    }
}
