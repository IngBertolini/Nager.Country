namespace Nager.Country.Currencies
{
	/// <summary>
	/// Rwf Currency
	/// </summary>
	public class RwfCurrency : ICurrency
	{
		///<inheritdoc/>
		public string Symbol => "RF";

		///<inheritdoc/>
		public string Singular => string.Empty;

		///<inheritdoc/>
		public string Plural => string.Empty;

		///<inheritdoc/>
		public string IsoCode => "RWF";

		///<inheritdoc/>
		public string NumericCode => "646";

		///<inheritdoc/>
		public string Name => "Rwandan Franc";
	}
}
