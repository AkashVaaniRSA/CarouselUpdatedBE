using System;
using System.Collections.Generic;
using Carousel.DataAccess.Repositiories;
using Carousel.Models.Models;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carousel.BusinessLogicData.CarouselBusinessLogic
{

    public class CarouselBL
    {
        CarouselRepository dal;
        public CarouselBL()
        {
            dal = new CarouselRepository();
        }

        public List<CarouselModel> GetCarouselData()
        {
            return dal.GetCarouselData();
        }

        public List<CarouselModel> InsertCarouselData(CarouselModel saveData)
        {

            return dal.InsertCarouselData(saveData);
        }

        public string UpdateCarouselData(int carouselId, CarouselModel value)
        {
            return dal.UpdateCarouselData(carouselId, value);
        }

        public string DeleteCarouselData(int carouselId)
        {
            return dal.DeleteCarouselData(carouselId);
        }
    }
}



