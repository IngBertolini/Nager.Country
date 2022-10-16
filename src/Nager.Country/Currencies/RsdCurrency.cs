namespace Nager.Country.Currencies
{
	/// <summary>
	/// Rsd Currency
	/// </summary>
	public class RsdCurrency : ICurrency
	{
		///<inheritdoc/>
		public string Symbol => "дин.";

		///<inheritdoc/>
		public string Singular => string.Empty;

		///<inheritdoc/>
		public string Plural => string.Empty;

		///<inheritdoc/>
		public string IsoCode => "RSD";

		///<inheritdoc/>
		public string NumericCode => "941";

		///<inheritdoc/>
		public string Name => "Serbian Dinar";
	}
}
