namespace Nager.Country.Currencies
{
	/// <summary>
	/// Myr Currency
	/// </summary>
	public class MyrCurrency : ICurrency
	{
		///<inheritdoc/>
		public string Symbol => "RM";

		///<inheritdoc/>
		public string Singular => string.Empty;

		///<inheritdoc/>
		public string Plural => string.Empty;

		///<inheritdoc/>
		public string IsoCode => "MYR";

		///<inheritdoc/>
		public string NumericCode => "458";

		///<inheritdoc/>
		public string Name => "Malaysian Ringgit";
	}
}
