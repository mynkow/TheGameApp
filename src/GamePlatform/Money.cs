namespace GamePlatform
{
    public class Money
    {
        public Money(decimal amount, string currencyCode)
        {
            if (amount < 0) throw new ArgumentException("Money could not be negative", nameof(amount));
            if (string.IsNullOrEmpty(currencyCode)) throw new ArgumentNullException(nameof(currencyCode));
            if (CurrenCode.IsValidCode(currencyCode) == false) throw new ArgumentException("Invalid Currency code", nameof(currencyCode));

            Amount = amount;
            CurrencyCode = currencyCode;
        }

        public decimal Amount { get; private set; }

        public string CurrencyCode { get; private set; }
    }
}
