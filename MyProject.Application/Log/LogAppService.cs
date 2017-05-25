using Abp.Domain.Repositories;
using MyProject.Log.Dto;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Log
{
    public class LogAppService : ILogAppService
    {
        private readonly IRepository<BLogRecord> _logRecordRepository;

        public LogAppService(IRepository<BLogRecord> logRecordRepository)
        {
            this._logRecordRepository = logRecordRepository;
        }

        /// <summary>
        /// 添加日志记录
        /// </summary>
        /// <param name="input"></param>
        public void AddLogRecord(BLogRecord input)
        {
            _logRecordRepository.Insert(input);
        }

        public LogRecordsQueryOutput GetLogRecords()
        {

            return QueryLogRecords(new LogRecordsQueryInput());
        }

        /// <summary>
        /// 查询日志记录列表
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public LogRecordsQueryOutput QueryLogRecords(LogRecordsQueryInput input)
        {
            if (input == null) return null;

            IQueryable<BLogRecord> tmpQuery = null;
            tmpQuery = _logRecordRepository.GetAll();
            //此处可以放查询过程

            var query = tmpQuery.Select(obj => new LogRecordsQueryItem()
            {
                ID = obj.Id,
                ActionName = obj.ActionName,
                ActionPara = obj.ActionPara,
                Category = obj.Category,
                Contents = obj.Contents,
                ControllerName = obj.ControllerName,
                CreateDate = obj.CreateDate,
                ETime = obj.ETime,
                IP = obj.IP,
                Level = obj.Level,
                OperatorCode = obj.OperatorCode,
                OperatorName = obj.OperatorName,
                STime = obj.STime,
                TimeSpan = obj.TimeSpan
            });
            int total = query.Count();
            var items = query.ToList();

            var output = new LogRecordsQueryOutput()
            {
                TotalCount = total,
                Items = new ReadOnlyCollection<LogRecordsQueryItem>(items)
            };
            return output;
        }

    }
}
