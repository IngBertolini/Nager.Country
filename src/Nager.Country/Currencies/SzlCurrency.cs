namespace Nager.Country.Currencies
{
	/// <summary>
	/// Szl Currency
	/// </summary>
	public class SzlCurrency : ICurrency
	{
		///<inheritdoc/>
		public string Symbol => "L";

		///<inheritdoc/>
		public string Singular => string.Empty;

		///<inheritdoc/>
		public string Plural => string.Empty;

		///<inheritdoc/>
		public string IsoCode => "SZL";

		///<inheritdoc/>
		public string NumericCode => "748";

		///<inheritdoc/>
		public string Name => "Swazi lilangeni";
	}
}
