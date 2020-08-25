using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;
using YuGabe.GitHub.io.Document;

namespace YuGabe.GitHub.io
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");
            builder.Services
                .AddSingleton<DocumentService>()
                .AddSingleton<JSFunctions>();
            await builder.Build().RunAsync();
        }
    }
}
