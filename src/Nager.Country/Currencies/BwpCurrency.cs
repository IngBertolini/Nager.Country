﻿namespace Nager.Country.Currencies
{
	/// <summary>
	/// Bwp Currency
	/// </summary>
	public class BwpCurrency : ICurrency
	{
		///<inheritdoc/>
		public string Symbol => "P";

		///<inheritdoc/>
		public string Singular => "Pula";

		///<inheritdoc/>
		public string Plural => string.Empty;

		///<inheritdoc/>
		public string IsoCode => "BWP";

		///<inheritdoc/>
		public string NumericCode => "072";

		///<inheritdoc/>
		public string Name => "Botswana pula";
	}
}
