using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HKOWeb.Models.HKOWebModels
{
    public class ZanimanjaOverview
    {
        [Index(IsUnique = true)]
        public int ZanimanjaOverviewID { get; set; }
        [Display(Name = "Naziv zanimanja")]
        public string zanimanjeNaziv { get; set; }
        [DisplayName("Naziv modula")]
        public string modulNaziv { get; set; }
        [DisplayName("Naziv studija")]
        public string studijNaziv { get; set; }
    }
}
