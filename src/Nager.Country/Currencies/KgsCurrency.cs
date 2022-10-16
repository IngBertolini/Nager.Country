namespace Nager.Country.Currencies
{
	/// <summary>
	/// Kgs Currency
	/// </summary>
	public class KgsCurrency : ICurrency
	{
		///<inheritdoc/>
		public string Symbol => "сом";

		///<inheritdoc/>
		public string Singular => string.Empty;

		///<inheritdoc/>
		public string Plural => string.Empty;

		///<inheritdoc/>
		public string IsoCode => "KGS";

		///<inheritdoc/>
		public string NumericCode => "417";

		///<inheritdoc/>
		public string Name => "Kyrgystani Som";
	}
}
