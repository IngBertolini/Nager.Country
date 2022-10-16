namespace Nager.Country.Currencies
{
	/// <summary>
	/// Jmd Currency
	/// </summary>
	public class JmdCurrency : ICurrency
	{
		///<inheritdoc/>
		public string Symbol => "$";

		///<inheritdoc/>
		public string Singular => string.Empty;

		///<inheritdoc/>
		public string Plural => string.Empty;

		///<inheritdoc/>
		public string IsoCode => "JMD";

		///<inheritdoc/>
		public string NumericCode => "388";

		///<inheritdoc/>
		public string Name => "Jamaican Dollar";
	}
}
