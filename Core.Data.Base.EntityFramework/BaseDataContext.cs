using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Data.Base.EntityFramework
{
    public abstract class BaseDataContext : DbContext
    {
        public BaseDataContext()
        {
           
        }
        public BaseDataContext(string param) : base(param)
        {

        }
    }
}
