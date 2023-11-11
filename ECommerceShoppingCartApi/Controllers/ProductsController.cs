using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Application.IServices;
using Application.Services;
using Domain.ViewModel;
using Domain.Entities;

namespace ECommerceShoppingCartApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        //private readonly IMapper _mapper;
        private readonly IProductService _productService;
        public ProductsController(IProductService productService)
        {
            _productService = productService;
            //_mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Product>> Get()
        {
            var products = _productService.GetAllProducts();
            //var productViewModels = _mapper.Map<IEnumerable<Product>, IEnumerable<ProductViewModel>>(products);
            return Ok(products);
        }
    }
}
