using System;
using System.Runtime.Serialization;

namespace Store.Core.Entities.Exceptions
{
    [Serializable]
    class ConsoleShopLowArgumentNullException:Exception
    {
        public ConsoleShopLowArgumentNullException() { }
        public ConsoleShopLowArgumentNullException(string message) { }
        protected ConsoleShopLowArgumentNullException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
