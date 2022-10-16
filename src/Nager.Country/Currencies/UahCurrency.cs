namespace Nager.Country.Currencies
{
	/// <summary>
	/// Uah Currency
	/// </summary>
	public class UahCurrency : ICurrency
	{
		///<inheritdoc/>
		public string Symbol => "₴";

		///<inheritdoc/>
		public string Singular => string.Empty;

		///<inheritdoc/>
		public string Plural => string.Empty;

		///<inheritdoc/>
		public string IsoCode => "UAH";

		///<inheritdoc/>
		public string NumericCode => "980";

		///<inheritdoc/>
		public string Name => "Ukrainian Hryvnia";
	}
}
