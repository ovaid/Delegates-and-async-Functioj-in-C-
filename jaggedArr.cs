
//this is the Jaggeld Array example :  JaggledArray is that Array which contains arrays insidew
//it in simple works we can say this is an array of Arrays. In this kindda array there is no defined
// the lenght of columns because the length of each rows column my or may not vary, so wedeclare only 
//the size of the rows but not he ciolumns.
//On declaring the column names this will not be the JaggledASrray;


using System;
class Rameez
{
    public static void Main()
    {

        // Declare the Jagged Array of four elements: 
        int[][] jaggedArr = new int[4][];
        // initializing the JaggedArray values
        jaggedArr[0] = new int[] { 1, 2, 3, 4 };
        jaggedArr[1] = new int[] { 11, 15, 418, 17 };
        jaggedArr[2] = new int[] { 45, 15, 23, 65 };
        jaggedArr[3] = new int[] { 22, 0, 418, 786 };

        for (int i = 0; i < jaggedArr.Length; i++)
        {
            Console.Write("Row({0}): => ", i);

            for (int j = 0; j < jaggedArr[i].Length; j++)
            {
                Console.Write(jaggedArr[i][j] + " ,");
            }

            Console.WriteLine();
        }
    }
}