using System;
using System.Collections.Generic;
namespace Lab3App
{
    public class Diamond : Treasure
    {
        public Diamond(string name, int score)
        {
            description = name;
            Score = score;

        }
        public override void Display()
        {
            Console.WriteLine("Diamond " + this.description + " is displayed");

        }

        public override void AddMe(List<Collectable> list)
        {
            base.AddMe(list);
        }
    }
}