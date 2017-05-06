using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    /// <summary>
    /// 系统_日志记录表
    /// </summary>
    public class BLogRecord: Entity
    {
        ///// <summary>
        ///// Id
        ///// </summary>
        //public virtual int Id { get; set; }

        /// <summary>
        /// 记录时间
        /// </summary>
        public virtual DateTime? CreateDate { get; set; }

        /// <summary>
        /// 类别
        /// </summary>
        public virtual string Category { get; set; }

        /// <summary>
        /// 日志级别：error  warn
        /// </summary>
        public virtual string Level { set; get; }

        /// <summary>
        /// 控制器名称
        /// </summary>
        public virtual string ControllerName { get; set; }

        /// <summary>
        /// 方法名称
        /// </summary>
        public virtual string ActionName { get; set; }

        /// <summary>
        /// 方法参数
        /// </summary>
        public virtual string ActionPara { get; set; }

        /// <summary>
        /// 内容
        /// </summary>
        public virtual string Contents { get; set; }

        /// <summary>
        /// 操作工号
        /// </summary>
        public virtual string OperatorCode { get; set; }

        /// <summary>
        /// 操作姓名
        /// </summary>
        public virtual string OperatorName { get; set; }

        /// <summary>
        /// IP
        /// </summary>
        public virtual string IP { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        public virtual DateTime? STime { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        public virtual DateTime? ETime { get; set; }

        /// <summary>
        /// 时间间隔
        /// </summary>
        public virtual decimal? TimeSpan { get; set; }

        /// <summary>
        /// 机构ID
        /// </summary>
        public virtual string TenantId { get; set; }
    }
}
