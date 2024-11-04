﻿using Library_Management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management.Services
{
    public class BookService : IBookService
    {
        private readonly List<Book> _books = new List<Book>();

        public Task<IEnumerable<Book>> GetAllBooksAsync()
        {
            return Task.FromResult<IEnumerable<Book>>(_books);
        }

        public Task<Book> GetBookByIdAsync(int id)
        {
            return Task.FromResult(_books.FirstOrDefault(b => b.Id == id));
        }

        public Task AddBookAsync(Book book)
        {
            _books.Add(book);
            return Task.CompletedTask;
        }

        public Task UpdateBookAsync(Book book)
        {
            var existingBook = _books.FirstOrDefault(b => b.Id == book.Id);
            if (existingBook != null)
            {
                existingBook.Title = book.Title;
                existingBook.Author = book.Author;
                existingBook.YearPublished = book.YearPublished;
            }
            return Task.CompletedTask;
        }

        public Task DeleteBookAsync(int id)
        {
            var book = _books.FirstOrDefault(b => b.Id == id);
            if (book != null)
            {
                _books.Remove(book);
            }
            return Task.CompletedTask;
        }
    }
}
