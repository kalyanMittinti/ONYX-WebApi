using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Onxy.DataAccess;
namespace ONYX_WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepo repo;

        public  ProductController(IProductRepo _repo)
        {
            _repo = repo;
            //repo.GetAll(0);

        }
        [HttpGet()]
        public List<ProductRepo> Get()
        {
            return repo.GetAll();
        }


    }
}
