using FluentValidation;

namespace FluentApiValidation.Model
{
    public class Validation : AbstractValidator<Register>
    {
        public Validation() 
        {
            RuleFor(Register => Register.Email).NotEmpty().WithMessage("Email should not be Empty");
        }
    }
    public class Validations : AbstractValidator<Address>
    {
        public Validations()
        {
            RuleFor(Register => Register.AddressName).NotEmpty().WithMessage("Name should not be Empty");
        }
    }
}
