namespace Nager.Country.Currencies
{
	/// <summary>
	/// Xdr Currency
	/// </summary>
	public class XdrCurrency : ICurrency
	{
		///<inheritdoc/>
		public string Symbol => "XDR";

		///<inheritdoc/>
		public string Singular => string.Empty;

		///<inheritdoc/>
		public string Plural => string.Empty;

		///<inheritdoc/>
		public string IsoCode => "XDR";

		///<inheritdoc/>
		public string NumericCode => "960";

		///<inheritdoc/>
		public string Name => "Special Drawing Rights";
	}
}
