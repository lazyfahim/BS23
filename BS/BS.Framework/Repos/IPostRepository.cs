using BS.Data;
using BS.Framework.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BS.Framework.Repos
{
    public interface IPostRepository : IRepository<Post, int, FrameworkContext>
    {
    }
}
