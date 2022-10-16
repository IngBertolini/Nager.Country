namespace Nager.Country.Currencies
{
	/// <summary>
	/// Lak Currency
	/// </summary>
	public class LakCurrency : ICurrency
	{
		///<inheritdoc/>
		public string Symbol => "₭";

		///<inheritdoc/>
		public string Singular => string.Empty;

		///<inheritdoc/>
		public string Plural => string.Empty;

		///<inheritdoc/>
		public string IsoCode => "LAK";

		///<inheritdoc/>
		public string NumericCode => "418";

		///<inheritdoc/>
		public string Name => "Laotian Kip";
	}
}
