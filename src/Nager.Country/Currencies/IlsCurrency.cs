namespace Nager.Country.Currencies
{
	/// <summary>
	/// Ils Currency
	/// </summary>
	public class IlsCurrency : ICurrency
	{
		///<inheritdoc/>
		public string Symbol => "₪";

		///<inheritdoc/>
		public string Singular => string.Empty;

		///<inheritdoc/>
		public string Plural => string.Empty;

		///<inheritdoc/>
		public string IsoCode => "ILS";

		///<inheritdoc/>
		public string NumericCode => "376";

		///<inheritdoc/>
		public string Name => "Israeli New Shekel";
	}
}
