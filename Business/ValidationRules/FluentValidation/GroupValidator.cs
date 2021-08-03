using Business.Constants;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
	public class GroupValidator : AbstractValidator<Group>
    {
        public GroupValidator()
        {
        //    RuleFor(p => p.Date).LessThan(DateTime.Now).WithMessage("bill date is invalid, it must be less than now");
        //    RuleFor(p => p.FlatId).NotEmpty();
        //    RuleFor(p => p.Price).NotEmpty();
        }
    }
}