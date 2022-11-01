namespace Task_2
{
    class Converter
    {
        public double usd { get; set; }
        public double eur { get; set; }
        public double gbp { get; set; }

        public double UAHToCurrency(double amountOfUAH, double rate) => amountOfUAH / rate;
        public double CurrencyToUAH(double amountOfCurrency, double rate) => amountOfCurrency * rate;

        public Converter(double usd, double eur, double gbp)
        {
            this.usd = usd;
            this.eur = eur;
            this.gbp = gbp;
        }
    }
}
