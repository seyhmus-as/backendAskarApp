using Business.Constants;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class MessageValidator : AbstractValidator<Message>
    {
        public MessageValidator()
        {
        //    RuleFor(p => p.FirstName).MinimumLength(2);
        //    RuleFor(p => p.LastName).MinimumLength(2);
        }
    }
}
