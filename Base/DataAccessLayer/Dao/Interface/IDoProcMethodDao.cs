using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccessLayer.Dao.Interface
{
    public interface IDoProcMethodDao
    {
        /// <summary>
        /// 測試用Function
        /// </summary>
        /// <returns></returns>
        /// <history>
        /// 2022/03/17  Chris Liao  Create
        /// </history>
        string TestFunction(string seqNo);
    }
}
