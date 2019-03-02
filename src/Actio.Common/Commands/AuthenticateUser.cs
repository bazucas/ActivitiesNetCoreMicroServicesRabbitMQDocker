using Actio.Common.Events;

namespace Actio.Common.Commands
{
    public class AuthenticateUser : ICommand, IRejectedEvent
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string Reason { get; }
        public string Code { get; }
    }
}