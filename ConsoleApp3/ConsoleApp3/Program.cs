using System;

interface IFirstInterface
{
    void Methoada();
}
interface ISecondInterface
{
    void Methodb();
}
class MyClass:IFirstInterface, ISecondInterface
{
    public void Methoada()
    {
        Console.WriteLine("First Interface Method");
    }
    public void Methodb()
    {
        Console.WriteLine("Second Interface Method");
    }
}
class Program
{
    static void Main()
    {
        MyClass myClass = new MyClass();
        myClass.Methoada();
        myClass.Methodb();
    }
}