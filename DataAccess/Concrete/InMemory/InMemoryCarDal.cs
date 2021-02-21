using DataAccess.Abstract;
using Entities.Concerete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
            new Car{CarId = 1, BrandId = 1, ColorId = 1, DailyPrice = 10000, ModelYear = 2000, Description = "Car1" },
            new Car {CarId = 2, BrandId = 2, ColorId = 2, DailyPrice = 80000, ModelYear = 2009, Description = "Car2"},
            new Car{CarId = 3, BrandId = 3, ColorId = 3, DailyPrice = 60000, ModelYear = 2003, Description = "Car3"},
            new Car{ CarId = 4, BrandId = 1, ColorId = 4, DailyPrice = 30000, ModelYear = 2020, Description = "Car4" },
            new Car {CarId = 5, BrandId = 2, ColorId = 5, DailyPrice = 10000, ModelYear = 2017, Description = "Car5"  },

            };
        }

        public void add(Car car)
        {
            _cars.Add(car);
        }

        public void delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetByBrandId(int branıd)
        {
            return _cars.Where(c => c.BrandId == branıd).ToList();
        }

        public List<Car> GetById(int colorId)
        {
            return _cars.Where(c => c.ColorId==colorId).ToList();
        }

        public void update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
