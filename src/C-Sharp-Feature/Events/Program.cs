









//using System;

//namespace SampleApp
//{
//    public delegate string MyDel(string str);

//    class EventProgram
//    {
//        event MyDel MyEvent;

//        public EventProgram()
//        {
//            this.MyEvent += new MyDel(this.WelcomeUser);
//        }



//        public string WelcomeUser(string username)
//        {
//            return "Welcome " + username;
//        }

//        static void Main(string[] args)
//        {
//            EventProgram obj1 = new EventProgram();
//            string result = obj1.MyEvent("Tutorials Point");
//            Console.WriteLine(result);
//        }

//    }
//}


//// See https://aka.ms/new-console-template for more information

//using Events;

//Button button = new Button();
//button.Click += PrintMessage;
//button.Click += PrintMessage2;


//void PrintMessage(string message)
//{
//    Console.WriteLine(message);

//}
//void PrintMessage2(string message)
//{
//    Console.WriteLine("Print from another: " + message);
//}

//button.Activate("Hello");