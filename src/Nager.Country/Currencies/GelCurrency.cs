namespace Nager.Country.Currencies
{
	/// <summary>
	/// Gel Currency
	/// </summary>
	public class GelCurrency : ICurrency
	{
		///<inheritdoc/>
		public string Symbol => "₾";

		///<inheritdoc/>
		public string Singular => string.Empty;

		///<inheritdoc/>
		public string Plural => string.Empty;

		///<inheritdoc/>
		public string IsoCode => "GEL";

		///<inheritdoc/>
		public string NumericCode => "981";

		///<inheritdoc/>
		public string Name => "Georgian Lari";
	}
}
