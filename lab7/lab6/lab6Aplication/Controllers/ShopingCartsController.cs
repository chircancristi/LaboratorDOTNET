﻿using Lab7.Business;
using Lab7.Data;
using lab7Aplication.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab7Aplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShopingCartsController : ControllerBase
    {
        private readonly ItRepository _repository;
        public ShopingCartsController(ItRepository repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public ActionResult<IReadOnlyList<ShoppingCart>> Get()
        {
            return  Ok(_repository.GetAll());
        }

        [HttpGet("{id}",Name ="GetById")]
        public ActionResult<ShoppingCart> Get (Guid id)
        {
            return Ok(this._repository.GetById(id));
        }
        [HttpPost]
        public ActionResult<ShoppingCart> Post([FromBody] CreateShopingCartModel createShopingCartModel)
        {
            if (createShopingCartModel == null)
            {
                return BadRequest();
            }

            ShoppingCart shoppingCart = new ShoppingCart(createShopingCartModel.date, createShopingCartModel.Description);
            this._repository.Create(shoppingCart);

            return CreatedAtRoute("GetById", new { id = shoppingCart.Id }, shoppingCart);
        }

    }
}
