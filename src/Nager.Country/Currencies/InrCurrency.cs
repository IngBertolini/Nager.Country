namespace Nager.Country.Currencies
{
	/// <summary>
	/// Inr Currency
	/// </summary>
	public class InrCurrency : ICurrency
	{
		///<inheritdoc/>
		public string Symbol => "₹";

		///<inheritdoc/>
		public string Singular => string.Empty;

		///<inheritdoc/>
		public string Plural => string.Empty;

		///<inheritdoc/>
		public string IsoCode => "INR";

		///<inheritdoc/>
		public string NumericCode => "356";

		///<inheritdoc/>
		public string Name => "Indian Rupee";
	}
}
