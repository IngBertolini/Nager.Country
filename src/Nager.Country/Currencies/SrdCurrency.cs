namespace Nager.Country.Currencies
{
	/// <summary>
	/// Sos Currency
	/// </summary>
	public class SosCurrency : ICurrency
	{
		///<inheritdoc/>
		public string Symbol => "S";

		///<inheritdoc/>
		public string Singular => string.Empty;

		///<inheritdoc/>
		public string Plural => string.Empty;

		///<inheritdoc/>
		public string IsoCode => "SOS";

		///<inheritdoc/>
		public string NumericCode => "706";

		///<inheritdoc/>
		public string Name => "Somali Shilling";
	}
}
