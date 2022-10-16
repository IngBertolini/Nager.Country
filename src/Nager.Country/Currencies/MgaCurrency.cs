namespace Nager.Country.Currencies
{
	/// <summary>
	/// Mga Currency
	/// </summary>
	public class MgaCurrency : ICurrency
	{
		///<inheritdoc/>
		public string Symbol => "Ar";

		///<inheritdoc/>
		public string Singular => string.Empty;

		///<inheritdoc/>
		public string Plural => string.Empty;

		///<inheritdoc/>
		public string IsoCode => "MGA";

		///<inheritdoc/>
		public string NumericCode => "969";

		///<inheritdoc/>
		public string Name => "Malagasy ariary";
	}
}
