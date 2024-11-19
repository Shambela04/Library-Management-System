using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    internal class Program1
    {
        static void Main()
        {
            var library = new Library();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\nLibrary Management System");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Remove Book ");
                Console.WriteLine("3. Add Member");
                Console.WriteLine("4. Remove Member");
                Console.WriteLine("5. Issued Book ");
                Console.WriteLine("6. Return Book");
                Console.WriteLine("7. List All Books");
                Console.WriteLine("8. List All Members");
                Console.WriteLine("9. Exit"); 
                Console.WriteLine("Select an Option :");


                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Invalid input. Please enter a number:");
                    continue;
                }

                try
                {
                    switch (choice)
                    {
                        case 1:
                            Console.Write("Enter Book ID : ");
                            int bookId = int.Parse(Console.ReadLine());

                            Console.Write("Enter Title: ");
                            string title = Console.ReadLine();

                            Console.Write("Enter Author : ");
                            string author = Console.ReadLine();

                            library.AddBook(new Book(bookId, title, author));
                            break;

                        case 2:
                            Console.Write("Enter Book ID to remove : ");
                            int removeBookId = int.Parse(Console.ReadLine());
                            library.RemoveBook(removeBookId);
                            break;

                        case 3:
                            Console.Write("Enter Member ID: ");
                            int memberId = int.Parse(Console.ReadLine());

                            Console.Write("Enter Name: ");
                            string name = Console.ReadLine();

                            library.AddMember(new Member(memberId, name));
                            break;

                        case 4:
                            Console.Write("Enter Member ID to remove: ");
                            int removeMemberId = int.Parse(Console.ReadLine());

                            library.RemoveMember(removeMemberId);
                            break;

                        case 5:
                            Console.Write("Enter Book ID to issue: ");
                            int issueBookId = int.Parse(Console.ReadLine());

                            Console.Write("Enter Member ID to issue to: ");
                            int issueMemberId = int.Parse(Console.ReadLine());

                            library.IssueBook(issueBookId, issueMemberId);
                            break;

                        case 6:
                            Console.Write("Enter Book ID to return: ");
                            int returnBookId = int.Parse(Console.ReadLine());

                            Console.Write("Enter Member ID to return to: ");
                            int returnMemberId = int.Parse(Console.ReadLine());

                            library.ReturnBook(returnBookId, returnMemberId);
                            break;

                        case 7:
                            library.ListAllBooks();
                            break;

                        case 8:
                            library.ListAllMembers();
                            break;

                        case 9:
                            Console.WriteLine(" Thank you visit again....");
                            Console.WriteLine(" Have A Good Day......");
                            exit = true;
                            break;

                        default:
                            Console.WriteLine("Invalid choice. Please select a valid option.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }
    }
}
