namespace Nager.Country.Currencies
{
	/// <summary>
	/// Jod Currency
	/// </summary>
	public class JodCurrency : ICurrency
	{
		///<inheritdoc/>
		public string Symbol => "د.ا.‏";

		///<inheritdoc/>
		public string Singular => string.Empty;

		///<inheritdoc/>
		public string Plural => string.Empty;

		///<inheritdoc/>
		public string IsoCode => "JOD";

		///<inheritdoc/>
		public string NumericCode => "400";

		///<inheritdoc/>
		public string Name => "Jordanian Dinar";
	}
}
