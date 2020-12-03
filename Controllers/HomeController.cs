using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Humman.Models;
using Humman.Models.ViewModels;

namespace Humman.Controllers
{
    public class HomeController : Controller
    {
        private IStoreRepository repository;

        public HomeController(IStoreRepository repo)
        {
            repository = repo;
        }
        public int PageSize = 3;
        public ViewResult Index(int productPage = 1)
            => View(new ProductListViewModel
            {
                Products = repository.Products
                .OrderBy(p => p.ID)
                .Skip((productPage - 1) * PageSize)
                .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = productPage,
                    ItemsPErPage = PageSize,
                    TotalItems = repository.Products.Count()
                }
            });

    }
}