using System;

namespace lab4
{
    class Town
    {
        public string Name;
        public string Country;
        public string Region;
        public int Population;
        public double YearIncome;
        public double Square;
        public bool HasPort;
        public bool HasAirport;
        public double GetYearIncomePerInhabitant()
        {
            return YearIncome / Population;
        }
    }
}
