using System;
using System.Collections.Generic;

namespace BookList
{
    class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Tạo 1 collection gồm 10 quyển sách.
            List<Book> books = new List<Book>()
            {
                new Book() { Id = 1, Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", Publisher = "Scribner", Year = 1925, Price = 10.99 },
                new Book() { Id = 2, Title = "To Kill a Mockingbird", Author = "Harper Lee", Publisher = "J. B. Lippincott & Co.", Year = 1960, Price = 8.99 },
                new Book() { Id = 3, Title = "1984", Author = "George Orwell", Publisher = "Secker & Warburg", Year = 1949, Price = 7.99 },
                new Book() { Id = 4, Title = "Animal Farm", Author = "George Orwell", Publisher = "Secker & Warburg", Year = 1945, Price = 6.99 },
                new Book() { Id = 5, Title = "Brave New World", Author = "Aldous Huxley", Publisher = "Chatto & Windus", Year = 1932, Price = 9.99 },
                new Book() { Id = 6, Title = "The Catcher in the Rye", Author = "J. D. Salinger", Publisher = "Little, Brown and Company", Year = 1951, Price = 11.99 },
                new Book() { Id = 7, Title = "Lord of the Flies", Author = "William Golding", Publisher = "Faber and Faber", Year = 1954, Price = 5.99 },
                new Book() { Id = 8, Title = "One Hundred Years of Solitude", Author = "Gabriel Garcia Marquez", Publisher = "Harper & Row", Year = 1967, Price = 12.99 },
                new Book() { Id = 9, Title = "Pride and Prejudice", Author = "Jane Austen", Publisher = "T. Egerton", Year = 1813, Price = 14.99 },
                new Book() { Id = 10, Title = "The Picture of Dorian Gray", Author = "Oscar Wilde", Publisher = "Ward, Lock, and Company", Year = 1890, Price = 13.99 },
            };

            // In danh sách các quyển sách tăng dần theo giá.
            Console.WriteLine("Danh sách các quyển sách tăng dần theo giá:");
            books.Sort((x, y) => x.Price.CompareTo(y.Price));
            foreach (var book in books)
            {
                Console.WriteLine("{0,-2} {1,-30} {2,-20} {3,-20} {4,-5} {5,5}", book.Id, book.Title);
            }
        }
    }
}

