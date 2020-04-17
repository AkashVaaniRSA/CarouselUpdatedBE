using System;
using System.Collections.Generic;
using Carousel.BusinessLogicData.CarouselBusinessLogic;
using Carousel.Models.Models;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;


namespace WebApiCarousel.Controllers
{
    [EnableCors("http://localhost:4200", "*", "GET,POST,PUT")]
    public class ValuesController : ApiController
    {

        CarouselBL bl = new CarouselBL();
        // GET api/values/5

        public IEnumerable<CarouselModel> Get()
        {
            return bl.GetCarouselData();
        }

        // POST api/values
        public IEnumerable<CarouselModel> Post([FromBody]CarouselModel value)
        {
            return bl.InsertCarouselData(value);

        }

        // PUT api/values/5
        public string Put(int carouselId, [FromBody]CarouselModel value)
        {
            return bl.UpdateCarouselData(carouselId, value);
        }

        // DELETE api/values/5
        public void Delete(int id)
        {

        }
    }
}




