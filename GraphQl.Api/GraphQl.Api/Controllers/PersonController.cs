using GraphQl.Api.Dtos;
using GraphQl.Api.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GraphQl.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IDbOpeartion _opeartion;


        public PersonController(IDbOpeartion opeartion)
        {
            _opeartion = opeartion;
        }

        [HttpGet]

        public async Task<ActionResult<PersonDto>> getallPerson()
        {
            var result = await _opeartion.GetAllPerson();
            return Ok(result);
        }
        [HttpPost]
        public  int addperson(PersonDto person)
        {
            var result =  _opeartion.AddPerson(person);
            return result;
        }


    }
}
