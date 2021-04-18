using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFreamwork;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController] // --> ATTRIBUTE / (JAVA)ANNOTATION
    public class ProductsController : ControllerBase
    {
        // Loosely coupled -- Gevşek bağımlılık
        // naming convention
        // IoC Container -- Inversion Of Control
        IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public List<Product> Get()
        {
            var result = _productService.GetAll();
            return result.Data;
        }
    }
}
