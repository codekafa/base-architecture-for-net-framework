using Core.ExceptionHandling.Data.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ExceptionHandling.Data.Derived.Authentication
{
    public class NotAuthorizedException : BaseException, IAuthenticationException
    {
        private string _AuthenticationMessage;
        public NotAuthorizedException(string message) : base(message)
        {
            _AuthenticationMessage = message;
        }

        public NotAuthorizedException(string message, Exception innerException) : base(message, innerException)
        {
            _AuthenticationMessage = message;
        }

        public string AuthenticationMessage
        {
            get => _AuthenticationMessage; set
            {
                _AuthenticationMessage = value;
            }
        }
    }
}
