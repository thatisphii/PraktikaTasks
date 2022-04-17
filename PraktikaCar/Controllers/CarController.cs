using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PraktikaCar.DTOs;
using PraktikaCar.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PraktikaCar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ICarService _carService;
        public CarController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpPost]
        public IActionResult Add(CarToAddDTO carToAddDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            _carService.Add(carToAddDTO);
            return Ok();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_carService.Get());
        }

        [HttpGet("{carId}")]
        public IActionResult Get(int carId)
        {
            return Ok(_carService.Get(carId));
        }

        [HttpPut]
        public IActionResult Update(CarToUpdateDTO carToUpdateDTO)
        {
            _carService.Update(carToUpdateDTO);
            return Ok();
        }

        [HttpDelete("{carId}")]
        public IActionResult Delete(int carId)
        {
            _carService.Delete(carId);
            return Ok();
        }
    }
}
