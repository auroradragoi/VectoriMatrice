using System;

namespace vectori_matrice
{
    class Vector
    {
        public static void Vectori()
        {
            int[] vector1; // declarare vector cu date de tip int
            vector1 = new int[5]; // definirea vectorului de lungime 5
            Console.WriteLine(vector1.Length); // afiseaza lungimea vectorului in consola

        }
        public static void AfisareElementeVectori()
        {
            // declares an Array of integers.
            int[] arr;

            // allocating memory for 5 integers.
            arr = new int[5];

            // initialize the elements of the array
            arr[0] = 10;
            arr[1] = 20;
            arr[2] = 30;
            arr[3] = 40;
            arr[4] = 50;

            // accessing the elements of the specified array
            for (int i = 0; i < arr.Length; i++)
                Console.WriteLine("Element at index " + i + " : " + arr[i]);
        }
        public static void DoubleVector()
        {
            double[] vector2; // declarare vector cu date de tip double
            vector2 = new double[3]; // definirea vectorului de lungime 3
            vector2[0] = 10.28;
            vector2[1] = 20.56;
            vector2[2] = 30.76;
            for (int i = 0; i < vector2.Length; i++)
                Console.WriteLine("Element at index " + i + " : " + vector2[i]);
        }
        public static void MinMax()
        {
            int min, max, i;
            int[] vector2;
            vector2 = new int[10]; 
            vector2[0] = 1;
            vector2[1] = 2;
            vector2[2] = 3;
            vector2[3] = 4;
            vector2[4] = 5;
            vector2[5] = 6;
            vector2[6] = 7;
            vector2[7] = 8;
            vector2[8] = 9;
            vector2[9] = 10;

            min = int.MaxValue;
            max = int.MinValue;

            for (i = 0; i < vector2.Length; i++)
            {
                if (vector2[i] < min)
                    min = vector2[i];
                if (vector2[i] > max)
                    max = vector2[i];
            }
            Console.WriteLine("Minimul este " + min);
            Console.WriteLine("Maximul este " + max);

        }
        public static void TransformIntToDouble()
        {
            int i;
            int[] vector; 
            vector = new int[3];
            double[] vectorD;
            vectorD = new double[3];

            vector[0] = 1;
            vector[1] = 2;
            vector[2] = 3;

            for (i=0; i<3; i++)
            {
                vectorD[i] = (double)vector[i] + 1.5;
            }
            for (i=0; i<3; i++)
            {
                Console.WriteLine(vectorD[i]);
            }
       
        }
        public static void Matrice()
        {
           
            int[,] oMatrice = new int[,] { { 2, 7, 9 }, { 3, -6, 1 }, { 7, 4, 2 } };
            int i, j;
            // printing 2D array
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    if (oMatrice[i, j] < 0)
                        Console.WriteLine("Valoarea negativa are coordonatele: " + i +" , "+ j);
                   // break;
                }
                    //Console.Write(oMatrice[i,j] + " ");
                //Console.WriteLine();
            }
           
        }

        static void Main(string[] args)
        {
            Vectori();
            AfisareElementeVectori();
            Matrice();
            DoubleVector();
            MinMax();
            Matrice();
            TransformIntToDouble();
        }
    }


}