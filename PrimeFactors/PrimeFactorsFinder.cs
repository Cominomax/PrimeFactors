using System.Text;

namespace PrimeFactors
{
    public class PrimeFactorsFinder
    {
        private static PrimeFactorsFinder _instance;

        private PrimeFactorsFinder() { }

        public static PrimeFactorsFinder Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new PrimeFactorsFinder();
                }
                return _instance;
            }
        }

        public string GetFrom(int number)
        {
            var sb = new StringBuilder();
            while (number % 2 == 0)
            {
                sb.Insert(0, "2 ");
                number /= 2;
            }

            for (int i = 3; i <= number; i += 2)
            {
                while(number % i == 0)
                {
                    sb.Insert(0, $"{i} ");
                    number /= i;
                }
            }

            return sb.ToString().Trim();
        }
    }
}
