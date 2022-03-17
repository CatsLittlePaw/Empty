using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccessLayer.Dao.Interface;

namespace DataAccessLayer.Dao.Implement
{
    public partial class DoProcMethodDao : IDoProcMethodDao
    {
        /// <summary>
        /// 測試用Function
        /// </summary>
        /// <returns></returns>
        /// <history>
        /// 2022/03/17  Chris Liao  Create
        /// </history>
        public int TestFunction()
        {
            return 1234;
        }
    }
}
