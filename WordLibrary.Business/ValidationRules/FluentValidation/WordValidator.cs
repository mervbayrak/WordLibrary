using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using WordLibrary.Entities.Concrete;

namespace WordLibrary.Business.ValidationRules.FluentValidation
{
    public class WordValidator : AbstractValidator<Word>
    {
        public WordValidator()
        {
            RuleFor(p => p.Name).NotEmpty();
            RuleFor(p => p.Mean).NotEmpty();
            RuleFor(p => p.Pronounce).NotEmpty();
        }
    }
}
