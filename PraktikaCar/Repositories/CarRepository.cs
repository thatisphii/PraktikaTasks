using PraktikaCar.DataContext;
using PraktikaCar.Entities;
using PraktikaCar.Repositories.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PraktikaCar.Repositories
{
    public class CarRepository:ICarRepository
    {
        private readonly TestDbContext _testDbContext;
        public CarRepository(TestDbContext testDbContext)
        {
            _testDbContext = testDbContext;
        }
        public void Add(Car car)
        {

            _testDbContext.Cars.Add(car);
            _testDbContext.SaveChanges();
        }

        public void Delete(int carId)
        {
            Car car = _testDbContext.Cars.Find(carId);

            car.isDeleted = true;

            _testDbContext.Cars.Update(car);

            //_testDbContext.Cars.Remove(car);
            _testDbContext.SaveChanges();
        }

        public List<Car> Get()
        {
            return _testDbContext.Cars.ToList();
        }

        public Car Get(int carId)
        {
            Car car = _testDbContext.Cars.FirstOrDefault(m => !m.isDeleted && m.CarId == carId);
            return car;
        }

        public void Update(Car car)
        {
            
            _testDbContext.Cars.Update(car);
            _testDbContext.SaveChanges();
        }
    }
}
