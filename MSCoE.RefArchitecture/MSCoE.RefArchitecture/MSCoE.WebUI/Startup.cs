﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MSCoE.WebUI.Startup))]
namespace MSCoE.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
