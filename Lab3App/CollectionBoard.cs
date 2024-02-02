using System;
namespace Lab3App
{
    public class CollectionBoard
    {
        private static int TotalScore;
        private static int TotalValue;

        public int totalScore
        {
            get
            {
                return TotalScore;
            }
            set
            {
                TotalScore = value;
            }
        }

        public int totalValue
        {
            get
            {
                return TotalValue;
            }
            set
            {
                TotalValue = value;
            }
        }
    }
}
