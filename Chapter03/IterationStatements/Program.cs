int x = 0;
while (x < 10)
{
    WriteLine(x);
    x++;
}

string? actualPassword = "Pa$$w0rd";
string? password;

do
{
    WriteLine("Enter your password: ");
    password = ReadLine();
}
while (password != actualPassword);

WriteLine("Correct!");

string[] names = { "Adam", "Barry", "Charlie" };

foreach (string name in names)
{
    WriteLine($"{name} has {name.Length} characters.");
}