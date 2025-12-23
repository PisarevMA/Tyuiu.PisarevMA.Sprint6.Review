using Tyuiu.PisarevMA.Sprint6.Review.V11.Lib;
namespace Tyuiu.PisarevMA.Sprint6.Review.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int k = 1;
            int l = 4;
            int c = 1;
            int n = 5;
            int m = 5;
            int n1 = 3;
            int n2 = 9;

            int[,] array = ds.GeneratingMatrix(n, m, n1, n2);

            int res = ds.result_GetMatrix(array, c, k, l);

            int wait = 2;

            Assert.AreEqual(wait, res);
        }
    }
}