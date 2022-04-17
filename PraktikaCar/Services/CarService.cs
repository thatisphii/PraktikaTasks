using AutoMapper;
using PraktikaCar.DTOs;
using PraktikaCar.Entities;
using PraktikaCar.Repositories.IRepositories;
using PraktikaCar.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PraktikaCar.Services
{
    public class CarService:ICarService
    {

        private readonly ICarRepository _carRepository;
        private readonly IMapper _mapper;
        public CarService(ICarRepository carRepository, IMapper mapper)

        {
            _carRepository = carRepository;
            _mapper = mapper;
        }

        public void Add(CarToAddDTO carToAddDTO)
        {
           Car car = _mapper.Map<Car>(carToAddDTO);
            _carRepository.Add(car);
        }

        public void Delete(int carId)
        {
            _carRepository.Delete(carId);
        }

        public List<CarToListDTO> Get()
        {
            return _mapper.Map<List<CarToListDTO>>(_carRepository.Get());
        }

        public CarToListDTO Get(int carId)
        {
            return _mapper.Map<CarToListDTO>(_carRepository.Get(carId));
        }

        public void Update(CarToUpdateDTO carToUpdateDTO)
        {
            Car car = _mapper.Map<Car>(carToUpdateDTO);
            _carRepository.Update(car);
        }
    }
}
