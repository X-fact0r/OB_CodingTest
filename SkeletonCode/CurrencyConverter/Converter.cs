using System;
using System.Linq;

namespace SkeletonCode.CurrencyConverter
{
	public class Converter
	{
		private readonly ICurrencyRate[] rates;

		// TODO : Poor mans DI, replace with DI framework
		public Converter():this(new[] {
										new CurrencyRate("GBP", 1m),
										new CurrencyRate("USD", 1.25m)
									  })
		{

		}

		public Converter(ICurrencyRate[] rates)
		{
			if(rates == null)
			{
				throw new ArgumentNullException("rates");
			}

			this.rates = rates;
		}

		public decimal Convert(string inputCurrency, string outputCurrency, decimal amount)
		{
			var inputRate = rates.FirstOrDefault(e => e.Code == inputCurrency.ToUpper());

			if(inputRate == null)
			{
				throw new ArgumentException(string.Format("Invalid input currency : {0}", inputCurrency));
			}

			var outputRate = rates.FirstOrDefault(e => e.Code == outputCurrency.ToUpper());

			if (outputRate == null)
			{
				throw new ArgumentException(string.Format("Invalid output currency : {0}", outputRate));
			}

			return (amount / inputRate.Rate) * outputRate.Rate;
		}
	}
}
