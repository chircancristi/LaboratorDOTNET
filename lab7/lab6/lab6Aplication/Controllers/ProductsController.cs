using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab7.Business;
using Lab7.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Aplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ItRepository _repository;
        public ProductsController(ItRepository repository)
        {
            _repository = repository;
        }
        /*
        [HttpGet("{id}", Name = "GetById")]
        public ActionResult<ICollection<Products>> Get(Guid id)
        {
            ICollection<Products> products = new List<Products>();
           //return  _repository.GetAll().ElementAt(id);
        }*/

        public Products getProduct(ShoppingCart shoppingCart,Guid id)
        {
            return shoppingCart.getProductById(id);
        }


    }
}