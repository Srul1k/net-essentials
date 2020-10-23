using System;
using ShapeLibrary;
using MoneyLibrary;
using FluentValidatorLibrary;
using System.Collections.Generic;

namespace UsageExapmles
{
    class Program
    {
        static void Main()
        {
            var triangleAreaValidator = new ValidatorBuilder<Triangle>()
                .AddRule(x => x.GetArea() > 20, t => $"Area value {t.GetArea()} is not correct. Should be more than 20")
                .Build();

            var validationResult = triangleAreaValidator.Validate(new Triangle(2, 4));
            if (!validationResult.IsValid)
            {
                Console.WriteLine(string.Join(Environment.NewLine, validationResult.ErrorMessages));
            }

            var moneyValidator = new ValidatorBuilder<Money>()
                .AddRule(x => x.Currency == Currency.BYN, t => $"Currency value {t.Currency} is not correct. Should be BYN")
                .AddRule(x => x.Amount > 1000, t => $"Amount {t.Amount} is not correct. Should be more than 1000")
                .Build();

            var moneyResults = new List<ValidationResult<Money>>();
            moneyResults.Add(moneyValidator.Validate(new Money(50, Currency.BYN)));
            moneyResults.Add(moneyValidator.Validate(new Money(1100, Currency.USD)));
            moneyResults.Add(moneyValidator.Validate(new Money(50, Currency.USD)));
            moneyResults.Add(moneyValidator.Validate(new Money(1100, Currency.BYN)));

            moneyResults.ForEach(x => Console.WriteLine(string.Join(Environment.NewLine, x.ErrorMessages)));
        }
    }
}
