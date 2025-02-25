using Actio.Common.Services;
using Actio.Common.Events;

namespace Actio.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ServiceHost.Create<Startup>(args)
            .UseRabbitMq()
            .SubscribeToEvent<ActivityCreated>()
            .Build()
            .Run();
        }

     
    }
}
