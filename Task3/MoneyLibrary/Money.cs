using System;
using System.Collections.Generic;

namespace MoneyLibrary
{
    public class Money
    {
        public decimal Amount { get; }  
        public Currency Currency { get; }
        public static Dictionary<(Currency, Currency), decimal> 
            ExchangeRates { get; } = new Dictionary<(Currency, Currency), decimal>()
            {
                { (Currency.USD, Currency.BYN), 2m },
                { (Currency.USD, Currency.EUR), 0.8m },
                { (Currency.BYN, Currency.USD), 0.5m },
                { (Currency.BYN, Currency.EUR), 0.4m },
                { (Currency.EUR, Currency.USD), 10/8m },
                { (Currency.EUR, Currency.BYN), 10/4m }
            };

        public Money(decimal a, Currency c)
        {
            Amount = a;
            Currency = c;
        }

        private static decimal CurrencyConversion(Currency primary, Currency finite, decimal value)
        {
            if (primary == finite) return value;
            else return value * ExchangeRates[(primary, finite)];
        }

        public static Money operator ++(Money m)
        {
            switch(m.Currency)
            {
                case Currency.USD:
                    return new Money(m.Amount + m.Amount / 10, m.Currency);
                case Currency.EUR:
                    return new Money(m.Amount + m.Amount / 5, m.Currency);
                case Currency.BYN:
                    return new Money(m.Amount + m.Amount * 0.3m, m.Currency);
                default:
                    return m;
            }
        }

        public static Money operator +(Money m1, Money m2)
        {
            decimal amount = m1.Amount + CurrencyConversion(m2.Currency, m1.Currency, m2.Amount);
            return new Money(amount, m1.Currency);
        }

        public static Money operator -(Money m1, Money m2)
        {
            decimal amount = m1.Amount - CurrencyConversion(m2.Currency, m1.Currency, m2.Amount);
            return new Money(amount, m1.Currency);
        }

        public static bool operator ==(Money m1, Money m2)
        {
            return m1.Amount == CurrencyConversion(m2.Currency, m1.Currency, m2.Amount);
        }

        public static bool operator !=(Money m1, Money m2)
        {
            return m1.Amount == CurrencyConversion(m2.Currency, m1.Currency, m2.Amount);
        }

        public static explicit operator string(Money m)
        {
            return $"{m.Amount:f5}_{m.Currency}";
        }

        public static implicit operator int(Money m)
        {
            return (int)Math.Round(m.Amount * CurrencyConversion(m.Currency, Currency.BYN, m.Amount));
        }

        public override bool Equals(object obj)
        {
            return obj is Money && GetHashCode() == obj.GetHashCode();
        }

        public override int GetHashCode()
        {
            return Amount.GetHashCode() + (int)Currency;
        }
    }
}
