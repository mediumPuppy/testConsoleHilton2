using System.Security.Cryptography.X509Certificates;
using testConsoleHilton2;

internal class Program
{
    private static void Main(string[] args)
    {
        PrintStuff ps = new PrintStuff('EN') ;

        string name = "";

        System.Console.WriteLine("Please enter your name");
        name = System.Console.ReadLine();
        ps.PrintName(name);
    }
    // make the method static, use the full class name. 
    // make the method NOT static, use an instance of the class.


}