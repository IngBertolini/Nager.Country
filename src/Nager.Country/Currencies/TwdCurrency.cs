namespace Nager.Country.Currencies
{
	/// <summary>
	/// Twd Currency
	/// </summary>
	public class TwdCurrency : ICurrency
	{
		///<inheritdoc/>
		public string Symbol => "NT$";

		///<inheritdoc/>
		public string Singular => string.Empty;

		///<inheritdoc/>
		public string Plural => string.Empty;

		///<inheritdoc/>
		public string IsoCode => "TWD";

		///<inheritdoc/>
		public string NumericCode => "901";

		///<inheritdoc/>
		public string Name => "New Taiwan Dollar";
	}
}
