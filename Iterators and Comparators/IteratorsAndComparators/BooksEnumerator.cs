using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IteratorsAndComparators
{
    public class BooksEnumerator : IEnumerator<Book>
    {
        private readonly List<Book> books;
        private int currentIndex = -1;
        public BooksEnumerator()
        {
            this.books = new List<Book>();
        }

        public BooksEnumerator(List<Book> books)
        {
            this.books = books;
        }

        public Book Current => books[currentIndex];

        object? IEnumerator.Current => Current;

        public void Dispose()
        { }

        public bool MoveNext()
        {
            currentIndex++;
            return currentIndex < books.Count;
        }

        public void Reset()
        {
            currentIndex = -1;
        }
    }
}
