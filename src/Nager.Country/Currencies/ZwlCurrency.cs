namespace Nager.Country.Currencies
{
	/// <summary>
	/// Zwl Currency
	/// </summary>
	public class ZwlCurrency : ICurrency
	{
		///<inheritdoc/>
		public string Symbol => string.Empty;

		///<inheritdoc/>
		public string Singular => string.Empty;

		///<inheritdoc/>
		public string Plural => string.Empty;

		///<inheritdoc/>
		public string IsoCode => "ZWL";

		///<inheritdoc/>
		public string NumericCode => "932";

		///<inheritdoc/>
		public string Name => "Zimbabwean dollar";
	}
}
