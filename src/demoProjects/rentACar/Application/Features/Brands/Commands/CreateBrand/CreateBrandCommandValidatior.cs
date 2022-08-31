using FluentValidation;

namespace Application.Features.Brands.Commands.CreateBrand;

public class CreateBrandCommandValidatior : AbstractValidator<CreateBrandCommand>
{
    public CreateBrandCommandValidatior()
    {
        RuleFor(c => c.Name).NotEmpty();
        RuleFor(c => c.Name).MinimumLength(2);
    }
}