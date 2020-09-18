using BS.Framework.Repos;
using System;
using System.Collections.Generic;
using System.Text;

namespace BS.Framework.UOW
{
    public interface IPostUnitOfWork
    {
        public IPostRepository PostRepository { get; }
    }
}
