namespace Nager.Country.Currencies
{
	/// <summary>
	/// Isk Currency
	/// </summary>
	public class IskCurrency : ICurrency
	{
		///<inheritdoc/>
		public string Symbol => "kr";

		///<inheritdoc/>
		public string Singular => string.Empty;

		///<inheritdoc/>
		public string Plural => string.Empty;

		///<inheritdoc/>
		public string IsoCode => "ISK";

		///<inheritdoc/>
		public string NumericCode => "352";

		///<inheritdoc/>
		public string Name => "Icelandic Króna";
	}
}
