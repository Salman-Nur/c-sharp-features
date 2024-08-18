////int a = int.Parse(Console.ReadLine());
////int b = int.Parse(Console.ReadLine());
////Console.WriteLine(a + b);

/////------  By using File class = create a file + Write in that file + Read All the Text of that file  ---------
//string file = "../../../Hello.txt";
//using (FileStream prevFile = File.Create(file))
//{
//    //prevFile.Dispose();
//    //byte[] buffer = System.Text.Encoding.UTF8.GetBytes("Hello World");
//    //using FileStream stream = File.Open(file, FileMode.Open);
//    //stream.Write(buffer);
//    //stream.Flush();
//    prevFile.Write(System.Text.Encoding.UTF8.GetBytes("Subbhaanallah"));

//}
//string text = File.ReadAllText(file);
//Console.WriteLine(text);

/////--------------------------------------  Read from the file 1 byte by 1 byte  ------------------------------------
//FileInfo fileInfo = new FileInfo(file);

//if (fileInfo.Exists)
//{
//    using (FileStream stream = fileInfo.Open(FileMode.Open))
//    {
//        long size = fileInfo.Length;
//        for (long i = 0; i < size; i++)
//        {
//            byte[] buffer = new byte[1];
//            stream.Read(buffer);
//            string str = System.Text.Encoding.UTF8.GetString(buffer);
//            Console.WriteLine(str);
//        }
//    }
//    fileInfo.Delete();
//}







///// --------------------------------------- Create 2 File + Write in the 1st file +  Copy text 1st File to 2nd File  ------------------------------------------------
//string file = "../../../Hello.txt";
//string file1 = "../../../Hello1.txt";

//FileInfo fileInfo = new FileInfo(file);

//FileStream f = fileInfo.Create();
//f.Dispose();
//f = fileInfo.Open(FileMode.Open);
//f.Write(System.Text.Encoding.UTF8.GetBytes("Allahu   Akbar"));
//f.Dispose(); 

//FileInfo fileInfo1 = new FileInfo(file1);
//FileStream f1 = fileInfo1.Create();
//f1.Dispose();


//using FileStream stream = fileInfo.Open(FileMode.Open);
//using FileStream stream1 = fileInfo1.Open(FileMode.Open);

//long size = fileInfo.Length;
//for (long i = 0; i < size; i++)
//{
//    byte[] buffer = new byte[1];
//    stream.Read(buffer);
//    string str  = System.Text.Encoding.UTF8.GetString(buffer);

//    byte[] buffer1 = System.Text.Encoding.UTF8.GetBytes(str); 
//    stream1.Write(buffer1); 

//}



////string str = File.ReadAllText(file);
////byte[] buffer1 = System.Text.Encoding.UTF8.GetBytes(str);
////stream1.Write(buffer1);

if (!Directory.Exists("MyFolder"))
{
    DirectoryInfo directoryInfo = Directory.CreateDirectory("Myfolder");
}
string currentDirectoryName = Directory.GetCurrentDirectory();
Console.WriteLine(currentDirectoryName);


DirectoryInfo currentDirectory = new DirectoryInfo(currentDirectoryName);
Console.WriteLine(currentDirectory.Parent.Parent.Parent.FullName);

//Directory.Delete("C:\\New folder");
Directory.Delete("Myfolder");




