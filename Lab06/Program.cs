/* Task 1 */
using Lab06;

List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

// query syntax
var even = from n in numbers
           where n % 2 == 0
           select n;

// print out to verify
Console.WriteLine("==Task 1==\n");

foreach (var e in even)
{
    Console.WriteLine(e);
}

Console.WriteLine("---");

// lambda syntax
var even2 = numbers
            .Where(n => n % 2 == 0);

foreach(var e in even2)
{
    Console.WriteLine(e);
}

/* Task 2 */

List<Product> products = new List<Product>()
{
    new Product("Laptop", 500),
    new Product("Book", 20),
    new Product("Desk", 100)
};

var discounted = products
                 .Select(p => new Product(p.Name, (int)Math.Round(0.9 * p.Price)));

Console.WriteLine("\n==Task 2==");

foreach (var p in discounted)
{
    Console.WriteLine(p.Name + ": " + p.Price);
}

/* Task 3 */

List<Book> books = new List<Book>()
{
    new Book("C# for beginners", "A. Programmer", 10),
    new Book("LINQ made easy", "D.B. Query", 25),
    new Book("Design Patterns Rock", "R.U. Kidding", 15)
};

var bookFilter = from b in books
                 where b.Price < 20
                 orderby b.Title
                 select b;

Console.WriteLine("\n==Task 3==");

foreach (var b in bookFilter)
{
    Console.WriteLine(b.Title + " by " + b.Author + " (£" + b.Price + ")");
}

/* Task 4 */

List<Student> students = new List<Student>()
{
    new Student("Alice", "Computer Science"),
    new Student("Bob", "Cyber Security"),
    new Student("Claire", "Cyber Security"),
    new Student("Donald", "Computer Science"),
    new Student("Edith", "Computer Science")
};

var grouped = from s in students
              group s by s.Course;

Console.WriteLine("\n==Task 4==");

foreach (var g in grouped)
{
    Console.WriteLine("=" + g.Key + "=");
    foreach (var s in g)
    {
        Console.WriteLine(s.Name);
    }
    Console.WriteLine();
}