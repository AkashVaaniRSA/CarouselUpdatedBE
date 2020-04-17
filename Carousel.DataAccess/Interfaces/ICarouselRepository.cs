using System;
using System.Collections.Generic;
using Carousel.Models.Models;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carousel.DataAccess.Interfaces
{
    public interface ICarouselRepository
    {
        List<CarouselModel> GetCarouselData();
        List<CarouselModel> InsertCarouselData(CarouselModel carousel);
        string UpdateCarouselData(int carouselId, CarouselModel data);

    }

}
