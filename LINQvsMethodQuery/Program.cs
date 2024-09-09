using System.Security.Cryptography.X509Certificates;

List<int> varNumbers = new List<int>() { 34, 56, 32, 12, 32, 17, 98, 56};

//Lambda Expression
varNumbers.Sort((x,y) => x - y  );

//LINQ query syntax
var querySyntax = from num in varNumbers where num%2==0 select num;
//Method syntax
var methondSyntax = varNumbers.Where(num => num%2==0);

foreach (var num in methondSyntax)
{
    Console.WriteLine(num);
}