using System;
namespace BeaverChat.Core.EventHandlers
{
    public class MessageEventArgs : IMessageEventArgs
    {
        public string Message { get; }
        public string User { get; }

        public MessageEventArgs(string message, string user)
        {
            Message = message;
            User = user;
        }
    }
}
