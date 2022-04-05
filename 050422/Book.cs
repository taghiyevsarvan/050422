using System;
using System.Collections.Generic;
using System.Text;

namespace _050422
{
    internal class Book
    { //- No
      //- Name
      //- AuthorName
      //- Genre(genre enum tipində)
      //- Price

        public Book()
        {
            _no++;
            No = _no;
        }
        private static int _no;
        public int No { get;}
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public Genre Genre { get; set; }
        public double Price { get; set; }

        public string ShowInfo()
        {
            return $"No: {this.No} - Name: {this.Name} - AuthorName: {this.AuthorName} - Genre: {this.Genre} - Price: {this.Price}$";
        }
    }
}
