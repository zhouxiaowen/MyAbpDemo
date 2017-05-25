using Abp.Application.Services;
using MyProject.Log.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace MyProject.Log
{
    public interface ILogAppService : IApplicationService
    {
        [HttpGet]
        void AddLogRecord(BLogRecord input);

        [HttpGet]
        LogRecordsQueryOutput GetLogRecords();

        /// <summary>
        /// 查询日志记录列表
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        LogRecordsQueryOutput QueryLogRecords(LogRecordsQueryInput input);

    }


}
