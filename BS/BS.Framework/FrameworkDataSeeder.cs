using BS.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BS.Framework
{
    public class FrameworkDataSeeder : DataSeeder
    {
        public FrameworkDataSeeder(FrameworkContext context) : base(context)
        {

        }

        public override Task SeedAsync()
        {
            throw new NotImplementedException();
        }
    }

}
