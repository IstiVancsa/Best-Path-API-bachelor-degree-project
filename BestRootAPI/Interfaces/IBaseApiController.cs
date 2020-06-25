using Entities;
using Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Models.IFilterModels;

namespace Interfaces
{
    public interface IBaseApiController
    {
        string APIPath { get; }
        IConfiguration Configuration { get; }
        IActionResult GetDefault();
    }
}