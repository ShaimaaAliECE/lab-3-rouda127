using System;
using System.Collections.Generic;
namespace Lab3App
{
    public abstract class Collectable : Displayable
    {
        private string Description;
        private CollectionBoard board = new CollectionBoard();

        public string description
        {
            get
            {
                return this.Description;
            }
            set
            {
                this.Description = value;
            }
        }

        public CollectionBoard Board
        {
            get
            {
                return this.board;
            }
            set
            {
                this.board = value;
            }
        }

        public virtual void AddMe(List<Collectable> list)
        {
            list.Add(this);
            Console.WriteLine(this.description + " Collected, Congrats!!!!");


        }

        public abstract void Display();
       
    }
}
