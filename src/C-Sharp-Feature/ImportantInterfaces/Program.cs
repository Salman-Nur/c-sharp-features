using ImportantInterfaces;

interface IAnimal
{
    void AnimalSound();

}

class Jamaloon : IAnimal
{
    public void AnimalSound()
    {
        Console.WriteLine("Va va...");
    }
}

class Dog : IAnimal
{
    public void AnimalSound()
    {
        Console.WriteLine("Vew vew...");
    }
}

//-----------------------------------------------------------------



interface IFirstCourse
{
    void FirstCourse();
    

}

interface ISecondCourse
{
    void SecondCourse();
}


class MyAllCourse : IFirstCourse, ISecondCourse
{
    public void FirstCourse()
    {
        Console.WriteLine("1. C_sharp Beginner !");
    }
    public void SecondCourse()
    {
        Console.WriteLine("2. Asp.net MVC Full Stack Development !");
    }



    /*
     
     void IFirstCourse.FirstCourse()
    {
        Console.WriteLine("1. C_sharp Beginner !");
    }

    void IFirstCourse.FirstCourse()
    {
        Console.WriteLine("1. C_sharp Beginner !");
    }


    //  Tahale Program.cs e Error asbe nicher 2 line e. Because, when you implement an interface explicitly, you can access interface members only through the instance of an interface type.
        myAllCourse.FirstCourse();
        myAllCourse.SecondCourse();




    //  Tokhon nicher moto korei korte hobe :

        IAnimal ianimal1 = new Jamaloon();
        ianimal1.AnimalSound();

        IAnimal ianimal2 = new Dog();
        ianimal2.AnimalSound();   
    
    
     */
}




    // Implement Multiple Interfaces : https://www.tutorialsteacher.com/csharp/csharp-interface
    interface IFile
    {
        void ReadFile();
    }

    interface IBinaryFile
    {
        void OpenBinaryFile();
        void ReadFile();
    }


    class FileInfo : IFile, IBinaryFile
    {
        void IBinaryFile.OpenBinaryFile()
        {
            Console.WriteLine("Opening Binary File.......");
        }

        void IFile.ReadFile()
        {

            Console.WriteLine("Reading File.......");
        }

        void IBinaryFile.ReadFile()
        {
            Console.WriteLine("Reading Binary File.......");
        }

        public void Search(string text)
        {
            Console.WriteLine(text);
        }
    }












//===============================================================================================================================


class Program
{
    

















    public static void Main(string[] args)
    {
        Jamaloon jamaloon = new Jamaloon();
        jamaloon.AnimalSound();  
        Dog dog = new Dog();
        dog.AnimalSound();


        // You can also create an object of the class and assign it to a variable of an interface type, as shown below :
        IAnimal ianimal1 = new Jamaloon();
        ianimal1.AnimalSound();

        IAnimal ianimal2 = new Dog();
        ianimal2.AnimalSound();                                                                                             
        
        
       

        MyAllCourse myAllCourse = new MyAllCourse();
        myAllCourse.FirstCourse();
        myAllCourse.SecondCourse();


        // Implement Multiple Interfaces : https://www.tutorialsteacher.com/csharp/csharp-interface
        FileInfo file1 = new FileInfo();
        file1.Search("Searching in File");
        
        IFile file2 = new FileInfo();
        file2.ReadFile();

        IBinaryFile file3 = new FileInfo();
        file3.OpenBinaryFile();
        file3.ReadFile();

        //--------------------------------------------------------------------------------------------------------


        People people = new People(4);

        people.Add(new Person() { Name = "Jalaluddin" });
        people.Add(new Person() { Name = "Asadoon" });
        people.Add(new Person() { Name = "Nahloon" });
        people.Add(new Person() { Name = "Lahmoon" });



        foreach (Person p in people)
        {
            Console.WriteLine(p.Name);

        }



    }
}





