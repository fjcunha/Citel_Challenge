using AutoMapper;
using CitelProject.Application.Interface;
using CitelProject.Domain.Entities;
using CitelProject.WebApi.AutoMapper;
using CitelProject.WebApi.ViewModels;
using System.Collections.Generic;
using System.Web.Http;

namespace CitelProject.WebApi.Controllers
{
    public class CategoriesController : ApiController
    {
        private readonly ICategoryAppService _categoryApp;
        private readonly IMapper _mapper;

        public CategoriesController(ICategoryAppService categoryAppService)
        {
            _categoryApp = categoryAppService;
            _mapper = AutoMapperConfig.Mapper;
        }


        /// <summary>
        /// Retornar Lista de Categorias cadastradas
        /// </summary>
        // GET: api/Categories
        public IEnumerable<CategoryViewModel> Get()
        {
            return _mapper.Map<IEnumerable<CategoryViewModel>>(_categoryApp.GetAll());
        }

        /// <summary>
        /// Retornar uma Categoria cadastrada
        /// </summary>
        // GET: api/Categories/5
        public CategoryViewModel Get(int id)
        {
            return _mapper.Map<CategoryViewModel>(_categoryApp.GetById(id));
        }

        /// <summary>
        /// Cadastrar uma nova Categoria
        /// </summary>
        // POST: api/Categories
        public void Post([FromBody]CategoryViewModel obj)
        {
            _categoryApp.Add(_mapper.Map<Category>(obj));
        }

        /// <summary>
        /// Editar uma Categoria cadastrada
        /// </summary>
        // PUT: api/Categories/5
        public void Put(int id, [FromBody]CategoryViewModel obj)
        {
            _categoryApp.Update(_mapper.Map<Category>(obj));
        }

        /// <summary>
        /// Remover uma Categoria cadastrada
        /// </summary>
        // DELETE: api/Categories/5
        public void Delete(int id)
        {
            _categoryApp.Remove(_categoryApp.GetById(id));
        }
    }
}
