using FluentValidation;
using PlatePass.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatePass.Business.Validation
{
    public class PlateValidator : AbstractValidator<Plate>
    {
        public PlateValidator()
        {
            RuleFor(plate => plate.PlateText).NotEmpty().MinimumLength(3);
        }
    }
}
