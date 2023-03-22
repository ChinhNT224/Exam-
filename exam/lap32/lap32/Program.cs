using System;

namespace BookApp
{
    class Book
    {
        private string author;
        private int pages;
        private string isbn;
        private string title;
        private int currentPage;

        public Book()
        {
            currentPage = 1;
        }

        public Book(string author, int pages, string isbn, string title)
        {
            this.author = author;
            this.pages = pages;
            this.isbn = isbn;
            this.title = title;
            currentPage = 1;
        }

        public void FlipPageForward()
        {
            if (currentPage < pages)
            {
                currentPage++;
            }
        }

        public void FlipPageBackward()
        {
            if (currentPage > 1)
            {
                currentPage--;
            }
        }

        public void Display()
        {
            Console.WriteLine("Title: {0}", title);
            Console.WriteLine("Author: {0}", author);
            Console.WriteLine("ISBN: {0}", isbn);
            Console.WriteLine("Pages: {0}", pages);
            Console.WriteLine("Current Page: {0}", currentPage);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Mark Twain", 200, "1234567890", "Adventures of Huckleberry Finn");
            Book book2 = new Book("J.K. Rowling", 300, "0987654321", "Harry Potter and the Philosopher's Stone");

            book1.Display();
            Console.WriteLine();
            book2.Display();
            Console.WriteLine();

            book1.FlipPageForward();
            book2.FlipPageForward();

            Console.WriteLine("After flipping forward:");
            book1.Display();
            Console.WriteLine();
            book2.Display();
            Console.WriteLine();

            book1.FlipPageBackward();
            book2.FlipPageBackward();

            Console.WriteLine("After flipping backward:");
            book1.Display();
            Console.WriteLine();
            book2.Display();

            Console.ReadKey();
        }
    }
}
