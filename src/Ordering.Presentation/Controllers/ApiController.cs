﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace Ordering.Presentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ApiController : ControllerBase
    {
        private ISender _sender;

        /// <summary>
        /// Gets the sender.
        /// </summary>
        protected ISender Sender => _sender ??= HttpContext.RequestServices.GetService<ISender>();
    }
}
