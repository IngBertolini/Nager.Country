namespace Nager.Country.Currencies
{
	/// <summary>
	/// Kmf Currency
	/// </summary>
	public class KmfCurrency : ICurrency
	{
		///<inheritdoc/>
		public string Symbol => "CF";

		///<inheritdoc/>
		public string Singular => string.Empty;

		///<inheritdoc/>
		public string Plural => string.Empty;

		///<inheritdoc/>
		public string IsoCode => "KMF";

		///<inheritdoc/>
		public string NumericCode => "174";

		///<inheritdoc/>
		public string Name => "Comoro franc";
	}
}
