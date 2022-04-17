using PraktikaCar.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PraktikaCar.Services.IServices
{
   public interface ICarService
    {
        void Add(CarToAddDTO carToAddDTO);

        List<CarToListDTO> Get();
        CarToListDTO Get(int carId);

        void Update(CarToUpdateDTO carToUpdateDTO);

        void Delete(int carId);
    }
}
