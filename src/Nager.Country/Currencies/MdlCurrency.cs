namespace Nager.Country.Currencies
{
	/// <summary>
	/// Mdl Currency
	/// </summary>
	public class MdlCurrency : ICurrency
	{
		///<inheritdoc/>
		public string Symbol => "L";

		///<inheritdoc/>
		public string Singular => string.Empty;

		///<inheritdoc/>
		public string Plural => string.Empty;

		///<inheritdoc/>
		public string IsoCode => "MDL";

		///<inheritdoc/>
		public string NumericCode => "498";

		///<inheritdoc/>
		public string Name => "Moldovan Leu";
	}
}
