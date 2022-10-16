namespace Nager.Country.Currencies
{
	/// <summary>
	/// Mop Currency
	/// </summary>
	public class MopCurrency : ICurrency
	{
		///<inheritdoc/>
		public string Symbol => "MOP";

		///<inheritdoc/>
		public string Singular => string.Empty;

		///<inheritdoc/>
		public string Plural => string.Empty;

		///<inheritdoc/>
		public string IsoCode => "MOP";

		///<inheritdoc/>
		public string NumericCode => "446";

		///<inheritdoc/>
		public string Name => "Macanese Pataca";
	}
}
