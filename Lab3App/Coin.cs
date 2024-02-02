using System;
using System.Collections.Generic;
namespace Lab3App
{
    public class Coin : Treasure
    {
        private int Value;

        public Coin(string name, int score, int value)
        {
            Value = value;
            this.Score = score;
            this.description = name;
        }
        public int UpdateTotalValue(int newValue)
        {
            Board.totalValue += newValue;
            return Board.totalValue;
        }
        public override void Display()
        {
            Console.WriteLine("Coin " + this.description + " is displayed");

        }
        public override void AddMe(List<Collectable> list)  
        {
            base.AddMe(list);
            Console.WriteLine("Total Value is updated to: " + UpdateTotalValue(Value));
        }
    }
}
