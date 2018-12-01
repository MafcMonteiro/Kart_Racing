using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gympass_Kart.Core
{
    [Route("api/[controller]")]
    public class ApiControllerBase : ControllerBase
    {
        protected IActionResult CreateResponse<T>(Func<T> function)
        {
            try
            {
                var data = function.Invoke();

                return Response(data);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new
                {
                    success = false,
                    notifications = ex.InnerException
                });
            }
        }


        private new IActionResult Response(object data = null)
        {
            return Ok(new
            {
                success = true,
                data
            });
        }

    }
}
