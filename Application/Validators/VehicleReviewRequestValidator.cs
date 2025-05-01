using Application.Dtos.Request;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Validators
{
    public class VehicleReviewRequestValidator : AbstractValidator<VehicleReviewRequest>
    {
        public VehicleReviewRequestValidator()
        {
            RuleFor(x => x.ReservationId)
                .NotEmpty()
                .WithMessage("El ID de la reserva es obligatorio.");

            RuleFor(x => x.Rating)
                .NotEmpty()
                .WithMessage("La calificación es obligatoria.")
                .InclusiveBetween(1, 5)
                .WithMessage("La calificación debe estar entre 1 y 5.");            
        }
    }
}
