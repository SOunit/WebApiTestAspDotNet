using System.Collections.Generic;
using System.Web.Http;
using WebApiTestAspDotNet.Models;

namespace WebApiTestAspDotNet.ApiControllers
{
    public class BrandsController : ApiController
    {
        public List<Brand> Get()
        {
            var brandsList = new List<Brand>();

            brandsList.Add(new Brand()
            {
                Id = 1,
                Name = "Test1"
            });

            return brandsList;
        }
    }
}
