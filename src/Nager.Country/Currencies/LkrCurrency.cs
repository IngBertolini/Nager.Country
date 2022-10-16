namespace Nager.Country.Currencies
{
	/// <summary>
	/// Lkr Currency
	/// </summary>
	public class LkrCurrency : ICurrency
	{
		///<inheritdoc/>
		public string Symbol => "රු.";

		///<inheritdoc/>
		public string Singular => string.Empty;

		///<inheritdoc/>
		public string Plural => string.Empty;

		///<inheritdoc/>
		public string IsoCode => "LKR";

		///<inheritdoc/>
		public string NumericCode => "144";

		///<inheritdoc/>
		public string Name => "Sri Lankan Rupee";
	}
}
