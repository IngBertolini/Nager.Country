namespace Nager.Country.Currencies
{
	/// <summary>
	/// Kes Currency
	/// </summary>
	public class KesCurrency : ICurrency
	{
		///<inheritdoc/>
		public string Symbol => "Ksh";

		///<inheritdoc/>
		public string Singular => string.Empty;

		///<inheritdoc/>
		public string Plural => string.Empty;

		///<inheritdoc/>
		public string IsoCode => "KES";

		///<inheritdoc/>
		public string NumericCode => "404";

		///<inheritdoc/>
		public string Name => "Kenyan Shilling";
	}
}
