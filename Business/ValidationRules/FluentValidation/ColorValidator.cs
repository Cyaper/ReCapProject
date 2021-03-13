﻿using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class ColorValidator: AbstractValidator<Color>
    {
        public ColorValidator()
        {
            RuleFor(c => c.ColorId).NotEmpty();
            RuleFor(c => c.ColorName).NotEmpty();
        }
    }
}
