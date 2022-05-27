using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLogicLayer.Service.Interface;
using DataAccessLayer.Dao.Interface;
using DataAccessLayer.Dao.Implement;
using CMUtility;


namespace BusinessLogicLayer.Service.Implement
{
    public partial class DoProcMethodService : IDoProcMethodService
    {
        private IDoProcMethodDao _DoProcMethodDao;
        public IDoProcMethodDao DoProcMethodDao
        {
            get
            {
                if (_DoProcMethodDao == null)
                {
                    _DoProcMethodDao = (IDoProcMethodDao)(new RepositoryFactory()).Service("DoProcMethodDao");
                }

                return _DoProcMethodDao;
            }
            set
            {
                _DoProcMethodDao = value;
            }
        }
    }
}
