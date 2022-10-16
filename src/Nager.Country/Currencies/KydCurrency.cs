namespace Nager.Country.Currencies
{
	/// <summary>
	/// Kyd Currency
	/// </summary>
	public class KydCurrency : ICurrency
	{
		///<inheritdoc/>
		public string Symbol => "$";

		///<inheritdoc/>
		public string Singular => string.Empty;

		///<inheritdoc/>
		public string Plural => string.Empty;

		///<inheritdoc/>
		public string IsoCode => "KYD";

		///<inheritdoc/>
		public string NumericCode => "136";

		///<inheritdoc/>
		public string Name => "Cayman Islands dollar";
	}
}
