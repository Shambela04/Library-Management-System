using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    public class Member
    {

        public int MemberId { get; set; }
        public string Name { get; set; }
        public List<Book> IssuedBooks { get; set; }

        public Member(int memberId, string name)
        {
            MemberId = memberId;
            Name = name;
            IssuedBooks = new List<Book>();
        }

        public void DisplayMemberDetails()
        {
            Console.WriteLine($"Member ID : {MemberId}, Name : {Name}, Issued Books : {IssuedBooks.Count}");
        }
    }
}

