using System.Threading.Tasks;
using Actio.Common.Commands;
using RawRabbit;
using System;
using Actio.Common.Events;

namespace Actio.Services.Activities.Handlers
{
    public class CreateActivityHandler : ICommandHandler<CreateActivity>
    {
        private readonly IBusClient _busClient;
        public CreateActivityHandler(IBusClient busClient)
        {
            _busClient = busClient;
        }
        public async Task HandleAsync(CreateActivity command)
        {
           Console.WriteLine($"Creating Activity : '{command.Id}' for user: '{command.UserId}'");
           await _busClient.PublishAsync(new ActivityCreated(command.Id,
           command.UserId,
           command.Category,
           command.Name,
           command.Description,
           command.CreatedAt
           ));
        }
    }
}