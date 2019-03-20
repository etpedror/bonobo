using System;
using System.Collections.Generic;

namespace Bonobo.Parameters
{
    public interface IParameters
    {
        IEnumerable<string> Values { get; } 
    }
}