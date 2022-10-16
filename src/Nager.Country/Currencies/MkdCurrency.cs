namespace Nager.Country.Currencies
{
	/// <summary>
	/// Mkd Currency
	/// </summary>
	public class MkdCurrency : ICurrency
	{
		///<inheritdoc/>
		public string Symbol => "ден";

		///<inheritdoc/>
		public string Singular => string.Empty;

		///<inheritdoc/>
		public string Plural => string.Empty;

		///<inheritdoc/>
		public string IsoCode => "MKD";

		///<inheritdoc/>
		public string NumericCode => "807";

		///<inheritdoc/>
		public string Name => "Macedonian Denar";
	}
}
