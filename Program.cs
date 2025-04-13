Console.WriteLine("Hello, World!");
var manager = new UserManager();
manager.AddUser("test");
Console.WriteLine(manager.RemoveUser("test")); // В консоли должен вывести True