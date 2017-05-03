using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace MyProject.PersonApp
{
    public interface IPersonAppService : IApplicationService
    {
        [HttpGet]
        List<Person> GetPersonList();
    }
}
