﻿using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace Consolee
{
   class Program
    {
        static void Main(string[] args)
        {
            CarManager carmanager = new CarManager(new InMemoryCarDal());
            foreach (var car in carmanager.GetAll())
            {
                Console.WriteLine(car.BrandId);
            }
        }
    }
}
