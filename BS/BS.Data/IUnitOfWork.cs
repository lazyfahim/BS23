using System;
using System.Collections.Generic;
using System.Text;

namespace BS.Data
{
    public interface IUnitOfWork : IDisposable
    {
        void Save();
    }
}
