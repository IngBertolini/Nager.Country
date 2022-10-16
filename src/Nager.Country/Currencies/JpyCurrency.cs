namespace Nager.Country.Currencies
{
	/// <summary>
	/// Jpy Currency
	/// </summary>
	public class JpyCurrency : ICurrency
	{
		///<inheritdoc/>
		public string Symbol => "¥";

		///<inheritdoc/>
		public string Singular => string.Empty;

		///<inheritdoc/>
		public string Plural => string.Empty;

		///<inheritdoc/>
		public string IsoCode => "JPY";

		///<inheritdoc/>
		public string NumericCode => "392";

		///<inheritdoc/>
		public string Name => "Japanese Yen";
	}
}
