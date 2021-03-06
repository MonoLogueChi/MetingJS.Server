using Aliyun.Serverless.Core.Http;
using Microsoft.AspNetCore.Hosting;

namespace MetingJS.Server.Fc
{
    public class FcRemoteEntrypoint : FcHttpEntrypoint
    {
        protected override void Init(IWebHostBuilder builder)
        {
            builder.UseStartup<Startup>();
        }
    }
}
