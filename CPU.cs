using System;

namespace lab4
{
    class CPU
    {
        public string Model;
        public string Manufacturer;
        public int Cores;
        public int Threads;
        public double Frequency;
        public int CacheMB;
        public int TDPWatts;
        public bool HasHyperThreading;

        public double CalculatePerformance()
        {
            return Threads * Frequency;
        }
    }
}
