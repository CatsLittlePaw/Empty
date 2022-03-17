using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLogicLayer.Service.Interface;

namespace BusinessLogicLayer.Service.Implement
{
    public partial class DoProcMethodService : IDoProcMethodService
    {
        /// <summary>
        /// 測試用Function
        /// </summary>
        /// <param name="stepSeqNo">測試用變數</param>
        /// <returns></returns>
        /// <history>
        /// 2022/03/17  Chris Liao  Create
        /// </history>
        public void TestFunction(string stepSeqNo)
        {
            _DoProcMethodDao.TestFunction();
        }
    }
}
