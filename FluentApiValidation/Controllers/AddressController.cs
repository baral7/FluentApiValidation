using FluentApiValidation.Model;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;

namespace FluentApiValidation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AddressController : ControllerBase
    {
        public AddressController(IValidator<Address> validator)
        {
            Validator = validator;
        }

        public IValidator<Address> Validator { get; }

        [HttpPost]
        public IActionResult post(Address address) 
        {
            var validationResult = Validator.Validate(address);
            return Ok(address);
        }
    }
}
