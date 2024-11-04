using Library_Management.Commands;
using Library_Management.Models;
using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;

namespace Library_Management
{
    public class BookDetailsViewModel : INotifyPropertyChanged
    {
        private string _bookTitle;
        private string _bookAuthor;
        private string _bookYear;
        private Book _originalBook;

        public string BookTitle
        {
            get => _bookTitle;
            set
            {
                _bookTitle = value;
                OnPropertyChanged(nameof(BookTitle));
            }
        }

        public string BookAuthor
        {
            get => _bookAuthor;
            set
            {
                _bookAuthor = value;
                OnPropertyChanged(nameof(BookAuthor));
            }
        }

        public string BookYear
        {
            get => _bookYear;
            set
            {
                _bookYear = value;
                OnPropertyChanged(nameof(BookYear));
            }
        }


        public ICommand SaveCommand { get; }

        public event Action<Book> BookSaved;

        public BookDetailsViewModel()
        {
            SaveCommand = new RelayCommand(SaveBook);
        }

        public BookDetailsViewModel(Book book) : this()
        {
            _originalBook = book;
            BookTitle = book.Title;
            BookAuthor = book.Author;
            BookYear = book.YearPublished.ToString();
        }

        private void SaveBook(object obj)
        {
            if (int.TryParse(BookYear, out int year))
            {
                if (_originalBook != null)
                {
                    _originalBook.Title = BookTitle;
                    _originalBook.Author = BookAuthor;
                    _originalBook.YearPublished = year;
                    BookSaved?.Invoke(_originalBook);
                }
                else
                {
                    var newBook = new Book
                    {
                        Title = BookTitle,
                        Author = BookAuthor,
                        YearPublished = year
                    };
                    BookSaved?.Invoke(newBook);
                }

                if (obj is Window window)
                {
                    window.Close();
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid year.");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
