using System;
using System.Collections.Generic;
namespace Lab3App
{
    public abstract class Treasure : Collectable
    {
        private int score;
        public int Score
        {
            get
            {
                return this.score;
            }
            set
            {
                this.score = value;
            }
        }
        public int UpdateTotalScore(int newScore)
        {
            Board.totalScore += newScore;
            return Board.totalScore;

        }

        public override void AddMe(List<Collectable> list) {

            base.AddMe(list);
            Console.WriteLine("Total Score is updated to: " + UpdateTotalScore(this.Score));
        }
        

        public abstract override void Display();

        
    }
}
