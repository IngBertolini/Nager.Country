namespace Nager.Country.Currencies
{
	/// <summary>
	/// Mzn Currency
	/// </summary>
	public class MznCurrency : ICurrency
	{
		///<inheritdoc/>
		public string Symbol => "MT";

		///<inheritdoc/>
		public string Singular => string.Empty;

		///<inheritdoc/>
		public string Plural => string.Empty;

		///<inheritdoc/>
		public string IsoCode => "MZN";

		///<inheritdoc/>
		public string NumericCode => "943";

		///<inheritdoc/>
		public string Name => "Mozambican metical";
	}
}
