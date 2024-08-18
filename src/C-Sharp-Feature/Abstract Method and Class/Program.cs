












public abstract class Abst
{
    public abstract void Print();
    public abstract string Str { get; set; }

    public abstract string Description { get; set; }

    public abstract void PrintSomething();

     
}

public class X : Abst
{
    public override void PrintSomething()
    {
        throw new NotImplementedException();

    }
    {
        throw new NotImplementedException();
    }

    public override string Str { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public override string Description { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        

}


class Program
{
    public static void Main(string[] args)
    {


        
    }
}















































//public abstract class Something
//{
//    public abstract void Print();
//    public Something()
//    {

//    }
//}

//class X : Something
//{
//    public override void Print()
//    {
//        Console.WriteLine("Allahu_Akbar...");
//    }
//}


//class Program
//{
//    static void Main()
//    {
//        var x = new X();    
//        x.Print();
//    }
//}