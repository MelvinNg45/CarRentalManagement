using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using CarRentalManagement.Client.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Toolbelt.Blazor.Extensions.DependencyInjection;

namespace CarRentalManagement.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddHttpClient("CarRentalManagement.ServerAPI", (sp,client) =>
            {
                client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress); client.EnableIntercept(sp);
            })
                .AddHttpMessageHandler<BaseAddressAuthorizationMessageHandler>();

            // Supply HttpClient instances that include access tokens when making requests to the server project
            builder.Services.AddScoped(sp => sp.GetRequiredService<IHttpClientFactory>().CreateClient("CarRentalManagement.ServerAPI"));

            builder.Services.AddHttpClientInterceptor();

            builder.Services.AddApiAuthorization();

            builder.Services.AddScoped<HttpInterceptorService>();

            await builder.Build().RunAsync();
        }
    }
}
