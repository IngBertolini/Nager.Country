namespace Nager.Country.Currencies
{
	/// <summary>
	/// Nio Currency
	/// </summary>
	public class NioCurrency : ICurrency
	{
		///<inheritdoc/>
		public string Symbol => "C$";

		///<inheritdoc/>
		public string Singular => string.Empty;

		///<inheritdoc/>
		public string Plural => string.Empty;

		///<inheritdoc/>
		public string IsoCode => "NIO";

		///<inheritdoc/>
		public string NumericCode => "558";

		///<inheritdoc/>
		public string Name => "Nicaraguan Córdoba";
	}
}
