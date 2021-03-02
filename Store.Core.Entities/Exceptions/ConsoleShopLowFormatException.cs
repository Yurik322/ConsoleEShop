using System;
using System.Runtime.Serialization;

namespace Store.Core.Entities.Exceptions
{
    [Serializable]
    class ConsoleShopLowFormatException:Exception
    {
        public ConsoleShopLowFormatException() { }

        public ConsoleShopLowFormatException(string message) { }
        protected ConsoleShopLowFormatException(SerializationInfo info, StreamingContext context) : base(info, context) { }

    }
}
