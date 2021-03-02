using System;
using System.Runtime.Serialization;

namespace Store.Core.Entities.Exceptions
{
    [Serializable]
    public class ConsoleShopLowArgumentException : Exception
    {
        public ConsoleShopLowArgumentException() { }
        public ConsoleShopLowArgumentException(string message) { }
        protected ConsoleShopLowArgumentException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
