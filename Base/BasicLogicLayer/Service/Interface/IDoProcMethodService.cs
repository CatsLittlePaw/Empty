using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Service.Interface
{
    public interface IDoProcMethodService
    {
        /// <summary>
        /// 測試用Function
        /// </summary>
        /// <param name="stepSeqNo">測試用變數</param>
        /// <returns></returns>
        /// <history>
        /// 2022/03/17  Chris Liao  Create
        /// </history>
        void TestFunction(string stepSeqNo);
    }
}
