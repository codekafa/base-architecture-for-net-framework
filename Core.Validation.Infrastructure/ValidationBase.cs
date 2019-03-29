using Core.Model;
using Core.Validation.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Validation.Infrastructure
{
    public abstract class ValidationBase<T> where T : class, IModel
    {
        public T Item { get; protected set; }
        public bool IsValid { get; protected set; }
        public List<ValidationMessage> Messages { get; private set; }
        public ValidationBase(T item)
        {
            Item = item;
            Messages = new List<ValidationMessage>();
            IsValid = true;
            Validate();
        }

        protected abstract void Validate();
    }
}
