using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StoreOfBuild.Domain;
using StoreOfBuild.Domain.Dtos;
using StoreOfBuild.Domain.Products;
using StoreOfBuild.Web.ViewsModels;

namespace StoreOfBuild.Web.Controllers
{
    public class CategoryController : Controller
    {
        private readonly CategoryStorer _categoryStorer;    

        public CategoryController(CategoryStorer categoryStorer)
        {
            _categoryStorer = categoryStorer;
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreateOrEdit()
        {          
            return View();
        }

        [HttpPost]
        public IActionResult CreateOrEdit(int id, string name)
        {
            _categoryStorer.Store(id,name);
            return View();
        }
    }
}
