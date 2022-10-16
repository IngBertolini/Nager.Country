namespace Nager.Country.Currencies
{
	/// <summary>
	/// Lyd Currency
	/// </summary>
	public class LydCurrency : ICurrency
	{
		///<inheritdoc/>
		public string Symbol => "د.ل.‏";

		///<inheritdoc/>
		public string Singular => string.Empty;

		///<inheritdoc/>
		public string Plural => string.Empty;

		///<inheritdoc/>
		public string IsoCode => "LYD";

		///<inheritdoc/>
		public string NumericCode => "434";

		///<inheritdoc/>
		public string Name => "Libyan Dinar";
	}
}
