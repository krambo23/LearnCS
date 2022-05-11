using System;

struct Books
{
    public string title;
    public string author;
    public string subject;
    public int bookId;
};

public class TestStructure
{
    public static void Main(string[] args)
    {
        Books book1;
        Books book2;

        book1.title = "C Programming";
        book1.author = "Nuha Ali";
        book1.subject = "C Programming Tutorial";
        book1.bookId = 6495407;

        book2.title = "Telecom Billing";
        book2.author = "Zara Ali";
        book2.subject = "Telecom Billing Tutorial";
        book2.bookId = 6495700;

        Console.WriteLine("Book 1 Title : {0}", book1.title);
        Console.WriteLine("Book 1 Author : {0}", book1.author);
        Console.WriteLine("Book 1 Subject : {0}", book1.subject);
        Console.WriteLine("Book 1 Book Id : {0}", book1.bookId);

        System.Console.WriteLine();

        Console.WriteLine("Book 2 Title : {0}", book2.title);
        Console.WriteLine("Book 2 Author : {0}", book2.author);
        Console.WriteLine("Book 2 Subject : {0}", book2.subject);
        Console.WriteLine("Book 2 Book Id : {0}", book2.bookId);
    }
}
// pg 135 - 137