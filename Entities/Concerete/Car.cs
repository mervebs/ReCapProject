﻿using Entities.Abstaract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concerete
{
    public class Car:IEntity
    {
        public int CarId { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public int ModelYear { get; set; }
        public float DailyPrice { get; set; }
        public string Description { get; set; }




    }
}
