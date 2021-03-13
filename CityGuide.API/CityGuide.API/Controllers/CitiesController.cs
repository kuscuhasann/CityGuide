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

        public CitiesController(IAppRepository appRepository)
        {
            _appRepository = appRepository;
        }
        public ActionResult GetCities()
        {
            var cities = _appRepository.GetCities();
            //var citiesToReturn = _mapper.Map<List<CityForListDto>>();
            return Ok(cities);
        }
    }
}
