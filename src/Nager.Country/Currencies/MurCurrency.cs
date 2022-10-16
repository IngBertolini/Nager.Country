namespace Nager.Country.Currencies
{
	/// <summary>
	/// Mur Currency
	/// </summary>
	public class MurCurrency : ICurrency
	{
		///<inheritdoc/>
		public string Symbol => "₨";

		///<inheritdoc/>
		public string Singular => string.Empty;

		///<inheritdoc/>
		public string Plural => string.Empty;

		///<inheritdoc/>
		public string IsoCode => "MUR";

		///<inheritdoc/>
		public string NumericCode => "480";

		///<inheritdoc/>
		public string Name => "Mauritian rupee";
	}
}
