namespace Nager.Country.Currencies
{
	/// <summary>
	/// Tjs Currency
	/// </summary>
	public class TjsCurrency : ICurrency
	{
		///<inheritdoc/>
		public string Symbol => "смн";

		///<inheritdoc/>
		public string Singular => string.Empty;

		///<inheritdoc/>
		public string Plural => string.Empty;

		///<inheritdoc/>
		public string IsoCode => "TJS";

		///<inheritdoc/>
		public string NumericCode => "972";

		///<inheritdoc/>
		public string Name => "Tajikistani Somoni";
	}
}
