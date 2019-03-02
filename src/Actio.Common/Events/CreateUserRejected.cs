namespace Actio.Common.Events {
    public class CreateUserRejected : IRejectedEvent {
        public string Email { get; }
        public string Reason { get; }
        public string Code { get; }

        protected CreateUserRejected () { }
        private readonly string email;
        private readonly string reason;
        private readonly string code;

        public CreateUserRejected (string email, string reason, string code) {
            Code = code;
            Reason = reason;
            Email = email;
        }
    }
}