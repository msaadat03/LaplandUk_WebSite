using Back_end.Models;
using System.Collections.Generic;

namespace Back_end.ViewModels
{
    public class OurStoryVM 
    {
        public OurStoryTitle OurStoryTitles { get; set; }
        public List<RedBook> RedBooks { get; set; }
        public RedBookimg RedBookimgs { get; set; }
        public List<RedBookPage> RedBookPages { get; set; }
        public RedBookApp RedBookApps { get; set; }



    }
}
