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
    [Route("api/[controller]")]
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
        public void TestAPI()
        {
            _DoProcMethodService.TestFunction("123");
        }
    }
}
