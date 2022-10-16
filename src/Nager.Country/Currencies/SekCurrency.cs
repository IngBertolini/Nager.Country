namespace Nager.Country.Currencies
{
	/// <summary>
	/// Sek Currency
	/// </summary>
	public class SekCurrency : ICurrency
	{
		///<inheritdoc/>
		public string Symbol => "kr";

		///<inheritdoc/>
		public string Singular => string.Empty;

		///<inheritdoc/>
		public string Plural => string.Empty;

		///<inheritdoc/>
		public string IsoCode => "SEK";

		///<inheritdoc/>
		public string NumericCode => "752";

		///<inheritdoc/>
		public string Name => "Swedish Krona";
	}
}
