namespace Nager.Country.Currencies
{
	/// <summary>
	/// Mxn Currency
	/// </summary>
	public class MxnCurrency : ICurrency
	{
		///<inheritdoc/>
		public string Symbol => "$";

		///<inheritdoc/>
		public string Singular => string.Empty;

		///<inheritdoc/>
		public string Plural => string.Empty;

		///<inheritdoc/>
		public string IsoCode => "MXN";

		///<inheritdoc/>
		public string NumericCode => "484";

		///<inheritdoc/>
		public string Name => "Mexican Peso";
	}
}
