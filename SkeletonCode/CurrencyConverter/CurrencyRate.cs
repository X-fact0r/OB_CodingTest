namespace SkeletonCode.CurrencyConverter
{
	public class CurrencyRate : ICurrencyRate
	{
		public CurrencyRate(string code, decimal rate)
		{
			Code = code;
			Rate = rate;
		}

		public string Code { get; private set; }

		public decimal Rate { get; private set; }
	}
}
