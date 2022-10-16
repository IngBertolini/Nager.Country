namespace Nager.Country.Currencies
{
	/// <summary>
	/// Bov Currency
	/// </summary>
	public class BovCurrency : ICurrency
	{
		///<inheritdoc/>
		public string Symbol => string.Empty;

		///<inheritdoc/>
		public string Singular => string.Empty;

		///<inheritdoc/>
		public string Plural => string.Empty;

		///<inheritdoc/>
		public string IsoCode => "BOV";

		///<inheritdoc/>
		public string NumericCode => "984";

		///<inheritdoc/>
		public string Name => "Bolivian Mvdol (funds code)";
	}
}
