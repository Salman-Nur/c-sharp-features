// ------------------   1d array   -------------------------
using System.Net.Http.Headers;

int[] arr = new int[5];

arr[0] = 343;
arr[1] = 4;
arr[2] = 34;
arr[3] = 334;
arr[4] = 88;

foreach (int i in arr)
{
    Console.WriteLine(i);
}



// --------------------   2d array   ------------------------
int[,] arr2d = new int[2, 4]
{
    {34,43,3,34 },
    {34,43,343,3 }

};

//for (int i = 0; i < 2; i++)               // taking user input 
//{
//    for (int j = 0; j < 4; j++)
//    {
//        arr2d[i, j] = int.Parse(Console.ReadLine());
//    }
    
//}

for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.Write(arr2d[i,j] + " ");
    }
    Console.WriteLine();
}

/// ----------------------------   3d array  -------------------------------------

/// ---------------------------   Jagged array   ---------------------------------
int[][] jaggedArr = new int[2][];

jaggedArr[0] = new int[] { 34, 34, 34, 34 };

jaggedArr[1] = new int[] { 3445 };


