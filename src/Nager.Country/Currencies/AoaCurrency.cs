﻿namespace Nager.Country.Currencies
{
	/// <summary>
	/// Aoa Currency
	/// </summary>
	public class AoaCurrency : ICurrency
	{
		///<inheritdoc/>
		public string Symbol => "Kz";

		///<inheritdoc/>
		public string Singular => "kwanza";

		///<inheritdoc/>
		public string Plural => string.Empty;

		///<inheritdoc/>
		public string IsoCode => "AOA";

		///<inheritdoc/>
		public string NumericCode => "973";

		///<inheritdoc/>
		public string Name => "Angolan kwanza";
	}
}
