using Microsoft.Owin;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

[assembly: OwinStartupAttribute(typeof(SiteEcommerceProject.Entity.ProductModels.Product))]
namespace Admin.Views
{
    public class StartUp
    {
        public void Configuration(IAppBuilder app)
        {
            Configuration(app);
        }
    }
}