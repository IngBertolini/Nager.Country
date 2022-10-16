namespace Nager.Country.Currencies
{
	/// <summary>
	/// Pab Currency
	/// </summary>
	public class PabCurrency : ICurrency
	{
		///<inheritdoc/>
		public string Symbol => "B/.";

		///<inheritdoc/>
		public string Singular => string.Empty;

		///<inheritdoc/>
		public string Plural => string.Empty;

		///<inheritdoc/>
		public string IsoCode => "PAB";

		///<inheritdoc/>
		public string NumericCode => "590";

		///<inheritdoc/>
		public string Name => "Panamanian Balboa";
	}
}
