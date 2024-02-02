using System;
using System.Collections.Generic;

namespace Lab3App
{
    public class Axe : Tool
    {
        public Axe(string name)
        {
            description = name;
       
        }
        public override void Display()
        {
            Console.WriteLine("Axe " + this.description + " is displayed");

        }

        public override void DoAction()
        {
            Console.WriteLine("Axe is Used");
        }

        public override void AddMe(List<Collectable> list)
        {
            base.AddMe(list);
        }
    }
}
