using Back_end.Models;
using System.Collections.Generic;

namespace Back_end.ViewModels
{
    public class LocationVm
    {
        public LocationTitle LocationTitles { get; set; }
        public List<CompasContent> CompasContents { get; set; }
        public GoldeBell GoldeBells { get; set; }
        public Compass Compasses { get; set; }
        public List<GoldenContents> GoldenContentsses { get; set; }

    }
}
