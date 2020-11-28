using System;
using System.Collections.Generic;

namespace FluentValidatorLibrary
{
    public class ValidatorBuilder<T> : IValidatorBuilder<T>
    {
        private List<ValidationRule<T>> _rules;

        public ValidatorBuilder()
        {
            _rules = new List<ValidationRule<T>>();
        }

        public IValidatorBuilder<T> AddRule(Predicate<T> IsValid, Func<T, string> errorMessage)
        {
            var rule = new ValidationRule<T>() { IsValid = IsValid, ErrorMessage = errorMessage };
            _rules.Add(rule);
            return this;
        }

        public IValidator<T> Build()
        {
            return new Validator<T>(_rules);
        }
    }
}
