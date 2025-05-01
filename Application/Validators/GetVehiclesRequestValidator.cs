using Application.Dtos.Request;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Validators
{
    public class GetVehiclesRequestValidator : AbstractValidator<GetVehiclesRequest>
    {
        public GetVehiclesRequestValidator()
        {
            RuleFor(x => x.Offset)
                .GreaterThanOrEqualTo(0)
                .When(x => x.Offset.HasValue)
                .WithMessage("El valor 'offset' debe ser un numero entero no negativo.");

            RuleFor(x => x.Size)
                .GreaterThanOrEqualTo(0)
                .When(x => x.Size.HasValue)
                .WithMessage("El valor 'size' debe ser un numero entero no negativo.");
        }
    }
}
