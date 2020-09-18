using System;
using System.Collections.Generic;
using System.Text;

namespace BS.Data
{
    public interface IEntity<T>
    {
        T Id { get; set; }
    }
}
