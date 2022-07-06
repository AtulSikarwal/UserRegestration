using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegestration
{
    public class UserRegistrationException : Exception
    {
        public enum ExceptionType
        {
           
            INVALID_FIRSTNAME,
            INVALID_LASTNAME,
            INVALID_EmailId,
            INVALID_PASSWORD,
            INVALID_MOBILE_NO
        }
           
            
         
        
        private readonly ExceptionType type;

        public UserRegistrationException(ExceptionType Type, String message) : base(message)
        {
            this.type = Type;
        }
    }
}