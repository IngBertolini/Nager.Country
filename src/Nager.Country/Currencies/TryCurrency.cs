namespace Nager.Country.Currencies
{
	/// <summary>
	/// Try Currency
	/// </summary>
	public class TryCurrency : ICurrency
	{
		///<inheritdoc/>
		public string Symbol => "₺";

		///<inheritdoc/>
		public string Singular => string.Empty;

		///<inheritdoc/>
		public string Plural => string.Empty;

		///<inheritdoc/>
		public string IsoCode => "TRY";

		///<inheritdoc/>
		public string NumericCode => "949";

		///<inheritdoc/>
		public string Name => "Turkish Lira";
	}
}
