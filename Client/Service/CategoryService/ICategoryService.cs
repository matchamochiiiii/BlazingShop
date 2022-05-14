﻿using BlazingShop.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazingShop.Client.Service.CategoryService
{
    interface ICategoryService
    {
        public List<Category> Categories { get; set; }

        void LoadCategories();
    }
}