using System;
namespace BeaverChat.Core.EventHandlers
{
    public interface IMessageEventArgs
    {
        string Message { get; }
    }
}
