using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace MyProject
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = false)]
    public class WebApiLogTrackerAttribute : ActionFilterAttribute
    {
        //private readonly string Key = "_thisWebApiOnActionMonitorLog_";

        /// <summary>
        /// 调用时触发
        /// </summary>
        /// <param name="actionContext"></param>
        public override void OnActionExecuting(HttpActionContext actionContext)
        {

        }
        /// <summary>
        /// 产生错误
        /// </summary>
        /// <param name="actionExecutedContext"></param>
        public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        {
            //WebApiProp wenApiProp = actionExecutedContext.Request.Properties[Key] as WebApiProp;

            var ActionName = actionExecutedContext.ActionContext.ActionDescriptor.ActionName;
            var ControllerName = actionExecutedContext.ActionContext.ActionDescriptor.ControllerDescriptor.ControllerName;

            if (ControllerName != "Log") {
                BLogRecord log = new BLogRecord()
                {
                    ActionName = ActionName,
                    ControllerName = ControllerName + "Controller",
                    //STime = MonLog.ExecuteStartTime,\
                    ETime = DateTime.Now,
                    //CreateDate = DateTime.Now,
                    //ActionPara = MonLog.GetCollections(MonLog.ActionParams),
                    //TimeSpan = decimal.Parse((MonLog.ExecuteEndTime - MonLog.ExecuteStartTime).TotalSeconds.ToString()),
                    //IP = MonLog.GetIP()
                };
            }
        }
    }

    public class WebApiProp
    {
        public string ControllerName { get; set; }
        public string ActionName { get; set; }

        public DateTime ExecuteStartTime { get; set; }
        public DateTime ExecuteEndTime { get; set; }

        /// <summary>
        /// 请求的Action 参数
        /// </summary>
        public Dictionary<string, object> ActionParams { get; set; }

        /// <summary>
        /// Http请求头
        /// </summary>
        public string HttpRequestHeaders { get; set; }

        /// <summary>
        /// 请求方式
        /// </summary>
        public string HttpMethod { get; set; }

        /// <summary>
        /// 请求的IP地址
        /// </summary>
        public string IP { get; set; }

        /// <summary>
        /// 获取Action 参数
        /// </summary>
        /// <param name="Collections"></param>
        /// <returns></returns>
        public string GetCollections(Dictionary<string, object> Collections)
        {
            string Parameters = string.Empty;
            if (Collections == null || Collections.Count == 0)
            {
                return Parameters;
            }
            foreach (string key in Collections.Keys)
            {
                Parameters += string.Format("{0}={1}&", key, Collections[key]);
            }
            if (!string.IsNullOrWhiteSpace(Parameters) && Parameters.EndsWith("&"))
            {
                Parameters = Parameters.Substring(0, Parameters.Length - 1);
            }
            return Parameters;
        }

        /// <summary>
        /// 获取IP
        /// </summary>
        /// <returns></returns>
        public string GetIP()
        {
            string ip = string.Empty;
            if (!string.IsNullOrEmpty(System.Web.HttpContext.Current.Request.ServerVariables["HTTP_VIA"]))
                ip = Convert.ToString(System.Web.HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"]);
            if (string.IsNullOrEmpty(ip))
                ip = Convert.ToString(System.Web.HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"]);
            return ip;
        }
    }
}