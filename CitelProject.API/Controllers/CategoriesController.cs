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


        // GET: api/Categories
        public IEnumerable<CategoryViewModel> Get()
        {
            return _mapper.Map<IEnumerable<CategoryViewModel>>(_categoryApp.GetAll());
        }

        // GET: api/Categories/5
        public CategoryViewModel Get(int id)
        {
            return _mapper.Map<CategoryViewModel>(_categoryApp.GetById(id));
        }

        // POST: api/Categories
        public void Post([FromBody]CategoryViewModel obj)
        {
            _categoryApp.Add(_mapper.Map<Category>(obj));
        }

        // PUT: api/Categories/5
        public void Put(int id, [FromBody]CategoryViewModel obj)
        {
            _categoryApp.Update(_mapper.Map<Category>(obj));
        }

        // DELETE: api/Categories/5
        public void Delete(int id)
        {
            _categoryApp.Remove(_categoryApp.GetById(id));
        }
    }
}
