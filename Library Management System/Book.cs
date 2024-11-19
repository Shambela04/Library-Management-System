using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public bool IsIssued { get; set; }

        public Book(int bookId, string title, string author)
        {
            BookId = bookId;
            Title = title;
            Author = author;
            IsIssued = false;
        }

        public void DisplayBookDetails()
        {
            Console.WriteLine($"Book ID: {BookId}, Title: {Title}, Author: {Author}, Issued: {IsIssued}");
        }
    }
}
