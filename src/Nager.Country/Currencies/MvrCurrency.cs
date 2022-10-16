namespace Nager.Country.Currencies
{
	/// <summary>
	/// Mvr Currency
	/// </summary>
	public class MvrCurrency : ICurrency
	{
		///<inheritdoc/>
		public string Symbol => "ރ.";

		///<inheritdoc/>
		public string Singular => string.Empty;

		///<inheritdoc/>
		public string Plural => string.Empty;

		///<inheritdoc/>
		public string IsoCode => "MVR";

		///<inheritdoc/>
		public string NumericCode => "462";

		///<inheritdoc/>
		public string Name => "Maldivian Rufiyaa";
	}
}
