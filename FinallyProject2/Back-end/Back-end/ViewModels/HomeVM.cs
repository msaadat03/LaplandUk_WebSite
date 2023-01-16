using Back_end.Models;
using System.Collections.Generic;

namespace Back_end.ViewModels
{
    public class HomeVM
    {
        public List<Logo> Logos { get; set; }
        public HomeWorld HomeWorlds { get; set; }
        public HomeInvitation HomeInvitations { get; set; }
        public HomeAdventure HomeAdventures { get; set; }
        public List<JourneySlider> JourneySliders { get; set; }
        public HomeGallery HomeGalleries { get; set; }
        public List<SliderContent> SliderContents { get; set; }
        public List<SliderGallery> SliderGalleries { get; set; }
        public HomeMeet HomeMeets { get; set; }

    }
}
