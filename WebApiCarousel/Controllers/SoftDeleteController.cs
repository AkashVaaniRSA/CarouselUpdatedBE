using System;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;
using Carousel.BusinessLogicData.CarouselBusinessLogic;
using Carousel.Models.Models;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApiCarousel.Controllers
{

    [EnableCors("http://localhost:4200", "*", "GET,POST,PUT")]
    public class SoftDeleteController : ApiController
    {
        CarouselBL bl = new CarouselBL();

        public string Get(int carouselId)
        {
            return bl.DeleteCarouselData(carouselId);
        }

    }
}





