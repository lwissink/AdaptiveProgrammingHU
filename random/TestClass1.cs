using System.Threading;

namespace random
{
    public class TestClass1
    {
        private int leeftijd;
        
        public int verhoogleeftijd(int verhoging)
        {
            leeftijd = leeftijd + verhoging;
            return leeftijd;
        }
    }
}