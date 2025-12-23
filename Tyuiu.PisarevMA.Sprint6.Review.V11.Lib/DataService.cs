namespace Tyuiu.PisarevMA.Sprint6.Review.V11.Lib
{
    public class DataService
    {
        public int[,] GeneratingMatrix(int n, int m, int n1, int n2)
        {
            Random rnd = new Random();
            int[,] array = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {

                    if ((i + 1) % 3 == 0)
                    {
                        array[i, j] = Convert.ToInt32(array[i - 1, j] + array[i - 2, j]);
                    }
                    else
                    {
                        int a = rnd.Next(n1, n2 + 1);
                        array[i, j] = a;
                    }
                }

            }
            return array;
        }

        public int result_GetMatrix(int[,] array, int c, int k, int l)
        {
            int rows = array.GetLength(0);
            int columns = array.GetLength(1);
            int max = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (i == c && j >= k && j <= l && j % 2 != 0)
                    {
                        if (array[i, j] > max)
                        {
                            max = array[i, j];
                        }
                    }
                }
            }

            if (max == 0)
            {
                throw new ArgumentException("В указанном диапазоне нет нечётных чисел");
            }

            return max;
        }
    }
}