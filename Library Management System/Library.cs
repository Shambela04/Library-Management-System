using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    public class Library
    {
        public List<Book> Books { get; set; }
        public List<Member> Members { get; set; }

        public Library()
        {
            Books = new List<Book>();
            Members = new List<Member>();
        }

        public void AddBook(Book book)
        {
            Books.Add(book);
            Console.WriteLine("Book added Successfully....");
        }

        public void RemoveBook(int bookId)
        {
            var book = Books.FirstOrDefault(b => b.BookId == bookId);
            if (book == null)
            {
                throw new Exception("Book not found.");
            }
            Books.Remove(book);
            Console.WriteLine("Book removed Successfully.....");
        }

            //for add new member
        public void AddMember(Member member)
        {
            Members.Add(member);
            Console.WriteLine("Member Added Successfully.....");
        }
             //for remove member
        public void RemoveMember(int memberId)
        {
            var member = Members.FirstOrDefault(m => m.MemberId == memberId);
            if (member == null)
            {
                throw new Exception("Member not found.");
            }
            Members.Remove(member);
            Console.WriteLine("Member removed successfully....");
        }

        public void IssueBook(int bookId, int memberId)
        {
            var book = Books.FirstOrDefault(b => b.BookId == bookId);
            var member = Members.FirstOrDefault(m => m.MemberId == memberId);

            if (book == null) throw new Exception("Book not found.");
            if (member == null) throw new Exception("Member not found.");
            if (book.IsIssued) throw new Exception("Book already issued.");

            book.IsIssued = true;
            member.IssuedBooks.Add(book);
            Console.WriteLine("Book issued successfully.....");
        }

        public void ReturnBook(int bookId, int memberId)
        {
            var book = Books.FirstOrDefault(b => b.BookId == bookId);
            var member = Members.FirstOrDefault(m => m.MemberId == memberId);

            if (book == null) throw new Exception("Book not found.");
            if (member == null) throw new Exception("Member not found.");
            if (!book.IsIssued) throw new Exception("Book is not currently issued.");

            book.IsIssued = false;
            member.IssuedBooks.Remove(book);
            Console.WriteLine("Book returned successfully......");
        }

        public void ListAllBooks()
        {
            if (Books.Count == 0)
            {
                Console.WriteLine("No books available.");
                return;
            }
            Console.WriteLine("Books in the library:");
            foreach (var book in Books)
            {
                book.DisplayBookDetails();
            }
        }

        public void ListAllMembers()
        {
            if (Members.Count == 0)
            {
                Console.WriteLine("No members registered.");
                return;
            }
            Console.WriteLine("Library members:");
            foreach (var member in Members)
            {
                member.DisplayMemberDetails();
            }
        }
    }
}
