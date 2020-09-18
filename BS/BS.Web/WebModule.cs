using Autofac;
using BS.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BS.Web
{
    public class WebModule : Module
    {
        private readonly string _connectionString;
        private readonly string _migrationAssemblyName;

        public WebModule(string connectionString, string migrationAssemblyName)
        {
            _connectionString = connectionString;
            _migrationAssemblyName = migrationAssemblyName;
        }

        protected override void Load(ContainerBuilder builder)
        {
            // Register Models here if need DI
            //Mapper Register

            // Admin Area
            //builder.RegisterType<Areas.Admin.Models.DashboardModel>();
            builder.RegisterType<HomeModel>();
            base.Load(builder);
        }
    }

}
