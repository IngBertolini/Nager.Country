namespace Nager.Country.Currencies
{
	/// <summary>
	/// Sbd Currency
	/// </summary>
	public class SbdCurrency : ICurrency
	{
		///<inheritdoc/>
		public string Symbol => "$";

		///<inheritdoc/>
		public string Singular => string.Empty;

		///<inheritdoc/>
		public string Plural => string.Empty;

		///<inheritdoc/>
		public string IsoCode => "SBD";

		///<inheritdoc/>
		public string NumericCode => "090";

		///<inheritdoc/>
		public string Name => "Solomon Islands dollar";
	}
}
