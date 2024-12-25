using FluentApiValidation.Model;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;

namespace FluentApiValidation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RegisterController : ControllerBase
    {
        private readonly IValidator<Register> Validator;
        public RegisterController(IValidator<Register> validator)
        {
            Validator = validator;
        }

        [HttpGet]
        public IEnumerable<Register> Get()
        {
            return new List<Register> { new Register { Email = "baral33niraj", Name = "NirajBaral", NumberOfState = 1 } };
        }
        [HttpPost]
        public IActionResult Post(Register register) 
        {
          var validationResult =  Validator.Validate(register);
            if (!validationResult.IsValid)
            {
                var Errors = validationResult.Errors;
                return BadRequest(Errors);
            }
            return Ok(register);
        }
    }
}
