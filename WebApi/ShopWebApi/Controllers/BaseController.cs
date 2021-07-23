using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class BaseController : ControllerBase
    {
        private readonly IMapper _mapper;
        public BaseController(IMapper mapper)
        {
            _mapper = mapper;
        }
    }
}
