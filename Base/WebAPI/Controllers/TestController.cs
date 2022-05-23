using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLogicLayer.Service.Interface;
using BusinessLogicLayer.Service.Implement;
using Spring.Transaction;
using CMUtility;

namespace WebAPI.Controllers
{
    [ApiController]
    public class TestController : ControllerBase
    {
        #region Properties
        private static IDoProcMethodService _DoProcMethodService;
        public IDoProcMethodService DoProcMethodService
        {
            get
            {
                if (_DoProcMethodService == null)
                {
                    _DoProcMethodService = (DoProcMethodService)(new RepositoryFactory()).Service("DoProcMethodService");
                }

                return _DoProcMethodService;
            }
        }
        #endregion

        [HttpPost]
        public string TestAPI(string str)
        {
            return str;
            //_DoProcMethodService.TestFunction(str);
        }

        [HttpGet]
        public string TestAPI2()
        {
            return "1234";
        }
    }
}
