﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductApp.Models;

namespace ProductApp.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ILogger<ProductsController> _logger;

        public ProductsController(ILogger<ProductsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult GetAllProdutcs()
        {
            var products = new List<Product>()
            {
                new Product { Id = 1, ProductName = "Computer"},
                new Product { Id = 2, ProductName = "Keyboard"},    
                new Product { Id = 3, ProductName = "Mouse"}
            };
            //debug ve cmd üzerine işleme dair log kaydı eklendi.İstenirse database ortamına da log kayıtları eklenebilir.
            //get işleminde info seviyesinde bir log kaydı düşecektir.
            _logger.LogInformation("GetAllProducts action has been called.");
            return Ok(products);
        }

        [HttpPost]
        public IActionResult GetAllProdutcs([FromBody] Product product)
        {
            //Post işleminde warning seviyesinde log kaydı düşecektir.
            _logger.LogWarning("Product has been created."); 
            return StatusCode(201); //Created
        }
    }
}
