namespace Nager.Country.Currencies
{
	/// <summary>
	/// Gip Currency
	/// </summary>
	public class GipCurrency : ICurrency
	{
		///<inheritdoc/>
		public string Symbol => "£";

		///<inheritdoc/>
		public string Singular => string.Empty;

		///<inheritdoc/>
		public string Plural => string.Empty;

		///<inheritdoc/>
		public string IsoCode => "GIP";

		///<inheritdoc/>
		public string NumericCode => "292";

		///<inheritdoc/>
		public string Name => "Gibraltar pound";
	}
}
