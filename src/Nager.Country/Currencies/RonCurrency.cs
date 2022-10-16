namespace Nager.Country.Currencies
{
	/// <summary>
	/// Ron Currency
	/// </summary>
	public class RonCurrency : ICurrency
	{
		///<inheritdoc/>
		public string Symbol => "lei";

		///<inheritdoc/>
		public string Singular => string.Empty;

		///<inheritdoc/>
		public string Plural => string.Empty;

		///<inheritdoc/>
		public string IsoCode => "RON";

		///<inheritdoc/>
		public string NumericCode => "946";

		///<inheritdoc/>
		public string Name => "Romanian Leu";
	}
}
