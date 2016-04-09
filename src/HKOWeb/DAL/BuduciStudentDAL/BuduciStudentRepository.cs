using HKOWeb.Models.HKOWebModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HKOWeb.DAL.BuduciStudentDAL
{
    public class BuduciStudentRepository
    {
        public List<ZanimanjaOverview> generateListOfZanimanja()
        {
            List<ZanimanjaOverview> lListaZanimanja = new List<ZanimanjaOverview>();
            for (int i = 0; i < 5; i++)
            {
                lListaZanimanja.Add(new ZanimanjaOverview() { ZanimanjaOverviewID = i, zanimanjeNaziv = "Analitičar"+i, modulNaziv = "Mehatronika"+i, studijNaziv = "Preddiplomski"+i });
            }
            return lListaZanimanja;
        }
    }
}
