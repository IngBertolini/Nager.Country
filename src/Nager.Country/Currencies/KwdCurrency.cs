namespace Nager.Country.Currencies
{
	/// <summary>
	/// Kwd Currency
	/// </summary>
	public class KwdCurrency : ICurrency
	{
		///<inheritdoc/>
		public string Symbol => "د.ك.‏";

		///<inheritdoc/>
		public string Singular => string.Empty;

		///<inheritdoc/>
		public string Plural => string.Empty;

		///<inheritdoc/>
		public string IsoCode => "KWD";

		///<inheritdoc/>
		public string NumericCode => "414";

		///<inheritdoc/>
		public string Name => "Kuwaiti Dinar";
	}
}
