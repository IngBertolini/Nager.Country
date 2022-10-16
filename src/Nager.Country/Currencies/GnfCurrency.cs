namespace Nager.Country.Currencies
{
	/// <summary>
	/// Gnf Currency
	/// </summary>
	public class GnfCurrency : ICurrency
	{
		///<inheritdoc/>
		public string Symbol => "FG";

		///<inheritdoc/>
		public string Singular => string.Empty;

		///<inheritdoc/>
		public string Plural => string.Empty;

		///<inheritdoc/>
		public string IsoCode => "GNF";

		///<inheritdoc/>
		public string NumericCode => "324";

		///<inheritdoc/>
		public string Name => "Guinean franc";
	}
}
