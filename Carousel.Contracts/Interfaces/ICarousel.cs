using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carousel.Contracts.Interfaces
{
    public interface ICarousel
    { 
            int carouselId { get; set; }
            string applicationName { get; set; }
            string userName { get; set; }
            string carouselData { get; set; }
            DateTime validFrom { get; set; }
            DateTime validTo { get; set; }
            int isDeleted { get; set; }

    }
}
