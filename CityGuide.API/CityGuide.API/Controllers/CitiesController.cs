using AutoMapper;
using CityGuide.API.Data;
using CityGuide.API.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityGuide.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        private IAppRepository _appRepository;
        private IMapper _mapper;

        public CitiesController(IAppRepository appRepository,IMapper mapper)
        {
            _appRepository = appRepository;
            _mapper = mapper;
        }
        public ActionResult GetCities()
        {
            var cities = _appRepository.GetCities();
            var citiesToReturn = _mapper.Map<List<CityForListDto>>(cities);
            return Ok(cities);
        }
        [HttpPost]
        [Route("add")]
        public ActionResult Add([FromBody] CityForListDto city)
        {
            _appRepository.Add(city);
            _appRepository.SaveAll();
            return Ok(city);
        }
        [HttpGet("detail")]
        public ActionResult GetCityById(int id) 
        {
            var city = _appRepository.GetCityById(id);
            var cityToReturn = _mapper.Map<CityForDetailDto>(city);
            return Ok(cityToReturn);
        }

        [HttpGet("photos")]
        public ActionResult GetPhotosByCity(int cityId) 
        {
            var photos = _appRepository.GetPhotosByCity(cityId);
            return Ok(photos);
        }
    }
}
