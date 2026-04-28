using lab1;
Console.WriteLine("pls enter your name and press enter");
string? name = Console.ReadLine();
Student test = new Student(new PersonInfo(name ?? "No Name",1));
Console.WriteLine(test.WelcomeMessage);