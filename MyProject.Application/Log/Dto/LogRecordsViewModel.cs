using Abp.Application.Services.Dto;
using Abp.Runtime.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Log.Dto
{
    #region Query
    public class LogRecordsQueryInput : PagedAndSortedResultRequestDto, IShouldNormalize
    {
        public void Normalize()
        {
            //base.Sorting = "PX,DLMC";
        }
    }


    public class LogRecordsQueryItem
    {
        /// <summary> 
        /// 方法名称
        /// </summary> 
        public string ActionName { set; get; }

        /// <summary> 
        /// 方法参数
        /// </summary> 
        public string ActionPara { set; get; }

        /// <summary> 
        /// 类别
        /// </summary> 
        public string Category { set; get; }

        /// <summary> 
        /// 内容
        /// </summary> 
        public string Contents { set; get; }

        /// <summary> 
        /// 控制器名称
        /// </summary> 
        public string ControllerName { set; get; }

        /// <summary> 
        /// 记录时间
        /// </summary> 
        public DateTime? CreateDate { set; get; }

        /// <summary> 
        /// 结束时间
        /// </summary> 
        public DateTime? ETime { set; get; }

        /// <summary> 
        /// Id 
        /// </summary> 
        public int ID { set; get; }

        /// <summary> 
        /// IP
        /// </summary> 
        public string IP { set; get; }

        /// <summary> 
        /// 日志级别
        /// </summary> 
        public string Level { set; get; }

        /// <summary> 
        /// 操作工号
        /// </summary> 
        public string OperatorCode { set; get; }

        /// <summary> 
        /// 操作时间
        /// </summary> 
        public string OperatorName { set; get; }

        /// <summary> 
        /// 开始时间
        /// </summary> 
        public DateTime? STime { set; get; }

        /// <summary> 
        /// 时间间隔
        /// </summary> 
        public decimal? TimeSpan { set; get; }

    }
    public class LogRecordsQueryOutput : PagedResultDto<LogRecordsQueryItem>
    { }

    #endregion
}
