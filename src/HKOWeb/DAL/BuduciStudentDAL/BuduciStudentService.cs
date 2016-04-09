using HKOWeb.Models.HKOWebModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HKOWeb.DAL.BuduciStudentDAL
{
    public class BuduciStudentService
    {
        #region members
        private BuduciStudentRepository buduciStudentRepository = new BuduciStudentRepository();
        #endregion
        public List<ZanimanjaOverview> generateListOfZanimanja()
        {
            return buduciStudentRepository.generateListOfZanimanja();
        }
    }
}
