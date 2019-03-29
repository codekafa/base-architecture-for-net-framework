using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ExceptionHandling.Data.Infrastructure
{
    public  interface IAuthenticationException
    {
        string AuthenticationMessage { get; set; }
    }
}
