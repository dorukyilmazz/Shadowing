global using global::System;
global using global::System.Collections.Generic;
global using global::System.IO;
global using global::System.Linq;
global using global::System.Net.Http;
global using global::System.Threading;
global using global::System.Threading.Tasks;
interface IHayvan
{
 void SesCikar();
}
interface IBeslen
{
    void Beslen();
}
public class Kedi: IHayvan,IBeslen
 
{
    public void SesCikar()
    {
        Console.WriteLine("Kedi: miyav");
    }
    public void Beslen()
    {
        Console.WriteLine("Kedi süt içti.");
    }
}
public class Kopek
: IHayvan
, IBeslen
{
    public void SesCikar()
    {
        Console.WriteLine("Köpek: hav hav");
    }
    public void Beslen()
    {
        Console.WriteLine("Köpek et yedi");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Kedi kedi = new Kedi();
        kedi.SesCikar();
        kedi.Beslen();
        Kopek kopek = new Kopek();
        kopek.SesCikar();
        kopek.Beslen();
        Console.WriteLine("==================");
        IHayvan hayvan1 = kedi;
        IHayvan hayvan2 = kopek;
        hayvan1.SesCikar();
        hayvan2.SesCikar();
        Console.WriteLine("=================");
        IBeslen beslen1 = kedi;
        IBeslen beslen2 = kopek;
        beslen1.Beslen();
        beslen2.Beslen();
    }
}
