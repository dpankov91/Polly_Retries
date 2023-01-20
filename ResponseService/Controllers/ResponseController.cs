using Microsoft.AspNetCore.Mvc;

namespace ResponseService.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class ResponseController : ControllerBase
    {
        //GET /api/response/3

        [Route("{id:int}")]
        [HttpGet]
        public ActionResult GetAResponse(int id)
        {
            Random rnd = new Random();
            var rndInteger = rnd.Next(1, 101);
            if(rndInteger >= id)
            {
                Console.WriteLine("--> Failure - Gnerate a HTTP 500");
                return StatusCode(StatusCodes.Status500InternalServerError);
            }

            Console.WriteLine("--> Success - Gnerate a HTTP 200");
            return Ok();               
        }        
    }
}