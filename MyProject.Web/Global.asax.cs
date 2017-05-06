using System;
using Abp.Castle.Logging.Log4Net;
using Abp.Web;
using Castle.Facilities.Logging;
using System.Web.Http;

namespace MyProject.Web
{
    public class MvcApplication : AbpWebApplication<MyProjectWebModule>
    {
        protected override void Application_Start(object sender, EventArgs e)
        {
            AbpBootstrapper.IocManager.IocContainer.AddFacility<LoggingFacility>(
                            f => f.UseAbpLog4Net().WithConfig("log4net.config")
                        );

            //注册日志过滤器到全局过滤器中
            GlobalConfiguration.Configuration.Filters.Add(new WebApiLogTrackerAttribute());

            base.Application_Start(sender, e);
        }
    }
}
