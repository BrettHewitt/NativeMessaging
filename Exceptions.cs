using System;

namespace NativeMessaging
{
    [Serializable]
    public class NotRegisteredWithChromeException : Exception
    {
        public NotRegisteredWithChromeException(string message) : base(message) { }
    }
}
