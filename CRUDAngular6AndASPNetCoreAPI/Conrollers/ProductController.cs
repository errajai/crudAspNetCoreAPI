using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRUDAngular6AndASPNetCoreAPI.Conrollers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [Produces("Application/json")]
        [HttpGet("findall")]
        public async Task<IActionResult> findAll()
        {
            try
            {

            }
            catch
            {
                return BadRequest();
            }
        }
    }
}