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
      public  ProductController(IProductRepo repo)
        {
            repo.GetProducts();
        }



    }
}
