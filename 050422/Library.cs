using System;
using System.Collections.Generic;
using System.Text;

namespace _050422
{
    internal class Library
    {
        List<Book> _books;
        public Library()
        {
            _books = new List<Book>();
        }


        public bool IsExistsBook(Predicate<Book> predicate)
        {
            var search = _books.Find(predicate);
            if (search == null)
                return false;
            return true;
        }

        public List<Book> FilterByPrice(double minPrice, double maxPrice)
        {
            var filteredPrice = _books.FindAll(b => b.Price >= minPrice && b.Price <= maxPrice);
            if (filteredPrice.Count == 0)
                throw new Exception("xeta");

            return filteredPrice;
        }

        public List<Book> FilterByGenre(Genre genre)
        {
            return _books.FindAll(b => b.Genre == genre);
        }

        public Book FindBookByNo(int? no)
        {
            if (no == null)
                throw new NullReferenceException("id null ola bilmez");

            return _books.Find(b => b.No == no);
        }

        public void AddBook(Book book)
        {
            if (IsExistsBook(b => b.Name == book.Name))
                throw new Exception("Bu kitab movcuddur");
            _books.Add(book);
        }
    }
}
