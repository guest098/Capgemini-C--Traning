using CalculatorFrontend.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace CalculatorFrontend
{
    public class Program
    {
        public static async Task Main(string[] args) // ✅ Make Main async
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            // Register HttpClient for API calls
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:5001/") });

            await builder.Build().RunAsync(); // ✅ Await inside an async method
        }
    }
}
