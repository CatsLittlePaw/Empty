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
using Microsoft.Extensions.Logging;


namespace WebAPI.Controllers
{
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

        private readonly ILogger<TestController> _logger;

        public TestController(ILogger<TestController> logger)
        {
            _logger = logger;
        }

        #endregion



        [HttpPost]
        public string TestAPI(dynamic str)
        {
            return  "sdf";// _DoProcMethodService.TestFunction();
        }

        [HttpGet]
        public string TestAPI2()
        {
            return "1234";
        }
    }
}
