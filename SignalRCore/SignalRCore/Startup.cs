using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace SignalRCore
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection service)
        {
            service.AddSignalR();

        }
        public void configure(IApplicationBuilder appbuilder)
        {
            appbuilder.UseRouting();
            appbuilder.UseEndpoints(endpoints =>
            {
                endpoints.MapHub<Feed>("/nmea");
            });
        }
    }
}
