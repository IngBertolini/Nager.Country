namespace Nager.Country.Currencies
{
	/// <summary>
	/// Lrd Currency
	/// </summary>
	public class LrdCurrency : ICurrency
	{
		///<inheritdoc/>
		public string Symbol => "$";

		///<inheritdoc/>
		public string Singular => string.Empty;

		///<inheritdoc/>
		public string Plural => string.Empty;

		///<inheritdoc/>
		public string IsoCode => "LRD";

		///<inheritdoc/>
		public string NumericCode => "430";

		///<inheritdoc/>
		public string Name => "Liberian dollar";
	}
}
