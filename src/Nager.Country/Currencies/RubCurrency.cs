namespace Nager.Country.Currencies
{
	/// <summary>
	/// Rub Currency
	/// </summary>
	public class RubCurrency : ICurrency
	{
		///<inheritdoc/>
		public string Symbol => "₽";

		///<inheritdoc/>
		public string Singular => string.Empty;

		///<inheritdoc/>
		public string Plural => string.Empty;

		///<inheritdoc/>
		public string IsoCode => "RUB";

		///<inheritdoc/>
		public string NumericCode => "643";

		///<inheritdoc/>
		public string Name => "Russian Ruble";
	}
}
