namespace Nager.Country.Currencies
{
	/// <summary>
	/// Sdg Currency
	/// </summary>
	public class SdgCurrency : ICurrency
	{
		///<inheritdoc/>
		public string Symbol => "SDG";

		///<inheritdoc/>
		public string Singular => string.Empty;

		///<inheritdoc/>
		public string Plural => string.Empty;

		///<inheritdoc/>
		public string IsoCode => "SDG";

		///<inheritdoc/>
		public string NumericCode => "938";

		///<inheritdoc/>
		public string Name => "Sudanese pound";
	}
}
