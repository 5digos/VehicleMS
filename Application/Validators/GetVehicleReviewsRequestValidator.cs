using Application.Dtos.Request;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Validators
{
    public class GetVehicleReviewsRequestValidator : AbstractValidator<GetVehicleReviewsRequest>
    {
        public GetVehicleReviewsRequestValidator()
        {
            When(x => x.Rating.HasValue, () =>
            {
                RuleFor(x => x.Rating.Value)
                    .InclusiveBetween(1, 5)
                    .WithMessage("La calificación, si se especifica, debe estar entre 1 y 5.");
            });

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
