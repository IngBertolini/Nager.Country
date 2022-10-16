namespace Nager.Country.Currencies
{
	/// <summary>
	/// Ngn Currency
	/// </summary>
	public class NgnCurrency : ICurrency
	{
		///<inheritdoc/>
		public string Symbol => "₦";

		///<inheritdoc/>
		public string Singular => string.Empty;

		///<inheritdoc/>
		public string Plural => string.Empty;

		///<inheritdoc/>
		public string IsoCode => "NGN";

		///<inheritdoc/>
		public string NumericCode => "566";

		///<inheritdoc/>
		public string Name => "Nigerian Naira";
	}
}
