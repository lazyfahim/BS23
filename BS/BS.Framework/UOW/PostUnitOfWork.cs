using BS.Data;
using BS.Framework.Repos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BS.Framework.UOW
{
    public class PostUnitOfWork : UnitOfWork, IPostUnitOfWork
    {
        public PostUnitOfWork(FrameworkContext context, IPostRepository postRepository) : base(context)
        {
            PostRepository = postRepository;
        }

        public IPostRepository PostRepository { get; private set; }
    }
}
