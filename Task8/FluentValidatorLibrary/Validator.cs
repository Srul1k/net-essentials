using System.Collections.Generic;

namespace FluentValidatorLibrary
{
    public class Validator<T> : IValidator<T>
    {
        private List<ValidationRule<T>> _rules;

        public Validator(List<ValidationRule<T>> rules)
        {
            _rules = rules;
        }
        public ValidationResult<T> Validate(T entity)
        {
            bool isValid = true;
            var errorMessages = new List<string>();

            foreach(var r in _rules)
            {
                if (!r.IsValid(entity))
                {
                    isValid = false;
                    errorMessages.Add(r.ErrorMessage(entity));
                }
            }

            return new ValidationResult<T>() { Entity = entity, 
                IsValid = isValid, ErrorMessages = errorMessages };
        }
    }
}
