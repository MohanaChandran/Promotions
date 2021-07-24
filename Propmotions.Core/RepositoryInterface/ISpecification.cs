using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Propmotions.Core.Interface
{
    public interface ISpecification<T>
    {
        Expression<Func<T, bool>> Criteria { get; }
    }
}
