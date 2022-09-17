namespace BeginContinueProject
{
    enum CellType
    {
        Wall,
        Empty,
        Start,
        Finish
    }
    internal class Program
    {
        static int Sum(int a, int b)
        {
            return a + b;
        }

        static void Swap(ref int a, ref int b)
        {

        }

        static void InitRand(out int num)
        {
            num = (new Random()).Next();
        }

        static int SumN(params int[] arrint)
        {
            int result = 0;
            foreach (var item in arrint)
                result += item;

            //for(int i = 0; i < arrint.Length; i++)
            //    result += arrint[i];

            return result;
        }
        static void Main(string[] args)
        {

            CellType cellType = CellType.Wall;

            int size = 10;
            int[] array1 = new int[size];

            Random random = new Random();

            for(int i = 0; i < array1.Length; i++)
                array1[i] = random.Next() % 100;

            foreach (var item in array1)
                Console.Write($"{item} ");

            int x = 10;
            int y = 20;
            Swap(ref x, ref y);

            int r;
            InitRand(out r);

        }
    }
}