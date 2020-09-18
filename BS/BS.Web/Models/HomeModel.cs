using Autofac;
using BS.Framework.Entities;
using BS.Framework.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BS.Web.Models
{
    public class HomeModel
    {
        private readonly IPostService postService;

        public HomeModel()
        {
            this.postService = Startup.AutofacContainer.Resolve<IPostService>();
        }

        public (IList<Post>, int, int) GetPosts(int pageNum, string SearchText) => postService.GetPosts(pageNum, SearchText);

        internal object GetAll(DataTableAjaxRequestModel tableModel)
        {
            var data = postService.GetPosts(tableModel.PageIndex,tableModel.SearchText);

            return new {
                recordsTotal = data.Item2,
                recordsFiltered = data.Item3,
                data = (from record in data.Item1
                        select new string[]
                        {
                            record.Title.ToString(),
                            record.UserName.ToString(),
                            "naan",
                            "naan"
                        }
                        )
            };
        }
    }
}
