namespace Nager.Country.Currencies
{
	/// <summary>
	/// Hnl Currency
	/// </summary>
	public class HnlCurrency : ICurrency
	{
		///<inheritdoc/>
		public string Symbol => "L";

		///<inheritdoc/>
		public string Singular => string.Empty;

		///<inheritdoc/>
		public string Plural => string.Empty;

		///<inheritdoc/>
		public string IsoCode => "HNL";

		///<inheritdoc/>
		public string NumericCode => "340";

		///<inheritdoc/>
		public string Name => "Honduran Lempira";
	}
}
