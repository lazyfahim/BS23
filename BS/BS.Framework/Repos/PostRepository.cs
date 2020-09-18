using BS.Data;
using BS.Framework.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BS.Framework.Repos
{
    public class PostRepository:Repository<Post,int,FrameworkContext>,IPostRepository
    {
        public PostRepository(FrameworkContext context):base(context)
        {
        }
    }
}
