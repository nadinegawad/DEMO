namespace ConsoleApp1
{
    internal class Program
    {


        #region Fun E01
        static void PrintShape(int count = 3, string pattern = "!!")
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(pattern);
            }
        }
        #endregion


        #region Fun E02
        static void swap(int x, int y)
        {
            int temp = y;
            y = x;
            x = temp;
        }

        static void swap2(ref int x, ref int y)
        {
            int temp = y;
            y = x;
            x = temp;
        }

        #endregion

        #region  Fun E03
        static int SumArray(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
        #endregion


        #region Fun E04
        static void SumMal(int x, int y, out int sum, out int mal)
        {
            sum = x + y;
            mal = x * y;
        }
        #endregion


        #region Fun E05
        static int SumArray2(params int[] arr)
        {
            int sum = 0;
            if (arr is not null)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    sum += arr[i];
                }

            }
            return sum;
        } 
        #endregion   








        static void Main(string[] args)
        {
            #region E01
            //int? y = null;
            //int x = 10;
            //y = x;
            //int? num01 = null;
            //int num02 = (int) num01;
            #endregion

            #region E02
            //int? k = null;
            //int l;
            //if (k != null)
            //{
            //    l = (int)k;
            //}

            ////or
            //if (k.HasValue)
            //{
            //    l = (int)k.Value;
            //}
            //else
            //{
            //    l = 0;
            //}

            ////or

            //l= k.HasValue ? k.Value : 0;
            #endregion

            #region E03
            //int[] numbers = default;
            //for (int i = 0; i < numbers.Length && numbers != null; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //} 
            #endregion

            //Fun E01
            //PrintShape(5, "//$\\");  // PASSING BY ORDER
            //PrintShape(pattern: "@@", count: 9); // passing by name
            //PrintShape(); // passing by default


            //Fun E02
            //int x = 7;
            //int y = 10;
            //Console.WriteLine(x);   
            //Console.WriteLine(y);
            //Console.WriteLine("========================");
            //swap(x, y);  // passing by value
            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //Console.WriteLine("========================");
            //swap2(ref x, ref y);
            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //Console.WriteLine("========================");


            //Fun E03
            //int[] arr = { 1, 2, 3 };
            //Console.WriteLine(SumArray(arr));


            //Fun E04

            //int a = 10;
            //int b = 5;
            //int sum, mal;
            //SumMal(a, b, out sum, out mal);
            //Console.WriteLine(sum);
            //Console.WriteLine(mal);


            //Fun E05

            //Console.WriteLine(SumArray2(1, 2, 3));
        }
    }
}
