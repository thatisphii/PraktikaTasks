using PraktikaCar.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PraktikaCar.Repositories.IRepositories
{
    public interface ICarRepository
    {
        void Add(Car car);
        List<Car> Get();

        Car Get(int carId);

        void Update(Car car);

        void Delete(int carId);
    }
}
