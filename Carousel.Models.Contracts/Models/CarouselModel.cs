using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carousel.Contracts.Interfaces;


namespace Carousel.Models.Models
{
    public class CarouselModel:ICarousel
    {
        public int carouselId { get; set; }
        public string applicationName { get; set; }
        public string userName { get; set; }
        public string carouselData { get; set; }
        public DateTime validFrom { get; set; }
        public DateTime validTo { get; set; }
        public int isDeleted { get; set; }
        

    }
}




