using Entities.Concerete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarDal
    {
        List<Car> GetAll();
        List<Car> GetById(int colorId);
        List<Car> GetByBrandId(int branıd);
        void add(Car car);
        void update(Car car);
        void delete(Car car);
    }
}
