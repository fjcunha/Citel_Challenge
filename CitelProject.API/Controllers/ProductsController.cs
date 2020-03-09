using AutoMapper;
using CitelProject.Application.Interface;
using CitelProject.Domain.Entities;
using CitelProject.WebApi.AutoMapper;
using CitelProject.WebApi.ViewModels;
using System.Collections.Generic;
using System.Web.Http;

namespace CitelProject.API.Controllers
{
    public class ProductsController : ApiController
    {
        private readonly IProductAppService _productApp;
        private readonly IMapper _mapper;

        public ProductsController(IProductAppService productApp)
        {
            _productApp = productApp;
            _mapper = AutoMapperConfig.Mapper;
        }

        /// <summary>
        /// Retornar Lista de Produtos cadastrados
        /// </summary>
        // GET: api/Categories
        public IEnumerable<ProductViewModel> Get()
        {
            return _mapper.Map<IEnumerable<ProductViewModel>>(_productApp.GetAll());
        }

        /// <summary>
        /// Retornar um Produto cadastrado
        /// </summary>
        // GET: api/Categories/5
        public ProductViewModel Get(int id)
        {
            return _mapper.Map<ProductViewModel>(_productApp.GetById(id));
        }

        /// <summary>
        /// Criar um novo Produto
        /// </summary>
        // POST: api/Categories
        public void Post([FromBody]ProductViewModel obj)
        {
            _productApp.Add(_mapper.Map<Product>(obj));
        }

        /// <summary>
        /// Editar um novo Produto
        /// </summary>
        // PUT: api/Categories/5
        public void Put(int id, [FromBody]ProductViewModel obj)
        {
            _productApp.Update(_mapper.Map<Product>(obj));
        }

        /// <summary>
        /// Remover um Produto cadastrado
        /// </summary>
        // DELETE: api/Categories/5
        public void Delete(int id)
        {
            _productApp.Remove(_productApp.GetById(id));
        }
    }
}
