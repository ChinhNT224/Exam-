using System;

class Book
{
    private int id;
    private string title;
    private double price;
    private string publisher;

    public Book()
    {
        this.id = 0;
        this.title = "";
        this.price = 0;
        this.publisher = "";
    }

    public Book(int id, string title, double price, string publisher)
    {
        this.id = id;
        this.title = title;
        this.price = price;
        this.publisher = publisher;
    }

    public int Id { get { return this.id; } }
    public string Title { get { return this.title; } }

    public double Price
    {
        get { return this.price; }
        set { this.price = value; }
    }

    public string Publisher
    {
        get { return this.publisher; }
        set { this.publisher = value; }
    }

    public override string ToString()
    {
        return "Book[ID=" + this.id + ", Title=" + this.title +
            ", Price=" + this.price + ", Publisher=" + this.publisher + "]";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Book book1 = new Book(1, "The Great Gatsby", 9.99, "Scribner");
        Book book2 = new Book(2, "To Kill a Mockingbird", 7.99, "HarperCollins");

        Console.WriteLine(book1);
        Console.WriteLine(book2);

        book1.Price = 8.99;
        book2.Publisher = "Vintage";

        Console.WriteLine(book1);
        Console.WriteLine(book2);
    }
}
