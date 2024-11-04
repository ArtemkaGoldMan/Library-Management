using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using Library_Management.Commands;
using Library_Management.Models;
using Library_Management;
using Library_Management.Services;

public class MainViewModel : INotifyPropertyChanged
{
    private readonly IBookService _bookService;
    public ObservableCollection<Book> Books { get; set; }
    public Book SelectedBook { get; set; }

    public ICommand AddBookCommand { get; }
    public ICommand UpdateBookCommand { get; }
    public ICommand DeleteBookCommand { get; }

    public MainViewModel(IBookService bookService)
    {
        _bookService = bookService;
        Books = new ObservableCollection<Book>();

        AddBookCommand = new RelayCommand(OpenBookDetailsWindowForAdding);
        UpdateBookCommand = new RelayCommand(OpenBookDetailsWindowForEditing, _ => SelectedBook != null);
        DeleteBookCommand = new RelayCommand(DeleteSelectedBook, _ => SelectedBook != null);

        LoadBooks();
    }

    private void LoadBooks()
    {
        var books = _bookService.GetAllBooksAsync().Result; 
        foreach (var book in books)
        {
            Books.Add(book);
        }
    }

    private void OpenBookDetailsWindowForAdding(object obj)
    {
        var bookDetailsViewModel = new BookDetailsViewModel();
        var bookDetailsWindow = new BookDetailsWindow
        {
            DataContext = bookDetailsViewModel
        };

        bookDetailsViewModel.BookSaved += async (newBook) =>
        {
            await _bookService.AddBookAsync(newBook);
            Books.Add(newBook);
        };

        bookDetailsWindow.ShowDialog();
    }

    private void OpenBookDetailsWindowForEditing(object obj)
    {
        if (SelectedBook == null) return;

        var bookDetailsViewModel = new BookDetailsViewModel(SelectedBook);
        var bookDetailsWindow = new BookDetailsWindow
        {
            DataContext = bookDetailsViewModel
        };

        bookDetailsViewModel.BookSaved += async (updatedBook) =>
        {
            await _bookService.UpdateBookAsync(updatedBook);
            OnPropertyChanged(nameof(Books));
        };

        bookDetailsWindow.ShowDialog();
    }

    private void DeleteSelectedBook(object obj)
    {
        if (SelectedBook == null) return;

        _bookService.DeleteBookAsync(SelectedBook.Id).Wait();
        Books.Remove(SelectedBook);
    }

    public event PropertyChangedEventHandler PropertyChanged;
    protected virtual void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
