namespace Nager.Country.Currencies
{
	/// <summary>
	/// Khr Currency
	/// </summary>
	public class KhrCurrency : ICurrency
	{
		///<inheritdoc/>
		public string Symbol => "៛";

		///<inheritdoc/>
		public string Singular => string.Empty;

		///<inheritdoc/>
		public string Plural => string.Empty;

		///<inheritdoc/>
		public string IsoCode => "KHR";

		///<inheritdoc/>
		public string NumericCode => "116";

		///<inheritdoc/>
		public string Name => "Cambodian Riel";
	}
}
