using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class CustomException:Exception
    {
        public ExceptionType type;
        public enum ExceptionType
        {
            PERSON_ALREADY_EXISTS
        }
        public CustomException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }

    }
}
