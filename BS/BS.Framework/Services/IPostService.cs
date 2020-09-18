using BS.Framework.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BS.Framework.Services
{
    public interface IPostService
    {
        (IList<Post>, int, int) GetPosts(int pageNum, string searchText);
    }
}
