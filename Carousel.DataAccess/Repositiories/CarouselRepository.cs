using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using Carousel.Models.Models;
using System.Text;
using System.Threading.Tasks;
using Carousel.DataAccess.Interfaces;

namespace Carousel.DataAccess.Repositiories
{
   public class CarouselRepository : BaseRepository, ICarouselRepository
    {
        public List<CarouselModel> GetCarouselData()
        {
            List<CarouselModel> GetAllCarousel = new List<CarouselModel>();
            using (var dataset = GetDataset(ProcedureNames.spGetCarouselData))
            {
                var Carousel = dataset.Tables[0];
                var CarouselTableDetail = Carousel.AsEnumerable();

                foreach (var CarouselRow in CarouselTableDetail)
                {
                    GetAllCarousel.Add(PopulateData<CarouselModel>(CarouselRow));
                }
            }
            return GetAllCarousel;

        }


        public List<CarouselModel> InsertCarouselData(CarouselModel carousel)
        {
            List<CarouselModel> carouselInsert = new List<CarouselModel>();
            using (var dataset = GetDataset(ProcedureNames.SpInsert,
                    new SqlParameter("@applicationName", carousel.applicationName),
                    new SqlParameter("@userName", carousel.userName),
                    new SqlParameter("@carouselData", carousel.carouselData),
                    new SqlParameter("@validFrom", carousel.validFrom),
                    new SqlParameter("@validTo", carousel.validTo),
                    new SqlParameter("@isDeleted", carousel.isDeleted)))


            {
                try
                {
                    var Carousel = dataset.Tables[0];
                    var CarouselTableDetail = Carousel.AsEnumerable();

                    foreach (var CarouselRow in CarouselTableDetail)
                    {
                        carouselInsert.Add(PopulateData<CarouselModel>(CarouselRow));
                    }

                }
                catch (Exception io)
                {
                    Console.WriteLine(io);
                }

            }
            return carouselInsert;
        }

        public string UpdateCarouselData(int carouselId, CarouselModel data)
        {
            var status = GetValue<string>(ProcedureNames.spUpdate,
            new SqlParameter("@carouselId", carouselId),
            new SqlParameter("@applicationName", data.applicationName),
            new SqlParameter("@userName", data.userName),
            new SqlParameter("@carouselData", data.carouselData),
            new SqlParameter("@validFrom", data.validFrom),
            new SqlParameter("@validTo", data.validTo));
            return status;
        }

        public string DeleteCarouselData(int carouselId)
        {
            var status = GetValue<string>(ProcedureNames.spSoftDelete,
            new SqlParameter("@carouselId", carouselId));
            return status;
        }

    }
}






