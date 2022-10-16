namespace Nager.Country.Currencies
{
	/// <summary>
	/// Mmk Currency
	/// </summary>
	public class MmkCurrency : ICurrency
	{
		///<inheritdoc/>
		public string Symbol => "K";

		///<inheritdoc/>
		public string Singular => string.Empty;

		///<inheritdoc/>
		public string Plural => string.Empty;

		///<inheritdoc/>
		public string IsoCode => "MMK";

		///<inheritdoc/>
		public string NumericCode => "104";

		///<inheritdoc/>
		public string Name => "Myanmar Kyat";
	}
}
