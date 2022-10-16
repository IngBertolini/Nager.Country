namespace Nager.Country.Currencies
{
	/// <summary>
	/// Vnd Currency
	/// </summary>
	public class VndCurrency : ICurrency
	{
		///<inheritdoc/>
		public string Symbol => "₫";

		///<inheritdoc/>
		public string Singular => string.Empty;

		///<inheritdoc/>
		public string Plural => string.Empty;

		///<inheritdoc/>
		public string IsoCode => "VND";

		///<inheritdoc/>
		public string NumericCode => "704";

		///<inheritdoc/>
		public string Name => "Vietnamese Dong";
	}
}
