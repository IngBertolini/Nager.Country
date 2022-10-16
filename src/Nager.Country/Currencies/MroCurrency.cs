namespace Nager.Country.Currencies
{
	/// <summary>
	/// Mro Currency
	/// </summary>
	public class MroCurrency : ICurrency
	{
		///<inheritdoc/>
		public string Symbol => "UM";

		///<inheritdoc/>
		public string Singular => string.Empty;

		///<inheritdoc/>
		public string Plural => string.Empty;

		///<inheritdoc/>
		public string IsoCode => "MRO";

		///<inheritdoc/>
		public string NumericCode => "478";

		///<inheritdoc/>
		public string Name => "	Mauritanian ouguiya";
	}
}
