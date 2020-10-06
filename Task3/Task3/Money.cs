using System;

namespace Task3
{
    public class Money
    {
        private decimal amount;
        private readonly Currency currency;

        public Money(decimal amount, Currency currency)
        {
            this.amount = amount;
            this.currency = currency;
        }

        private static decimal ConvertToBYN(decimal amount, Currency currency)
        {
            if (currency == Currency.USD)
            {
                return amount * 2;
            }
            else if (currency == Currency.EUR)
            {
                return amount / 0.4m;
            }
            else
            {
                return amount;
            }
        }

        private static decimal ConvertFromBYN(decimal amount, Currency currency)
        {
            if (currency == Currency.USD)
            {
                return amount / 2;
            }
            else if (currency == Currency.EUR)
            {
                return amount * 0.4m;
            }
            else
            {
                return amount;
            }
        }

        public static Money operator ++(Money m)
        {
            if (m.currency == Currency.USD)
            {
                return new Money(m.amount += m.amount / 10, m.currency);
            }
            else if (m.currency == Currency.EUR)
            {
                return new Money(m.amount += m.amount / 5, m.currency);
            }
            else
            {
                return new Money(m.amount += m.amount * 0.3m, m.currency);
            }
        }

        public static Money operator +(Money m1, Money m2)
        {
            decimal amount = m1.amount + ConvertFromBYN(ConvertToBYN(m2.amount, m2.currency), m1.currency);
            return new Money(amount, m1.currency);
        }

        public static Money operator -(Money m1, Money m2)
        {
            decimal amount = m1.amount - ConvertFromBYN(ConvertToBYN(m2.amount, m2.currency), m1.currency);
            return new Money(amount, m1.currency);
        }

        public static bool operator ==(Money m1, Money m2)
        {
            return ConvertToBYN(m1.amount, m1.currency) ==
                ConvertToBYN(m2.amount, m2.currency);
        }

        public static bool operator !=(Money m1, Money m2)
        {
            return ConvertToBYN(m1.amount, m1.currency) !=
                ConvertToBYN(m2.amount, m2.currency);
        }

        public static explicit operator string(Money m)
        {
            return new string($"{m.amount:f5}_{m.currency}");
        }

        public static implicit operator int(Money m)
        {
            return (int)Math.Round(ConvertToBYN(m.amount, m.currency));
        }

        public override bool Equals(object obj)
        {
            Money m = obj as Money;
            if (obj as Money == null)
            {
                return false;
            }

            return amount == m.amount && currency == m.currency;
        }

        public override int GetHashCode()
        {
            return amount.GetHashCode() + (int)currency;
        }
    }
}
