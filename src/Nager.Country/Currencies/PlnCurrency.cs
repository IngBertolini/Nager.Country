namespace Nager.Country.Currencies
{
    public class PlnCurrency : ICurrency
    {
        public string Symbol => "zł";

        public string Singular => null;

        public string Plural => null;

        public string IsoCode => "PLN";

        public string NumericCode => null;

        public string Name => "Polish Zloty";
    }
}
