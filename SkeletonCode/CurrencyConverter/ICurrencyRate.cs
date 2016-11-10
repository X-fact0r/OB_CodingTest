namespace SkeletonCode.CurrencyConverter
{
	public interface ICurrencyRate
	{
		string Code { get; }

		decimal Rate { get; }
	}
}
