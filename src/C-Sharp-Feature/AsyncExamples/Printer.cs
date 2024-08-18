using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncExamples
{
    internal class Printer
    {
        /// This code is for understanding = try catch throw 
        //public async Task Write(int size)
        // {
        //     if (size < 0)
        //     {
        //         throw new Exception("Size is incorrect");
        //     }
        //     await Task.Run(() =>
        //     {
        //         for (int i = 0; i < size; i++)
        //         {
        //             Console.WriteLine(i);
        //             Thread.Sleep(200);
        //         }
        //     });
        // }



        public async Task Write()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(i);
                    Thread.Sleep(200);
                }
            });
        }























        //public async Task Write()         //public async Task<string> Write() // if it has a return type like string etc in the angel <> brecket
        //{
        //    await Task.Run(() =>
        //    {
        //        for (int i = 0; i < 10; i++)
        //        {
        //            Console.WriteLine(i);
        //            Thread.Sleep(200);

        //        }

        //    });
        //    for (int i = 10; i > 0; i--)
        //    {
        //        Console.WriteLine(i);
        //        Thread.Sleep(200);

        //    }
        //}



    }
}
