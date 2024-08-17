using Homework1708;

Console.WriteLine("İstifadəçi adını daxil edin:");
string username = Console.ReadLine();
Console.WriteLine("Şifrəni daxil edin:");
string password = Console.ReadLine();

User userObject = new User(username, password);
Console.WriteLine($"Hesab yaradıldı:UserName={userObject.UserName},Password={userObject.Password}");


